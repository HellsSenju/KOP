using Contracts.Book;
using Contracts.Ganre;
using DatabaseImplement;
using Unity;
using Unity.Lifetime;
using BusinessLogic;
using WinFormsAppByPlugins;

namespace WinFormsAppByPlugins
{
    internal static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container { get { if (container == null) { container = BuildUnityContainer(); } return container; } }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IBookStorage, BookStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IGanreStorage, GanreStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IBookLogic, BookLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IGanreLogic, GanreLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}