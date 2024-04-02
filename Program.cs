
            Console.Write("Ingrese el ancho lote ");
            int ancho = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el largo lote ");
            int largo = int.Parse(Console.ReadLine());

            double precio = 20.0;

            int area = ancho * largo; 
            Console.WriteLine($"El area es: {area} m^2");
            Console.WriteLine($"Se multiplicara el area que es {area} por el precio que es {precio}$ por metro^2");
            double precio_total =  precio * area;
            Console.WriteLine($"El precio del lote es: {precio_total} por m^2");



            
