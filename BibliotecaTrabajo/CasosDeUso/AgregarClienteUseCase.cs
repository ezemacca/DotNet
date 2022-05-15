namespace BibliotecaTrabajo;
public class AgregarClienteUseCase
{
    private RepositorioClienteArchTexto repo_cli= new RepositorioClienteArchTexto();
    public void Ejecutar(Cliente cli)
    {
        if(cli!=null)
        {
            if(cli.Dni!=null)
            {
                Cliente? existe=repo_cli.GetCliente(int.Parse(cli.Dni));
                /*
                El método get cliente devuelve nulo si no encontró un cliente con
                el mismo DNI, es decir, se puede agregar el cliente.
                */
                if( existe == null )
                {
                    repo_cli.AgregarCliente(cli); 
                }
                else
                {
                    throw new Exception("El cliente que se desea agregar ya existe");
                }
            }
            else
            {
                throw new Exception("El DNI del cliente es nulo");
            }             
        }
        else
        {
            throw new Exception("El parámetro ingresado es nulo");
        }
       
    }
}