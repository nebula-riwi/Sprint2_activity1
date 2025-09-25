using Sprint2.Controllers;
using Sprint2.Models;

namespace Sprint2.Classes;

public class Queries
{
    UserController User = new UserController();

    public void QueriesMenu()
    {
      string choose;
      
      do
      {
        Console.Clear();
        Console.WriteLine("======== Menú de consultas ========");
        Console.WriteLine(@"Seleccione la opción deseada:
1. Ver todos los usuarios
2. Ver un usuario por id:
3. Ver un usuario por email:
4. Listar usuarios por ciudad
5. Listar usuarios por país
6. Listar usuarios mayores a una edad
7. Listar usuarios por género
8. Mostrar solo nombres y correo
9. Total usuarios registrados
10. Total usuarios por ciudad
11. Total usuarios por país
12. Ver usuarios sin teléfono registrado
13. Ver usuarios sin dirección registrada
14. Listar últimos usuarios registrados
15. Listar usuarios ordenados por apellido
16. Regresar al menú principal");
        choose = Console.ReadLine();

        switch (choose)
        {
          case "1":
            Console.Clear();
            Console.WriteLine("----Todos los usuarios----");
            foreach (var user in User.Index())
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "2":
            Console.Clear();
            Console.WriteLine("----Buscar usuario por Id----");
            Console.WriteLine("Ingrese el id del usuario: ");
            int id = int.Parse(Console.ReadLine());
            var userId = User.GetById(id);
            Console.WriteLine(
              $"Id: {userId.Id} - Nombre: {userId.First_name} {userId.Last_name} - Username: {userId.Username} - Email: {userId.Email} - Phone: {userId.Phone} - CellPhone: {userId.Cellphone} - Address: {userId.Address} - City: {userId.City} - State: {userId.State} - Zipcode: {userId.Zipcode} - Country: {userId.Country} - Gender: {userId.Gender} - Age: {userId.Age}");
            break;
          case "3":
            Console.Clear();
            Console.WriteLine("----Buscar usuario por Email----");
            Console.WriteLine("Ingrese el correo del usuario: ");
            string email = Console.ReadLine();
            User userMail = User.GetByEmail(email);
            Console.WriteLine(
              $"Id: {userMail.Id} - Name: {userMail.First_name} {userMail.Last_name} - Username: {userMail.Username} - Email: {userMail.Email} - Phone: {userMail.Phone} - CellPhone: {userMail.Cellphone} - Address: {userMail.Address} - City: {userMail.City} - State: {userMail.State} - Zipcode: {userMail.Zipcode} - Country: {userMail.Country} - Gender: {userMail.Gender} - Age: {userMail.Age}");
            break;
          case "4":
            Console.Clear();
            Console.WriteLine("----Filtrar usuarios por ciudad----");
            Console.WriteLine("Ingrese el nombre de la ciudad: ");
            string city = Console.ReadLine();
            foreach (var user in User.GetUsersByCity(city))
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "5":
            Console.Clear();
            Console.WriteLine("----Filtrar usuarios por país----");
            Console.WriteLine("Ingrese el nombre del país: ");
            string country = Console.ReadLine();
            foreach (var user in User.GetUsersByCountry(country))
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "6":
            Console.Clear();
            Console.WriteLine("----Filtrar usuarios por edad----");
            Console.WriteLine("Ingrese la edad buscada: ");
            int age = int.Parse(Console.ReadLine());
            foreach (var user in User.GetUsersByAge(age))
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "7":
            Console.Clear();
            Console.WriteLine("----Filtrar usuarios por género----");
            Console.WriteLine("Ingrese el género buscado: ");
            string gender = Console.ReadLine();
            foreach (var user in User.GetUsersByGender(gender))
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "8":
            Console.Clear();
            Console.WriteLine("----Todos los nombres y correos----");
            foreach (var user in User.Index())
            {
              Console.WriteLine($"Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "9":
            Console.Clear();
            Console.WriteLine("----Total usuarios registrados----");
            Console.WriteLine($"Hay un total de {User.Index().Count()} usuarios registrados");
            break;
          case "10":
            Console.Clear();
            Console.WriteLine("----Total usuarios por cada ciudad----");
            foreach (var user in User.GetTotalByCity())
            {
              Console.WriteLine($"Ciudad: {user.Place} - Usuarios: {user.UserCount}");
            }

            break;
          case "11":
            Console.Clear();
            Console.WriteLine("----Total usuarios por cada país----");
            foreach (var user in User.GetTotalByCountry())
            {
              Console.WriteLine($"País: {user.Place} - Usuarios: {user.UserCount}");
            }

            break;
          case "12":
            Console.Clear();
            Console.WriteLine("----Usuarios sin teléfono registrado----");
            foreach (var user in User.GetUsersWithoutPhone())
            {
              Console.WriteLine($"Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "13":
            Console.Clear();
            Console.WriteLine("----Usuarios sin dirección registrada----");
            foreach (var user in User.GetUsersWithoutAddress())
            {
              Console.WriteLine($"Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "14":
            Console.Clear();
            Console.WriteLine("----Últimos usuarios registrados----");
            foreach (var user in User.GetLastUsers())
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }

            break;
          case "15":
            Console.Clear();
            Console.WriteLine("----Usuarios ordenados por apellido----");
            foreach (var user in User.GetUsersByLastname())
            {
              Console.WriteLine($"Id: {user.Id} - Nombre: {user.First_name} {user.Last_name} - Correo: {user.Email}");
            }
            break;
          case "16":
            Console.Clear();
            Console.WriteLine("----Regresando al menú principal----");
            return;
          default:
            Console.WriteLine("Opción inválida");
            break;
        }
        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
      } while (choose != "16");
    }
}