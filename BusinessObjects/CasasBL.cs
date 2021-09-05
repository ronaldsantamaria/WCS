using BusinessObjects.Interfaces;
using BusinessObjets;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BusinessObjects
{
    public class CasasBL : ICasasBL
    {
        private readonly ICasasDAL _ICasasDAL;

        public CasasBL(ICasasDAL CasasDAL)
        {
            _ICasasDAL = CasasDAL;
        }

        public List<CasaModel> GetAllCasas()
        {
            var allCasas = _ICasasDAL.GetAllCasas();
            return toModel(allCasas);
        }

        public CasaModel GetCasa(int Id)
        {
            var allCasas = _ICasasDAL.GetAllCasas();
            var casa = toModel(allCasas).Where(i => i.Id == Id).FirstOrDefault();
            return casa;
        } 


        private List<CasaModel> toModel(List<Casa> casas)
        {
            var casaModel = new List<CasaModel>();

            foreach (var item in casas)
            {
                casaModel.Add(
                    new CasaModel()
                    {
                        Id = item.Id,
                        Nombre = item.Nombre
                    }
                    );
            }
            return casaModel;
        }
    }
}
