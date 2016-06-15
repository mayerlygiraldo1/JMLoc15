using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JMLoc15.Models
{
    public class Users
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Url)]
        public string Avatar { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Url)]
        public string FacebookID { get; set; }
        [DataType(DataType.Url)]
        public string TwitterID { get; set; }
        [DataType(DataType.Url)]
        public string YouTubeID { get; set; }
        [DataType(DataType.Url)]
        public string InstagramID { get; set; }

    }
}