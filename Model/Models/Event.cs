//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.Images = new HashSet<Image>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public int TypeEventID { get; set; }
        public System.DateTime Date { get; set; }
        public string Text { get; set; }
        public int CoverImageID { get; set; }
        public string Introduction { get; set; }
        public string Path { get; set; }
        public string VideoLink { get; set; }
    
        public virtual Image CoverImage { get; set; }
        public virtual TypeEvent TypeEvent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
    }
}
