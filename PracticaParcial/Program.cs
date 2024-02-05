using Matematicas;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            DateTime resultado;
            int PrimerNumero, SegundoNumero, Opcion, salir = 0;
            OpMat clasematematica = new OpMat();
            Console.WriteLine("Ingrese el primer numero");
            PrimerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            SegundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decida que accion realizar");
            Console.WriteLine("1- Sumar");
            Console.WriteLine("2- Multiplicar");
            Console.WriteLine("3- Porcentaje entre dos numeros");
            while (salir == 0)
            {
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado es: " + clasematematica.Sumar(PrimerNumero, SegundoNumero));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es: " + clasematematica.Multiplicar(PrimerNumero, SegundoNumero));
                        break;
                    case 3:
                        Console.WriteLine("El numero:" + SegundoNumero + " representa el: " + PorcentajeEntreDosNumeros(PrimerNumero, SegundoNumero) + "% de el numero: " + PrimerNumero);
                        break;
                    case 4:
                        resultado = DateTime.Now;
                        Console.WriteLine("Hoy es: " + resultado);
                        break;
                    case 5:
                        salir = 1;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static decimal PorcentajeEntreDosNumeros(int PN1, int PN2)
    {
        return ((PN2 * 100) / PN1);
    }
}