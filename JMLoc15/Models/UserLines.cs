using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMLoc15.Models
{
    public class UserLines
    {
        public string Id { get; set; }
        public Users User { get; set; }
        public Lines Line { get; set; }
    }
}