
/*PUNTO2_Calculadora V1
construya un programa que sea una calculadora que permita al usuario realizar las 4 
operaciones basicas (Sumar, Restar, Multiplicar y Dividir) a partir de un menú para 
seleccionar la opcion a elegir y que luego pida dos numeros y que devuelva el resultado 
de la operacion seleccionada. Ademas una vez que termine de realizar la operacion le 
pregunte si desea realizar otro calculo.
*/

Console.WriteLine("\nCALCULADORA");
Console.WriteLine("\nSeleccione una opcion:");

int control=1;
while(control != 0){
    Console.WriteLine("\n1_sumar 2_restar 3_multiplicar 4_dividir 0_salir");
    int.TryParse(Console.ReadLine(), out int operacion);

    Console.WriteLine("Ingrese valor1:");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("Ingrese valor2:");
    float.TryParse(Console.ReadLine(), out float b);

    float resultado=0;
    switch(operacion){
        case 1: 
            resultado = a+b; 
            break;

        case 2: 
            resultado = a-b; 
            break;

        case 3: 
            resultado = a*b; 
            break;

        case 4: 
           if (b != 0){
                resultado = a / b;
            }else{
                Console.WriteLine("No se puede dividir entre 0. Ingrese otro número.");
            }
            break;

        default:
            Console.WriteLine("Operacion invalida, elija otra operacion");
            continue;
    }
    
    Console.WriteLine("Resultado: " + resultado);

    Console.WriteLine("Desea Realizar otra operacion? 1_Si Enter_No");
    if(!int.TryParse(Console.ReadLine(), out int opcion)){
        control = 0;
    }
}
Console.WriteLine("¡Gracias por usar la calculadora!");



