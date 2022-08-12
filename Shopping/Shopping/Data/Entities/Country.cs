using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")] // esto es otro DataAnnotations que sirve apar definar la cantidad maxima de caracteres 
        [Required(ErrorMessage ="el campo {0} es obligatorio.")]// un DataAnnotations se hace para validar es decir no me deja crear un pais sin un nombre 
        // si el required lo dejamos asi [Required] el usuario le va aparecer un mensaje que no va a entender
        // es mejor ponerlo con parentesis
        [Display(Name = "País")]
        public string Name { get; set; }

        


    }
}
