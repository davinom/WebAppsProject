using MattDavinoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MattDavinoProject.DTOs;

namespace MattDavinoProject.Data
{

    public interface IAuthRepository
    {
        Task<User> Register(string user, string password, string gender, DateTime birthday, string name, string city);
        Task<User> Login(string userName, string password);
        bool ValidateUserName(string userName);
    }
}
