using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IAspirantesDAL
    {
        List<Aspirante> GetAllAspirantes();
        Aspirante Find(int Id);
        void Create(Aspirante newAspirante);
        void Update(Aspirante newAspirante);
        void Remove(int id);
    }
}
