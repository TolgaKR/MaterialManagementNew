using MaterialManagement.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Abstract
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(string email, string password); //Register yaptık
        Task<IdentityResult> UpdateUserAsync(AppUser user);//Güncelleme
        Task<IdentityResult> DeleteUserAsync(string userId);//Silme
        Task<AppUser> GetUserByIdAsync(string userId);//KullanıcıCagirdk

    }
}
