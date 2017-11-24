using System;

namespace Factory
{
    // Define the different types of plasma guns.
    enum PlasmaGun
    {
        F4,
        MB9,
        SG100
    }

    // Ensure every plasma gun class has a "manufacturer" method.
    interface IPlasmaGun
    {
        string manufacturer();
    }

    // Define an F4 plasma gun object.
    class F4 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Metco";
        }
    }

    // Define an MB9 plasma gun object (originally 9MB).
    class MB9 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Metco";
        }
    }

    // Define an SG100 plasma gun object.
    class SG100 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Praxair";
        }
    }
    
    // Set up the plasma gun creation factory.
    class PlasmaGunFactory
    {
        // "createGun" method creates a new plasma gun object.
        public IPlasmaGun createGun(PlasmaGun gun)
        {
            switch(gun)
            {
                case (PlasmaGun.F4):
                    return new F4();
                case (PlasmaGun.MB9):
                    return new MB9();
                case (PlasmaGun.SG100):
                    return new SG100();
                default:
                    return new F4();
            }
        }
    }

	class Program
	{
		static void Main()
        {
            // Test object creation using factory
            PlasmaGunFactory gunFactory = new PlasmaGunFactory();
            IPlasmaGun plasmaGun1 = gunFactory.createGun(PlasmaGun.F4);
            IPlasmaGun plasmaGun2 = gunFactory.createGun(PlasmaGun.SG100);

            // Verify objects were successfully created by using their
            // "manufacturer" methods
            string manufacturer = plasmaGun1.manufacturer();
            Console.WriteLine("{0}", manufacturer);
            manufacturer = plasmaGun2.manufacturer();
            Console.WriteLine("{0}", manufacturer);
		}
	}
}