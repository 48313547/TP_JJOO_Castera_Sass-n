namespace TP_JJOO_Castera_Sass_n.Models;

public class Pais
{
    public int IdPais {get; set;}
    public string Nombre{get; set;}
    public string Bandera{get; set;}
    public DateTime FechaFundacion {get; set;}
    public Pais(){
    }

    
    public Pais(int idpais, string nombre, string bandera, DateTime fechafundacion){
        IdPais=idpais;
        nombre=Nombre;
        bandera=Bandera;
        fechafundacion=FechaFundacion;
    }
}