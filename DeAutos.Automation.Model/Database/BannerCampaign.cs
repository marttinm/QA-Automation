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
    public partial class BannerCampaign
    {
        public BannerCampaign()
        {
            this.PeopleToBeContacteds = new HashSet<PeopleToBeContacted>();
        }
    
        public int P_Id { get; set; }
        public string A_Name { get; set; }
        public int F_VehicleModel_Id { get; set; }
        public DateTime A_CreationDate { get; set; }
        public string A_BannerSize { get; set; }
        public string A_Origin { get; set; }
    
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual ICollection<PeopleToBeContacted> PeopleToBeContacteds { get; set; }
    }
}
