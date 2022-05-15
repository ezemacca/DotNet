namespace BibliotecaTrabajo;
public class ListaDeClientesUseCase
{
        private RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
        
        public List<Cliente> Ejecutar()
        {
            return (repo_cli.GetClientes());
        }

}