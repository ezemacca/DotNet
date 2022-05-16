using BibliotecaTrabajo;

/**************************************************************************************************************
                                                           Pruebas con clientes
*****************************************************************************************************************/


/*****************************
    Agregando un nuevo cliente
******************************/

// Cliente cli= new Cliente("39203330","Ulises","Bueno","50 n 737",new DateTime(1994,04,20),new DateTime(2021,3,14));
// new AgregarClienteUseCase().Ejecutar(cli);

// /*****************************
//     Agregando varios clientes
// ******************************/
// var nuevoCliente= new AgregarClienteUseCase();
//  nuevoCliente.Ejecutar(new Cliente("19992229","Alzogaray","Juan","Walaby 42",new DateTime(1968,7,14),new DateTime(2021,4,2)));
// nuevoCliente.Ejecutar(new Cliente("39933399","De La Canal","Pedro","Cerrito 122",new DateTime(1933,9,22),new DateTime(2020,2,3)));
//  nuevoCliente.Ejecutar(new Cliente("29999333","Olzoro","Pablo","Azcuenaga 4000",new DateTime(1945,7,2),new DateTime(2012,1,3)));
// nuevoCliente.Ejecutar(new Cliente("48884833","Atenas","Esteban","Libertadores 1234",new DateTime(1950,2,14),new DateTime(2020,2,5)));

/*****************************
Agregar cliente repetido
******************************/
//  Cliente cli= new Cliente("39203330","Ulises","Bueno","50 n 737",new DateTime(1994,04,20),new DateTime(2021,3,14));
//  try
//  {
//     new AgregarClienteUseCase().Ejecutar(cli);
//  }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }


/*****************************
Modificar un cliente
******************************/
// 39203330 es el DNI de un cliente existente


// Cliente cli= new Cliente("39203330","pepito","Tincho","475 n 128",new DateTime(1993,2,14),new DateTime(2022,1,3));
// new ModificarClienteUseCase().Ejecutar(cli);

/*****************************
Listar los clientes con la cantidad de dias de su ultima compra
******************************/

// var listarDiasUltimaCompra= new ListaDeClientesUseCase().Ejecutar();
// foreach (var cliente in listarDiasUltimaCompra)
// {
//     Console.WriteLine($"{cliente.Apellido}, {cliente.Nombre}: {cliente.dias_ultima_compra} dias pasaron desde su ultima compra.");
// }

/*****************************
Eliminar el cliente Atenas que tiene dni 48884833
******************************/

// new EliminarClienteUseCase().Ejecutar(48884833);

/*****************************
Eliminando DNI de cliente que no existe
******************************/
// try
// {
//     new EliminarClienteUseCase().Ejecutar(12547896);
// }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }

/*****************************
Listar Clientes
******************************/

// var lista= new ListaDeClientesUseCase().Ejecutar();
// foreach (var cliente in lista)
// {
//     Console.WriteLine(cliente);
// }


/**************************************************************************************************************
                                                           Pruebas con empleados
*****************************************************************************************************************/

/*****************************
Agregar varios empleados
******************************/

// var agregarEmpleado= new AgregarEmpleadoUseCase();
// agregarEmpleado.Ejecutar(new Empleado("39243330","Juani","Buenos","50 n 737",new DateTime(1994,04,20),"12125"));
// agregarEmpleado.Ejecutar(new Empleado("12526444","Jermie","Robertina","24 n 444",new DateTime(1999,8,22),"20020"));
// agregarEmpleado.Ejecutar(new Empleado("11112455","Janzinez","Raffael","32 n 777",new DateTime(1999,11,23),"12147"));
// agregarEmpleado.Ejecutar(new Empleado("40455445","Jarteno","Renato","85 n 4512",new DateTime(1992,2,24),"58454"));


/*****************************
Agregar Empleado repetido
******************************/
//  Empleado emp= new Empleado("39203330","Ulises","Bueno","50 n 737",new DateTime(1994,04,20),"12125");
//  try
//  {
//     new AgregarEmpleadoUseCase().Ejecutar(emp);
//  }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }

/*****************************
Modificar un empleado
******************************/
// 39203330 es el DNI de un empleado existente

// Empleado emp= new Empleado("39203330","pereyra","Tenite","485 n 128",new DateTime(1993,2,16),"121245");
// new ModificarEmpleadoUseCase().Ejecutar(emp);



/***********************************************************************************
Listado de todas las personas
***********************************************************************************/
var lista= new ListaDePersonasUseCase().Ejecutar();
foreach (var persona in lista)
{
    Console.WriteLine(persona);
}

