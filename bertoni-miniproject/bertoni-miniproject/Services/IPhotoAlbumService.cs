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

        List<AlbumDto> GetPhotoAlbums();
        List<PhotoDto> GetPhotos(int albumId);
        List<CommentDto> GetComments(int photoId);
    }
}