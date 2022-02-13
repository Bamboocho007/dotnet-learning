using static dontnet_learning.Constants.Enums;

namespace dontnet_learning.DTO
{
    public class AddUserForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public string CityId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public UserRoles Role { get; set; }
    }
}
