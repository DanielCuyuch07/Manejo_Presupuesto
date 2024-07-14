/*
    Author : Andy Daniel Cuyuch Chitay 
    Fecha de creacion : 11-07-24  10:30 pm
    Objetivo : Creacion de modelo con validacion de campos.
 */

using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta 
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "el campo {0} es requerido ")] 
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

    }
}
