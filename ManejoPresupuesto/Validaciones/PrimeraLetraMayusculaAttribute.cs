/*
    Author : Andy Daniel Cuyuch Chitay 
    Fecha de creacion : 11-07-24  10:30 pm
    Objetivo : Validacion de formularios 
 */


// [acuyuch] Clases para validar propiedades de datos
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    public class PrimeraLetraMayusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            // [acuyuch] Valida el value que no venga nulo o vacio
            if(value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            // [acuyuch] Obtenemos al primera letra (Se pasa primero a caracter y se tomo la primera letra [0] y se convierte en caracter)
            var firtLetter = value.ToString()[0].ToString();

            // [acuyuch] Se compara la primera letra con su version en mayuscula
            if (firtLetter != firtLetter.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayuscula");
            }

            return ValidationResult.Success;

        }
    }
}
