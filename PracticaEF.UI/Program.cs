using PracticaEF.Logic;
using PracticaEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo simple
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            foreach (Territories territorie in territoriesLogic.GetAll())
            {
                Console.WriteLine($"{territorie.TerritoryID} - {territorie.TerritoryDescription}");
            }
            
            //Add Category
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (var item in categoriesLogic.GetAll())
            {
                Console.WriteLine($"ID: {item.CategoryID} Name: {item.CategoryName} - Description: {item.Description}");
            }

            Console.WriteLine("Ingrese una nombre de nueva categoria:");
            try
            {
                categoriesLogic.Add(new Categories
                   {
                      CategoryName = Console.ReadLine()
                    });
            }
            catch (FormatException e)
            {
                Console.WriteLine("Necesitas ingresar un numero y luego un nombre {0}", e.Message);
            }
            
            
            foreach (var item in categoriesLogic.GetAll())
            {
                Console.WriteLine($" ID: {item.CategoryID} - Name: {item.CategoryName} - Description: {item.Description}");
            }


            //Delete Category
            Console.WriteLine("Ingrese el id de la categoria a borrar");
            try
            {
                    categoriesLogic.Delete(int.Parse(Console.ReadLine()));
                    Console.WriteLine("El registro se ha eliminado");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Necesitas ingresar un numero de id para borrarlo {0}", e.Message);
            }

            foreach (var item in categoriesLogic.GetAll())
            {
                Console.WriteLine($" ID: {item.CategoryID} - Name: {item.CategoryName} - Description: {item.Description}");
            }

            //Update Category
            Console.WriteLine("Ingrese el id de la categoria a modificar y luego el nombre modificado");
           try
            {
                categoriesLogic.Update(new Categories
                            {
                                CategoryID = int.Parse(Console.ReadLine()),
                                CategoryName = Console.ReadLine()
                            }) ;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Necesitas ingresar un numero de id para modificarlo {0}", e.Message);
            }

            foreach (var item in categoriesLogic.GetAll())
            {
                Console.WriteLine($"Name: {item.CategoryName} - Description: {item.Description}");
            }

            Console.ReadLine();
        }
    }
}
