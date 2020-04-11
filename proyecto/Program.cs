using System;

namespace Cajero_Automatico
{
    class Program
    {
        static void Main(string[] args)
        {/*cajero automatico*/
            /*variables*/
            long no_cuenta, numero_de_cuenta, no_tarjeta, monto = 0, balance = 100000;
            int pin, retiro = 0, consulta, enter, comprobante, depositar, transferencia;
            int end = 0;
            string correo, nombre, direccion;
            /*Insertar*/
            Console.WriteLine("                          Bienvenido al Cajero Automatico");
            Console.Write("Inserte su Nombre ");
            nombre = Console.ReadLine();
            Console.Write("Inserte su direccion ");
            direccion = Console.ReadLine();
            Console.Write("Inserte el numero de cuenta ");
            no_cuenta = Convert.ToInt64(Console.ReadLine());
            Console.Write("Inserte el numero de la tarjeta ");
            no_tarjeta = Convert.ToInt64(Console.ReadLine());
            Console.Write("Inserte el pin ");
            pin = Convert.ToInt32(Console.ReadLine());
            /*condiciones*/
            do
            {/*opciones*/
                Console.WriteLine("1. consultar balance  2. Realizar un retiro  3. Realizar un deposito  4. Realizar una transferencia");
                consulta = Convert.ToInt32(Console.ReadLine());
                /*primera opcion, consultar balance*/
                if (consulta == 1)
                {
                    Console.WriteLine("1. mostrar en pantalla  2. imprimir comprobante");
                    enter = Convert.ToInt32(Console.ReadLine());
                    {
                        if (1 == enter) Console.WriteLine("su balance es de {0}", balance);

                        else
                        {
                            Console.WriteLine("comprobante fiscal:");
                            Console.WriteLine("Nombre de cliente {0}", nombre);
                            Console.WriteLine("direccion: {0}", direccion);
                            Console.WriteLine("cantidad: {0}", balance);
                        }
                        {
                            Console.WriteLine("1. Continuar    2. Finalizar");
                            end = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                /*segunda opcion, realizar un retiro*/
                else if (consulta == 2)
                {
                    Console.WriteLine("Ingrese el monto que deseas retirar");
                    retiro = Convert.ToInt32(Console.ReadLine());
                    if (balance >= retiro) ;
                    else
                    {
                        do
                        {
                            Console.WriteLine("no tienes fondo suficiente");
                            Console.WriteLine("Ingrese el monto que deseas retirar");
                            retiro = Convert.ToInt32(Console.ReadLine());
                        } while (balance < retiro);
                    }
                    {

                        do
                        {
                            balance = balance - retiro;
                            Console.WriteLine("1. ver retiro en pantalla  2. imprimir comprobante");
                            enter = Convert.ToInt32(Console.ReadLine());
                            {
                                if (1 == enter) Console.WriteLine("su balance es de {0}", balance);

                                else
                                {
                                    Console.WriteLine("comprobante fiscal:");
                                    Console.WriteLine("Nombre de cliente {0}", nombre);
                                    Console.WriteLine("direccion: {0}", direccion);
                                    Console.WriteLine("retiro: {0}", retiro);
                                }
                                Console.WriteLine("1. Continuar    2. Finalizar");
                                end = Convert.ToInt32(Console.ReadLine());
                            }
                        } while (balance < retiro);
                    }
                }
                /*tercera opcion*/
                else if (consulta == 3)
                {
                    Console.WriteLine("Ingrese el monto que deseas depositar");
                    depositar = Convert.ToInt32(Console.ReadLine());
                    balance = balance + depositar;

                    Console.WriteLine("1. Continuar    2. Finalizar");
                    end = Convert.ToInt32(Console.ReadLine());
                }
                /*cuarta opcion, realizar una transferencia*/
                else if (consulta == 4)
                {
                    do
                    {
                        Console.WriteLine("1. Transferencia a tercero     2. Transferencia entre cuenta");
                        transferencia = Convert.ToInt32(Console.ReadLine());
                        if (transferencia == 1);
                        else
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el numero de cuenta a donde deseas transferir");
                                numero_de_cuenta = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Ingrese el monto que deseas transferir");
                                monto = Convert.ToInt64(Console.ReadLine());
                            } while (balance < monto);
                            balance = balance - monto;
                            Console.WriteLine("1. mostrar en pantalla  2.imprimir comprobante");
                            comprobante = Convert.ToInt32(Console.ReadLine());
                            if (1 == comprobante)
                                Console.WriteLine("usted transfirio {0}", monto);
                            else
                            {
                                Console.WriteLine("comprobante fiscal:");
                                Console.WriteLine("Numero de cuenta {0}", numero_de_cuenta);
                                Console.WriteLine("Direccion: {0}", direccion);
                                Console.WriteLine("Balance: {0}", balance);
                                Console.WriteLine("transferencia: {0}", monto);
                            }
                            Console.WriteLine("1. Continuar    2. Finalizar");
                            end = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el numero de cuenta a quien deseas transferir");
                                numero_de_cuenta = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Ingrese la direccion de correo electronico de quien le vayas a trasnferir");
                                correo = Console.ReadLine();
                                Console.WriteLine("Ingrese el monto que deseas transferir");
                                monto = Convert.ToInt64(Console.ReadLine());
                            } while (balance < monto);
                            balance = balance - monto;
                            Console.WriteLine("1. mostrar en pantalla  2.imprimir comprobante");
                            comprobante = Convert.ToInt32(Console.ReadLine());
                            if (1 == comprobante)
                                Console.WriteLine("usted transfirio {0}", monto);
                            else
                            {
                                Console.WriteLine("comprobante fiscal:");
                                Console.WriteLine("Numero de cuenta {0}", numero_de_cuenta);
                                Console.WriteLine("correo electronico: {0}", correo);
                                Console.WriteLine("Direccion: {0}", direccion);
                                Console.WriteLine("balance: {0}", balance);
                                Console.WriteLine("transferencia: {0}", monto);
                            }
                            Console.WriteLine("1. Continuar    2. Finalizar");
                            end = Convert.ToInt32(Console.ReadLine());
                        }
                    } while (balance < monto);
                }

            } while (end != 2);
            Console.WriteLine("Muchas gracias");
        }
    }
}
