using System.ComponentModel.DataAnnotations.Schema;

namespace EF6SQLite.Contracts
{
    public class VisitDetailsContract
    {
        public int VisitId { get; set; } 
        public int PatientId { get; set; } 
        public DateTime VisitDate { get; set; } 
        public string ProgressNotes { get; set; } = string.Empty; 
        public string SectionName { get; set; } = string.Empty; 
        public decimal Height { get; set; } 
        public decimal Weight { get; set; } 
        public decimal Temperature { get; set; }
    }
}
