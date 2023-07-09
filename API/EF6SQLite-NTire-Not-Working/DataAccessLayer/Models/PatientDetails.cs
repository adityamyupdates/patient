using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("PatientDetails")]
    public class PatientDetails
    {
        [Key]
        [Column("PatientID")]
        public int PatientID { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;
        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;
        [Column("Address")]
        public string Address { get; set; } = string.Empty;
        [Column("State")]
        public string State { get; set; } = string.Empty;
        [Column("City")]
        public string City { get; set; } = string.Empty;
        [ForeignKey("Organization")]
        [Column("OrganizationId")]
        public int OrganizationId { get; set; }
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }
        public Organization Organization { get; set; }
        public ICollection<VisitDetails> VisitDetails { get; set; }
    }
}
