using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp02
{
    internal class InternationalShipment :Shipment
    {
        #region filed
        string destinationcountry;

        decimal customsfee; 
        #endregion

        #region prop
        public string DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(destinationcountry)!)
                {
                    destinationcountry = value;
                }

            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsfee;
            }
            set
            {
                if (customsfee >= 0)
                {
                    customsfee = value;
                }

            }
        }
        public override decimal EstimatedCost

        {
            get
            {
                return Deliveryfee + (Weight * 5) + CustomsFee;
            }
        } 
        #endregion

        #region const
        public InternationalShipment(string destinationcountry,decimal customsfee, string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination) :base( trackingcode,  description,  weight, deliveryfee,  destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = customsfee;
            Console.WriteLine("const03");
        }

        #endregion


    }
}
