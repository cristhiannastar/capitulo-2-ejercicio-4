namespace ejercicio24
{

    public class clase
    {
      public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int sum;
            double media;
            int produc;

            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            num4 = int.Parse(Console.ReadLine());

            produc = num1 + num2 + num3 + num4;
            sum = num1 + num2 + num3 + num4;
            media = sum / 4;
            Console.WriteLine($"el resultado de la suma es {sum}, el producto es {produc}, y la media {media}");        
        }
    }
}