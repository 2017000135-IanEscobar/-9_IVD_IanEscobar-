internal class Program
{
    //Verificar si un numero es positivo
    // o negativo
    private static void Main(string[] args)
    {
        //Entradas
        Console.WriteLine("===NUMEROS POSITIVOS Y NEGATIVOS");
        int num;
        Console.Write("Dame un numero emtero: ");
        num=Convert.ToInt32(Console.ReadLine());
        //Proceso
        //salidas
        if (num >= 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }
    }
}