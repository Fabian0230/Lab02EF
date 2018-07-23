using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model
{
    public partial class SalesOrderHeader
    {
        [DataMember]
        [NotMapped]
        public double PorcentajeDeImpuesto
        {
            get {
                var subTotal = SubTotal;
                var totalFinal = subTotal + TaxAmt;
                var co = (totalFinal * 100) / subTotal;
                var Porc = co - 100;
                return Convert.ToDouble(Porc);
               
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string NombreDeStatus
        {
            get {
                string status="";
                int statusCode=Status;
                switch (statusCode)
                {
                    case 1:
                        status = "In process";
                        break;
                    case 2:
                        status = "Approved";
                        break;
                    case 3:
                        status = "Backordered";
                        break;
                    case 4:
                        status = "Rejected";
                        break;
                    case 5:
                        status = "Shipped";
                        break;
                    case 6:
                        status = "Cancelled";
                        break;
                    default:
                        status = "Unknown status";
                        break;
                }
                return status;
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string NombreCompleto
        {
            get {
                string nombreCompleto = "";
                if (Customer.PersonID==null)
                {
                    nombreCompleto = Customer.Person.LastName + " " + Customer.Person.FirstName;
                }
                return nombreCompleto;
            }
            set { }
        }

    }
}
