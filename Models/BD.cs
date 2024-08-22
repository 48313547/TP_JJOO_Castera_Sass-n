using System.Data.SqlClient;
using Dapper;
namespace TP_JJOO_Castera_Sass_n.Models;
static class BD{
    private static string _connectionString = @"Server=A-PHZ2-CIDI-35; DataBase=JJOO; Trusted_Connection=True;";
    
    public static void AgregarDeportista(Deportista dep){
        string SQL ="Insert Into Deportistas(IdDeportista, Nombre, Apellido, FechaNacimiento, IdPais, IdDeporte) Values (@pIdDeportista, @pNombre, @pApellido, @pFechaNacimiento, @pIdPais, @pIdDeporte)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdDeportista = dep.IdDeportista, pNombre = dep.Nombre, pApellido = dep.Apellido, pFechaNacimiento = dep.FechaNacimiento, pIdPais = dep.IdPais, pIdDeporte = dep.IdDeporte });
        }
    }
    public static void EliminarDeportista(int idDeportista){
        string SQL ="DELETE from Deportistas where IdDeportista=@IdDeportista()";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL,new{pIdDeportista = idDeportista} );
        }
    }
    public static void VerInfoDeporte(int idDeporte){
        string SQL ="SELECT* FROM Deportes where IdDeporte=@pIdDeporte";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdDeporte = idDeporte });
        }
    }
}