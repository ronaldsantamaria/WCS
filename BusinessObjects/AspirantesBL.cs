using BusinessLayer.Interfaces;
using BusinessObjects.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class AspirantesBL : IAspirantesBL
    {
        private readonly IAspirantesDAL _aspirantesDAL;
        private readonly ICasasBL _casasBL;

        public AspirantesBL(IAspirantesDAL aspirantesDAL, ICasasBL casasBL)
        {
            _aspirantesDAL = aspirantesDAL;
            _casasBL = casasBL;
        }

        public void Create(AspiranteModel newAspirante)
        {
            // Check if the "Casa" exists
            var casaModel = _casasBL.GetCasa(newAspirante.Casa.Id);
            if (casaModel == null)
            {
                throw new ArgumentException("No se encontro la Casa");
            }
            
            var aspiranteEntity = ToEntity(newAspirante);
            _aspirantesDAL.Create(aspiranteEntity);
        }

        public void Update(AspiranteModel aspiranteModel)
        {
            // Check if the "Aspirante" exists
            var aspiranteEntity = _aspirantesDAL.Find(aspiranteModel.Id);
            if (aspiranteEntity == null)
            {
                throw new ArgumentException("No se encontro el Aspirante");
            }

            var casaModel = _casasBL.GetCasa(aspiranteModel.Casa.Id);
            if (casaModel == null)
            {
                throw new ArgumentException("No se encontro la Casa");
            }

            aspiranteEntity = ToUpdateEntity(aspiranteEntity, aspiranteModel);

            _aspirantesDAL.Update(aspiranteEntity);
        }

        public void Remove(int id)
        {
            _aspirantesDAL.Remove(id);
        }

        List<AspiranteModel> IAspirantesBL.GetAllAspirantes()
        {
            var allAspirantes = _aspirantesDAL.GetAllAspirantes();
            return toModel(allAspirantes);
        }

        private List<AspiranteModel> toModel(List<Aspirante> aspirantes)
        {
            var aspiranteModel = new List<AspiranteModel>();

            foreach (var item in aspirantes)
            {
                var casaModel = _casasBL.GetCasa(item.IdCasa);

                aspiranteModel.Add(
                    new AspiranteModel()
                    {
                        Id = item.Id,
                        Nombre = item.Nombre,
                        Apellido = item.Apellido,
                        Edad = item.Edad,
                        Identificacion = item.Identificacion,
                        Casa = casaModel
                    }
                    );
            }
            return aspiranteModel;
        }

        private Aspirante ToEntity(AspiranteModel aspiranteModel)
        {
            var aspiranteEntity = new Aspirante();

            aspiranteEntity.Id = aspiranteModel.Id;
            aspiranteEntity.Nombre = aspiranteModel.Nombre;
            aspiranteEntity.Apellido = aspiranteModel.Apellido;
            aspiranteEntity.Edad = aspiranteModel.Edad;
            aspiranteEntity.Identificacion = aspiranteModel.Identificacion;
            aspiranteEntity.IdCasa = aspiranteModel.Casa.Id;

            return aspiranteEntity;
        }

        private Aspirante ToUpdateEntity(Aspirante aspiranteEntity, AspiranteModel aspiranteModel)
        {
            aspiranteEntity.Nombre = aspiranteModel.Nombre;
            aspiranteEntity.Apellido = aspiranteModel.Apellido;
            aspiranteEntity.Edad = aspiranteModel.Edad;
            aspiranteEntity.Identificacion = aspiranteModel.Identificacion;
            aspiranteEntity.IdCasa = aspiranteModel.Casa.Id;

            return aspiranteEntity;
        }

    }
}
