using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.BL
{
    public static class LoginManager
    {
        public static bool VerifyPassword(string base64Password, string password)
        {
            // decode base64 password
            byte[] data = Convert.FromBase64String(base64Password);
            string decodedPassword = ASCIIEncoding.ASCII.GetString(data);

            return BCrypt.Net.BCrypt.Verify(decodedPassword, password, hashType: BCrypt.Net.HashType.SHA256);
        }
    }
}
