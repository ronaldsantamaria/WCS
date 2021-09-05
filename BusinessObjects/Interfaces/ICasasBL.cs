using BusinessObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Interfaces
{
    public interface ICasasBL
    {
        public List<CasaModel> GetAllCasas();
        public CasaModel GetCasa(int Id);
    }
}
