using dontnet_learning.DTO;
using dontnet_learning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dontnet_learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DbSet<User> usersDb;
        private readonly ApplicationContext _dbContext;

        public UsersController(ApplicationContext context)
        {
            usersDb = context.Users;
            _dbContext = context;
        }

        [HttpGet("getOne")]
        public Task<User?> GetOne(int id)
        {
            return usersDb.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost("create")]
        public async Task<User?> AddOne(AddUserForm data)
        {
            User user = new User
            {
                Phone = data.Phone,
                LastName = data.LastName,
                FirstName = data.FirstName,
                Email = data.Email,
                Role = data.Role,
                Patronymic = data.Patronymic,
                Password = data.Password,
                CityId = data.CityId
            };

            var testc = await usersDb.AddAsync(user);
            _dbContext.SaveChanges();
            return testc.Entity;
        }
    }
}
