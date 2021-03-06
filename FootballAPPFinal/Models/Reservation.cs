//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballAPPFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public int StadiumID { get; set; }
        public int RoomID { get; set; }
        public System.DateTime ResStartDate { get; set; }
        public System.DateTime ResEndDate { get; set; }
        public int Amount { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
