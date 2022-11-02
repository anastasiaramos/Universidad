using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int CreatorUserId { get; set; }
        //[NotMapped]
        //public virtual BaseEntity? CreatorUser { get; set; } = new BaseEntity();
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int UpdaterUserId { get; set; }
        //[NotMapped]
        //public virtual BaseEntity? UpdaterUser { get; set; } = new BaseEntity();
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public int RemoverUserId { get; set; }
        //[NotMapped]
        //public virtual BaseEntity? RemoverUser { get; set; } = new BaseEntity();
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;




    }
}
