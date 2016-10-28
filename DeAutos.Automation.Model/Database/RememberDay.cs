//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace DeAutos.Automation.Model.Database
{
    public partial class RememberDay
    {
        public RememberDay()
        {
            this.AuditRememberDays = new HashSet<AuditRememberDay>();
            this.RememberDayItems = new HashSet<RememberDayItem>();
        }
    
        public int Id { get; set; }
        public Nullable<int> RememberId { get; set; }
        public DateTime ContactDate { get; set; }
        public string State { get; set; }
        public Guid KeyGuidMail { get; set; }
        public Nullable<int> ConversationId { get; set; }
    
        public virtual ICollection<AuditRememberDay> AuditRememberDays { get; set; }
        public virtual Remember Remember { get; set; }
        public virtual Conversation Conversation { get; set; }
        public virtual ICollection<RememberDayItem> RememberDayItems { get; set; }
    }
}