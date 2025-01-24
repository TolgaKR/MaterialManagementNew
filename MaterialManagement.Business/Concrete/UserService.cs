using System;
using System.Net;
using System.Threading.Tasks;
using MaterialManagement.Business.Abstract;
using MaterialManagement.Business.Concrete;
using MaterialManagement.Entity;
using Microsoft.AspNetCore.Identity;

namespace MaterialManagement.Business.Concrete
{
    public class UserService : IUserService
    {
        public readonly UserManager<AppUser> _userManager;
        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new InvalidOperationException("User id bulunamadı");
            }

            return await _userManager.DeleteAsync(user);
        }

        public async Task<AppUser> GetUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new InvalidOperationException($"User with ID '{userId}' not found.");
            }

            return user;
        }

        public async Task<IdentityResult> RegisterUserAsync(string email, string password, string address, string phoneNumber, string name, string surname, string idcard,string depertment)
        {
            var user = new AppUser
            {
                Email = email,
                UserName = email,
                Address = address,
                PhoneNumber = phoneNumber,
                Name = name,
                Surname = surname,
                IdentityCard = idcard,
                Department=depertment
            };
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateUserAsync(AppUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "Kullanıcı nesnesi null olamaz");
            }

            var existingUser = await _userManager.FindByIdAsync(user.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException($"User.id null olamaz.");
            }

            existingUser.Email = user.Email;
            existingUser.UserName = user.UserName;


            return await _userManager.UpdateAsync(existingUser);
        }

      
     
    }
}





