namespace BibliotecaTrabajo;

public class RepositorioEmpleadoArchTexto
{
    public void AgregarEmpleado(Empleado empleado)
    {
        string? aux;
        using (StreamReader EmpleadoSR= new StreamReader("Empleados.txt"))
       {
           aux= EmpleadoSR.ReadToEnd();
       }
       //Luego escribo el archivo con todo lo que lei y el empleado nuevo a agregar
       using (StreamWriter EmpleadoSR= new StreamWriter("Empleados.txt"))
        {
            EmpleadoSR.Write(aux);
            EmpleadoSR.WriteLine(empleado.GuardarEnArchivo());
        }


    }
    public List<Empleado> GetEmpleados()
    {
        StreamReader EmpleadosSR=new StreamReader("Empleados.txt");
        List<Empleado> lista = new List<Empleado>();
        string? linea;
        string[] vec_empleado;
        while(EmpleadosSR.EndOfStream)
        {
            linea= EmpleadosSR.ReadLine();
            /* El método Split(), al igual que en JavaScript 
             divide a un string según el parámetro */
            if(linea!=null){
            vec_empleado=linea.Split("|");            
            Empleado emp= new Empleado(vec_empleado[0],vec_empleado[1],vec_empleado[2],vec_empleado[3],Convert.ToDateTime(vec_empleado[4]),vec_empleado[5]);
            lista.Add(emp);
            }
        }
        return lista;
    }

     /*Abre el archivo y lo recorre hasta encontrar un empleado,
     Si no se encontró el empleado retorna null
     Si se encontró el empleado, lo retorna */
     public Empleado? GetEmpleado(int Dni)
    {
        try{
            using (StreamReader EmpleadoSR = new StreamReader("Empleados.txt"))
            {
                while(!EmpleadoSR.EndOfStream)
                {
                    string? l= EmpleadoSR.ReadLine();
                    if(l!=null){
                        string[] ? vec_empleado = l.Split('|');
                        if (vec_empleado[0] == Dni.ToString())
                        {
                            Empleado emp= new Empleado(vec_empleado[0],vec_empleado[1],vec_empleado[2],vec_empleado[3],Convert.ToDateTime(vec_empleado[4]),vec_empleado[5]);
                            return emp;
                        } 
                    } 
                } 
                      
            }
        }
        catch
        {
            Console.WriteLine("No se pudo abrir el archivo");
        }
        
        return null;    
    }

    public void ModificarEmpleado(Empleado empleado)
    {
        List<Empleado> listaEmpleados= this.GetEmpleados();
        foreach (var nodo_empleado in listaEmpleados)
        {
            if (nodo_empleado.Dni == empleado.Dni)
            {
                listaEmpleados.Remove(nodo_empleado);
                listaEmpleados.Add(empleado);
                using (StreamWriter EmpleadoSW = new StreamWriter("Empleados.txt"))
                {
                    foreach (var emp in listaEmpleados)
                    {
                        EmpleadoSW.WriteLine(emp.GuardarEnArchivo());
                    }
                }
                break;
            }            
        }
    }

    public void EliminarEmpleado(int Dni)
    {
        List<Empleado> listaEmpleados= this.GetEmpleados();
        foreach (var value in listaEmpleados)
        {
            if (value.Dni == Dni.ToString())
            {
                listaEmpleados.Remove(value);
                using (StreamWriter escritor = new StreamWriter("Empleados.txt"))
                {
                    foreach (var emp in listaEmpleados)
                    {
                        escritor.WriteLine(emp.GuardarEnArchivo());
                    }
                }
                break;
            }            
        }      
        
    }
}