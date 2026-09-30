using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp02
{
    public class Shipment
    {
        #region filed
        private string trackingcode;
        private string description;
        private decimal weight;
        private decimal deliveryfee;
        public DeliveryAddress Destination { get; set; }
        #endregion

        #region validation
        public string TrackingCode
        {
            get
            {
                return trackingcode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingcode = value;
                }
            }

        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public decimal Weight
        {
            set
            {
                if (value > 0)
                    weight = value;
            }
            get { return weight; }

        }
        public decimal Deliveryfee
        {
            private set
            {
                if (value > 0)
                    deliveryfee = value;
            }
            get
            {
                return deliveryfee;
            }
        }
        #endregion
        #region constractor
        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
        {

            TrackingCode = trackingcode;
            Description = description;
            Weight = weight;
            Deliveryfee = deliveryfee;
            Destination = destination;
            Console.WriteLine("const01");
        }
        public Shipment(string trackingcode) : this(trackingcode, "unknown", 1, 50, new DeliveryAddress("unkown", "unknown", 1))
        {

        } 
        #endregion

        #region calculate method
        public virtual decimal EstimatedCost
        {
            get
            {
                return (decimal)Deliveryfee + (Weight * 5);
            }
        } 
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                Deliveryfee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"{trackingcode}   {Destination}    {weight}  {deliveryfee}   {description} {EstimatedCost} ");

        }
        #endregion
    }
}
