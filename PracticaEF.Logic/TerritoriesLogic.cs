using PracticaEF.Data;
using PracticaEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public class TerritoriesLogic : BaseLogic
    {
      
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
    }
}
