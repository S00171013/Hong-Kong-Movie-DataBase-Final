//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hong_Kong_Movie_DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Director { get; set; }
        public string RunningTime { get; set; }
        public string PosterImage { get; set; }
        public string Actor { get; set; }
    }
}