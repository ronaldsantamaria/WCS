using BusinessObjets;
using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class AspiranteModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Nombre { get; set; }
        [StringLength(20)]
        public string Apellido { get; set; }
        [Range(0, 9999999999)]
        public int Identificacion { get; set; }
        [Range(0, 99)]
        public int Edad { get; set; }
        public CasaModel Casa { get; set; }
    }
}
