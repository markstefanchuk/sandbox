using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    public class RandomLicenseGenerator
    {
        Random rng = new Random();

        public RandomLicenseGenerator()
        {
        }

        public string LicenseGen()
        {
            StringBuilder sb = new StringBuilder();

            // Generate a sequence of digits and letters 
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    int idx = rng.Next(0, 36);
                    sb.Append(s.Substring(idx, 1));
                }
                if (j < 4)
                    sb.Append("-");
            }

            return sb.ToString();
        }

        public string GetComputerInfo()
        {
            return String.Empty;
        }
    }
}
