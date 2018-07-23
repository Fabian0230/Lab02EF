using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model.Propiedades
{
    public partial class SalesOrderHeader
    {
        //[DataMember]
        //[NotMapped]
        //public string ProductCategoryName { get; set; }

        //private const double FactorDeConversionAPulgadas = 0.393701;

        //[DataMember]
        //[NotMapped]
        //public double SizeInInches
        //{
        //    get
        //    {
        //        var elResultado = 0.0;
        //        if (SizeUnitMeasureCode == "CM")
        //        {
        //            elResultado = Convert.ToDouble(Size) / FactorDeConversionAPulgadas;
        //        }

        //        return (elResultado);
        //    }
        //    set { }
        //}
        [DataMember]
        [NotMapped]
        public double PorcentajeDeImpuesto
        {
            get {
                
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string NombreDeStatus { get; set; }
        [DataMember]
        [NotMapped]
        public string NombreCompleto { get; set; }

    }
}
