using PracticaEF.Data;
using PracticaEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public class CustomersLogic : BaseLogic
    {
      
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();

        }
    }
}
