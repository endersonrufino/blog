using blog.Models;
using blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

public class Program
{
    const string connectionString = "Data Source=DESKTOP-FVOS0IE\\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True;TrustServerCertificate=True";

    private static void Main(string[] args)
    {
        //ReadUsers();
        //ReadUser();
        //CreateUser();
        //UpdateUser();
        //DeleteUser();

        var connection = new SqlConnection(connectionString);

        connection.Open();

        // ReadUsers(connection);
        // ReadRoles(connection);
        // ReadTags(connection);
        // ReadCategories(connection);
        ReadUsersWithRoles(connection);

        connection.Close();

    }

    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);

        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);

        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);

        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static void ReadCategories(SqlConnection connection)
    {
        var repository = new Repository<Category>(connection);

        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static void ReadUsersWithRoles(SqlConnection connection)
    {
        var userRepository = new UserRepository(connection);
        var items = userRepository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);

            foreach (var role in item.Roles)
            {
                Console.WriteLine($" - {role.Name}");
            }
        }
    }
}