using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using bertoni_miniproject.Services.Dto;
using Newtonsoft.Json;

namespace bertoni_miniproject.Services
{
    public interface IPhotoAlbumService
    {

        List<Album> GetPhotoAlbums();
        List<Photo> GetPhotos(int albumId);
        List<Comment> GetComments(int photoId);
    }
}