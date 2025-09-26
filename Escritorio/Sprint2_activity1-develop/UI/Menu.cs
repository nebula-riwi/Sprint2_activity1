using Sprint2.Classes;

namespace Sprint2.UI;

public class Menu
{
    public void Caller()
    {
        Create add = new Create();
        // Delete del = new Delete();
        Queries queries = new Queries();
        string opt;
        Console.Clear();
        Console.WriteLine("Bienvenido a el sistema");
        do
        {
            Console.WriteLine("Gestion de usuarios");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Seleccione una opcion ");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" 1 - Agregar un usuario ");
            Console.WriteLine(" 2 - Actualizar un usuario ");
            Console.WriteLine(" 3 - Eliminar un usuario ");
            Console.WriteLine(" 4 - Filtrar usuarios ");
            Console.WriteLine(" 5 - Salir ");
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.Clear();
                    add.CreateMenu();
                    break;
                case "2":
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    //del.DeleteMenu();
                    break;
                case "4":
                    Console.Clear();
                    queries.QueriesMenu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Tenga un buen día");
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        } while (opt !="5");
    }
}