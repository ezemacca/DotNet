namespace BibliotecaTrabajo;
public class ListaDeEmpleadosUseCase
{
        private RepositorioEmpleadoArchTexto repo_emp= new RepositorioEmpleadoArchTexto();
        
        public List<Empleado> Ejecutar()
        {
            return (repo_emp.GetEmpleados());
        }

}