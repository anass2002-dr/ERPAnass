using ERP_Anass_backend.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class FamillyDtos
    {
        public int idFamilly { get; set; }
        [DefaultValue(null)]
        public string familyRef { get; set; }
        [DefaultValue(null)]
        public string familyName { get; set; }
        [DefaultValue(null)]
        public string familyDesc { get; set; }

        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }
        public FamillyDtos(Familly familly)
        {
            this.idFamilly=familly.idFamilly;
            this.familyRef=familly.familyRef;
            this.familyDesc=familly.familyDesc;
            this.familyName=familly.familyName;
            IsAcitve = familly.IsAcitve;
            
        }

        public FamillyDtos()
        {
        }
    }
}
