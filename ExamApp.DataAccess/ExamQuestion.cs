//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ExamQuestion
    {
        public long ID { get; set; }
        public long ExamID { get; set; }
        public long QuestionID { get; set; }
        public long OptionID { get; set; }
        public string QuestionStatus { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual Examination Examination { get; set; }
        public virtual OptionMaster OptionMaster { get; set; }
        public virtual QuizMaster QuizMaster { get; set; }
    }
}
