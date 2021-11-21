using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;

namespace LifeworthAPI.Helper
{
    public class General
    {
        public General()
        {
        }
        //public byte[] createSalt()
        //{
        //    byte[] salt = new byte[128 / 8];
        //    var rng = RandomNumberGenerator.Create();
        //    rng.GetBytes(salt);
        //    return salt;
        //}
        //public string generatehash(string input, byte[] salt)
        //{
        //    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2
        //        (password: input,
        //        salt: salt,
        //        prf: KeyDerivationPrf.HMACSHA256,
        //        iterationCount: 1000,
        //        numBytesRequested: 258 / 8));
        //    return hashed;
        //}


        //Generate Token
        public string GenerateToken(string EmployeeNo)
        {
            var claims = new Claim[]
            {
            new Claim("EmployeeNo", EmployeeNo),
            //new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
            //new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };
            var jwt = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ProviderPortalApplication")), SecurityAlgorithms.HmacSha256),
                claims: claims
                );
            

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
        public string GenerateResetToken()
        {
            try
            {
                string dateTime = DateTime.Now.ToString("dd/MM/yy");
                char[] chars =
                ("MCEAuclIRIZFisaRISY0984376$@ULOGlnbv12erKLI" + dateTime).ToCharArray();
                byte[] data = new byte[8];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(8);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}