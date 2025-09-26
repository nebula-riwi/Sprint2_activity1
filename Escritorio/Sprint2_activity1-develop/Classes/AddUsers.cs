using Sprint2.Controllers;
using Sprint2.Models;
namespace Sprint2.Classes;

public class Create
{
    UserController userController = new UserController();

    public void CreateMenu()
    {
        while (true)
        {
            Console.WriteLine("========== Bienvenido ==========");
            Console.WriteLine("======== Menú para crear ========");
            Console.WriteLine("1. Crear nuevo usuario");
            Console.WriteLine("2. Salir");
            Console.WriteLine("Seleccione la opción deseada: ");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    User newUser = new User();
                    Console.WriteLine("Ingrese el nombre del usuario: ");
                    newUser.First_name = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del usuario: ");
                    newUser.Last_name = Console.ReadLine();
                    Console.WriteLine("Ingrese el username del usuario: ");
                    newUser.Username = Console.ReadLine();
                    Console.WriteLine("Ingrese el correo del usuario: ");
                    newUser.Email = Console.ReadLine();
                    userController.CreateUser(newUser);
                    Console.WriteLine("Usuario creado exitosamente.");
                    break;
                default:
                    Console.WriteLine("Saliendo del menú.");
                    return;
                
            }
        }
    }
}