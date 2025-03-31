using System;
using System.Data;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenú Principal");
            Console.WriteLine("1. Menu 1");
            Console.WriteLine("2. Menu 2");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Menu_1();
                    break;
                case 2:
                    Menu_2();
                    break;
                case 3:
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void Menu_1()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Asterisco baras");
            Console.WriteLine("2. Asterisco espiral");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("4. volver al menu principal");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Bara();
                    break;
                case 2:
                    Espiral();
                    break;
                case 3:
                    Cuadrado();
                    break;
                case 4:
                    Console.Clear();
                    return;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }


    private static void Bara()
    {
        int y = 122;
        int x = 25;
        int longitud = 7;
        int alto = 13;

        Console.Clear();
        Console.SetCursorPosition(55, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dibujar gráfico");
        Console.ResetColor();

        for (int i = 0; i < 10; i++)
        {
            Dibujar(ref y, ref x, -1, 0, longitud, ConsoleColor.Cyan);
            Dibujar(ref y, ref x, 0, -1, alto, ConsoleColor.Blue);
            Dibujar(ref y, ref x, -1, 0, longitud, ConsoleColor.Cyan);
            Dibujar(ref y, ref x, 0, 1, alto, ConsoleColor.Blue);
        }

        MostrarMenu();
    }

    private static void Dibujar(ref int y, ref int x, int cambioY, int cambioX, int pasos, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        for (int i = 0; i < pasos; i++)
        {
            y += cambioY;
            x += cambioX;
            if (y >= 0 && y < Console.WindowWidth && x >= 0 && x < Console.WindowHeight)
            {
                Console.SetCursorPosition(y, x);
                System.Threading.Thread.Sleep(3);
                Console.Write("*");
            }
        }
    }

    private static void MostrarMenu()
    {
        Console.SetCursorPosition(1, Console.WindowHeight - 3);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, Console.WindowHeight - 2);
        Console.WriteLine("1. Ir al menú anterior   2. Continuar   3. Salir");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Bara();
                        return;
                    case 2:
                        Console.Clear();
                        return;
                    case 3:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    private static void Espiral()
    {
        int currentCol = 64;
        int currentRow = 14;

        int horizontalSteps = 4;
        int verticalSteps = 0;

        int dir = 0;

        Console.Clear();
        ConsoleColor[] palette = new ConsoleColor[]
        {
        ConsoleColor.Green,
        ConsoleColor.Yellow,
        ConsoleColor.DarkBlue,
        ConsoleColor.Red,
        ConsoleColor.Cyan
        };
        int paletteIndex = 0;

        const int totalCycles = 30;
        for (int cycle = 0; cycle < totalCycles; cycle++)
        {
            int steps = (dir % 2 == 0) ? horizontalSteps : verticalSteps;

            for (int step = 0; step < steps; step++)
            {
                if (IsWithinConsole(currentCol, currentRow))
                {
                    Console.SetCursorPosition(currentCol, currentRow);
                    System.Threading.Thread.Sleep(3);
                    Console.ForegroundColor = palette[paletteIndex];
                    Console.WriteLine("*");
                    paletteIndex = (paletteIndex + 1) % palette.Length;
                }
                else
                {
                    break;
                }
                (currentCol, currentRow) = Move(currentCol, currentRow, dir);
            }

            dir = (dir + 1) % 4;

            if (dir % 2 == 0)
            {
                horizontalSteps += 5;
            }
            else
            {
                verticalSteps += 2;
            }
        }

        ShowMenuPrompt();
    }

    private static (int, int) Move(int col, int row, int dir)
    {

        switch (dir)
        {
            case 0: return (col - 1, row);
            case 1: return (col, row - 1);
            case 2: return (col + 1, row);
            case 3: return (col, row + 1);
            default: return (col, row);
        }
    }

    private static bool IsWithinConsole(int col, int row)
    {
        return col >= 0 && col < Console.WindowWidth && row >= 0 && row < Console.WindowHeight;
    }

    private static void ShowMenuPrompt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.Write("Digite una opción del menú: 1. Ir al menú anterior       2. Continuar        3. Salir: ");
        Console.ResetColor();

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        Main();
                        return;
                    case 2:
                        Console.Clear();
                        return;
                    case 3:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            }
        }
    }
    private static void Cuadrado()
    {
        int centroX = Console.WindowWidth / 2;
        int centroY = Console.WindowHeight / 2;
        int escalaX = 10;
        int escalaY = 4;

        Console.Clear();
        EscribirTexto("Dibujar rectángulos", 51, 1, ConsoleColor.Green);
        ConsoleColor[] colores = { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.DarkBlue, ConsoleColor.Red, ConsoleColor.Cyan };

        for (int i = 0; i < 5; i++)
        {
            Console.ForegroundColor = colores[i % colores.Length];
            int ancho = i * escalaX + 4;
            int alto = i * escalaY;
            int inicioX = centroX - ancho / 2;
            int inicioY = centroY - alto / 2;
            int finX = centroX + ancho / 2;
            int finY = centroY + alto / 2;

            DibujarLineaHorizontal(inicioX, finX, inicioY, 10);
            DibujarLineaVertical(inicioY, finY, finX, 15);
            DibujarLineaHorizontal(finX, inicioX, finY, 20);
            DibujarLineaVertical(finY, inicioY, inicioX, 25);
        }
        MostrarMenu();
    }

    private static void EscribirTexto(string texto, int posX, int posY, ConsoleColor color)
    {
        if (posX < 0 || posY < 0 || posX >= Console.WindowWidth || posY >= Console.WindowHeight)
            return;
        Console.SetCursorPosition(posX, posY);
        Console.ForegroundColor = color;
        Console.WriteLine(texto);
        Console.ResetColor();
    }

    private static void DibujarLineaHorizontal(int startX, int endX, int y, int retardo)
    {
        int paso = startX <= endX ? 1 : -1;
        for (int x = startX; (paso > 0 ? x <= endX : x >= endX); x += paso)
        {
            if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                System.Threading.Thread.Sleep(retardo);
            }
        }
    }

    private static void DibujarLineaVertical(int startY, int endY, int x, int retardo)
    {
        int paso = startY <= endY ? 1 : -1;
        for (int y = startY; (paso > 0 ? y <= endY : y >= endY); y += paso)
        {
            if (y >= 0 && y < Console.WindowHeight && x >= 0 && x < Console.WindowWidth)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                System.Threading.Thread.Sleep(retardo);
            }
        }
    }
    private static void ShowMenu()
    {
        Console.SetCursorPosition(1, Console.WindowHeight - 3);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, Console.WindowHeight - 2);
        Console.WriteLine("1. Ir al menú anterior       2. Continuar        3. Salir");

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        Main();
                        return;
                    case 2:
                        Console.Clear();
                        return;
                    case 3:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, intente de nuevo.");
            }
        }
    }


    static void Menu_2()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenú 2. Programas de localización");
            Console.WriteLine("1. tabla de senos ");
            Console.WriteLine("2. tabla de cosenos ");
            Console.WriteLine("3. C triángulo rectángulo.");
            Console.WriteLine("4.  recta dados dos puntos.");
            Console.WriteLine("5. Calcular la trayectoria de un proyectil.");
            Console.WriteLine("6. Volver al menú principal.");
            Console.WriteLine("7. Salir.");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    TablaSeno();
                    break;
                case 2:
                    TablaCoseno();
                    break;
                case 3:
                    Triangulo();
                    break;
                case 4:
                    Recta();
                    break;
                case 5:
                    Proyectil();
                    break;
                case 6:
                    Console.Clear();
                    return;
                case 7:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static double Factorial(int n)
    {
        double fact = 1;
        for (int i = 2; i <= n; i++)
            fact *= i;
        return fact;
    }

    static double Seno(double grados)
    {
        double radianes = grados * (Math.PI / 180);
        double seno = 0;
        for (int i = 0; i < 10; i++)
        {
            seno += (Math.Pow(-1, i) * Math.Pow(radianes, 2 * i + 1)) / Factorial(2 * i + 1);
            System.Threading.Thread.Sleep(5);
        }
        return seno;
    }

    static double Coseno(double grados)
    {
        double radianes = grados * (Math.PI / 180);
        double coseno = 0;
        for (int i = 0; i < 10; i++)
        {
            coseno += (Math.Pow(-1, i) * Math.Pow(radianes, 2 * i)) / Factorial(2 * i);
        }
        return coseno;
    }

    static void TablaSeno()
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 3, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menu 2 - Programas de localización");
        Console.ResetColor();
        Console.SetCursorPosition(1, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nTabla de Senos:");
        Console.ResetColor();

        int anchoConsola = Console.WindowWidth;
        int altoConsola = Console.WindowHeight;

        for (int i = 0; i <= 90; i++)
        {
            int fila = i % 16;
            int col = (i / 16);

            if (fila == 0 && i != 0)
            {
                Console.WriteLine();
            }

            Console.SetCursorPosition(col * 20, fila + 5);
            Console.Write($"Seno({i}) = {Seno(i):F4}");
        }
        Console.SetCursorPosition(1, altoConsola - 4);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, altoConsola - 3);
        Console.WriteLine("1. Ir al menú anterior       2. Continuar        3. Salir");
        while (true)
        {
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Main();
                    return;
                case 2:
                    Console.Clear();
                    return;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }


    static void TablaCoseno()
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 3, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menu 2 - Programas de localización");
        Console.ResetColor();
        Console.SetCursorPosition(1, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nTabla de Cosenos:");
        Console.ResetColor();

        int anchoConsola = Console.WindowWidth;
        int altoConsola = Console.WindowHeight;

        for (int i = 0; i <= 90; i++)
        {
            int fila = i % 16;
            int col = (i / 16);

            if (fila == 0 && i != 0)
            {
                Console.WriteLine();
            }

            Console.SetCursorPosition(col * 20, fila + 5);
            Console.WriteLine($"Cos({i}) = {Coseno(i):F4}");
        }
        Console.SetCursorPosition(1, altoConsola - 4);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, altoConsola - 3);
        Console.WriteLine("1. Ir al menú anterior       2. Continuar        3. Salir");
        while (true)
        {
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Main();
                    return;
                case 2:
                    Console.Clear();
                    return;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

    }
    static void Triangulo()
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 3, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menu 2 - Programas de localización");
        Console.ResetColor();

        double catetoA = obtenerCateto("Cateto A: ");
        double catetoB = obtenerCateto("Cateto B: ");

        double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
        double anguloA = Math.Atan(catetoA / catetoB) * (180 / Math.PI);
        double anguloB = Math.Atan(catetoB / catetoA) * (180 / Math.PI);

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
        Console.WriteLine($"Ángulo opuesto a cateto A: {anguloA:F2}°");
        Console.WriteLine($"Ángulo opuesto a cateto B: {anguloB:F2}°");

        DrawTriangle(catetoA, catetoB);

        ShowMenuOptions();
    }

    static double obtenerCateto(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

    static void DrawTriangle(double a, double b)
    {
        Console.WriteLine("\nRepresentación del triángulo:\n");
        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j <= b; j++)
            {
                if (i == a || j == 0 || j == (int)Math.Round((double)i * b / a))
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }

    static void ShowMenuOptions()
    {
        Console.SetCursorPosition(1, Console.WindowHeight - 4);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, Console.WindowHeight - 3);
        Console.WriteLine("1. Ir al menú anterior       2. Continuar        3. Salir");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Main();
                        return;
                    case 2:
                        Console.Clear();
                        return;
                    case 3:
                        Console.Clear();
                        Environment.Exit(0);

                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
    }

    static void Recta()
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 4, 1);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Menú - Cálculo de rectas");
        Console.ResetColor();

        double[] puntos = new double[4];
        string[] coordenadas = { "x1", "y1", "x2", "y2" };
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Ingrese {coordenadas[i]}: ");
            puntos[i] = Convert.ToDouble(Console.ReadLine());
        }

        double m = (puntos[3] - puntos[1]) / (puntos[2] - puntos[0]);
        double angulo = Math.Atan(m) * 180 / Math.PI;
        double xMedio = (puntos[0] + puntos[2]) / 2;
        double yMedio = (puntos[1] + puntos[3]) / 2;

        Console.WriteLine($"Pendiente: {m:F4}");
        Console.WriteLine($"Ángulo: {angulo:F4}°");
        Console.WriteLine($"Punto medio: ({xMedio}, {yMedio})");
        Console.WriteLine("\nDibujando la recta:\n");

        int yMax = (int)Math.Max(puntos[1], puntos[3]);
        int yMin = (int)Math.Min(puntos[1], puntos[3]);
        int xMin = (int)Math.Min(puntos[0], puntos[2]);
        int xMax = (int)Math.Max(puntos[0], puntos[2]);

        int desplazamiento = 10;

        for (int y = yMax; y >= yMin; y--)
        {
            Console.Write(new string(' ', desplazamiento));
            for (int x = xMin; x <= xMax; x++)
            {
                if (Math.Abs((y - puntos[1]) - m * (x - puntos[0])) < 0.5)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(1, Console.WindowHeight - 3);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Seleccione una opción:");
        Console.ResetColor();
        Console.WriteLine("1. Volver al menú    2. Repetir    3. Salir");

        while (true)
        {
            string opcion = Console.ReadLine();
            if (opcion == "1") { Main(); return; }
            if (opcion == "2") { Console.Clear(); return; }
            if (opcion == "3") { Environment.Exit(0); }
            Console.WriteLine("Opción inválida, intente de nuevo.");
        }
    }

    static void Proyectil()
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 3, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menú 2 - Programas de localización");
        Console.ResetColor();
        Console.Write("Ingrese la velocidad inicial (m/s): ");
        double velocidadInicial = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ángulo de lanzamiento (°): ");
        double anguloLanzamiento = double.Parse(Console.ReadLine());

        double gravedad = 9.81;
        double radianes = anguloLanzamiento * Math.PI / 180;
        double velocidadX = velocidadInicial * Math.Cos(radianes);
        double velocidadY = velocidadInicial * Math.Sin(radianes);

        double tiempoVuelo = (2 * velocidadY) / gravedad;
        double alturaMaxima = (velocidadY * velocidadY) / (2 * gravedad);
        double distanciaMaxima = velocidadX * tiempoVuelo;

        double velocidadMaxima = velocidadInicial;
        int alturaConsola = Console.WindowHeight - 12;
        Console.WriteLine("\nTrayectoria del proyectil:");
        int lineaConsola = 0;
        int columnaActual = 0;
        int espacioColumna = 30;

        for (double t = 0; t <= tiempoVuelo; t += 0.1)
        {
            double posicionX = velocidadX * t;
            double posicionY = velocidadY * t - 0.5 * gravedad * t * t;
            double velocidad = Math.Sqrt(Math.Pow(velocidadX, 2) + Math.Pow(velocidadY - gravedad * t, 2));
            if (posicionY < 0) break;

            if (lineaConsola >= alturaConsola)
            {
                lineaConsola = 0;
                columnaActual += espacioColumna;
            }

            if (columnaActual >= Console.WindowWidth)
            {
                Console.WriteLine("\nEl límite de columnas ha sido sobrepasado.");
                break;
            }

            Console.SetCursorPosition(columnaActual, 5 + lineaConsola);
            Console.Write($"T: {Math.Truncate(t * 10) / 10:F1}s - P: ({Math.Truncate(posicionX * 10) / 10:F1}; {Math.Truncate(posicionY * 10) / 10:F1})");
            lineaConsola++;
            System.Threading.Thread.Sleep(30);
        }

        Console.SetCursorPosition(0, Console.WindowHeight - 6);
        Console.WriteLine($"Altura máxima: {Math.Truncate(alturaMaxima * 10) / 10:F1} m");
        Console.WriteLine($"Distancia máxima: {Math.Truncate(distanciaMaxima * 10) / 10:F1} m");
        Console.WriteLine($"Velocidad máxima: {Math.Truncate(velocidadMaxima * 10) / 10:F1} m/s");

        Console.SetCursorPosition(1, Console.WindowHeight - 3);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite una opción del menú:");
        Console.ResetColor();
        Console.SetCursorPosition(25, Console.WindowHeight - 2);
        Console.WriteLine("1. Ir al menú anterior       2. Continuar        3. Salir");
        while (true)
        {
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Main();
                    return;
                case 2:
                    Console.Clear();
                    return;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}