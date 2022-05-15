namespace BibliotecaTrabajo;

public class ListaDePersonasUseCase
{
    private RepositorioClienteArchTexto repositorioCliente= new RepositorioClienteArchTexto();
    private RepositorioEmpleadoArchTexto repositorioEmpleado= new RepositorioEmpleadoArchTexto();

    public List<Persona> Ejecutar()
    {
        List<Persona> listaDePersonas= new List<Persona>();
        /*
        Se agregan los empleados y clientes a una misma lista
        */
        listaDePersonas.AddRange(repositorioCliente.GetClientes());
        listaDePersonas.AddRange(repositorioEmpleado.GetEmpleados());
        /*
        Se listan las personas con 2 criterios
        */
        return listaDePersonas.OrderBy(primera => primera.Apellido).ThenBy(segunda => segunda.Nombre).ToList();
    }
}