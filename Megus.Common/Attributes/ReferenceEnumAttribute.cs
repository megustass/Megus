using System;

namespace Megus.Common.Attributes
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes"), AttributeUsage(AttributeTargets.Field)]
    public class ReferenceEnumAttribute : Attribute
    {
        #region IConstructors
        public ReferenceEnumAttribute(string shortName)
        {
            ShortName = shortName;
        }
        #endregion IConstructors

        #region IProperties
        public string Description {
            get;
            set;
        }

        public string LongName {
            get;
            set;
        }

        public string ShortName {
            get;
            set;
        }

        public string Code {
            get;
            set;
        }
        #endregion IProperties
    }
}
