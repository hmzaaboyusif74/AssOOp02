using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp02
{
    public class ExpressShipment :Shipment
    {
        decimal extrafee; //filed

        #region prop
        public decimal Extrafee
        {
            get { return extrafee; }

            set
            {
                if (extrafee > 0)
                {
                    extrafee = value;
                }

            }
        } 
        #endregion

        #region const
        public ExpressShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination, decimal extrafee)
           : base(trackingcode, description, weight, deliveryfee, destination)
        {
            Extrafee = extrafee;
            Console.WriteLine("const04");
        } 
        #endregion

    }
}
