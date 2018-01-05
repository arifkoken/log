using System;
using System.Linq;
using System.Reflection;

namespace IocContainer
{

    public class IoCResolver
    {
        #region Constructor
        private static readonly object ObjLock = new object();
        private static IoCResolver _ioCResolver;
        public static IoCResolver GetInstance
        {
            get
            {
                if (_ioCResolver != null)
                    return _ioCResolver;
                lock (ObjLock)
                {
                    _ioCResolver = new IoCResolver();
                }
                return _ioCResolver;
            }
            set { _ioCResolver = value; }
        }

        #endregion

        /// <summary>
        /// Injection of control
        /// </summary>
        /// <typeparam name="TSource">Injection yapılacak class type.</typeparam>
        /// <typeparam name="TDestination">Injection edilecek class type.</typeparam>
        /// <returns></returns>
        public void Resolve<TSource, TDestination>()
        {
            object dependencyForInstance, implementedByInstance;
            dependencyForInstance = Activator.CreateInstance(typeof(TSource));
            implementedByInstance = Activator.CreateInstance(typeof(TDestination));

            foreach (var pi in dependencyForInstance.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                var piList = implementedByInstance.GetType().GetInterfaces().Where(x => x.Name.Equals(pi.FieldType.Name)).ToList();
                if (piList.Count <= 0)
                    continue;
                pi.SetValue(dependencyForInstance, implementedByInstance);
                break;
            }
        }

    }
}
