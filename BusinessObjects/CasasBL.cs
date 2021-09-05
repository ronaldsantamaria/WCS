using BusinessObjects.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class CasasBL : ICasasBL
    {
        private readonly ICasasDAL _ICasasDAL;

        public CasasBL(ICasasDAL CasasDAL)
        {
            _ICasasDAL = CasasDAL;
        }

        public void GetAllCasas()
        {
            _ICasasDAL.GetAllCasas();
        }
    }
}
