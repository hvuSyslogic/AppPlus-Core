using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Microsoft.Practices.Unity;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Core.Service;

namespace HisPlus.Core
{
    //http://www.cnblogs.com/lzrabbit/archive/2012/07/09/2574491.html

    public sealed class DependencyContext
    {
        static string[] excludeAssemblies = new string[]
        {
            "HisPlus.Core.dll",
            "HisPlus.Infrastructure.dll",
            "HisPlus.Domain.dll",
            "HisPlus.Client.dll",
        };

        private static IUnityContainer _UnityContainer = new UnityContainer();

        static DependencyContext()
        {
            RegisterDependency();
        }

        public static IUnityContainer Current
        {
            get
            {
                return _UnityContainer;
            }
        }

        private DependencyContext() { }


        private static IEnumerable<string> GetAssemblyFiles()
        {
            string assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

            IEnumerable<string> assemblyFiles = Directory.GetFiles(assemblyDirectory, "*.dll")
                .Select(x => Path.GetFileName(x)).Where(x => x.Contains("HisPlus.") && !x.Contains("Test"));            

            assemblyFiles = assemblyFiles.Where(x => !excludeAssemblies.Contains(x));

            return assemblyFiles;
        }

        public static IEnumerable<Assembly> LoadAssembly()
        {
            IEnumerable<string> assemblyFiles = GetAssemblyFiles();

            //加载程序集不能使用Assembly.LoadFile()方法，该方法会导致DLL文件占用无法释放，改为文件流加载方式
            return assemblyFiles.Select(assemblyFile => Assembly.Load(File.ReadAllBytes(assemblyFile))).ToList();

            //放弃使用Assembly.Load方法加载程序集
            //Assembly.Load方法返回的程序集和当前应用程序域运行的程序集是相互独立
            //当使用Load方法加载程序集Assembly1并加载类型T1时，然后从应用程序中的程序集Assembly1加载一个类型T1，
            //尽管这两个类型看上去是完全相同的而且也确实是完全相同的，但这两个T1类型却不相同，因为这两个都叫T1的类型分属两个不同的Assembly
            //只有一种情况下才会相同即你使用的这个类型有一个接口，并且这个接口定义在其它Assembly中
            //因此为了程序的兼容性这里采取从当前应用程序域获取程序集

           //return AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assemblyFiles.Contains(assembly.ManifestModule.ScopeName)).ToList();
        }

        static bool IsServiceType(Type type)
        {
            return type.IsClass && (type.IsDerivedOfGenericType(typeof(AbstractService<,,>)) || type.IsSubclassOf(typeof(ServiceRoot)));
        }

        private static IEnumerable<Type> GetClassTypes(IEnumerable<Assembly> assemblies)
        {
            IEnumerable<Type> types = new List<Type>();

            assemblies.ToList().ForEach(x => 
            {
                types = x.GetTypes().Where(y => IsServiceType(y));
            });

            return types;
        }

        public static List<Type> GetBaseTypes(Type classType)
        {           
            List<Type> baseTypes = classType.GetInterfaces().ToList();
            GetAbstractTypes(classType, baseTypes);
            return baseTypes;
        }

        /// <summary>
        /// 获取类型所有的抽象基类
        /// </summary>
        /// <param name="classType"></param>
        /// <param name="abstructTypes"></param>
        public static void GetAbstractTypes(Type classType, IEnumerable<Type> abstractTypes)
        {
            Type baseType = classType.BaseType;
            if (baseType != typeof(object) && baseType.IsAbstract)
            {
                abstractTypes.ToList().Add(baseType);
                GetAbstractTypes(baseType, abstractTypes);
            }
        }
        

        /// <summary>
        /// 从指定的类型集合中过滤出从指定类或接口派生的类
        /// </summary>
        /// <typeparam name="T">基类或接口</typeparam>
        /// <param name="classTypes">类型集合</param>
        /// <returns></returns>
        private static IEnumerable<Type> GetDerivedClass<T>(IEnumerable<Type> classTypes) where T : class
        {
            return classTypes.AsParallel().Where(t => t.GetInterface(typeof(T).ToString()) != null).ToList();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="types"></param>
        /// <param name="lifetimeManager"></param>
        private static void RegisterType<T>(IEnumerable<Type> types) where T : LifetimeManager, new()
        {
            types.AsParallel().ForAll(classType =>
            {
                List<Type> baseTypes = GetBaseTypes(classType).ToList();
                foreach (Type baseType in baseTypes)
                {
                    Current.RegisterType(baseType, classType, new T());
                    Current.RegisterType(baseType, classType, classType.FullName, new T());
                }
            });
        }

        /// <summary>
        /// 初始化依赖注入
        /// 注册所有实现了ISingleton和IWeakReference接口的类型到IUnityContainer容器
        /// </summary>
        /// TransientLifetimeManager
        /// ContainerControlledLifetimeManager
        /// ExternallyControlledLifetimeManager

        private static void Register()
        {         
            //ExternallyControlledLifetimeManager 弱引用

            IEnumerable<Assembly> assemblies = LoadAssembly();

            IEnumerable<Type> classTypes = GetClassTypes(assemblies);

            //所有接口默认注册为弱引用
            RegisterType<ExternallyControlledLifetimeManager>(GetDerivedClass<IServiceRoot>(classTypes));

            //先注册单例，再注册若引用，确保若同时实现了ISingleton和IWeakReference接口，则注册为弱引用

            //实现ISingleton接口的类型集合注册为单例模式
            //List<Type> singletonTypeList = GetDerivedClass<IServiceRoot>(classTypes);

            //注册单例
            //RegisterType<ContainerControlledLifetimeManager>(singletonTypeList);

            //实现IWeakReference接口的类型集合注册为弱引用
            //List<Type> weakReferenceTypeList = GetDerivedClass<IWeakReference>(classTypes);
            //注册弱引用
            //RegisterType<ExternallyControlledLifetimeManager>(weakReferenceTypeList);

        }

        /// <summary>
        /// 注册依赖注入
        /// </summary>
        public static void RegisterDependency()
        {

            Register();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(Current));
        }

    }

}
