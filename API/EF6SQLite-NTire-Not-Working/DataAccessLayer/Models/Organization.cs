using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("Organization")]
    public class Organization
    {
        [Key]
        [Column("OrganizationId")]
        public int OrganizationId { get; set; }
        [Column("OrganizationName")]
        public string OrganizationName { get; set; } = string.Empty;

        public ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
