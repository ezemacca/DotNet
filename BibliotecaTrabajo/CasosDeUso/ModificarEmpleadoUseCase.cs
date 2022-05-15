namespace BibliotecaTrabajo;
public class ModificarEmpleadoUseCase{
    private RepositorioEmpleadoArchTexto repo_emp= new RepositorioEmpleadoArchTexto();
   
    /*
     Busca un empleado si DNI no es nulo*/
     void Ejecutar(Empleado emp)
    {
        if(emp!=null)
        {
            RepositorioEmpleadoArchTexto repo_emp= new RepositorioEmpleadoArchTexto();
            if(emp.Dni!=null)
            {
                /*
                    El método get empleado devuelve un empleado si lo encuentra,
                    y ese empleado será modificado con el método ModificarEmpleado
                */
                Empleado? existe = repo_emp.GetEmpleado((int.Parse(emp.Dni)));
                    
                if(existe!=null )
                {
                    repo_emp.ModificarEmpleado(emp); 
                }
                else
                {
                    throw new Exception("El empleado que se desea modificar no existe");
                }
            }
            else
            {
                throw new Exception("El DNI del empleado ingresado para modificar es nulo");
            }             
        }
        else
        {
            throw new Exception("El parámetro ingresado es nulo");
        }
    }
}