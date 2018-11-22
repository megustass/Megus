using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Megus.Common.Attributes;

namespace Megus.Common.ExtensionMethods
{
    /// <summary>
    /// Extensions for enum type
    /// </summary>
    public static class EnumExtensions
    {
        #region SFields
        private static readonly Dictionary<Enum, string> CacheEnumToCode = new Dictionary<Enum, string>();
        #endregion SFields

        #region SMethods
        private static ReferenceEnumAttribute GetReferenceEnumAttribute(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            return fieldInfo.GetCustomAttributes<ReferenceEnumAttribute>(true).ToArray().FirstOrDefault();
        }

        /// <summary>
        /// Get code of an enum value.
        /// </summary>
        public static string GetCode(this Enum enumValue)
        {
            if (!CacheEnumToCode.ContainsKey(enumValue))
            {
                var referenceEnumAttribute = GetReferenceEnumAttribute(enumValue);
                var result = referenceEnumAttribute?.Code;
                CacheEnumToCode[enumValue] = result;
                return result;
            }

            return CacheEnumToCode[enumValue];
        }

        /// <summary>
        /// Get short display name of an enum value.
        /// </summary>
        public static string GetShortName(this Enum enumValue)
        {
            var referenceEnumAttribute = GetReferenceEnumAttribute(enumValue);
            return referenceEnumAttribute != null ? referenceEnumAttribute.ShortName : string.Empty;
        }

        /// <summary>
        /// Get long display name of an enum value.
        /// </summary>
        public static string GetLongName(this Enum enumValue)
        {
            var referenceEnumAttribute = GetReferenceEnumAttribute(enumValue);
            return referenceEnumAttribute != null ? referenceEnumAttribute.LongName : string.Empty;
        }

        /// <summary>
        /// Get description of an enum value.
        /// </summary>
        public static string GetDescription(this Enum enumValue)
        {
            var referenceEnumAttribute = GetReferenceEnumAttribute(enumValue);
            return referenceEnumAttribute != null ? referenceEnumAttribute.Description : string.Empty;
        }
        #endregion SMethods
    }
}
