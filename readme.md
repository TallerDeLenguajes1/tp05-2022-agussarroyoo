4. a) String es un tipo por referencia ya que no tienen un tamaño determinado
   b) Las secuencias de escape de tipo cadena son 
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)
   c) El caracter $ sirve para usar la interpolacion de cadenas: Ej: 
	var jh = (firstName: "Jupiter", lastName: "Hammon", born: 	1711, published: 1761);
	Console.WriteLine($"{jh.firstName} {jh.lastName} was an 	African American poet born in {jh.born}.");

	// Output:
	// Jupiter Hammon was an African American poet born in 1711.
	El caracter @ sirve para utilizar los 'literales de cadena textual'. Esto resulta mas comodo para la impresion de cadenas de varias lineas que contienen caracteres de barra diagonal inversa o comillas dobles inscrustadas. Por ejemplo: 
// Initialize with a regular string literal.
	string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

// Initialize with a verbatim string literal.
string newPath = @"c:\Program Files\Microsoft Visual Studio 8.0";