using Sprint2.Controllers;
using Sprint2.Models;

namespace Sprint2.Classes;

public class Delete
{
    UserController User = new UserController();
    public void DeleteMenu()
    {
        while (true)
        {
            Console.WriteLine("========== Bienvenido ==========");
            Console.WriteLine("======== Menú para eliminar ========");
            Console.WriteLine("1. Eliminar usuario por id");
            Console.WriteLine("2. Eliminar usuario por email");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Seleccione la opción deseada: ");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.WriteLine("Ingrese el id del usuario: ");
                    int id = int.Parse(Console.ReadLine());
                    var userId = User.GetById(id);
                    if (userId != null)
                    {
                        Console.WriteLine($"¿Está seguro que desea eliminar al usuario {userId.First_name} {userId.Last_name}? (s/n)");
                        string confirmation = Console.ReadLine().ToLower();
                        if (confirmation != "s")
                        {
                            Console.WriteLine("Operación cancelada.");
                            return;
                        }
                        User.DeleteUser(userId);
                        Console.WriteLine("Usuario eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Usuario no encontrado.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Ingrese el correo del usuario: ");
                    string email = Console.ReadLine();
                    var userMail = User.GetByEmail(email);
                    if (userMail != null)
                    {
                        Console.WriteLine($"¿Está seguro que desea eliminar al usuario {userMail.First_name} {userMail.Last_name}? (s/n)");
                        string confirmation = Console.ReadLine().ToLower();
                        if (confirmation != "s")
                        {
                            Console.WriteLine("Operación cancelada.");
                            return;
                        }
                        User.DeleteUser(userMail);
                        Console.WriteLine("Usuario eliminado exitosamente.");
                    }

                    else
                    {
                        Console.WriteLine("Usuario no encontrado.");
                    }
                    break;
                    case "3":
                        Console.WriteLine("Saliendo del menú.");
                        return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
      