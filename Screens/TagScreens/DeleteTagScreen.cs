using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Models;
using blog.Repositories;

namespace blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("---------");

            Console.WriteLine("Id da tag a ser deletada:");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();

            MenuTagScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Delete(id);

                Console.WriteLine("Tag deletada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}