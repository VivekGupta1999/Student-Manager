using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDWithEF.Models
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
    }

    internal class StudentMetaData
    {
        [Required(ErrorMessage ="Id is the primary key. It's required.")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name should not be blank.")]
        public string Name { get; set; }

        [Range(0.0, 5.0, ErrorMessage ="Grade should be within 0.0 to 5.0")]
        [Required]
        public Nullable<double> Grade { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Display(Name ="Faculty")]
        public Nullable<int> FId { get; set; }
    }
}