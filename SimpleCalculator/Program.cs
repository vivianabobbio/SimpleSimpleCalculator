using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double numeroUno;
            string tipoDiOperazione;
            double numeroDue;


            if (args.Length == 0)
            {
                Console.WriteLine("devi inserire dei parametri");
                return;
            }
            else if (args.Length == 1 || args.Length == 2)
            {
                Console.WriteLine("non hai inserito tutti i parametri");
                return;
            }

            //try /*(args[0] == " ")*/
            //{
            //    if (args[0] == null);
                
            //}
            //catch
            //{
            //    Console.WriteLine("non hai inserito il primo numero");

            //}
            //try /*(args[0] == " ")*/
            //{
            //    if (args[1] == null) ;

            //}
            //catch
            //{
            //    Console.WriteLine("non hai inserito il simbolo dell'operazione");

            //}
            //try /*(args[0] == " ")*/
            //{
            //    if (args[2] == null) ;

            //}
            //catch
            //{
            //    Console.WriteLine("non hai inserito il secondo numero");

            //}

            //{

            //    if (string.IsNullOrEmpty(""))
            //    {
            //        Console.WriteLine("non hai inserito i dati");
            //    }


            //}
            try
                {
            //if (args[0] == " ")
            //    {
            //        Console.WriteLine("non hai inserito il primo numero");
            //    }

            numeroUno = Convert.ToDouble(args[0]);
            tipoDiOperazione = args[1];
            numeroDue = Convert.ToDouble(args[2]);

            }
            catch (Exception)
            {
                
                Console.WriteLine("non hai inserito il numero in forma corretta");
                Console.WriteLine("attenzione inserire il primo numero seguito dal simbolo di un'operazione valida e il secondo numero");
                Console.WriteLine("per l'addizione usa il simbolo +");
                Console.WriteLine("per l'addizione usa il simbolo -");
                Console.WriteLine("per l'addizione usa il simbolo *");
                Console.WriteLine("per l'addizione usa il simbolo /");
                return;
            }


            tipoDiOperazione = args[1];

            if (tipoDiOperazione=="+")
            {
                double somma = numeroUno + numeroDue;
                Console.WriteLine(somma);               
                             
            }
            else if (tipoDiOperazione == "-")
            {
                double sottrazione = numeroUno - numeroDue;
                Console.WriteLine(sottrazione);
            }
            else if (tipoDiOperazione == "*")
            {
                double moltiplicazione = numeroUno * numeroDue;
                Console.WriteLine(moltiplicazione);
            }
            else if (tipoDiOperazione == "/")
            {
                double divisione = numeroUno / numeroDue;
                Console.WriteLine(divisione);
            }
            else
            {

                Console.WriteLine("attenzione puoi inserire solo il simbolo di un'operazione valida");
                Console.WriteLine("per l'addizione usa il simbolo +");
                Console.WriteLine("per l'addizione usa il simbolo -");
                Console.WriteLine("per l'addizione usa il simbolo *");
                Console.WriteLine("per l'addizione usa il simbolo /");

            }

            
        }
    }
}
