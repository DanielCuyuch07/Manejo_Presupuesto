/*
    Author : Andy Daniel Cuyuch Chitay 
    Fecha de creacion : 11-07-24  10:30 pm
    Objetivo : Creacion de modelo con validacion de campos.
 */

using Dapper;
using ManejoPresupuesto.Interface;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Services
{

    public class RepositorioTiposCuentas: IRepositorioTiposCuentas
    {
        // [acuyuch] Accedemos al connection String
        private readonly string connectionString;

        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // [acuyuch]

        public async Task  CrearTipoCuenta(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>($@"
            INSERT INTO Tipo_Cuentas(Nombre,UsuarioId,Orden)
            VALUES (@Nombre, @UsuarioId, 0);
            SELECT SCOPE_IDENTITY();", tipoCuenta);
            tipoCuenta.Id = id;

        }

        public async Task<bool> ValidateRepeatExist(string nombre, int usuarioid)
        {
            using var connection = new SqlConnection(connectionString);
            var existe = await connection.QueryFirstOrDefaultAsync<int>(
                    @"SELECT 1 
                    FROM Tipo_Cuentas 
                    Where Nombre = @Nombre AND UsuarioId = @UsuarioId;", new { nombre, usuarioid});
            return existe == 1;
        }

    }
}
