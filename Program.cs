using System;
using System.IO;

namespace myApp
{
    class Program
    {
        double p, q, z, n;
        double k, j;
        double mensaje, cifrado;

        string algo;
        public void ElegirPrimo ()
        {
         float a=0,b=0,i,j;

         Console.WriteLine("Ingrese numero P:");
         p = double.Parse(Console.ReadLine());
            for(i=1;i<(p+1);i++)
            {
                if(p%i==0)
                {
                a++;
                }
            }
            if(a!=2)
            {
                Console.WriteLine("No es Primo");
            }

            Console.WriteLine("Ingrese numero Q:");
            q = double.Parse(Console.ReadLine());

            for(j=1;j<(j+1);j++)
            {
                if(q%j==0)
                {
                    b++;
                }
            }
            if(b!=2)
            {
                Console.WriteLine("No es Primo");
            }
        }

     public void calculo()
     {

         n = p*q;
         double numero1 = p-1;
         double numero2 = q-1;
         z = numero1 * numero2;
         Convert.ToString(z);
         Console.WriteLine(z);
         Console.WriteLine("Tu número z es: " + z);

     }

     public void CoPrimo()
     {
        double a = Math.Max(p,q);
        double b = Math.Min(p,q);
        double res; 
        do{
            res = b;
            a = a%b;
            a = res;
        }while(b!=0);

         Console.WriteLine("Elija el número Co-primo de z:" + res);
         //k = double.Parse(Console.ReadLine());
         //Console.WriteLine("Tu clave pública es: "+n +" y "+k);

     }

     public void Privada()
     {
         //Aquí se calculará la llave privada
        j = 1;
        while(((j*k)%z) != 1)
        {
            j++;
        }
        Console.WriteLine("La clave privada es: " + j);
     }

     public void Mensaje()
     {
         Console.WriteLine("Ingresa el mensaje que quieres cifrar:");
         mensaje = double.Parse(Console.ReadLine());
         cifrado = Math.Pow(mensaje, k)%n;
         Console.WriteLine("Tu mensaje cifrado es: "+ cifrado);
     }

     public void Descifrar()
     {
         Console.WriteLine("Ingresa el mensaje que quieres descifrar:");
         cifrado = double.Parse(Console.ReadLine());
         mensaje = Math.Pow(cifrado, j)%n;
         Console.WriteLine("Tu mensaje descifrado es: "+ mensaje);
     }

        static void Main(string[] args)
        {
           Program programa = new Program();
           programa.ElegirPrimo();
           programa.calculo();
           programa.CoPrimo();
           programa.Privada();
           programa.Mensaje();
           programa.Descifrar();
           
        }
    }
}