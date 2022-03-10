using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestNetCore.CPClub.WebAPI.DTOs
{
    public class UserLoginResponseDTO
    {
        public string Token { get; set; }

        public bool Login { get; set; }

        public List<string> Errors { get; set; }
    }
}
