namespace BibliotecaTrabajo;

public class RepositorioClienteArchTexto : IRepositorioCliente
{
    public void AgregarCliente(Cliente cliente)
    {
        string? aux;
        using (StreamReader ClienteSR= new StreamReader("Clientes.txt"))
       {
           aux= ClienteSR.ReadToEnd();
       }
       //Luego escribo el archivo con todo lo que lei y el cliente nuevo a agregar
       using (StreamWriter ClienteSR= new StreamWriter("Clientes.txt"))
        {
            ClienteSR.Write(aux);
            ClienteSR.WriteLine(cliente.ToString());
        }


    }
    public List<Cliente> GetClientes()
    {
        StreamReader ClientesSR=new StreamReader("Clientes.txt");
        List<Cliente> lista = new List<Cliente>();
        string? linea;
        string[] vec_cliente;
        while(ClientesSR.EndOfStream)
        {
            linea= ClientesSR.ReadLine();
            /* El método Split(), al igual que en JavaScript 
             divide a un string según el parámetro */
            vec_cliente=linea.Split("|");
            Cliente cli= new Cliente(vec_cliente[0],vec_cliente[1],vec_cliente[2],vec_cliente[3],Convert.ToDateTime(vec_cliente[4]),Convert.ToDateTime(vec_cliente[5]));
            lista.Add(cli);
        }
        return lista;
    }

     public Cliente? GetCliente(int Dni)
    {
        using (StreamReader ClienteSR = new StreamReader("Clientes.txt"))
        {
            while(!ClienteSR.EndOfStream)
            {
                string[] vec_cliente = ClienteSR.ReadLine().Split('|');
                if (vec_cliente[0] == Dni.ToString())
                {
                    Cliente cli= new Cliente(vec_cliente[0],vec_cliente[1],vec_cliente[2],vec_cliente[3],Convert.ToDateTime(vec_cliente[4]),Convert.ToDateTime(vec_cliente[5]));
                    return cli;
                }   
            } 
            return null;          
        }
    }

    public void ModificarCliente(Cliente cliente)
    {
        List<Cliente> listaClientes= this.GetClientes();
        foreach (var nodo_cliente in listaClientes)
        {
            if (nodo_cliente.Dni == cliente.Dni)
            {
                listaClientes.Remove(nodo_cliente);
                listaClientes.Add(cliente);
                using (StreamWriter ClienteSW = new StreamWriter("Clientes.txt"))
                {
                    foreach (var cli in listaClientes)
                    {
                        ClienteSW.WriteLine(cli.ToString());
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
                using (StreamWriter escritor = new StreamWriter("Clientes.txt"))
                {
                    foreach (var cli in listaClientes)
                    {
                        escritor.WriteLine(cli.ToString());
                    }
                }
                break;
            }            
        }      
        
    }


     
       
    
}