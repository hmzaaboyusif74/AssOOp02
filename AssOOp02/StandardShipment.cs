using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp02
{
    public class StandardShipment :Shipment
    {
        public StandardShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
               : base(trackingcode, description, weight, deliveryfee, destination)
        {
            Console.WriteLine("const02");
        }

    }
}
