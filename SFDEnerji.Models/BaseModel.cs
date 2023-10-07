using System.ComponentModel.DataAnnotations;

namespace SFDEnerji.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
