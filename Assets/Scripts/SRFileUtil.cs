using UnityEngine;
public static class SRFileUtil
{
    // Methods
    public static void DeleteDirectory(string path)
    {
        System.IO.Directory.Delete(path:  path, recursive:  true);
    }
    public static string GetBytesReadable(long i)
    {
        float val_18;
        var val_19;
        if(R1 < 0)
        {
                "" = "-";
        }
        
        long val_1 = i + (R1 >> 31);
        val_1 = val_1 ^ (R1 >> 31);
        var val_2 = R2 ^ (R1 >> 31);
        if(R1 >= 268435456)
        {
            goto label_1;
        }
        
        if(R1 >= 262144)
        {
            goto label_2;
        }
        
        if(R1 >= 256)
        {
            goto label_3;
        }
        
        long val_3 = i - 1073741824;
        if(R1 >= 256)
        {
            goto label_4;
        }
        
        long val_4 = i - 1048576;
        if(R1 >= 256)
        {
            goto label_5;
        }
        
        long val_5 = i - 1024;
        if(R1 >= 256)
        {
            goto label_6;
        }
        
        string val_6 = 1359327184 + -634648432(-634648432);
        string val_7 = i.ToString(format:  1359327184);
        return;
        label_1:
        val_18 = R1 >> 18;
        val_19 = "EB";
        goto label_12;
        label_2:
        val_18 = R1 >> 8;
        val_19 = "PB";
        goto label_12;
        label_3:
        long val_10 = i >> 30;
        var val_11 = R1 >> 30;
        val_10 = val_10 | (R1 << 2);
        val_18 = val_10;
        val_19 = "TB";
        goto label_12;
        label_4:
        long val_12 = i >> 20;
        var val_13 = R1 >> 20;
        val_12 = val_12 | (R1 << 12);
        val_18 = val_12;
        val_19 = "GB";
        goto label_12;
        label_5:
        long val_14 = i >> 10;
        var val_15 = R1 >> 10;
        val_14 = val_14 | (R1 << 22);
        val_18 = val_14;
        val_19 = "MB";
        goto label_12;
        label_6:
        val_18 = i;
        val_19 = "KB";
        label_12:
        val_18 = val_18 * 0;
        string val_16 = val_18.ToString(format:  -634647872);
        string val_17 = 1359327184 + -634635832(-634635832) + -634647952(-634647952);
    }

}
