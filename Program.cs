﻿
            Console.WriteLine("Calculadora de MRUA");
            Console.Write("Ingrese la velocidad inicial (m/s): ");
            double velocidadInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la aceleración (m/s^2): ");
            double aceleracion = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tiempo (s): ");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            double distancia = velocidadInicial * tiempo + 0.5 * aceleracion * Math.Pow(tiempo, 2);
            Console.WriteLine($"La distancia recorrida es: {distancia} metros");

            double metros = distancia / 1000;
            double yardas = metros * 39.3701;
            Console.WriteLine($"La distancia recorrida es: {yardas} en yardas");

            
