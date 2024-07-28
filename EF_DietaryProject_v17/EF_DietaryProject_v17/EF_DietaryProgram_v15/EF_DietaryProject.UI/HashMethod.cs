using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.UI;

public static class HashMethod
{
    public static string SHA256_hash(string password)
    {
        using (SHA256 hash = SHA256Managed.Create())
        {
            return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
        }
    }
}
