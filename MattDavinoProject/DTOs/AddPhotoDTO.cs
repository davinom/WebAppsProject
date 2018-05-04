using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattDavinoProject.Models;
using Microsoft.AspNetCore.Http;

namespace MattDavinoProject.DTOs
{
    public class AddPhotoDTO
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
        public User User { get; set; }
        public AddPhotoDTO()
        {
            DateAdded = DateTime.Now;
        }
    }
}
