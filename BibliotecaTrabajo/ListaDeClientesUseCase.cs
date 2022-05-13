namespace BibliotecaTrabajo;
public class ListaDeClientesUseCase
{
        List<Cliente> Ejecutar()
        {
                RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
                return (repo_cli.GetClientes());
            
        }

}