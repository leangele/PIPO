﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabTrack
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CasesControlEntities : DbContext
    {
        public CasesControlEntities()
            : base("name=CasesControlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<CaseControl> CaseControls { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Technitian> Technitians { get; set; }
        public virtual DbSet<TechnitianXArea> TechnitianXAreas { get; set; }
    
        public virtual ObjectResult<SearchInformation_Result> SearchInformation(Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, string filter)
        {
            var dateStartParameter = dateStart.HasValue ?
                new ObjectParameter("DateStart", dateStart) :
                new ObjectParameter("DateStart", typeof(System.DateTime));
    
            var dateEndParameter = dateEnd.HasValue ?
                new ObjectParameter("DateEnd", dateEnd) :
                new ObjectParameter("DateEnd", typeof(System.DateTime));
    
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchInformation_Result>("SearchInformation", dateStartParameter, dateEndParameter, filterParameter);
        }
    }
}
