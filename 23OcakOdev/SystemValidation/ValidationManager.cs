using System;
using System.Collections.Generic;
using System.Text;

namespace _23OcakOdev
{
    class ValidationManager : IValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (int.Parse(gamer.BirthYear) < 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
