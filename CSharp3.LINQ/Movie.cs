//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharp3.LINQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public Movie()
        {
            this.Reviews = new HashSet<Review>();
        }
    
        public int MovieId { get; set; }
        public string Title { get; set; }
        public System.DateTime ReleaseDate { get; set; }
    
        public virtual ICollection<Review> Reviews { get; set; }
    }
}