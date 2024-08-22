namespace TP_JJOO_Castera_Sass_n.Models;

public class Deporte
{
public int IdDeporte {get; set;}
public string Nombre {get; set;}
public string Foto {get; set;}

public Deporte(){
}
public Deporte(int iddeporte, string nombre, string foto)
{
    iddeporte=IdDeporte;
    nombre=Nombre;
    foto=Foto;
}
}