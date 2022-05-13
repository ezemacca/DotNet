namespace BibliotecaTrabajo;
public class EliminarClienteUseCase
{
        void Ejecutar(int DNI)
        {
                RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
                repo_cli.EliminarCliente(DNI);
            
        }

}