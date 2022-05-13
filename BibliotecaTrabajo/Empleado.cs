namespace BibliotecaTrabajo;

public class Empleado:Persona
{
    private string legajo;

   

    public string Legajo { get => legajo; set => legajo = value; } 
    public Empleado(string Legajo)
    {
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Dni=Dni;
        this.Direccion=Direccion;
        this.Fecha_nacimiento=Fecha_nacimiento;
        this.legajo= Legajo;
    }

    public override string ToString()
    {
        return $"{this.Dni}|{this.Apellido}|{this.Nombre}|{this.Direccion}|{this.Fecha_nacimiento}|{this.Legajo}";
    }
}