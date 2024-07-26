using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripOrganizer.Domain.Exception
{
    public class CustomException : SystemException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
