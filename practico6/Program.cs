
/*PUNTO3_calculadora V2
Implementar las mejoras en la calculadora 
Solicite al usuario un número y muestre por pantalla:
    ● El valor absoluto de un numero
    ● El cuadrado
    ● La raiz cuadrada
    ● El seno
    ● El Coseno
    ● La parte entera de un tipo float.
Luego de esto, solicite dos numeros al usuario y determine:
    ● El Maximo entre los dos numeros
    ● El Minimo entre los dos naumeros
Contemplar el caso de que el usuario no ingrese un número valido
*/

Console.WriteLine("Ingrese un numero:");

if (!float.TryParse(Console.ReadLine(), out float numero)){
    Console.WriteLine("El numero ingresado es invalido, ingrese otro numero");
        return;
}

Console.WriteLine("Valor absoluto: " + Math.Abs(numero));
Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2));
Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));
Console.WriteLine("Seno: " + Math.Sin(numero));
Console.WriteLine("Coseno: " + Math.Cos(numero));
Console.WriteLine("Parte entera: " + Math.Truncate(numero));

Console.WriteLine("Ingrese dos numeros:");

float num1, num2;
if (!float.TryParse(Console.ReadLine(), out num1)){
    Console.WriteLine("El numero ingresado es invalido, ingrese otro numero");
        return;
}

if (!float.TryParse(Console.ReadLine(), out num2)){
    Console.WriteLine("El numero ingresado es invalido, ingrese otro numero");
        return;
}

Console.WriteLine("Máximo: " + Math.Max(num1, num2));
Console.WriteLine("Mínimo: " + Math.Min(num1, num2));

