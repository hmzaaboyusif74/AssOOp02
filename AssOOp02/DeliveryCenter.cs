using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp02
{
   
    public class DeliveryCenter
    {
        private Shipment[] shepmentArray;
        public DeliveryCenter()
        {
            shepmentArray = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return shepmentArray[index];
                }
                return default;
            }
            set
            {
                if (index >= 0)
                {
                    value = shepmentArray[index];
                }
                else { Console.WriteLine("nothing"); }

            }
        }
        public Shipment this[string trackingcode]
        {
            get
            {

                if (!string.IsNullOrWhiteSpace(trackingcode))
                {
                    for (int i = 0; i < shepmentArray.Length; i++)
                    {

                        if (shepmentArray[i].TrackingCode == trackingcode)
                        {
                            return shepmentArray[i];
                        }
                    }
                }


                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shepmentArray.Length; i++)
            {

                if (string.IsNullOrWhiteSpace(shepmentArray[i].TrackingCode))
                {
                    shepmentArray[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
}
