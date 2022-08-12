namespace OOP
{
    
        internal class Program
        {
            class Treatment : Pharmacy
            {

                // public abstract string BloodTest { get; }
                //  public abstract string PhysicalTest { get; }
                public override string BloodTest => throw new NotImplementedException();

                public override string PhysicalTest => throw new NotImplementedException();

                public override string MentalObservation(string mentalHealth)
                {
                    return mentalHealth = "OCD";
                }
                public override void Result()
                {
                    Console.WriteLine("Malaria Deceted");
                }


            }
            class Hosptial : IHospital
            {
                public int PatientNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
                public string PatientBioData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
                public string PatientNextofKin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

                public void PatientSerivce(string Status)
                {
                    throw new NotImplementedException();
                }

                public bool PayingHMO(string hmoName)
                {
                    throw new NotImplementedException();
                }

                public int PaymnetDebt()
                {
                    throw new NotImplementedException();
                }

                public int PaymnetDebt(string Debt)
                {
                    throw new NotImplementedException();
                }

                bool IHospital.PatientSerivce(string Status)
                {
                    throw new NotImplementedException();
                }
            }
            static void Main(string[] args)
            {
                Treatment treatment = new Treatment();
                treatment.BacterialResult();
                treatment.Infection();
            treatment.ViralResult();
            
            }
        }
    }

    
