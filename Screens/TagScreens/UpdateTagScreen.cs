using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Models;
using blog.Repositories;

namespace blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("---------");

            Console.WriteLine("Id da tag:");
            var id = Console.ReadLine();

            Console.WriteLine("Nome:");
            var name = Console.ReadLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });

            Console.ReadKey();

            MenuTagScreen.Load();
        }

        private static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Update(tag);

                Console.WriteLine("Tag atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar a tag.");
                Console.WriteLine(ex.Message);
            }
        } 

    }
}