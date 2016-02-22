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
    
    public partial class Profile
    {
        public int Id { get; set; }
        public string Id_User { get; set; }
        public string Bio { get; set; }
        public string Avatar { get; set; }
        public string Website { get; set; }
        public int Id_CivilStatus { get; set; }
        public int Id_Messenger { get; set; }
        public string MessengerName { get; set; }
        public string Company { get; set; }
        public string Profession { get; set; }
        public int Id_Sector { get; set; }
        public string ProfessionalInterests { get; set; }
        public string ProfessionalSkills { get; set; }
        public string Interests { get; set; }
        public string Hobbies { get; set; }
        public string FavoriteTVSerie { get; set; }
        public string FavoriteMusic { get; set; }
        public string FavoriteSport { get; set; }
        public string FavoriteBooks { get; set; }
        public string FavoriteMovies { get; set; }
        public string FavoriteFood { get; set; }
        public string Heroe { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public int Id_Gender { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual CivilStatus CivilStatus { get; set; }
        public virtual Messenger Messenger { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
