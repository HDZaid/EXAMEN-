using examen_parcial__1_;
Menus menus = new Menus();
Interfaz algoDiferente = new Interfaz();
List<ClaseBase> listaclaseBases = new List<ClaseBase>();
List<Interfaz> interfazs = new List<Interfaz>();

    bool opcionWhile = true;
    while (opcionWhile)

    {
        int opcion = 0;
        int opcionSwitch2 = 0;
        Console.Write("ingrese un numero");
        switch (opcion = LlenarNumeroEntero())
        {
            case 1:
                Console.WriteLine("REGISTRAR CLIENTE");
                algoDiferente.AgregarObjeto();
                ClaseBase claseBase = new ClaseBase();
                claseBase.Agregar();
                listaclaseBases.Add(claseBase);
                break;

            case 2:
                Console.WriteLine("REGISTRAR RESERVAS");
                break;

            case 3:
                Console.WriteLine("MOSTRAR DETALLES DEL CLIENTE Y RESERVAS");
                Console.WriteLine("[ 1 ] DETALLES DE CLIENTES");
                Console.WriteLine("[ 2 ] DETALLES DE RECETAS");
                switch (opcionSwitch2 = LlenarNumeroEntero())
                {
                    case 1:
                        Console.WriteLine("DETALLES DE CLIENTE");
                      
                        break;
                    case 2:
                        Console.WriteLine("DETALLES DE  RESERVA");
                        
                        break;
                }
                break;
            case 4:
                Console.WriteLine("BUSCAR CLIENTE O RESERVAS");
                switch (opcionSwitch2 = LlenarNumeroEntero())
                {
                    case 1:
                        Console.WriteLine("BUSCAR CLIENTE");
                        
                        break;
                    case 2:
                        Console.WriteLine("BUSCAR RESERVA");
                        
                        break;
                }
                break;

            case 5:
                opcionWhile = false;
                break;
        }
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


