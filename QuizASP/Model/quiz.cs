using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizASP.Model
{
    public class quiz
    {
       [Key]
        public int Kerdes_id { get; set; }

        [Required(ErrorMessage ="A mező kitöltése kötelező!")]
        public string Kerdes { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Valasz_A { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Valasz_B { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Valasz_C { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Valasz_D { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Helyes { get; set; }
    }
}
