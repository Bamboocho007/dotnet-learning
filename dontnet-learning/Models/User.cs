using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static dontnet_learning.Constants.Enums;

namespace dontnet_learning.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("patronymic")]
        public string? Patronymic { get; set; }
        [Column("city_id")]
        public string CityId { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string? Phone { get; set; }
        [Column("role")]
        public UserRoles Role { get; set; }
    }
}
