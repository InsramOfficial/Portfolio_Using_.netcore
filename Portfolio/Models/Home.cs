using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;

namespace Portfolio.Models
{
    public class Home
    {
        public int Id { get; set; }
        [AllowNull]
        public string FirstName { get; set; }
        [AllowNull]
        public string LastName { get; set; }
        [AllowNull]
        public DateTime DateOfBirth { get; set; }
        
        [AllowNull]
        public string Address { get; set; }
        [AllowNull]
        public string ZipCode { get; set; }
        [AllowNull]
        public string Email { get; set; }
        [AllowNull]
        public string Phone { get; set; }
        [AllowNull]
        public string ProNO { get; set; }
        
        //public string ImageName { get; set; }
        //public IFormFile Image { get; set; }

    }
}
