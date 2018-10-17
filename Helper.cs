using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DevBlockChain
{
    class Helper
    {
        #region Private methods
        private static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        #endregion

#region Public methods
        public static string GetSha256Hash(object obj)
        {
            var sha256 = new SHA256Managed();
            var hashBuilder = new StringBuilder();
            //zmienna obiektu na tablice bajtów
            byte[] bytes = ObjectToByteArray(obj);
            //obliczenie hasza
            byte[] hash = sha256.ComputeHash(bytes);
            //konwersja tablicy bajtów na łańcuch znaków heksadecymalnych
            foreach (byte x in hash)
                hashBuilder.Append($"{x:x2}");
            return hashBuilder.ToString();
        }
#endregion
    }
}
