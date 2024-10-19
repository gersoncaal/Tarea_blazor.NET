using System.ComponentModel.DataAnnotations;

namespace ApiEmpressa.Models;
public class Clientes{
    [Key]
     public Int32 Id_cliente { get; set; }
    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public DateTime? Fecha_nac { get; set; }

}
