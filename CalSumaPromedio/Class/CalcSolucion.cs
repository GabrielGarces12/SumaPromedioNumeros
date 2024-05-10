
namespace CalSumaPromedio.Class
{
    internal class CalcSolucion
    {
        public void CalSumaPromedio() 
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal num4 = 0;
            decimal suma = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Ingrese el primer numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer numero: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero: ");
                num4 = int.Parse(Console.ReadLine());

                suma = (num1 + num2 + num3 + num4);
                promedio = (num1 + num2 + num3 + num4);
                promedio = promedio / 4;

                Console.WriteLine($"La suma de los cuatros numeros es: { suma} y el promedio es: { promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: { ex.Message }");
            }
            


        }

    }
}
