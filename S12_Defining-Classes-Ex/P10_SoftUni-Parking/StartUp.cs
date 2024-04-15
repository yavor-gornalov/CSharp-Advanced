﻿namespace SoftUniParking
{
    public class StartUp
    {
        static void Main()
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            var parking = new Parking(2);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));

            var numbersToRemove = new List<string>()
            {
                "CC1856BG",
                "EB8787MN"
            };

            parking.RemoveSetOfRegistrationNumber(numbersToRemove);
            Console.WriteLine(parking.Count);

            //Console.WriteLine(car.ToString());
            //// Make: Skoda
            //// Model: Fabia
            //// HorsePower: 65
            //// RegistrationNumber: CC1856BG

            //var parking = new Parking(5);
            //Console.WriteLine(parking.AddCar(car));
            //// Successfully added new car Skoda CC1856BG

            //Console.WriteLine(parking.AddCar(car));
            //// Car with that registration number, already exists!

            //Console.WriteLine(parking.AddCar(car2));
            //// Successfully added new car Audi EB8787MN

            //Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            //// Make: Audi
            //// Model: A3
            //// HorsePower: 110
            //// RegistrationNumber: EB8787MN

            //Console.WriteLine(parking.RemoveCar("EB8787MN"));
            //// Successfullyremoved EB8787MN

            //Console.WriteLine(parking.Count);
            //// 1

        }
    }
}
