using ERP_Anass_backend.Models;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class FamillyDtos
    {
        public int idFamilly;
        public string familyRef { get; set; }
        public string familyName { get; set; }
        public string familyDesc { get; set; }
        public FamillyDtos(Familly familly)
        {
            this.idFamilly=familly.idFamilly;
            this.familyRef=familly.familyRef;
            this.familyDesc=familly.familyDesc;
            this.familyName=familly.familyName;
            
        }
    }
}
