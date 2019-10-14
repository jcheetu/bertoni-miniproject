using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using bertoni_miniproject.Services;
namespace bertoni_miniproject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IPhotoAlbumService, PhotoAlbumService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}