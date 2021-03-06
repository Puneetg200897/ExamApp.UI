﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamApp.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TTEntities : DbContext
    {
        public TTEntities()
            : base("name=TTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CMSContent> CMSContents { get; set; }
        public virtual DbSet<CMSModule> CMSModules { get; set; }
        public virtual DbSet<CMSPage> CMSPages { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Examination> Examinations { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<ExamUser> ExamUsers { get; set; }
        public virtual DbSet<GroupMaster> GroupMasters { get; set; }
        public virtual DbSet<OptionMaster> OptionMasters { get; set; }
        public virtual DbSet<QuizMaster> QuizMasters { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubGroupMaster> SubGroupMasters { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    
        public virtual ObjectResult<string> ManageCMSContent(string pflag, Nullable<long> iD, Nullable<int> moduleID, string pageName, string keyName, string language, string content, Nullable<long> createdBy)
        {
            var pflagParameter = pflag != null ?
                new ObjectParameter("pflag", pflag) :
                new ObjectParameter("pflag", typeof(string));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(long));
    
            var moduleIDParameter = moduleID.HasValue ?
                new ObjectParameter("ModuleID", moduleID) :
                new ObjectParameter("ModuleID", typeof(int));
    
            var pageNameParameter = pageName != null ?
                new ObjectParameter("PageName", pageName) :
                new ObjectParameter("PageName", typeof(string));
    
            var keyNameParameter = keyName != null ?
                new ObjectParameter("KeyName", keyName) :
                new ObjectParameter("KeyName", typeof(string));
    
            var languageParameter = language != null ?
                new ObjectParameter("Language", language) :
                new ObjectParameter("Language", typeof(string));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ManageCMSContent", pflagParameter, iDParameter, moduleIDParameter, pageNameParameter, keyNameParameter, languageParameter, contentParameter, createdByParameter);
        }
    
        public virtual ObjectResult<string> ManageContent(string pflag, Nullable<long> iD, Nullable<int> moduleID, string pageName, string keyName, string content, Nullable<long> createdBy)
        {
            var pflagParameter = pflag != null ?
                new ObjectParameter("pflag", pflag) :
                new ObjectParameter("pflag", typeof(string));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(long));
    
            var moduleIDParameter = moduleID.HasValue ?
                new ObjectParameter("ModuleID", moduleID) :
                new ObjectParameter("ModuleID", typeof(int));
    
            var pageNameParameter = pageName != null ?
                new ObjectParameter("PageName", pageName) :
                new ObjectParameter("PageName", typeof(string));
    
            var keyNameParameter = keyName != null ?
                new ObjectParameter("KeyName", keyName) :
                new ObjectParameter("KeyName", typeof(string));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ManageContent", pflagParameter, iDParameter, moduleIDParameter, pageNameParameter, keyNameParameter, contentParameter, createdByParameter);
        }
    }
}
