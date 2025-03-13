using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class PermissionDtos
    {
       

        public int IdPermission { get; set; }
        public Guid? UserId { get; set; }=Guid.NewGuid();
        [DefaultValue(0)]
        public int? IdModule { get; set; }
        [DefaultValue(false)]
        public bool Add { get; set; }
        [DefaultValue(false)]
        public bool Edit { get; set; }
        [DefaultValue(false)]
        public bool Delete { get; set; }

        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }
        public PermissionDtos(Permission permission)
        {
            IdPermission = permission.IdPermission;
            UserId =  permission.UserId;
            IdModule =  permission.IdModule;
            Add =  permission.Add;
            Edit =  permission.Edit;
            Delete =  permission.Delete;
            IsAcitve=permission.IsAcitve;
        }

        public PermissionDtos()
        {
        }
    }
}
