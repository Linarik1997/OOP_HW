using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{
    public enum Codification
    {
        Ok = 0,
        InsufficientFunds = 1,
        UnexpectedError = 2
    }
    public class OperationCode
    {
        private Codification code;
        public Codification Code
        {
            get { return code; }
            set { code = value; }
        }
        public OperationCode(Codification _code)
        {
            code = _code;
        }
    }
}
