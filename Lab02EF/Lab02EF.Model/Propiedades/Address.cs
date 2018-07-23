using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model.Propiedades
{
    public partial class Address
    {
        [DataMember]
        [NotMapped]
        public string NombreStateProvince { get; set; }
        [DataMember]
        [NotMapped]
        public string NombreCountryRegion { get; set; }
        [DataMember]
        [NotMapped]
        public int CodigoStateProvince { get; set; }
        [DataMember]
        [NotMapped]
        public int CodigoCountryRegion { get; set; }

    }
}
