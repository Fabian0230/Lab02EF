using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model
{
    public partial class SalesOrderDetail
    {
        [DataMember]
        [NotMapped]
        public double PorcentajeDescuentoUnitario
        {
            get {
                var precioTotal = OrderQty * UnitPrice;
                var precioFinal = LineTotal;
                var descuento = precioTotal - precioFinal;
                return Convert.ToDouble(descuento);
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string PorcentajeConFormato
        {
            get {
                var porcentajeUnitario = UnitPriceDiscount;
                var porcentajeUnitarioString = "";
                porcentajeUnitario = porcentajeUnitario * 100;
                porcentajeUnitarioString = string.Format("{0}", Math.Round(porcentajeUnitario, 2).ToString() + "%");
                return porcentajeUnitarioString;
            }
            set { }
        }
    }
}
