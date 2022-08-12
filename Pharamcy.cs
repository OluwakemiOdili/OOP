using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    public abstract class Pharmacy
    {
        public abstract string BloodTest { get; }
        public abstract string PhysicalTest { get; }

        public abstract void Result();

        public void ViralResult()
        {
            Console.WriteLine("Anti-Virus should be recommended");
        }
        public void BacterialResult()
        {
            Console.WriteLine("Anti-Bacterial should be recommended");
        }
        public void Infection()
        {
            Console.WriteLine("Contact Expert for further actions");
        }
        public void OtherPhysicalCondition()
        {
            Console.WriteLine("Patient should go for Xray");
        }

        public abstract string MentalObservation(string mentalHealth);

    }
}
