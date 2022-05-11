namespace BibliotecaTrabajo;
public abstract class Persona
{
    private string nombre;
    private string apellido;
    private string dni;
    private string direccion;
    private string fecha_nacimiento;

    public string Nombre{get=>nombre; set=> nombre=value};
    public string Apellido{};
    public string DNI{};
    public string Direccion{};
    public string Fecha_nacimiento{};
}
