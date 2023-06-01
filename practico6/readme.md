#PUNTO 4
**¿String es una tipo por valor o un tipo por referencia?**

El tipo string es un tipo de referencia, significa que se almacena en el heap 
y se accede a traves de referencias.

**¿Qué secuencias de escape tiene el tipo string?**

Secuencias de escape mas comunes son:

\n: Nueva línea
\r: Retorno de carro
\t: Tabulación horizontal
\": Comilla doble
\': Comilla simple
\\: Barra invertida

**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**

Cuando se utiliza el carácter @ antes de una cadena de texto, se trata de una cadena 
literal. Significa que los caracteres de escape no se interpretan y la cadena se 
interpreta literalmente. 

Por ejemplo, con el uso del carácter @:
    string path = @"C:\Users\Usuario\Documents";

Cuando se utiliza el caracter $ antes de una cadena de texto, se habilita la interpolacion 
de cadenas. Esto permite incrustar expresiones y variables dentro de la cadena utilizando 
la sintaxis ${} para formar cadenas dinamicas de manera mas conveniente.

Por ejemplo, con el uso de @ y $ juntos:
    string name = "John";
    int age = 30;
    string message = $"Mi nombre es {name} y tengo {age} años.";

La interpolacion de cadenas permite insertar los valores de las variables name y age 
dentro de la cadena message.

#Métodos pertenecientes al objeto string para procesar cadenas de texto

##Conversor de tipo: 

**ToString()** convierte un valor a su representación en forma de cadena (string). 

##Comparador de cadenas: 

**Compare()** compara dos cadenas y devuelve un valor que indica si son iguales, si una 
es mayor o si es menor que la otra.

**CompareTo()** compara la cadena actual con otra cadena y devuelve un valor que indica si 
son iguales, si la cadena actual es mayor o si es menor que la otra.

**Operadores == y !=** compara dos cadenas y determinar si son iguales o diferentes.

##Mayúsculas y minúsculas: 

**ToUpper()** convierte todos los caracteres de una cadena a mayúsculas.

**ToLower()** convierte todos los caracteres de una cadena a minúsculas.

##Acceso a los caracteres individuales: 

**Substring()** extrae una subcadena de una cadena, especificando la posición inicial y la 
longitud de la subcadena.

**Replace()** reemplaza todas las apariciones de un carácter o una subcadena por otra en una 
cadena.

**Split()** divide una cadena en subcadenas más pequeñas, utilizando un carácter o una 
cadena delimitadora como referencia.

**Trim()** elimina los espacios en blanco del principio y el final de una cadena.

##Búsqueda y manipulación de una cadena:

**IndexOf()** busca la primera aparición de un carácter o una subcadena dentro de una 
cadena y devuelve su posición.

**LastIndexOf()** busca la última aparición de un carácter o una subcadena dentro de una 
cadena y devuelve su posición.

**StartsWith()** determina si una cadena comienza con un carácter o una subcadena específica.

**EndsWith()** determina si una cadena termina con un carácter o una subcadena específica.

#PUNTO 5
