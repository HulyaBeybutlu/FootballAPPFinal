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
    
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            this.Comment_Report = new HashSet<Comment_Report>();
        }
    
        public int ID { get; set; }
        public string Comment1 { get; set; }
        public System.DateTime CommentDate { get; set; }
        public int CustomerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Report> Comment_Report { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
