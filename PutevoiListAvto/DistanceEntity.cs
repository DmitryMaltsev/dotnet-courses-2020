using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutevoiListAvto
{
    public class DistanceEntity
    {
        public DistanceEntity(string companyIn, string addressIn, string companyOut, string adressOut, string distance)
        {
            CompanyIn = companyIn;
            CompanyOut = companyOut;
            AddressIn = addressIn;
            AddressOut = adressOut;
            Distance = distance;
        }
        public string CompanyIn { get; set; }
        public string CompanyOut { get; set; }
        public string AddressIn { get; set; }
        public string AddressOut { get; set; }
        public string Distance { get; set; }
    }
}
