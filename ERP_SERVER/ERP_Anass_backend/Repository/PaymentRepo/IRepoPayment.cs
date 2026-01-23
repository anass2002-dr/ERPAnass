using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.PaymentRepo
{
    public interface IRepoPayment
    {
        Payment GetPaymentById(int id);
        List<dynamic> GetPaymentsDetails();
        List<Payment> GetPayments();
        Payment AddPayment(Payment payment);
        Payment UpdatePayment(Payment payment);
        Boolean DeletePayment(int id);
        List<Payment> GetPaymentsBySale(int saleId);
        List<Payment> GetPaymentsByPurchase(int purchaseId);
    }
}
