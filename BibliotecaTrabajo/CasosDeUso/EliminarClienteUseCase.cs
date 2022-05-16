namespace BibliotecaTrabajo;
public class EliminarClienteUseCase
{
        private RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
        public void Ejecutar(int DNI)
        {
            if(repo_cli.GetCliente(DNI)!=null){
                repo_cli.EliminarCliente(DNI);
            }
            else
            {
                throw new Exception("El Cliente que se desea eliminar no existe");
            }  
        }

}