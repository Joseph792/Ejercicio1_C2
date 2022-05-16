// See https://aka.ms/new-console-template for more information
            int cantLados;
            float mediaLados, perimetro;

            Console.Write("Cantidad de lados de la figura: ");
            cantLados = Int32.Parse(Console.ReadLine());
            Console.Write("\nMedia de un lado: ");
            mediaLados = Int32.Parse(Console.ReadLine());

            perimetro = cantLados * mediaLados;

            Console.WriteLine("El perimetro es: {0}", perimetro);
