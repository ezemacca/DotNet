namespace BibliotecaTrabajo;
public abstract class Persona
{
    private string nombre;
    private string apellido;
    private string dni;
    private string direccion;
    private DateTime fecha_nacimiento;

    public string Nombre{get=>nombre; set=> nombre=value;}
    public string Apellido { get => apellido; set => apellido = value; }
    public string Dni { get => dni; set => dni = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
}
