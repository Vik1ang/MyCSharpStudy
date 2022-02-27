using System;
using System.Reflection;
using Vik1ang.Framework;
using Vik1ang.Libraries.IDAL;

namespace Vik1ang.Libraries.Factory
{
    public class DALFactory
    {
        private static Type DALType = null;

        static DALFactory()
        {
            Assembly assembly = Assembly.Load(StaticConstant.DALDLLName);
            DALType = assembly.GetType(StaticConstant.DALTypeName);
        }

        public static IBaseDAL CreateInstance()
        {
            return (IBaseDAL)Activator.CreateInstance(DALType);
        }
    }
}