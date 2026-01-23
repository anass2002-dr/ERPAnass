using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PaymentRepo
{
    public class RepoPayment : IRepoPayment
    {
        private readonly DbContextERP _context;

        public RepoPayment(DbContextERP context)
        {
            _context = context;
        }

        public Payment AddPayment(Payment payment)
        {
            var p = _context.Set<Payment>().Add(payment);
            _context.SaveChanges();
            return p.Entity;
        }

        public bool DeletePayment(int id)
        {
            var payment = _context.Set<Payment>().Find(id);
            if (payment == null) return false;

            _context.Set<Payment>().Remove(payment);
            _context.SaveChanges();
            return true;
        }

        public Payment GetPaymentById(int id)
        {
            return _context.Set<Payment>()
                .Include(p => p.Sale)
                .Include(p => p.Purchase)
                .FirstOrDefault(p => p.idPayment == id);
        }

        public List<Payment> GetPayments()
        {
             return _context.Set<Payment>()
                .Include(p => p.Sale)
                .Include(p => p.Purchase)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        public List<Payment> GetPaymentsByPurchase(int purchaseId)
        {
             return _context.Set<Payment>()
                 .Where(p => p.PurchaseId == purchaseId)
                 .OrderByDescending(p => p.PaymentDate)
                 .ToList();
        }

        public List<Payment> GetPaymentsBySale(int saleId)
        {
             return _context.Set<Payment>()
                 .Where(p => p.SaleId == saleId)
                 .OrderByDescending(p => p.PaymentDate)
                 .ToList();
        }

        public List<dynamic> GetPaymentsDetails()
        {
             return _context.Set<Payment>()
                .Include(p => p.Sale)
                .Include(p => p.Purchase)
                .Select(p => new
                {
                    p.idPayment,
                    p.Amount,
                    p.PaymentDate,
                    p.PaymentMethod,
                    p.ReferenceNumber,
                    p.SaleId,
                    p.PurchaseId
                })
                .ToList<dynamic>();
        }

        public Payment UpdatePayment(Payment payment)
        {
             var existing = _context.Set<Payment>().Find(payment.idPayment);
             if (existing != null)
             {
                 existing.Amount = payment.Amount != 0 ? payment.Amount : existing.Amount;
                 existing.PaymentDate = payment.PaymentDate;
                 existing.PaymentMethod = payment.PaymentMethod ?? existing.PaymentMethod;
                 existing.ReferenceNumber = payment.ReferenceNumber ?? existing.ReferenceNumber;
                 existing.SaleId = payment.SaleId ?? existing.SaleId;
                 existing.PurchaseId = payment.PurchaseId ?? existing.PurchaseId;

                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
