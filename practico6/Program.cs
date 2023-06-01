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
*/

/*PUNTO 4
Realizar los siguientes ejercicios
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
tarea:*/
Console.WriteLine("Ingrese una cadena de texto:");
string texto = Console.ReadLine();
Console.WriteLine("La cadena ingresada es: " + texto);

//Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("Longitud de la cadena: " + texto.Length);

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas
Console.WriteLine("Ingrese otra cadena:");
string Cadena2 = Console.ReadLine();

string concatenacion = texto + Cadena2;
Console.WriteLine("Cadena concatenada: " + concatenacion);

//Extraer una subcadena de la cadena ingresada
Console.WriteLine("Ingrese índice de inicio para extraer subcadena:");
int indiceInicio = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());

string subcadena = texto.Substring(indiceInicio, longitudSubcadena);
Console.WriteLine("Subcadena extraída: " + subcadena);

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
Console.WriteLine("Recorrido de la cadena:");
    foreach (char caracter in texto){
        Console.WriteLine(caracter);
    }

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese palabra a buscar en la cadena:");
string palabraBuscada = Console.ReadLine();

bool palabraEncontrada = texto.Contains(palabraBuscada);
Console.WriteLine("La palabra se encontro en la cadena: " + palabraEncontrada);

//Convierta la cadena a mayúsculas y luego a minúsculas.
string textoMayusculas = texto.ToUpper();
string textoMinusculas = texto.ToLower();
Console.WriteLine("Cadena en mayúsculas: " + textoMayusculas);
Console.WriteLine("Cadena en minúsculas: " + textoMinusculas);

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();

string[] elementos = cadenaSeparada.Split(',');
Console.WriteLine("Resultados:");
foreach (string elemento in elementos){
    Console.WriteLine(elemento);
}

//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2

//Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado. Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente.
//Nota: Busque el comportamiento del Método ToString();


