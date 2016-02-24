
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
    public class CastDeptosDBtoDeptosModel
    {

        public IEnumerable<ModelDepartamentos> ParsearDepartamentos(ObjectResult<listarDepartamento_Result> listDB)
        {
            IList<ModelDepartamentos> list = new List<ModelDepartamentos>();
            foreach (var depto in listDB)
            {
                ModelDepartamentos d = new ModelDepartamentos()
                {
                    Id = depto.id,
                    Nombre = depto.nombre
                };

                list.Add(d);
            }
            return list;
        }
    }
}