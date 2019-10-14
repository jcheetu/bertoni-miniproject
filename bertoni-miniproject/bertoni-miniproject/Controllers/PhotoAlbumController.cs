using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bertoni_miniproject.Services;

namespace bertoni_miniproject.Controllers
{
    public class PhotoAlbumController : Controller
    {
        private IPhotoAlbumService _photoAlbumService;

        public PhotoAlbumController(IPhotoAlbumService photoAlbumService)
        {
            _photoAlbumService = photoAlbumService;
        }




        public ActionResult Albums()
        {
            //return Json(_photoAlbumService.GetPhotoAlbums(), JsonRequestBehavior.AllowGet);
            return View();
        }
        public ActionResult GetAlbums()
        {
            return Json(_photoAlbumService.GetPhotoAlbums(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Photos(int albumId)
        {
            return Json(_photoAlbumService.GetPhotos(albumId), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Comments(int photoId)
        {
            return Json(_photoAlbumService.GetComments(photoId), JsonRequestBehavior.AllowGet);
        }
    }
}