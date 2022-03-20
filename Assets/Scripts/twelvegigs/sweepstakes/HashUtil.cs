using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public static class HashUtil
    {
        // Methods
        public static string MD5(string text)
        {
            System.Text.UTF8Encoding val_1 = new System.Text.UTF8Encoding();
            System.Byte[] val_2 = GetBytes(s:  text);
            return twelvegigs.sweepstakes.HashUtil.MD5(bytes:  24707072);
        }
        public static string MD5(byte[] bytes)
        {
            var val_6;
            var val_7;
            val_6 = 0;
            null = new System.Security.Cryptography.MD5CryptoServiceProvider();
            System.Byte[] val_2 = ComputeHash(buffer:  bytes);
            val_7 = "";
            if( != 0)
            {
                    return PadLeft(totalWidth:  32, paddingChar:  '0');
            }
            
            return PadLeft(totalWidth:  32, paddingChar:  '0');
        }
        public static string MD5File(string path)
        {
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  path);
                return twelvegigs.sweepstakes.HashUtil.MD5(bytes:  path);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  1126606864, paramName:  1639489152);
        }
        public static string SHA1(string text)
        {
            System.Byte[] val_1 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  text);
            return twelvegigs.sweepstakes.HashUtil.SHA1(bytes:  text);
        }
        public static string SHA1(byte[] bytes)
        {
            System.Byte[] val_2 = ComputeHash(buffer:  bytes);
            string val_3 = System.BitConverter.ToString(value:  54046720);
            string val_4 = Replace(oldValue:  1359327184, newValue:  1098586544);
            Clear();
            if(new System.Security.Cryptography.SHA1Managed() != 0)
            {
                    return ToLower();
            }
            
            return ToLower();
        }
        public static string SHA1File(string path)
        {
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  path);
                return twelvegigs.sweepstakes.HashUtil.SHA1(bytes:  path);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  1126606864, paramName:  1639489152);
        }
        public static string SHA256(string text)
        {
            System.Byte[] val_1 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  text);
            return twelvegigs.sweepstakes.HashUtil.SHA256(bytes:  text);
        }
        public static string SHA256(byte[] bytes)
        {
            System.Byte[] val_2 = ComputeHash(buffer:  bytes);
            string val_3 = System.BitConverter.ToString(value:  54153216);
            string val_4 = Replace(oldValue:  1359327184, newValue:  1098586544);
            Clear();
            if(new System.Security.Cryptography.SHA256Managed() != 0)
            {
                    return ToLower();
            }
            
            return ToLower();
        }
        public static string SHA256File(string path)
        {
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  path);
                return twelvegigs.sweepstakes.HashUtil.SHA256(bytes:  path);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  1126606864, paramName:  1639489152);
        }
        public static string SHA512(string text)
        {
            System.Byte[] val_1 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  text);
            return twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  text);
        }
        public static string SHA512(byte[] bytes)
        {
            System.Byte[] val_2 = ComputeHash(buffer:  bytes);
            string val_3 = System.BitConverter.ToString(value:  54366208);
            string val_4 = Replace(oldValue:  1359327184, newValue:  1098586544);
            Clear();
            if(new System.Security.Cryptography.SHA512Managed() != 0)
            {
                    return ToLower();
            }
            
            return ToLower();
        }
        public static string SHA512File(string path)
        {
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  path);
                return twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  path);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  1126606864, paramName:  1639489152);
        }
        public static byte[] ToByte(string text)
        {
            System.Text.UTF8Encoding val_1 = new System.Text.UTF8Encoding();
            System.Byte[] val_2 = GetBytes(s:  text);
        }
        public static string ToHex(byte[] me)
        {
            var val_3;
            int val_4;
            val_3 = 0;
            val_4 = System.String.alignConst;
            goto label_1;
            label_4:
            string val_1 = me[16][val_3].ToString(format:  -1776898224);
            string val_2 = val_4 + me[16][val_3];
            val_3 = 1;
            val_4 = val_4;
            label_1:
            if(val_3 < val_4)
            {
                goto label_4;
            }
            
            if(val_4 != 0)
            {
                    return val_4.ToLower();
            }
            
            return val_4.ToLower();
        }
    
    }

}
