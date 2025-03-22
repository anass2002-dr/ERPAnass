using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class SupplierDtos
    {

        [DefaultValue(0)]
        public int idSupplier { get; set; }
        [DefaultValue(null)]
        public string SupplierRef { get; set; }
        [DefaultValue(null)]
        public string SupplierName { get; set; }
        [DefaultValue(null)]
        public string ContactPerson { get; set; }
        [DefaultValue(null)]
        public string Phone { get; set; }
        [DefaultValue(null)]
        public string Email { get; set; }
        [DefaultValue(null)]
        public string Address { get; set; }
        [DefaultValue(null)]
        public string IdentityNumber { get; set; }
        [DefaultValue(0)]
        public int? CountryId { get; set; }
        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }
        public SupplierDtos(Supplier supplier)
        {
            this.idSupplier = supplier.idSupplier;
            this.SupplierRef= supplier.SupplierRef;
            this.SupplierName = supplier.SupplierName;
            this.ContactPerson = supplier.ContactPerson;
            this.Phone= supplier.Phone;
            this.Email= supplier.Email;
            this.Address = supplier.Address;
            this.CountryId = supplier.CountryId;
            this.IsAcitve = supplier.IsAcitve;
            this.IdentityNumber = supplier.IdentityNumber;
        }

        public SupplierDtos()
        {
        }
    }
}
