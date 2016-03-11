using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipe.Class
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DiscountAttribute : Attribute
    {
        private bool _isDiscount;

        public DiscountAttribute(bool isDiscount)
        {
            this._isDiscount = isDiscount;
        }

        public bool IsTaxOrDiscount
        {
            get
            {
                return _isDiscount;
            }
        }
    }
}
