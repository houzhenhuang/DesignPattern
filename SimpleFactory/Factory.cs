using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public static ISects CreateInstance(SectsType sectsType)
        {
            switch (sectsType)
            {
                case SectsType.Gold:
                    return new Gold();
                case SectsType.Wood:
                    return new Wood();
                case SectsType.Water:
                    return new Water();
                case SectsType.Fire:
                    throw new ArgumentException("没有Fire门派");
                case SectsType.Soil:
                    throw new ArgumentException("没有Soil门派");
                default:
                    throw new ArgumentException();
            }
        }
    private static string SectsTypeName = ConfigurationManager.AppSettings["SectsTypeName"];
    public static ISects CreateInstanceWithConfig()
    {
        switch (Enum.Parse(typeof(SectsType), SectsTypeName))
        {
            case SectsType.Gold:
                return new Gold();
            case SectsType.Wood:
                return new Wood();
            case SectsType.Water:
                return new Water();
            case SectsType.Fire:
                throw new ArgumentException("没有Fire门派");
            case SectsType.Soil:
                throw new ArgumentException("没有Soil门派");
            default:
                throw new ArgumentException();
        }
    }
        private static string SectsTypeNameWithReflect = ConfigurationManager.AppSettings["SectsTypeNameWithReflect"];
        public static ISects CreateInstanceWithReflect()
        {
            string assemblyName = SectsTypeNameWithReflect.Split(',')[0];
            string typeName = SectsTypeNameWithReflect.Split(',')[1];
            return (ISects)Activator.CreateInstance(assemblyName,typeName).Unwrap();
        }

        public enum SectsType
        {
            Gold,
            Wood,
            Water,
            Fire,
            Soil
        }
    }
}
