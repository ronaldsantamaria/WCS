using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class AspirantesDAL : IAspirantesDAL
    {
        private ApiDbContext _context;

        public AspirantesDAL(ApiDbContext context)
        {
            _context = context;
        }

        public List<Aspirante> GetAllAspirantes()
        {
            return _context.Aspirantes.ToList();
        }

        public Aspirante Find(int Id)
        {
            var aspirante = _context.Aspirantes.SingleOrDefault(i => i.Id == Id);
            return aspirante;
        }

        public void Create(Aspirante newAspirante)
        {
            _context.Aspirantes.Add(newAspirante);
            _context.SaveChanges();
        }

        public void Update(Aspirante newAspirante)
        {
            _context.Aspirantes.Update(newAspirante);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var aspirante = _context.Aspirantes.Find(id);
            _context.Remove(aspirante);
            _context.SaveChanges();
        }
    }
}