//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace DeAutos.Automation.Model.Database
{
    public partial class Remember
    {
        public Remember()
        {
            this.RememberDays = new HashSet<RememberDay>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Discriminator { get; set; }
    
        public virtual ICollection<RememberDay> RememberDays { get; set; }
    }
}