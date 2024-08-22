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
        public static Deporte VerInfoDeporte(int idDeporte){
            Deporte deporte=null;
        string SQL ="SELECT * FROM Deportes where IdDeporte=@pIdDeporte";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            deporte=db.QueryFirstOrDefault<Deporte>(SQL, new{pIdDeporte = idDeporte });
        }
        return deporte;
    }
        public static Pais VerInfoPais(int idPais){
            Pais pais=null;
        string SQL ="SELECT * FROM Paises where IdPais=@pIdPais";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            pais=db.QueryFirstOrDefault<Pais>(SQL, new{pIdPais = idPais });
        }
        return pais;
    }
        public static Deportista VerInfoDeportista(int idDeportista){
            Deportista deportista=null;
        string SQL ="SELECT * FROM Deportistas where IdDeportista=@pIdDeportista";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            deportista=db.QueryFirstOrDefault<Deportista>(SQL, new{pIdDeportista = idDeportista });
        }
        return deportista;
    }
    public static List<Pais> ListarPaises()
    {
        List<Pais>ListadoPaises=new List<Pais>();
        using (SqlConnection db= new SqlConnection(_connectionString)){
            string SQL = "SELECT * FROM Paises";
            ListadoPaises=db.Query<Pais>(SQL).ToList();
        }
        return ListadoPaises;
    }
    public static List<Deporte> ListarDeportes()
    {
        List<Deporte>ListadoDeportes=new List<Deporte>();
        using (SqlConnection db= new SqlConnection(_connectionString)){
            string SQL = "SELECT * FROM Deportes";
            ListadoDeportes=db.Query<Deporte>(SQL).ToList();
        }
        return ListadoDeportes;
    }

    public static List<Deportista> ListarDeportistasxDeporte(int idDeporte){
        List<Deportista> ListadoDeportistasxDeporte=new List<Deportista>();
        using(SqlConnection db=new SqlConnection(_connectionString)){
            string SQL="Select * From Deportistas where IdDeporte=@pIdDeporte";
            ListadoDeportistasxDeporte=db.Query<Deportista>(SQL).ToList();
        }
        return ListadoDeportistasxDeporte;
    }
    public static List<Deportista> ListarDeportistasxPais(int idPais){
        List<Deportista> ListadoDeportistasxPais=new List<Deportista>();
        using(SqlConnection db=new SqlConnection(_connectionString)){
            string SQL="Select * From Deportistas where IdPais=@pIdPais";
            ListadoDeportistasxPais=db.Query<Deportista>(SQL).ToList();
        }
        return ListadoDeportistasxPais;
    }
}