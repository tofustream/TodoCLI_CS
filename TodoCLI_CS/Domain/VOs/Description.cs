using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCLI_CS.Domain.VOs
{
    public class Description
    {
        private string _value;

        public Description(string value)
        {
            if (value.Length > 500)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "please keep the description under 500 characters");
            }

            _value = value;
        }
        public string Value => _value;

        public override string ToString()
        {
            return _value;
        }
    }
}
