using System;
using System.Collections.Generic;

namespace restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables billetes y monedas
            int unEuro = 1;
            int dosEuros = 2;
            int cincoEuros = 5;
            int diezEuros = 10;
            int veinteEuros = 20;
            int cincuentaEuros = 50;
            int cienEuros = 100;
            int docientosEuros = 200;
            int quinientosEuros = 500;

            //Declaración de arrays platos y precio
            string[] menu = new string[5];
            int[] precio = new int[5];



            Console.WriteLine(" ");

            //Poblar arrays de menu y precio
            for (int i = 0; i < menu.Length; i++)
            {
                Console.Write("Introduce el plato: ");
                menu[i] = Console.ReadLine();
                Console.Write("Precio: ");
                precio[i] = int.Parse(Console.ReadLine()); ;

            }

            Console.WriteLine(" ");

            //Mostrar menu con respectivos precios por consola
            for (int i = 0; i < menu.Length; i++)
            {

                Console.WriteLine(menu[i] + " " + precio[i] + " Euros \n");

            }

            Console.WriteLine(" ");


            //Lista de pedidos
            List<string> comanda = new List<string>();

            //Control de bucle
            bool order = true;

            //Variable de incremento de bucle
            int j = 0;

            Console.WriteLine("Por favor haga su pedido");


            //Crear List de pedido y dar opción de seguir o parar el pedido
            while (order)
            {
                Console.Write("Introduce el plato: ");
                string pedido = Console.ReadLine();
                comanda.Add(pedido);

                Console.WriteLine("Desea algo más?");
                Console.WriteLine("Teclea 'y' para seguir o 'n' para encerrar el pedido.");
                Console.WriteLine(" ");

                string ordering = Console.ReadLine();
                if (ordering == "n")
                {
                    order = false;
                }

            }
            j++;


            //Var total cuenta y si pedido está en el menú
            int total = 0;
            bool inList = true;
        


            foreach (var plato in comanda)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (plato == menu[i])
                    {
                       total += precio[i];
                        inList = true;
                    }

                }

                if (!inList)
                {
                    Console.WriteLine($"{plato} no está en el menú.");
                    Console.WriteLine(" ");
                }
               inList = false;
            }
            Console.WriteLine("Total despesas: " + total + "Euros.");
            Console.WriteLine(" ");


            /*El proximo tramo de codigo es una adaptción de uno que encontré en internet,
           * no he podido llegar al algoritmo por cuenta propia */


            // Indicamos todas las monedas posibles
            int[] monedas = { quinientosEuros,
                            docientosEuros,
                            cienEuros,
                            cincuentaEuros,
                            veinteEuros,
                            diezEuros,
                            cincoEuros,
                            dosEuros,
                            unEuro  };

            // Creamos un array con 0 de longitud igual a la cantidad de monedas
            // Este array contendra las monedas a devolver
           int[] cambio = { 0, 0, 0, 0, 0, 0, 0, 0, 0};



          

            //Testar el array de monedas
            for (int i = 0; i < monedas.Length; i++)
            {
                
                if (total >= monedas[i])
                {
                    //Cantidad de monedas, resto de la division
                    cambio[i] = total / monedas[i];

                    // actualiza el valor del total
                   total = total - (cambio[i] * monedas[i]);
                }
            }

            Console.WriteLine("Desglose de billetes.");
            Console.WriteLine("Puedes pagar con.");

            // Muestra el resultado
            for (int i = 0; i < monedas.Length; i++)
            {
                if (cambio[i] > 0)
                {
                   
                    if (monedas[i] > 2)  //Billete
                    {
                       
                        Console.WriteLine($"{cambio[i]} billetes de: {monedas[i]} Euros");
                    }
                    else // Moneda
                    {

                        Console.WriteLine($"{cambio[i]} billetes de: {monedas[i]} Euros");
                    }
                }


            }

      
            

        }
    }
}
