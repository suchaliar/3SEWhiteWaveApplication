//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhiteWaveApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Description
    {
        public Description()
        {
            this.Accounts = new HashSet<Account>();
            this.AccountTypes = new HashSet<AccountType>();
            this.Customers = new HashSet<Customer>();
            this.Events = new HashSet<Event>();
            this.Locations = new HashSet<Location>();
            this.Projects = new HashSet<Project>();
            this.SupportEvents = new HashSet<SupportEvent>();
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string Text { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AccountType> AccountTypes { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SupportEvent> SupportEvents { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}