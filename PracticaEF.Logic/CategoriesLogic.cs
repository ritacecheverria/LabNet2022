using PracticaEF.Data;
using PracticaEF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Categories newCategory)
        {
            context.Categories.Add(newCategory);
            context.SaveChanges();
        }

        public void Delete (int id)
        {
            var categDelete = context.Categories.Find(id);
            context.Categories.Remove(categDelete);
            context.SaveChanges();
        }

        public void Update (Categories categories)
        {
            var catUpdate = context.Categories.Find(categories.CategoryID);
            
            try
            {
                catUpdate.CategoryName = categories.CategoryName; 
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.Write("Propiedad: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
            
        }

    }
}
