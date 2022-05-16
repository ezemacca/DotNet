namespace BibliotecaTrabajo;
public class EliminarEmpleadoUseCase
{
        private RepositorioEmpleadoArchTexto repo_emp= new RepositorioEmpleadoArchTexto();
        public void Ejecutar(int DNI)
        {
            if(repo_emp.GetEmpleado(DNI)!=null){
                repo_emp.EliminarEmpleado(DNI);
            }
            else
            {
                throw new Exception("El empleado que se desea eliminar no existe");
            }
           
        }

}