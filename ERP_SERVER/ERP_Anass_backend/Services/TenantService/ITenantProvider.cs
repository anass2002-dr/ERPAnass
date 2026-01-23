namespace ERP_Anass_backend.Services.TenantService
{
    public interface ITenantProvider
    {
        Guid CurrentTenantId { get; }
    }
}
