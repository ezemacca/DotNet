namespace BibliotecaTrabajo;
public class AgregarEmpleadoUseCase
{
    private RepositorioEmpleadoArchTexto repo_emp= new RepositorioEmpleadoArchTexto();
    void Ejecutar(Empleado emp)
    {
        if(emp!=null)
        {
            if(emp.Dni!=null)
            {
                Empleado? existe = repo_emp.GetEmpleado((int.Parse(emp.Dni)));
                /*
                El método get empleado devuelve nulo si no encontró un empleado con
                el mismo DNI, es decir, se puede agregar el empleado.
                */
               if(existe==null )
                {
                    repo_emp.AgregarEmpleado(emp); 
                }
                else
                {
                    throw new Exception("El empleado que se desea agregar ya existe");
                }
            }
            else
            {
                throw new Exception("El DNI del empleado es nulo");
            }             
        }
        else
        {
            throw new Exception("El parámetro ingresado es nulo");
        }
       
    }
}