namespace TP_JJOO_Castera_Sass_n.Models;
public class Deportista
{
    public int IdDeportista {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Foto {get; set;}
    public int IdPais {get; set;}
    public int IdDeporte {get; set;}
    public Deportista(){}
    public Deportista(int iddeportista, string nombre, string apellido, DateTime fechanacimiento, string foto, int idpais,int iddeporte){
        iddeportista = IdDeportista;
        nombre = Nombre;
        apellido = Apellido;
        fechanacimiento = FechaNacimiento;
        foto = Foto;
        idpais = IdPais;
        iddeporte = IdDeporte;
    }
}