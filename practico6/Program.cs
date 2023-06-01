// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

/*PUNTO1
Construir un programa que permita invertir un numero. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversion del
numero sólo si éste es mayor a 0
*/

Console.WriteLine("Punto 1");
Console.WriteLine("Ingrese un numero:");

//lee una línea de texto ingresada por el usuario, intenta convertirla a un numero entero 
//y almacena el resultado de la conversion en la variable num.
bool control=int.TryParse(Console.ReadLine(), out int num); 

if(control){//control si el valor ingresado es un numero 
    if (num>0){
        int numInvertido=0;
        while(num>0){
            int resto=num % 10;
            numInvertido=numInvertido * 10 + resto;
            num/= 10;
        }
        Console.WriteLine($"El numero invertido es: {numInvertido}");
    }else{
        Console.WriteLine("El numero ingresado es menor que cero");
    }
}else{
    Console.WriteLine("No ingreso un numero valido");
}




