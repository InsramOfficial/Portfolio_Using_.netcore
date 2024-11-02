using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Portfolio.Models
{
    public class Blogs
    {
        [Key]
     public int Id { get; set; }

        [AllowNull]
         public string Title { get; set; }
        [AllowNull]
        public string Description { get; set; }


    }
}
