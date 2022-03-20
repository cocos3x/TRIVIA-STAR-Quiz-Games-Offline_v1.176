using UnityEngine;
public static class CPlayerPrefs
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, string> keyHashs;
    private static System.Collections.Generic.Dictionary<string, int> xorOperands;
    private static int salt;
    private static bool _useRijndael;
    private static bool _useHashKey;
    private static bool _useXor;
    
    // Methods
    public static bool HasKey(string key)
    {
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        return UnityEngine.PlayerPrefs.HasKey(key:  key);
    }
    public static void DeleteKey(string key)
    {
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        UnityEngine.PlayerPrefs.DeleteKey(key:  key);
    }
    public static void DeleteAll()
    {
        UnityEngine.PlayerPrefs.DeleteAll();
    }
    public static void Save()
    {
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void SetInt(string key, int val)
    {
        int val_6;
        var val_7;
        val_6 = val;
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        val_7 = null;
        if(CPlayerPrefs._useXor != false)
        {
                int val_2 = CPlayerPrefs.computeXorOperand(key:  key, cryptedKey:  key);
            int val_3 = val_2 & (val_2 << 1);
            val_3 = val_3 + val_6;
            val_7 = null;
            val_6 = val_3 ^ val_2;
        }
        
        val_7 = null;
        if(CPlayerPrefs._useRijndael != false)
        {
                string val_4 = System.String.alignConst + 13152256;
            string val_5 = CPlayerPrefs.encrypt(cKey:  key, data:  System.String.alignConst);
            UnityEngine.PlayerPrefs.SetString(key:  key, value:  key);
            return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  val_6);
    }
    public static void SetLong(string key, long val)
    {
        string val_1 = ???.ToString();
        CPlayerPrefs.SetString(key:  key, val:  2134442952);
    }
    public static void SetString(string key, string val)
    {
        var val_8;
        var val_9;
        var val_10;
        string val_11;
        string val_12;
        string val_13;
        val_8 = 1152921504882458624;
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        val_9 = null;
        if(CPlayerPrefs._useXor == false)
        {
            goto label_3;
        }
        
        int val_2 = CPlayerPrefs.computeXorOperand(key:  key, cryptedKey:  key);
        val_10 = 0;
        val_11 = "";
        goto label_6;
        label_8:
        char val_4 = val.Chars[0];
        val_4 = (val_2 & (val_2 << 1)) + val_4;
        val_4 = val_4 ^ val_2;
        string val_5 = val_4.ToString();
        string val_6 = 1098586544 + 2134567226;
        val_10 = 1;
        val_11 = val_11;
        label_6:
        if(val_10 < val.m_stringLength)
        {
            goto label_8;
        }
        
        val_8 = 1152921504882458624;
        val_9 = null;
        goto label_9;
        label_3:
        val_11 = val;
        label_9:
        if(CPlayerPrefs._useRijndael != false)
        {
                string val_7 = CPlayerPrefs.encrypt(cKey:  key, data:  val_11);
            val_12 = key;
            val_13 = key;
        }
        else
        {
                val_13 = key;
            val_12 = val_11;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  val_13, value:  val_12);
    }
    public static void SetFloat(string key, float val)
    {
        string val_1 = ???.ToString();
        CPlayerPrefs.SetString(key:  key, val:  2134691532);
    }
    public static void SetBool(string key, bool value)
    {
        CPlayerPrefs.SetInt(key:  key, val:  value);
    }
    public static int GetInt(string key, int defaultValue)
    {
        var val_7;
        var val_8;
        var val_10;
        val_7 = defaultValue;
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return (int)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        if(CPlayerPrefs._useRijndael != false)
        {
                string val_3 = CPlayerPrefs.decrypt(cKey:  key);
            int val_4 = System.Int32.Parse(s:  key);
        }
        
        val_7 = UnityEngine.PlayerPrefs.GetInt(key:  key);
        val_10 = null;
        val_10 = null;
        if(CPlayerPrefs._useXor == false)
        {
                return (int)val_7;
        }
        
        string val_7 = key;
        int val_6 = CPlayerPrefs.computeXorOperand(key:  key, cryptedKey:  val_7);
        val_7 = val_6 ^ val_7;
        val_6 = val_6 & (val_6 << 1);
        val_7 = val_7 - val_6;
        return (int)val_7;
    }
    public static int GetInt(string key)
    {
        return CPlayerPrefs.GetInt(key:  key, defaultValue:  0);
    }
    public static long GetLong(string key, long defaultValue)
    {
        string val_1 = ???.ToString();
        string val_2 = CPlayerPrefs.GetString(key:  key, defaultValue:  2135172296);
        return (long)System.Int64.Parse(s:  key);
    }
    public static long GetLong(string key)
    {
        return (long)CPlayerPrefs.GetLong(key:  key, defaultValue:  CPlayerPrefs.__il2cppRuntimeField_cctor_finished);
    }
    public static string GetString(string key, string defaultValue)
    {
        var val_10;
        string val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        val_10 = defaultValue;
        string val_1 = CPlayerPrefs.hashedKey(key:  key);
        val_11 = key;
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(CPlayerPrefs._useRijndael != false)
        {
                val_13 = val_11;
            string val_3 = CPlayerPrefs.decrypt(cKey:  val_13);
        }
        else
        {
                val_13 = val_11;
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  val_13);
        }
        
        val_10 = val_13;
        val_14 = null;
        val_14 = null;
        if(CPlayerPrefs._useXor == false)
        {
                return;
        }
        
        int val_5 = CPlayerPrefs.computeXorOperand(key:  key, cryptedKey:  val_11);
        val_11 = 0;
        val_15 = "";
        goto label_15;
        label_17:
        char val_7 = val_10.Chars[0];
        val_7 = val_5 ^ val_7;
        val_7 = val_7 - (val_5 & (val_5 << 1));
        string val_8 = val_7.ToString();
        string val_9 = 1098586544 + 2135416766;
        val_11 = 1;
        val_15 = val_15;
        label_15:
        if(val_11 < key.m_stringLength)
        {
            goto label_17;
        }
        
        val_10 = val_15;
    }
    public static string GetString(string key)
    {
        return CPlayerPrefs.GetString(key:  key, defaultValue:  1098586544);
    }
    public static float GetFloat(string key, float defaultValue)
    {
        string val_1 = ???.ToString();
        string val_2 = CPlayerPrefs.GetString(key:  key, defaultValue:  2135661260);
        return (float)System.Single.Parse(s:  key);
    }
    public static float GetFloat(string key)
    {
        return CPlayerPrefs.GetFloat(key:  key, defaultValue:  null);
    }
    public static bool GetBool(string key, bool defaultValue = False)
    {
        if((CPlayerPrefs.HasKey(key:  key)) == false)
        {
                return (bool)defaultValue;
        }
        
        int val_2 = CPlayerPrefs.GetInt(key:  key);
        val_2 = val_2 - 1;
        defaultValue = val_2 >> 5;
        return (bool)defaultValue;
    }
    public static void SetDouble(string key, double value)
    {
        string val_1 = CPlayerPrefs.DoubleToString(target:  value);
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  R2);
    }
    public static double GetDouble(string key, double defaultValue)
    {
        string val_1 = CPlayerPrefs.DoubleToString(target:  defaultValue);
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  R2);
        return CPlayerPrefs.StringToDouble(target:  key);
    }
    public static double GetDouble(string key)
    {
        return (double)CPlayerPrefs.GetDouble(key:  key, defaultValue:  null);
    }
    private static string DoubleToString(double target)
    {
        string val_1 = 0.ToString(format:  1293130544);
    }
    private static double StringToDouble(string target)
    {
        if((System.String.IsNullOrEmpty(value:  target)) == false)
        {
                return System.Double.Parse(s:  target);
        }
        
        return (double)D0;
    }
    private static string encrypt(string cKey, string data)
    {
        string val_1 = CPlayerPrefs.getEncryptionPassword(pw:  cKey);
        return ZKW.CryptoPlayerPrefs.Helper.EncryptString(clearText:  data, Password:  cKey);
    }
    private static string decrypt(string cKey)
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  cKey);
        string val_2 = CPlayerPrefs.getEncryptionPassword(pw:  cKey);
        return ZKW.CryptoPlayerPrefs.Helper.DecryptString(cipherText:  cKey, Password:  cKey);
    }
    private static string hashedKey(string key)
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_6;
        var val_7;
        var val_9;
        var val_10;
        WordPets.WPTPetTile val_11;
        val_6 = 1152921504882458624;
        val_7 = null;
        val_7 = null;
        if(CPlayerPrefs._useHashKey == false)
        {
            goto label_3;
        }
        
        val_7 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_9 = null;
        val_9 = null;
        CPlayerPrefs.keyHashs = null;
        val_7 = null;
        val_7 = null;
        val_10 = null;
        if((ContainsKey(key:  key)) == false)
        {
            goto label_12;
        }
        
        val_10 = null;
        string val_4 = Item[key];
        val_11 = CPlayerPrefs.keyHashs;
        return;
        label_3:
        val_11 = key;
        return;
        label_12:
        string val_5 = CPlayerPrefs.hashSum(strToEncrypt:  key);
        val_11 = key;
        val_6 = CPlayerPrefs.keyHashs;
        Add(key:  key, value:  val_11);
    }
    private static int computeXorOperand(string key, string cryptedKey)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        string val_4 = cryptedKey;
        val_4 = null;
        val_4 = null;
        if(CPlayerPrefs.xorOperands == 0)
        {
                System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            val_4 = null;
            val_4 = null;
            CPlayerPrefs.xorOperands = null;
        }
        
        val_4 = null;
        if((ContainsKey(key:  key)) != false)
        {
                val_5 = null;
            val_5 = null;
            if(CPlayerPrefs.xorOperands != 0)
        {
                return Item[key];
        }
        
            return Item[key];
        }
        
        val_6 = 0;
        val_7 = 0;
        goto label_13;
        label_15:
        val_7 = val_7 + val_4.Chars[0];
        val_6 = 1;
        label_13:
        if(val_6 < cryptedKey.m_stringLength)
        {
            goto label_15;
        }
        
        val_8 = null;
        val_8 = null;
        val_4 = CPlayerPrefs.salt + val_7;
        Add(key:  key, value:  val_4);
        return val_4;
    }
    private static int computePlusOperand(int xor)
    {
        xor = xor & (xor << 1);
        return (int)xor;
    }
    public static string hashSum(string strToEncrypt)
    {
        var val_7;
        var val_8;
        val_7 = 0;
        null = new System.Text.UTF8Encoding();
        System.Byte[] val_2 = GetBytes(s:  strToEncrypt);
        System.Byte[] val_3 = ZKW.CryptoPlayerPrefs.Helper.hashBytes(input:  24707072);
        val_8 = "";
        if( != 0)
        {
                return PadLeft(totalWidth:  32, paddingChar:  '0');
        }
        
        return PadLeft(totalWidth:  32, paddingChar:  '0');
    }
    private static string getEncryptionPassword(string pw)
    {
        null = null;
        string val_1 = pw + 13152256;
        string val_2 = CPlayerPrefs.hashSum(strToEncrypt:  pw);
    }
    public static void setSalt(int s)
    {
        null = null;
        CPlayerPrefs.salt = s;
    }
    public static void useRijndael(bool use)
    {
        null = null;
        CPlayerPrefs._useRijndael = use;
    }
    public static void useXor(bool use)
    {
        null = null;
        CPlayerPrefs._useXor = use;
    }
    private static CPlayerPrefs()
    {
        CPlayerPrefs.salt = 2147483648;
        CPlayerPrefs._useRijndael = true;
        CPlayerPrefs._useHashKey = false;
        CPlayerPrefs._useXor = false;
    }

}
