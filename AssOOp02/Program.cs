namespace AssOOp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // diffrent between struct and classes
            /* the class is refarance type and better for large data , constractor parameterless is create only when donnot create any parameter , support all oop princple 
              the struct is value type and good for small data , more speed than class , constractor parameterless is create all time,donnot support all oop princple like inhertance */
            //becouse the class is refrance type , save data and  in heap,but struct use stack , class support all oop princple
            #endregion
            #region Q2
            //1-shipment
            //2-express shipment
            //3- the property "tracking code"
            //4-becouse inhertance can inhert methode and prop from perant to child class with out repeat them
            #endregion
            #region Q3
            StandardShipment ship01 = new StandardShipment("H2","h-25",250m,23, new DeliveryAddress("unkown", "unknown", 1));
            Console.WriteLine(ship01.Description);
            Console.WriteLine(ship01.Deliveryfee);
            Console.WriteLine(ship01.Weight);
            ship01.PrintShipment();

            ExpressShipment ship02 = new ExpressShipment("H3", "h-25", 250m, 23, new DeliveryAddress("unkown", "unknown", 1),22);
            Console.WriteLine(ship02.Description);
            Console.WriteLine(ship02.Deliveryfee);
            Console.WriteLine(ship02.Weight);
            Console.WriteLine(ship02.Extrafee);
           ship02.PrintShipment();

            InternationalShipment ship03 = new InternationalShipment("cairo",21,"H3", "h-25", 250m, 23, new DeliveryAddress("unkown", "unknown", 1));
            Console.WriteLine(ship03.Description);
            Console.WriteLine(ship03.Deliveryfee);
            Console.WriteLine(ship03.Weight);
            Console.WriteLine(ship03.DestinationCountry);
            ship03.PrintShipment();
            #endregion
        }
    }
}
