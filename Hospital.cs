using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IHospital
        {
            public int PatientNum { get; set; }
            public string PatientBioData { get; set; }
            public string PatientNextofKin { get; set; }

            public bool PayingHMO(string hmoName);

            public bool PatientSerivce(string status);
            public int PaymnetDebt(string debt);

        }

       
}

