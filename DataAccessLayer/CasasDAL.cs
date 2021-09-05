using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class CasasDAL : ICasasDAL
    {
        private ApiDbContext _context;

        public CasasDAL(ApiDbContext context)
        {
            _context = context;
        }

        public List<Casa> GetAllCasas()
        {
            return _context.Casas.ToList();
        }
    }
}
