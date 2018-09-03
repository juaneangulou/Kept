//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeptWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompetencyAndPerformance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetencyAndPerformance()
        {
            this.AssessmentTestQuestions = new HashSet<AssessmentTestQuestions>();
            this.CAndPByPP = new HashSet<CAndPByPP>();
            this.OportunitiesOfImprovement = new HashSet<OportunitiesOfImprovement>();
            this.Strengths = new HashSet<Strengths>();
        }
    
        public long CAndPId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompetency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentTestQuestions> AssessmentTestQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAndPByPP> CAndPByPP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OportunitiesOfImprovement> OportunitiesOfImprovement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Strengths> Strengths { get; set; }
    }
}
