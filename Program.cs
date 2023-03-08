using blog;
using blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

public class Program
{
    const string connectionString = "Data Source=DESKTOP-FVOS0IE\\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True;TrustServerCertificate=True";

    private static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(connectionString);

        Database.Connection.Open();

        Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

    private static void Load()
    {
        Console.Clear();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("-----------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuário");
        Console.WriteLine("2 - Gestão de perfil");
        Console.WriteLine("3 - Gestão de categoria");
        Console.WriteLine("4 - Gestão de tag");
        Console.WriteLine("5 - Vincular perfil/usuário");
        Console.WriteLine("6 - Vincular post/tag");
        Console.WriteLine("7 - Relatórios");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 4:
                MenuTagScreen.Load();
                break;
            default: Load(); break;
        }
    }
}