using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class TryCatch
    {

        private static void Throw1()
        {
            throw new DivideByZeroException();
        }

        public static void Throw2()
        {
            try
            {
                Throw1();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }

        public static void Throw3()
        {
            try
            {
                Throw1();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public static void Throw4()
        {
            try
            {
                Throw1();
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException(ex.Message, ex);
            }
        }
    }
}
