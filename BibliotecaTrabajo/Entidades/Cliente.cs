namespace BibliotecaTrabajo;

public class Cliente : Persona
{
    private DateTime  fecha_ultima_compra;

    public Cliente(string Dni, string Apellido,string Nombre,  string Direccion, DateTime Fecha_Nacimiento, DateTime Fecha_ultima_compra)
    {
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Dni=Dni;
        this.Direccion=Direccion;
        this.Fecha_nacimiento=Fecha_Nacimiento;
        this.fecha_ultima_compra= Fecha_ultima_compra;
    }

    public DateTime Fecha_ultima_compra { get => fecha_ultima_compra; }

    public int dias_ultima_compra{get=> (DateTime.Now-fecha_ultima_compra).Days ;}
/*
Se utiliza para facilitar su visualización en consola
*/
    public override string ToString()
        {
            return $"{this.Apellido}, {this.Nombre} ({this.Dni}) Dir:{this.Direccion} F.Nac:{this.Fecha_nacimiento} Ultima compra:{this.Fecha_ultima_compra.ToString("dd/MM/yyyy")} [CLIENTE]";
        }
        
/*
Se utiliza para guardar en el formato deseado en el archivo
*/
    public string GuardarEnArchivo()
    {
        return $"{this.Dni}|{this.Apellido}|{this.Nombre}|{this.Direccion}|{this.Fecha_nacimiento}|{this.Fecha_ultima_compra.ToString("dd/MM/yyyy")}";
    }
}