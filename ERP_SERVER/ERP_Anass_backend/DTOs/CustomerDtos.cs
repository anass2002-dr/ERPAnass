using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class CustomerDtos
    {

        [DefaultValue(0)]
        public int idCustomer { get; set; }
        [DefaultValue(null)]
        public string? CustomerRef { get; set; }
        [DefaultValue(null)]
        public string? CustomerName { get; set; }
        [DefaultValue(null)]
        public string? ContactPerson { get; set; }
        [DefaultValue(null)]
        public string? Phone { get; set; }
        [DefaultValue(null)]
        public string? Email { get; set; }
        [DefaultValue(null)]
        public string? Address { get; set; }
        [DefaultValue(null)]
        public string? IdentityNumber { get; set; }
        [DefaultValue(0)]
        public int? CountryId { get; set; }
        [DefaultValue(0)]
        public int? CityID { get; set; }
        [DefaultValue(true)]
        public Boolean? IsAcitve { get; set; }
        public CustomerDtos(Customer supplier)
        {
            this.idCustomer = supplier.idCustomer;
            this.CustomerRef = supplier.CustomerRef;
            this.CustomerName = supplier.CustomerName;
            this.ContactPerson = supplier.ContactPerson;
            this.Phone = supplier.Phone;
            this.Email = supplier.Email;
            this.Address = supplier.Address;
            this.CountryId = supplier.CountryId;
            this.CityID = supplier.CityID;
            this.IsAcitve = supplier.IsAcitve;
            this.IdentityNumber = supplier.IdentityNumber;
        }

        public CustomerDtos()
        {
        }
    }
}
