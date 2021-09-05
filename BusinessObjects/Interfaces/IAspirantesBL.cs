using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface IAspirantesBL
    {
        public List<AspiranteModel> GetAllAspirantes();
        void Create(AspiranteModel newAspirante);
        void Update(AspiranteModel newAspirante);
        void Remove(int id);
    }
}
