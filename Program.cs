// Autor: LozanoSoft

using System;

namespace tipos_de_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Números enteros

            sbyte numSB = 127; // Entero, 1 byte con signo (-128 a 127)
            byte numB = 255; // Entero, 1 byte sin signo (0 a 255)
            short numS = 32767; // Entero, 2 bytes con signo (-32,768 a 32,767)
            ushort numUS = 65535; // Entero, 2 bytes sin signo (0 a 65,535)
            int numI = 2147483647; // Entero, 4 bytes con signo (-2,147,483,648 a 2,147,483,647)
            uint numUI = 4294967295U; // Entero, 4 bytes sin signo (0 a 4,294,967,295)
            long numL = 9223372036854775807L; // Entero, 8 bytes con signo (-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807)
            ulong numUL = 18446744073709551615UL; // Entero, 8 bytes sin signo (0 a 18,446,744,073,709,551,615)

            Console.WriteLine(Convert.ToString(numSB));
            Console.WriteLine(Convert.ToString(numB));

            Console.WriteLine(

                Convert.ToString(numS) + '\n' +
                Convert.ToString(numUS) + '\n' +
                Convert.ToString(numI) + '\n' +
                Convert.ToString(numUI) + '\n' +
                Convert.ToString(numL) + '\n' +
                Convert.ToString(numUL) + '\n'

            );

            // Números flotantes (con punto decimal)

            float numF = 3.4E38F; // Real, IEEE 754, 32 bits (±1.5 x 10^-45 a ±3.4 x 10^38)
            double numD = 1.7E308D; // Real, IEEE 754, 64 bits (±5,0 × 10^−324 a ±1,7 × 10^308)
            decimal numDec = 7.9228E28M; // Real, 128 bits (28 dígitos significativos; ±1,0 x 10^-28 a ±7,9228 x 10^28)

            Console.WriteLine(

                Convert.ToString(numF) + '\n' +
                Convert.ToString(numD) + '\n' +
                Convert.ToString(numDec) + '\n'

            );

            // Cadenas de caracteres

            char letra = 'L'; // Caracter Unicode, 2 bytes
            string mensaje = "Hola mundo"; // Cadena de caracteres Unicode

            Console.WriteLine(

                Convert.ToString(letra) + '\n' +
                Convert.ToString(mensaje) + '\n'

            );

            // Booleanos (true / false)

            bool BooleanoT = true; // 1 bit -> 1
            bool BooleanoF = false; // 1 bit -> 0

            Console.WriteLine(

                Convert.ToString(BooleanoT) + '\n' +
                Convert.ToString(BooleanoF) + '\n'

            );

            // El lenguaje ocupa el espacio de nombres "System"
            // de .NET Framework
            //
            // System.String -> string
            //
            // Análogo a C++
            //
            // std::string -> string

        }

    }

}