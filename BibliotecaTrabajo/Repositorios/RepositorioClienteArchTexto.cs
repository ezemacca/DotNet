namespace BibliotecaTrabajo;

public class RepositorioClienteArchTexto : IRepositorioCliente
{
    public void AgregarCliente(Cliente cliente)
    {
        string? aux;
        using (StreamReader ClienteSR= new StreamReader("./Clientes.txt"))
        {
           aux= ClienteSR.ReadToEnd();
        }
       //Luego escribo el archivo con todo lo que lei y el cliente nuevo a agregar
       using (StreamWriter ClienteSR= new StreamWriter("./Clientes.txt"))
        {
            ClienteSR.Write(aux);
            ClienteSR.WriteLine(cliente.GuardarEnArchivo());
        }


    }
    public List<Cliente> GetClientes()
    {
        using StreamReader ClientesSR=new StreamReader("./Clientes.txt");
        List<Cliente> lista = new List<Cliente>();
        string? linea;
        string[] vec_cliente;
        while(!ClientesSR.EndOfStream)
        {
            linea= ClientesSR.ReadLine();
            /* El método Split(), al igual que en JavaScript 
             divide a un string según el parámetro */
            if(linea!=null){
                vec_cliente=linea.Split("|");            
                Cliente cli= new Cliente(vec_cliente[0],vec_cliente[1],vec_cliente[2],vec_cliente[3],Convert.ToDateTime(vec_cliente[4]),Convert.ToDateTime(vec_cliente[5]));
            lista.Add(cli);
            }
        }
        return lista;
    }

     /*Abre el archivo y lo recorre hasta encontrar un cliente,
     Si no se encontró el cliente retorna null
     Si se encontró el cliente, lo retorna */
     public Cliente? GetCliente(int Dni)
    {
        Cliente cli;
        try{
            using (StreamReader ClienteSR = new StreamReader("./Clientes.txt"))
            {
                while(!ClienteSR.EndOfStream)
                {
                    string? l = ClienteSR.ReadLine();
                    if(l != null){
                        string[] ? vec_cliente = l.Split('|');
                        if (vec_cliente[0] == Dni.ToString())
                        {
                            cli= new Cliente(vec_cliente[0],vec_cliente[1],vec_cliente[2],vec_cliente[3],Convert.ToDateTime(vec_cliente[4]),Convert.ToDateTime(vec_cliente[5]));
                            return cli;
                        } 
                    } 
                } 
                      
            }
        }
        catch
        {
            Console.WriteLine("No se pudo abrir el archivo");
        }
        
        return null;    
    }

    public void ModificarCliente(Cliente cliente)
    {
        List<Cliente> listaClientes= this.GetClientes();
        foreach (var nodo_cliente in listaClientes)
        {   
            if (nodo_cliente.Dni== cliente.Dni)
            {
                listaClientes.Remove(nodo_cliente);
                listaClientes.Add(cliente);
                using (StreamWriter ClienteSW = new StreamWriter("./Clientes.txt"))
                {
                    foreach (var cli in listaClientes)
                    {
                        ClienteSW.WriteLine(cli.GuardarEnArchivo());
                    }
                }
                break;
            }            
        }
    }

    public void EliminarCliente(int Dni)
    {
        List<Cliente> listaClientes= this.GetClientes();
        foreach (var value in listaClientes)
        {
            if (value.Dni == Dni.ToString())
            {
                listaClientes.Remove(value);
                using (StreamWriter escritor = new StreamWriter("./Clientes.txt"))
                {
                    foreach (var cli in listaClientes)
                    {
                        escritor.WriteLine(cli.GuardarEnArchivo());
                    }
                }
                break;
            }            
        }      
        
    }


     
       
    
}