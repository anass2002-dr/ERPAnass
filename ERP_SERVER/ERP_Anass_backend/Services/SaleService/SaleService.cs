using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.SaleRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using ERP_Anass_backend.Services.JournalEntryService;
using ERP_Anass_backend.Services.PaymentService;
using ERP_Anass_backend.Services.ArticleService;
using System.Linq;

namespace ERP_Anass_backend.Services.SaleService
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepo _saleRepo;
        private readonly ILogger<SaleService> _logger;
        private readonly IServiceJournalEntry _journalEntryService;
        private readonly IServicePayment _paymentService;
        private readonly IArticleService _articleService;

        public SaleService(ISaleRepo saleRepo, ILogger<SaleService> logger, IServiceJournalEntry journalEntryService, IServicePayment paymentService, IArticleService articleService)
        {
            _saleRepo = saleRepo;
            _logger = logger;
            _journalEntryService = journalEntryService; // Injected
            _paymentService = paymentService; // Injected
            _articleService = articleService; // Injected
        }

        public Sale AddSale(SaleDtos saleDtos)
        {
            try
            {
                // Validate DTO
                if (saleDtos == null)
                {
                    throw new ArgumentNullException(nameof(saleDtos), "Sale DTO cannot be null.");
                }

                // Map DTO to Model
                var sale = new Sale
                {
                    SaleRef = saleDtos.SaleRef,
                    TotalAmount = saleDtos.TotalAmount,
                    TotalPayment = saleDtos.TotalPayment,
                    IdCurrency = saleDtos.IdCurrency,
                    PaymentStatus = saleDtos.PaymentStatus,
                    PaymentDate = saleDtos.PaymentDate,
                    SaleDate = saleDtos.SaleDate,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Remarks = saleDtos.Remarks,
                    IdCustomer = saleDtos.IdCustomer,
                    IsActive = saleDtos.IsActive,

                    // Map additional fields
                    SaleStatus = saleDtos.SaleStatus,
                    ExpectedDeliveryDate = saleDtos.ExpectedDeliveryDate,
                    ActualDeliveryDate = saleDtos.ActualDeliveryDate,
                    ShippingAddress = saleDtos.ShippingAddress,
                    SaleType = saleDtos.SaleType,
                    DiscountAmount = saleDtos.DiscountAmount,
                    DiscountPercentage = saleDtos.DiscountPercentage,
                    TaxRate = saleDtos.TaxRate,
                    TotalTaxAmount = saleDtos.TotalTaxAmount,
                    ShippingAmount = saleDtos.ShippingAmount,
                    ExchangeRate = saleDtos.ExchangeRate,
                    ApprovedBy = saleDtos.ApprovedBy,
                    ApprovalDate = saleDtos.ApprovalDate,
                    PaymentTerms = saleDtos.PaymentTerms,
                    SaleChannel = saleDtos.SaleChannel
                };

                var addedSale = _saleRepo.AddSale(sale);
                _logger.LogInformation("Sale added successfully with ID: {IdSale}", addedSale.IdSale);
                return addedSale;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding a sale.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeleteSale(int id)
        {
            try
            {
                bool isDeleted = _saleRepo.DeleteSale(id);
                if (isDeleted)
                {
                    _logger.LogInformation("Sale with ID: {IdSale} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found for deletion.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting sale with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale GetSaleById(int id)
        {
            try
            {
                var sale = _saleRepo.GetSaleById(id);
                if (sale == null)
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found.", id);
                }
                return sale;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching sale with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetSaleDetails()
        {
            try
            {
                var saleDetails = _saleRepo.GetSaleDetails();
                return saleDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching sale details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<Sale> GetSales()
        {
            try
            {
                var sales = _saleRepo.GetSales();
                return sales;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all sales.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale UpdateSale(int id, SaleDtos saleDtos)
        {
            try
            {
                var existingSale = _saleRepo.GetSaleById(id);
                if (existingSale == null)
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found for update.", id);
                    throw new KeyNotFoundException($"Sale with ID {id} not found.");
                }

                // Update fields if provided in DTO
                existingSale.SaleRef = saleDtos.SaleRef ?? existingSale.SaleRef;
                existingSale.TotalAmount = saleDtos.TotalAmount != -1 ? saleDtos.TotalAmount : existingSale.TotalAmount;
                existingSale.TotalPayment = saleDtos.TotalPayment != -1 ? saleDtos.TotalPayment : existingSale.TotalPayment;
                existingSale.IdCurrency = saleDtos.IdCurrency != 0 ? saleDtos.IdCurrency : existingSale.IdCurrency;
                existingSale.PaymentStatus = saleDtos.PaymentStatus ?? existingSale.PaymentStatus;
                existingSale.PaymentDate = saleDtos.PaymentDate ?? existingSale.PaymentDate;
                existingSale.SaleDate = saleDtos.SaleDate ?? existingSale.SaleDate;
                existingSale.Remarks = saleDtos.Remarks ?? existingSale.Remarks;
                existingSale.IdCustomer = saleDtos.IdCustomer != 0 ? saleDtos.IdCustomer : existingSale.IdCustomer;
                existingSale.IsActive = saleDtos.IsActive;
                existingSale.UpdatedAt = DateTime.UtcNow;

                // Update additional fields
                existingSale.SaleStatus = saleDtos.SaleStatus ?? existingSale.SaleStatus;
                existingSale.ExpectedDeliveryDate = saleDtos.ExpectedDeliveryDate ?? existingSale.ExpectedDeliveryDate;
                existingSale.ActualDeliveryDate = saleDtos.ActualDeliveryDate ?? existingSale.ActualDeliveryDate;
                existingSale.ShippingAddress = saleDtos.ShippingAddress ?? existingSale.ShippingAddress;
                existingSale.SaleType = saleDtos.SaleType ?? existingSale.SaleType;
                existingSale.DiscountAmount = saleDtos.DiscountAmount;
                existingSale.DiscountPercentage = saleDtos.DiscountPercentage;
                existingSale.TaxRate = saleDtos.TaxRate;
                existingSale.TotalTaxAmount = saleDtos.TotalTaxAmount;
                existingSale.ShippingAmount = saleDtos.ShippingAmount;
                existingSale.ExchangeRate = saleDtos.ExchangeRate;
                existingSale.ApprovedBy = saleDtos.ApprovedBy ?? existingSale.ApprovedBy;
                existingSale.ApprovalDate = saleDtos.ApprovalDate ?? existingSale.ApprovalDate;
                existingSale.PaymentTerms = saleDtos.PaymentTerms ?? existingSale.PaymentTerms;
                existingSale.SaleChannel = saleDtos.SaleChannel ?? existingSale.SaleChannel;

                var updatedSale = _saleRepo.UpdateSale(id, existingSale);
                _logger.LogInformation("Sale with ID: {IdSale} updated successfully.", id);
                return updatedSale;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating sale with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale checkRef(string reff)
        {
            try
            {
                if (string.IsNullOrEmpty(reff))
                {
                    _logger.LogWarning("Reference string is null or empty.");
                    return null;
                }

                var sales = GetSales();
                foreach (var sale in sales)
                {
                    if (sale.SaleRef == reff)
                    {
                        _logger.LogInformation("Sale with refrence {reff} found.", reff);
                        return sale;
                    }
                }

                _logger.LogWarning("Sale with refrence {reff} not found.", reff);
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while checking sale refrence: {reff}.", reff);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public void FinalizeSale(int saleId, int paymentId)
        {
            try
            {
                var sale = _saleRepo.GetSaleById(saleId);
                if (sale == null) throw new KeyNotFoundException($"Sale with ID {saleId} not found");

                var payment = _paymentService.GetPaymentById(paymentId);
                if (payment == null) throw new KeyNotFoundException($"Payment with ID {paymentId} not found");

                if (!payment.idCashAccount.HasValue)
                    throw new InvalidOperationException($"Payment {payment.ReferenceNumber} is not linked to a Cash Account.");

                var journalEntry = new JournalEntryDtos
                {
                    EntryDate = DateTime.UtcNow,
                    Description = $"Auto-generated for Sale {sale.SaleRef} - Payment {payment.ReferenceNumber}",
                    Status = JournalEntryStatus.Posted,
                    TotalDebit = payment.Amount,
                    TotalCredit = payment.Amount,
                    JournalDetails = new List<JournalDetailsDtos>()
                };

                // Debit Cash Account
                journalEntry.JournalDetails.Add(new JournalDetailsDtos
                {
                    AccountID = payment.idCashAccount.Value,
                    DebitAmount = payment.Amount,
                    CreditAmount = 0,
                    Description = "Cash Receipt from Payment " + payment.ReferenceNumber
                });

                // Credit Income Account(s)
                // Logic: Distribute Payment Amount across Articles based on their contribution to Total Sale
                float totalSaleAmount = (float)(sale.TotalAmount ?? 0);
                
                if (totalSaleAmount == 0) totalSaleAmount = 1; // Prevent division by zero

                if (sale.SaleDetails != null && sale.SaleDetails.Any())
                {
                    foreach (var detail in sale.SaleDetails)
                    {
                        if (!detail.idArticle.HasValue) continue;

                        var article = _articleService.GetArticleById(detail.idArticle.Value);
                        if (article == null || article.idIncomeAccount == 0) continue;

                        // Calculate portion of this payment attributed to this line item
                        float detailTotal = (float)detail.TotalPrice;
                        float creditAmount = (detailTotal / totalSaleAmount) * payment.Amount;

                        journalEntry.JournalDetails.Add(new JournalDetailsDtos
                        {
                            AccountID = article.idIncomeAccount,
                            DebitAmount = 0,
                            CreditAmount = creditAmount,
                            Description = $"Income from Article {article.ArticleName}"
                        });
                    }
                }
                else 
                {
                     // Fallback if no details?
                     // Verify logic: if no details, we can't credit specific Income Accounts.
                     // Could throw or log warning.
                     _logger.LogWarning("Sale {SaleRef} has no details. Income accounts not credited.", sale.SaleRef);
                }


                // Add Journal Entry
                _journalEntryService.AddJournalEntry(journalEntry);
                _logger.LogInformation($"Journal Entry created for Sale {sale.SaleRef}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error finalizing sale transaction.");
                throw;
            }
        }
    }
}