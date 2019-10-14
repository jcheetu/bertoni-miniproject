﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using bertoni_miniproject.Services.Dto;
using Newtonsoft.Json;

namespace bertoni_miniproject.Services
{
    public class PhotoAlbumService : IPhotoAlbumService
    {
        private string Host = ConfigurationManager.AppSettings["PhotoAlbumAPIHost"];


        public List<Album> GetPhotoAlbums()
        {
            string url = Host + ConfigurationManager.AppSettings["Albums"]; ;
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Album>>(result);

            }
        }
        public List<Photo> GetPhotos(int albumId)
        {
            string url = Host + ConfigurationManager.AppSettings["Photos"]; ;
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                return (JsonConvert.DeserializeObject<List<Photo>>(result)).FindAll(x=>x.AlbumId == albumId);

            }
        }
        public List<Comment> GetComments(int photoId)
        {
            string url = Host + ConfigurationManager.AppSettings["Comments"]; ;
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                return (JsonConvert.DeserializeObject<List<Comment>>(result)).FindAll(x => x.PostId == photoId);

            }
        }
    }
}