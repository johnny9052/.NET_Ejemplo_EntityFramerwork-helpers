using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Referencias adicionales*/
using DataLayer.Entity;
using MVCListar.Models;
using System.Data.Entity.Core.Objects;

namespace MVCListar.Helpers
{
    public class CastMunDBtoMunModel
    {

        public IEnumerable<ModelMunicipio> ParsearMunicipio(ObjectResult<listarMunicipios_Result> listDB)
        {
            IList<ModelMunicipio> list = new List<ModelMunicipio>();
            foreach (var mun in listDB)
            {
                ModelMunicipio m = new ModelMunicipio()
                {
                    Id = mun.id,
                    Nombre = mun.nombre,
                    Departamento = new ModelDepartamentos(){
                        Id = mun.idDepartamento,
                        Nombre = mun.nombreDepartamento
                    }
                };
                
                list.Add(m);
            }
            return list;
        }

    }
}