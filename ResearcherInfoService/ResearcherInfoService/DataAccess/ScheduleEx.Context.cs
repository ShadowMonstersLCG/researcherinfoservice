﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResearcherInfoService.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScheduleExEntities : DbContext
    {
        public ScheduleExEntities()
            : base("name=ScheduleExEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApprovalStatus> ApprovalStatuses { get; set; }
        public virtual DbSet<Expertise> Expertises { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ResearcherApproval> ResearcherApprovals { get; set; }
        public virtual DbSet<ResearcherAvailability> ResearcherAvailabilities { get; set; }
        public virtual DbSet<ResearcherExpertise> ResearcherExpertises { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
