namespace BibliotecaTrabajo;
public class ModificarClienteUseCase{
    private RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
   
    /*
     Busca un cliente si DNI no es nulo
     */
     void Ejecutar(Cliente cli)
    {
        if(cli!=null)
        {
            RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
            if(cli.Dni!=null)
            {
                /*
                    El método get cliente devuelve un cliente si lo encuentra,
                    y ese cliente será modificado con el método ModificarCliente
                */
                Cliente? existe = repo_cli.GetCliente((int.Parse(cli.Dni)));
                    
                if(existe!=null )
                {
                    repo_cli.ModificarCliente(cli); 
                }
                else
                {
                    throw new Exception("El cliente que se desea modificar no existe");
                }
            }
            else
            {
                throw new Exception("El DNI del cliente ingresado para modificar es nulo");
            }             
        }
        else
        {
            throw new Exception("El parámetro ingresado es nulo");
        }
    }
}