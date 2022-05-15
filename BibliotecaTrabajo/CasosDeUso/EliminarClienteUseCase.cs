namespace BibliotecaTrabajo;
public class EliminarClienteUseCase
{
        private RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
        void Ejecutar(int DNI)
        {
            if(repo_cli.GetCliente(DNI)!=null){
                repo_cli.EliminarCliente(DNI);
            }
            else
            {
            throw new Exception("El cliente que se desea eliminar no existe");
            }
           
        }

}