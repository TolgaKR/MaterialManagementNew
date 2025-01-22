using MaterialManagement.Business.Abstract;
using MaterialManagement.Data;
using MaterialManagement.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService (UserManager<AppUser> userManager)
        {
            _userManager= userManager;
        }


        public Task<IdentityResult> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> RegisterUserAsync(string email, string password)
        {
            
            var user = new AppUser //Kullanıcı Nesnesi Olusturduk
            {
                UserName = email,
                Email = email
            };

            
            var result = await _userManager.CreateAsync(user, password); // Şifreyi ve kullanıcıyı kaydet.

            return result;
        }

        public Task<IdentityResult> UpdateUserAsync(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
