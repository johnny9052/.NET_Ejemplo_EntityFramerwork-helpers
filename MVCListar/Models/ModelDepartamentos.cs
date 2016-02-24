using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListar.Models
{
    public class ModelDepartamentos
    {


        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<String> ModelMunicipio { get; set; }


        /*private int total;

        public int Total
        {
            get { return (1 + 5 + 6); }
        }*/

    }
}