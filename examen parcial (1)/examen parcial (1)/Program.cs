using examen_parcial__1_;
Pedidos pedidos = new Pedidos();
Cliente cliente = new Cliente();
List<Cliente> listaClientes = new List<Cliente>();
List<Pedidos> listaPedidos = new List<Pedidos>();

int opcion = 0;
bool opcionWhile = true;
do
{
    Menu();
    Console.Write("Ingrese una opcion: ");
    switch (opcion = LlenarNumeroEntero())
        {
        case 1:
            Console.WriteLine("Registrar Cliente");
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.RegistrarCliente();
                listaClientes.Add(nuevoCliente);
                break;

            case 2:
                Console.WriteLine("Registrar Cliente Premium");
                ClientePremium nuevoClientePremium = new ClientePremium();
                nuevoClientePremium.RegistrarCliente();
                listaClientes.Add(nuevoClientePremium);
                break;
            case 3:
                Console.WriteLine("Registrar Pedido");
                Pedidos nuevoPedido = new Pedidos();
                nuevoPedido.RegistrarPedido(pedidos.NumPedido(listaPedidos), listaClientes);
                listaPedidos.Add(nuevoPedido);
            break;
            case 4:
            Console.WriteLine("Mostrar Detalles de Clientes");
            
            break;
            cliente.MostrarClientes(listaClientes);
            case 5:
                opcionWhile = false;
                break;
        }
    
} while (opcionWhile);

static void Menu() 
{
    Console.WriteLine("\t\t\tMenu Principal");
    Console.WriteLine("1. Registrar Cliente");
    Console.WriteLine("2. Registrar Cliente Premium");
    Console.WriteLine("3. Registrar Pedido");
    Console.WriteLine("4. Mostrar Detalles de Clientes");
    Console.WriteLine("5. Mostrar Detalles de Pedidos");
    Console.WriteLine("6. Buscar Clientes por Nombre");
    Console.WriteLine("6. Buscar Pedidos por Numero");
    Console.WriteLine("6. Salir");
}
    static int LlenarNumeroEntero()
    {
        int numeroEntero = 0;
        bool valido = false;
        while (!valido)
        {
            try
            {
                while (numeroEntero <= 0)
                {
                    numeroEntero = Convert.ToInt32(Console.ReadLine());
                    if (numeroEntero <= 0)
                    {
                        Console.Write("No puede ingresar numeros negativos...\nIntente de nuevo: ");
                    }
                    valido = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("[!] Error no puede ingresar letras...");
                Console.Write("> Intente de nuevo: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[!] Error desconocido... " + ex);
                Console.Write("> Intente de nuevo: ");
            }
        }
        return numeroEntero;
    }


