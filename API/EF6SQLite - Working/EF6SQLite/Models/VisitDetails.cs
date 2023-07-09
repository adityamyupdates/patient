using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    [Table("VisitDetails")]
    public class VisitDetails
    {
        [Key]
        [Column("VisitId")]
        public int VisitId { get; set; }
        [ForeignKey("PatientDetails")]
        [Column("PatientId")]
        public int PatientId { get; set; }
        [Column("VisitDate")]
        public DateTime VisitDate { get; set; }
        [Column("ProgressNotes")]
        public string ProgressNotes { get; set; } = string.Empty;
        [Column("SectionName")]
        public string SectionName { get; set; } = string.Empty;
        [Column("Height")]
        public decimal Height { get; set; }
        [Column("Weight")]
        public decimal Weight { get; set; }
        [Column("Temperature")]
        public decimal Temperature { get; set; }
        public PatientDetails PatientDetails { get; set; }

    }

