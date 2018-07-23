using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02EF.Model
{
    public partial class Address
    {
        [DataMember]
        [NotMapped]
        public string NombreStateProvince
        {
            get {
                string nombre = "";
                var stateProvinceCode = StateProvinceID;
                if (stateProvinceCode==StateProvince.StateProvinceID)
                {
                    nombre = StateProvince.Name;
                }
                return nombre;
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string NombreCountryRegion
        {
            get {
                string nombre = "";
                var countryRegionCode = StateProvince.CountryRegionCode;
                if (countryRegionCode==StateProvince.CountryRegion.CountryRegionCode)
                {
                    nombre = StateProvince.CountryRegion.Name;
                }
                return nombre;
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string CodigoStateProvince
        {
            get {
                return StateProvince.StateProvinceCode;
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string CodigoCountryRegion
        {
            get
            {
                return StateProvince.CountryRegion.CountryRegionCode;
            }
            set { }
        }

    }
}
