using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListar.Models
{
    public class ModelMunicipio
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public ModelDepartamentos Departamento { get; set; }        

    }
}