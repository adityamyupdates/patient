using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientApp.Shared.Model
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string ProgressNotes { get; set; } = string.Empty;
        public string SectionName { get; set; } = string.Empty;
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal Temperature { get; set; }
    }
}
