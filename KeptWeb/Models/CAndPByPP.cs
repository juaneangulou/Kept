//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeptWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAndPByPP
    {
        public long PPId { get; set; }
        public long CoPId { get; set; }
        public int AchievementPorcentage { get; set; }
        public bool AssessmentCompleted { get; set; }
    
        public virtual CompetencyAndPerformance CompetencyAndPerformance { get; set; }
        public virtual PerformanceProfile PerformanceProfile { get; set; }
    }
}