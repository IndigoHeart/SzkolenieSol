using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Szkolenie.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Name { get; set; }
        [StringLength(20, ErrorMessage = "No more then 20 characters")]
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(1, 10, ErrorMessage = "Enter a number from 1 to 10")]
        public float UserRate { get; set; }
        public int NumberOfPages { get; set; }
    }
}
