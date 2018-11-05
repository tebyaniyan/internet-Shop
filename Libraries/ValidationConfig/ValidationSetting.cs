using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationConfig
{
    public class ValidationSetting
    {
        public ValidationSetting() { 

        }

        public bool GetStatuse(string url)
        {
            bool x = new ValidatorServiceReference.Service1SoapClient().GetValidationStatus(url);
            return x;
        }
    }
}
