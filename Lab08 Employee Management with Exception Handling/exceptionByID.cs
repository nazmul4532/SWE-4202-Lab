using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Management_with_Exception_Handling
{
    public class exceptionByID : ApplicationException
    {
       public override string Message
        {
            get 
            {
                return "ID is incorrect!";
            }
        }
    }
}
