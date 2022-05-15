using BibliotecaTrabajo;

/*****************************
    Agregando un nuevo cliente
******************************/

Cliente cli= new Cliente("39203330","Ulises","Bueno","50 n 737",new DateTime(1994,04,20),new DateTime(2021,3,14));
new AgregarClienteUseCase().Ejecutar(cli);

/*****************************
    Agregando varios clientes
******************************/
// var nuevoCliente= new AgregarClienteUseCase();
// nuevoCliente.Ejecutar(new Cliente("19992229","Alzogaray","Juan","Walaby 42",new DateTime(1929,7,14),new DateTime(2021,4,2)));
// nuevoCliente.Ejecutar(new Cliente("39933399","De La Canal","Pedro","Cerrito 122",new DateTime(1933,9,22),new DateTime(2020,2,3)));
// nuevoCliente.Ejecutar(new Cliente("29999333","Olzoro","Pablo","Azcuenaga 4000",new DateTime(1945,7,2),new DateTime(2012,1,3)));
// nuevoCliente.Ejecutar(new Cliente("48884833","Atenas","Esteban","Libertadores 1234",new DateTime(1950,2,14),new DateTime(2020,2,5)));

/*****************************
Agregar cliente repetido
******************************/
// Cliente cli= new Cliente("39203330","Ulises","Bueno","50 n 737",new DateTime(1994,04,20),new DateTime(2021,3,14));
// try
// {
//     new AgregarClienteUseCase().Ejecutar(cli);
// }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }

// //Modificar un cliente
// Cliente cli= new Cliente("35741874","Aguero","Martin","47 n 148",new DateOnly(1993,2,14),new DateTime(2022,1,3));
// new ModificarClienteUseCase().Ejecutar(cli);

// //Listar los clientes con la cantidad de dias de su ultima compra
// var lista= new ListaDeClientesUseCase().Ejecutar();
// foreach (var c in lista)
// {
//     Console.WriteLine($"{c.Apellido}, {c.Nombre}: {c.DiasSinComprar} dias.");
// }


// //Eliminar el cliente Bolaños que tiene dni 40214358
// new EliminarClienteUseCase().Ejecutar(40214358);

// //Eliminando cliente que no existe
// try
// {
//     new EliminarClienteUseCase().Ejecutar(42574189);
// }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }

// //Listar todos los clientes
// var lista= new ListaDeClientesUseCase().Ejecutar();
// foreach (var c in lista)
// {
//     Console.WriteLine(c);
// }

// //Agregando Empleados
// var agregarEmpleado= new AgregarEmpleadoUseCase();
// agregarEmpleado.Ejecutar(new Empleado("38471265","Afrato","Miguel","14 n 965",new DateOnly(1994,3,28),"356"));
// agregarEmpleado.Ejecutar(new Empleado("38578234","Zomie","Marcos","68 n 475",new DateOnly(1995,8,28),"200"));
// agregarEmpleado.Ejecutar(new Empleado("38572265","Martinez","Ricardo","17 n 865",new DateOnly(1994,11,29),"147"));
// agregarEmpleado.Ejecutar(new Empleado("38398524","Mattoso","Miguel","47 n 1965",new DateOnly(1994,2,3),"584"));

// //Listado de todas las personas
// var lista= new ListaDePersonasUseCase().Ejecutar();
// foreach (var persona in lista)
// {
//     Console.WriteLine(persona);
// }

