﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public partial class TypeEventView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeEventView()
        {
            this.Event = new HashSet<Event>();
        }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }
    }
    public partial class TypeServiceView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeServiceView()
        {
            this.Service = new HashSet<Service>();
        }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Service { get; set; }
    }
    public partial class ServiceView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceView()
        {
            this.Event = new HashSet<Event>();
        }

        public string Name { get; set; }
        public int TypeService { get; set; }
        public string ServiceLink { get; set; }

        public virtual TypeService TypeService1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }
    }
    public partial class ImageView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageView()
        {
            this.Event = new HashSet<Event>();
            this.Event1 = new HashSet<Event>();
        }

        public string Title { get; set; }
        public string ImagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event1 { get; set; }
    }
    public partial class EventView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventView()
        {
            this.Image1 = new HashSet<Image>();
            this.Service = new HashSet<Service>();
        }

        public string Title { get; set; }
        public int TypeEventID { get; set; }
        public System.DateTime Date { get; set; }
        public string Text { get; set; }
        public Nullable<int> ImageID { get; set; }
        public string VideoLink { get; set; }
        public bool IsImage { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public virtual Image Image { get; set; }
        public virtual TypeEvent TypeEvent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Service { get; set; }
    }
}