using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClientManagement
{
    public class PasswordAuthentication
    {
        /// <summary>
        /// ソルトを出力
        /// </summary>
        /// <returns>ランダムなソルト</returns>
        public byte[] GenerateSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        /// <summary>
        /// 文字列+ソルトをハッシュ化する
        /// </summary>
        /// <returns>ハッシュ化された文字列</returns>
        public string HashPassword(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000)) // 10000はイテレーション回数
            {
                byte[] hash = pbkdf2.GetBytes(20); // 20はハッシュの長さ（バイト数）
                byte[] hashBytes = new byte[36]; // ハッシュ + ソルトの合計長さ
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// byte文字列をbyte[]に変換
        /// </summary>
        /// <param name="hex">変換したい文字列</param>
        /// <returns>byte[]になったデータ</returns>
        public byte[] StringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
