namespace BibliotecaTrabajo;
public class AgregarClienteUseCase{
    void Ejecutar(Cliente cli){
        RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
        Cliente existe = repo_cli.GetCliente((Int32.Parse(cli.Dni)));
        if(existe!=null)
        {
           // creo excepcion
           throw new Exception("El cliente que se desea agregar ya existe");
        }
        else
        {
           repo_cli.AgregarCliente(cli); 
        }
            
        
       
    }
}