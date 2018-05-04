using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MattDavinoProject.DTOs;
using MattDavinoProject.Models;
using MattDavinoProject.Data;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace MattDavinoProject.Controllers
{
    public class PhotosController : Controller
    {

        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        /*
        [HttpPost]
        public async Task<IActionResult> AddPhotoForUser(int userId, AddPhotoDTO photo)
        {
            var user = await _repo.GetUser(userId);
            if (user == null)
            {
                return BadRequest("No such user");
            }
           // var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            //if (currentUserId != user.ID)
              //  return Unauthorized();

            var file = photo.File;

            //var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
              /*      var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.Name, stream),
                        Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                */    };
                  //  uploadResult = _cloudinary.Upload(uploadParams);
                }
            //}
            //photo.Url = uploadResult.Uri.ToString();
            //photo.PublicId = uploadResult.PublicId;

//            var newPhoto = _mapper.Map<Photo>(photo);

  //          newPhoto.User = user;

    //        if (!user.Photos.Any(p => p.IsProfilePic))
      //          newPhoto.IsProfilePic = true;

        //    user.Photos.Add(newPhoto);

          //  if (await _repo.SaveAll())
            //{
            //    var photoToReturn = _mapper.Map<PhotoReturnedDTO>(newPhoto);
              //  return CreatedAtRoute("GetPhoto", new { id = newPhoto.Id }, photoToReturn);
            //}
            //return BadRequest("Could not save photo");
        //}
    //}
//}