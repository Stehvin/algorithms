using System;

namespace Factory
{
    enum PlasmaGun
    {
        F4,
        MB9,
        SG100
    }

    interface IPlasmaGun
    {
        string manufacturer();
    }

    class F4 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Metco";
        }
    }

    class MB9 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Metco";
        }
    }

    class SG100 : IPlasmaGun
    {
        public string manufacturer()
        {
            return "Praxair";
        }
    }

    class PlasmaGunFactory
    {
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

            string manufacturer = plasmaGun1.manufacturer();
            Console.WriteLine("{0}", manufacturer);
            manufacturer = plasmaGun2.manufacturer();
            Console.WriteLine("{0}", manufacturer);
		}
	}
}