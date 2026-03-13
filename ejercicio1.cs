/*Sistema 1: Sistema de Registro de Usuarios
El programa permitirá registrar usuarios en el sistema.
Menú principal
1. Registrar usuario
2. Mostrar usuarios registrados
3. Buscar usuario por nombre
4. Salir
Requisitos
Al registrar usuario se debe pedir:
• Nombre
• Edad
• Correo electrónico
• Tipo de usuario
El tipo de usuario debe seleccionarse con switch:
1 Administrador
2 Cliente
3 Invitado
Validaciones
• Si el nombre tiene menos de 3 caracteres, mostrar error.
• Si la edad es menor a 18, indicar que es menor de edad.
• Si el correo no contiene “@”, mostrar advertencia.*/

string nombre = "";
int edad;
string correo = "";
string tipoUsuario= "";
int opcion;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1.Registrar Usuario");
    Console.WriteLine("2.Mostrar usuarios registrados");
    Console.WriteLine("3.Buscar usuario por nombre");
    Console.WriteLine("4.Salir");
} while (opcion != 4);
