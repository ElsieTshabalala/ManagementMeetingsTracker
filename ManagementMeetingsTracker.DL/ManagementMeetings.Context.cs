﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementMeetingsTracker.BE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ManagementMeetingsEntities : DbContext
    {
        public ManagementMeetingsEntities()
            : base("name=ManagementMeetingsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingItem> MeetingItems { get; set; }
        public virtual DbSet<MeetingItemStatu> MeetingItemStatus { get; set; }
        public virtual DbSet<MeetingType> MeetingTypes { get; set; }
    }
}
