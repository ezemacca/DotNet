namespace BibliotecaTrabajo;

public class Empleado:Persona
{
    private string legajo;
    public string Legajo { get => legajo; set => legajo = value; } 
    public Empleado(string Dni,string Apellido, string Nombre,   string Direccion, DateTime Fecha_Nacimiento,string Legajo)
    {
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Dni=Dni;
        this.Direccion=Direccion;
        this.Fecha_nacimiento=Fecha_nacimiento;
        this.legajo= Legajo;
    }
/*
Se utiliza para facilitar su visualización en consola
*/
   public override string ToString()
        {
            return $"{this.Apellido}, {this.Nombre} ({this.Dni}) Dir:{this.Direccion} F.Nac:{this.Fecha_nacimiento} Legajo:{this.legajo}]";
        }
/*
Se utiliza para guardar en el formato deseado en el archivo
*/
    public string GuardarEnArchivo()
    {
        return $"{this.Dni}|{this.Apellido}|{this.Nombre}|{this.Direccion}|{this.Fecha_nacimiento}|{this.legajo}";
    }
}