using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        string entrada = Console.ReadLine();
        if(!int.TryParse(entrada, out int edad))
        {
            Console.WriteLine("Error Critico: Debe ingresar un numero entero valido (no letras ni simbolos)");
        }
        else if (edad < 0 || edad > 120){
            Console.WriteLine("Error: Edad fuerea de rango valido");
        }
        else if (edad <= 17){
            Console.WriteLine("Acceso Denegado: Usuario menor de Edad");
        }
        else if (edad <= 64){
            Console.WriteLine("Acceso Concedido: Rol Usuario Estandar");
        }
        else{
            Console.WriteLine("Acceso Concedido: Rol Administrador VIP");
        }
    }
}