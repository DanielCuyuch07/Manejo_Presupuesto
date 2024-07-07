using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "el campo {0} es requerido ")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }


        /* Campos de pruebas */

        [Required (ErrorMessage = " El campo {0} es requerido ")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electronico valido")]
        public string Email { get; set; }

        [Range(minimum:18, maximum:130, ErrorMessage = "El valor debe estar entre {1} y {2}")]
        public int Edad { get; set; }

        [Url(ErrorMessage = "El campo debe ser una URL valida")]
        public string URL { get; set; }

        [CreditCard(ErrorMessage = "La tarjeta de credito no es valida")]
        public string TarjetaCredito { get; set; }

    }
}
