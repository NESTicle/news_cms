//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace News_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post_Tags
    {
        public int Id { get; set; }
        public Nullable<int> Id_Post { get; set; }
        public Nullable<int> Id_Tags { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual Tags Tags { get; set; }
    }
}
