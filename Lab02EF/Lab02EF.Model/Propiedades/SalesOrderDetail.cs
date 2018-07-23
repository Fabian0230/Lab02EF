using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model.Propiedades
{
    public partial class SalesOrderDetail
    {
        [DataMember]
        [NotMapped]
        public double PorcentajeDescuentoUnitario { get; set; }
        [DataMember]
        [NotMapped]
        public string PorcentajeConFormato { get; set; }
    }
}
