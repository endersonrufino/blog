using blog.Models;
using blog.Repositories;

namespace blog.Screens.TagScreens
{
    public class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("---------");

            Console.WriteLine("Nome:");
            var name = Console.ReadLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();

            MenuTagScreen.Load();
        }

        private static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Insert(tag);

                Console.WriteLine("Tag cadastrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}