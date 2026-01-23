using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.PaymentRepo;
using ERP_Anass_backend.Repository.InvoiceRepo;
using ERP_Anass_backend.Services.JournalEntryService;
using ERP_Anass_backend;

namespace ERP_Anass_backend.Services.PaymentService
{
    public class PaymentService : IServicePayment
    {
        private readonly IRepoPayment _repoPayment;
        private readonly IInvoiceRepository _invoiceRepo;
        private readonly IServiceJournalEntry _journalEntryService;
        private readonly DbContextERP _context; // Access to context for fetching linked accounts directly if needed

        public PaymentService(IRepoPayment repoPayment, IInvoiceRepository invoiceRepo, IServiceJournalEntry journalEntryService, DbContextERP context)
        {
            _repoPayment = repoPayment;
            _invoiceRepo = invoiceRepo;
            _journalEntryService = journalEntryService;
            _context = context;
        }

        public Payment AddPayment(PaymentDtos paymentDtos)
        {
            Payment payment = new Payment();
            payment.Amount = paymentDtos.Amount;
            payment.PaymentDate = DateTime.UtcNow;
            payment.PaymentMethod = paymentDtos.PaymentMethod;
            payment.ReferenceNumber = paymentDtos.ReferenceNumber;
            payment.SaleId = paymentDtos.SaleId != 0 ? paymentDtos.SaleId : null;
            payment.PurchaseId = paymentDtos.PurchaseId != 0 ? paymentDtos.PurchaseId : null;
            payment.InvoiceId = paymentDtos.InvoiceId != 0 ? paymentDtos.InvoiceId : null;
            payment.idBankAccount = paymentDtos.idBankAccount != 0 ? paymentDtos.idBankAccount : null;

            // Save Payment
            var savedPayment = _repoPayment.AddPayment(payment);

            // Automated Journal Entry Logic
            if(savedPayment.InvoiceId.HasValue)
            {
                CreateJournalEntryForPayment(savedPayment);
            }

            return savedPayment;
        }

        private void CreateJournalEntryForPayment(Payment payment)
        {
            var invoice = _invoiceRepo.GetInvoice(payment.InvoiceId.Value).GetAwaiter().GetResult();
            if(invoice == null) return;

            string description = $"Payment for Invoice #{invoice.InvoiceNumber} - Ref: {payment.ReferenceNumber}";
            var journalEntryDto = new JournalEntryDtos
            {
                 EntryDate = payment.PaymentDate,
                 Description = description,
                 // Reference = payment.ReferenceNumber, // Not in DTO
                 Status = JournalEntryStatus.Posted, // Auto-post
                 JournalDetails = new List<JournalDetailsDtos>() 
            };

            // Determine Accounts
            int? debitAccountId = null;
            int? creditAccountId = null;

            // Fetch Bank Account linked GL Account
            int? bankGlAccountId = null;
            if(payment.idBankAccount.HasValue)
            {
                var bankAccount = _context.BankAccounts.Find(payment.idBankAccount.Value);
                if(bankAccount != null) bankGlAccountId = bankAccount.idAccount;
            }

            if(invoice.InvoiceType == "Sale")
            {
                // Debit: Bank (Asset) | Credit: Customer (Receivable)
                debitAccountId = bankGlAccountId; 
                
                // Get Customer Control Account
                if(invoice.CustomerId.HasValue)
                {
                    var customer = _context.Customer.Find(invoice.CustomerId.Value);
                    if(customer != null) creditAccountId = customer.idControlAccount;
                }
            }
            else if(invoice.InvoiceType == "Purchase")
            {
                 // Debit: Supplier (Payable) | Credit: Bank (Asset)
                 creditAccountId = bankGlAccountId;

                 // Get Supplier Control Account
                 if(invoice.SupplierId.HasValue)
                 {
                     var supplier = _context.Supplier.Find(invoice.SupplierId.Value);
                     if(supplier != null) debitAccountId = supplier.idControlAccount;
                 }
            }

            // Create Details if accounts are found
            if(debitAccountId.HasValue && creditAccountId.HasValue)
            {
                journalEntryDto.JournalDetails.Add(new JournalDetailsDtos
                {
                    AccountID = debitAccountId.Value,
                    DebitAmount = (float)payment.Amount,
                    CreditAmount = 0,
                    Description = "Payment Received/Start"
                });

                 journalEntryDto.JournalDetails.Add(new JournalDetailsDtos
                {
                    AccountID = creditAccountId.Value,
                    DebitAmount = 0,
                    CreditAmount = (float)payment.Amount,
                    Description = "Payment Source"
                });

                _journalEntryService.AddJournalEntry(journalEntryDto);
            }
        }

        public bool DeletePayment(int id)
        {
            return _repoPayment.DeletePayment(id);
        }

        public Payment GetPaymentById(int id)
        {
            return _repoPayment.GetPaymentById(id);
        }

        public List<Payment> GetPayments()
        {
            return _repoPayment.GetPayments();
        }

        public List<dynamic> GetPaymentsDetails()
        {
            return _repoPayment.GetPaymentsDetails();
        }

        public Payment UpdatePayment(int id, Payment payment)
        {
            payment.idPayment = id;
            return _repoPayment.UpdatePayment(payment);
        }
    }
}
