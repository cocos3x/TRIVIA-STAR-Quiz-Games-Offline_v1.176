using UnityEngine;
public class ByteReader
{
    // Fields
    private byte[] mBuffer;
    private int mOffset;
    
    // Properties
    public bool canRead { get; }
    
    // Methods
    public ByteReader(byte[] bytes)
    {
        this.mBuffer = bytes;
    }
    public ByteReader(UnityEngine.TextAsset asset)
    {
        System.Byte[] val_1 = asset.bytes;
        this.mBuffer = asset;
    }
    public bool get_canRead()
    {
        if(this.mBuffer == null)
        {
                this = 0;
            return (bool)this;
        }
        
        if(0 < this.mBuffer)
        {
                0 = 1;
        }
        
        return true;
    }
    private static string ReadLine(byte[] buffer, int start, int count)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        if(0 != 0)
        {
                return;
        }
    
    }
    public string ReadLine()
    {
        int val_5;
        int val_6;
        val_5 = this.mOffset;
        goto label_1;
        label_5:
        if(this.mBuffer[val_5] >= 32)
        {
            goto label_4;
        }
        
        val_5 = this.mOffset + 1;
        this.mOffset = val_5;
        label_1:
        if(val_5 < R8)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        val_5 = this.mOffset;
        label_6:
        if(val_5 >= R8)
        {
            goto label_7;
        }
        
        label_12:
        if(val_5 >= R8)
        {
            goto label_8;
        }
        
        val_6 = val_5 + 1;
        byte val_3 = this.mBuffer[val_5];
        if(val_3 == 10)
        {
            goto label_13;
        }
        
        val_5 = val_6;
        if(val_3 != 13)
        {
            goto label_12;
        }
        
        goto label_13;
        label_7:
        val_6 = R8;
        goto label_14;
        label_8:
        val_6 = val_5 + 1;
        label_13:
        int val_4 = ~this.mOffset;
        val_4 = val_6 + val_4;
        string val_1 = ByteReader.ReadLine(buffer:  this.mBuffer, start:  this.mOffset, count:  val_4);
        label_14:
        this.mOffset = val_6;
    }
    public System.Collections.Generic.Dictionary<string, string> ReadDictionary()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 61;
        if(this.mBuffer == null)
        {
                return;
        }
        
        do
        {
            if(this.mOffset >= this.mBuffer)
        {
                return;
        }
        
            string val_2 = this.ReadLine();
            if(this == 0)
        {
                return;
        }
        
            if((this.StartsWith(value:  1796283776)) != true)
        {
                System.String[] val_4 = this.Split(separator:  478563824, count:  2, options:  1);
            if(this.mOffset == 2)
        {
                string val_5 = R7.Trim();
            string val_6 = this.Trim();
            string val_7 = this.Replace(oldValue:  1372269184, newValue:  1269544832);
            set_Item(key:  R7, value:  1796344720);
        }
        
        }
        
        }
        while(this.mBuffer != null);
    
    }

}
