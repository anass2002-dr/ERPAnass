using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.PaymentService
{
    public interface IServicePayment
    {
        Payment GetPaymentById(int id);
        List<Payment> GetPayments();
        List<dynamic> GetPaymentsDetails();
        Payment AddPayment(PaymentDtos payment);
        Payment UpdatePayment(int id, Payment payment);
        bool DeletePayment(int id);
    }
}
