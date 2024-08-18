using examen_parcial__1_;
using System.Collections.Generic;
Menus menus = new Menus();
List<Pedidos> ListaPedidos = new List<Pedidos>();
List<ClaseBase> listaClaseBase = new List<ClaseBase>();

    bool opcionWhile = true;
    while (opcionWhile)
    {
        int opcion = 0;
        int opcionSwitch2 = 0;
        Console.WriteLine("ingrese un numero");
        menus.MenuPrincipal();
        switch (opcion = menus.LlenarNumeroEntero())
        {
            case 1:
            Console.WriteLine("[ 1 ]  CLIENTE Estandar");
            Console.WriteLine("[ 2 ] Cliente PREMIUM");
            switch (opcionSwitch2 = menus.LlenarNumeroEntero())
            {
                case 1:
                    ClienteEstandar clienteEstandar = new ClienteEstandar();
                    clienteEstandar.AgregarCliente();
                    listaClaseBase.Add(clienteEstandar);
                    break;
                case 2:
                   ClientePremium clientePremium = new ClientePremium();
                    clientePremium.AgregarCliente();
                    listaClaseBase.Add(clientePremium);
                    break;
            }
            break;

            case 2:
            Pedidos pedidos = new Pedidos();
            Console.WriteLine("Ingrese el nombre del cliente al que se le asignara el pedido:");
            string nombreCliente = Console.ReadLine();
            pedidos.AgregarPedidos(listaClaseBase, nombreCliente);
            ListaPedidos.Add(pedidos);
            break;

            case 3:
            Console.WriteLine("----------------------------LISTA CLIENTES:---------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            if (listaClaseBase.Count > 0)
            {
                foreach(ClaseBase clientes in listaClaseBase)
                {
                    clientes.MostrarInformacionCliente();
                }
            }
            else
            {
                Console.WriteLine("No hay clientes que mostrar:");
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------LISTA PEDIDOS:---------------------------");
            
            if (ListaPedidos.Count > 0)
            {
                
                foreach (Pedidos pedido in ListaPedidos)
                {
                    pedido.mostrarInformacionPedidos();
                }
            }
            else
            {
                Console.WriteLine("No hay pedidos registrados.");
            }

            break;
            case 4:
            Console.WriteLine("[ 1 ] BUSCAR CLIENTE");
            Console.WriteLine("[ 2 ] BUSCAR PEDIDO");
            switch (opcionSwitch2 = menus.LlenarNumeroEntero())
            {
                case 1:
                    string nombreBuscado = Console.ReadLine();
                    foreach (var clienteEncontrado in listaClaseBase)
                    {
                        if (clienteEncontrado.Nombre == nombreBuscado)
                        {
                            clienteEncontrado.MostrarInformacionCliente();
                        }
                        else
                        {
                            Console.WriteLine("NO HAY NINGUN CLIENTE CON ESE NOMBRE");
                        }
                    }
                    
                    break;
                case 2:
                    int numeroBuscado = menus.LlenarNumeroEntero();
                    foreach(var pedidoEncontrado in ListaPedidos)
                    {
                        if(pedidoEncontrado.NumeroUnico == numeroBuscado)
                        {
                            pedidoEncontrado.mostrarInformacionPedidos();
                        }
                        else
                        {
                            Console.WriteLine("NO SE ENCONTRO NINGUN PEDIDO CON ESE NUMERO");

                        }
                    }
                    break;
            }
            break;
            case 5:
                opcionWhile = false;
                break;
        }
    }




