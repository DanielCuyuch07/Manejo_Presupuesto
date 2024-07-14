using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Interface
{
    public interface IRepositorioTiposCuentas
    {
        Task CrearTipoCuenta(TipoCuenta tipoCuenta);
        Task<bool> ValidateRepeatExist(string nombre, int usuarioid);
    }
}
