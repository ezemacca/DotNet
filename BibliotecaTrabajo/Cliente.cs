namespace BibliotecaTrabajo;

public class Cliente : Persona
{
    private DateTime fecha_ultima_compra;

    public Cliente(string Nombre, string Apellido, string Dni, string Direccion, DateTime Fecha_Nacimiento, DateTime Fecha_ultima_compra)
    {
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Dni=Dni;
        this.Direccion=Direccion;
        this.Fecha_nacimiento=Fecha_nacimiento;
        this.fecha_ultima_compra= Fecha_ultima_compra;
    }

    public DateTime Fecha_ultima_compra { get => fecha_ultima_compra; }

    public int dias_ultima_compra{get=> (DateTime.Now-fecha_ultima_compra).Days ;}

    public override string ToString()
    {
        return $"{this.Dni}|{this.Apellido}|{this.Nombre}|{this.Direccion}|{this.Fecha_nacimiento}|{this.Fecha_ultima_compra}";
    }
}