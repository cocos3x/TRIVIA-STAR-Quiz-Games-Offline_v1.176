using UnityEngine;
private sealed class Json.Parser : IDisposable
{
    // Fields
    private const string WHITE_SPACE = " \t\n\r";
    private const string WORD_BREAK = " \t\n\r{}[],:\"";
    private System.IO.StringReader json;
    
    // Properties
    private char PeekChar { get; }
    private char NextChar { get; }
    private string NextWord { get; }
    private MiniJSON.Json.Parser.TOKEN NextToken { get; }
    
    // Methods
    private Json.Parser(string jsonString)
    {
        this.json = new System.IO.StringReader(s:  jsonString);
    }
    public static object Parse(string jsonString)
    {
        var val_5;
        var val_6;
        Json.Parser val_1 = new Json.Parser(jsonString:  jsonString);
        TOKEN val_2 = NextToken;
        object val_3 = ParseByToken(token:  459849728);
        if(val_1 == 0)
        {
            goto label_2;
        }
        
        Json.Parser val_6 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_3;
        }
        
        var val_5 = 0;
        label_5:
        val_5 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_4;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < (mem[null + 178]))
        {
            goto label_5;
        }
        
        label_3:
        val_6 = val_1;
        goto label_6;
        label_4:
        var val_4 = (mem[null + 88]) + 0;
        val_6 = val_6 + (((mem[null + 88] + 0) + 4) << 3);
        label_6:
        label_2:
        if(0 == 0)
        {
                return;
        }
    
    }
    public void Dispose()
    {
        this.json.Dispose();
        this.json = 0;
    }
    private System.Collections.Generic.Dictionary<string, object> ParseObject()
    {
        System.IO.StringReader val_7;
        var val_8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_7 = this.json;
        if(val_7 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_9:
        val_7 = val_7;
        TOKEN val_2 = this.NextToken;
        if(this != 5)
        {
                return;
        }
        
        TOKEN val_3 = this.NextToken;
        object val_4 = this.ParseByToken(token:  1161577648);
        set_Item(key:  val_7, value:  1161577648);
        do
        {
            label_6:
            TOKEN val_5 = this.NextToken;
        }
        while(this == 6);
        
        val_8 = 0;
        if(this == 0)
        {
                return;
        }
        
        if(this == 2)
        {
            goto label_8;
        }
        
        string val_6 = this.ParseString();
        if(this != 0)
        {
            goto label_9;
        }
        
        return;
        label_8:
        val_8 = null;
    }
    private System.Collections.Generic.List<object> ParseArray()
    {
        System.IO.StringReader val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_4 = this.json;
        if(val_4 == 0)
        {
            
        }
    
    }
    private object ParseValue()
    {
        TOKEN val_1 = this.NextToken;
        return this.ParseByToken(token:  1161818032);
    }
    private object ParseByToken(MiniJSON.Json.Parser.TOKEN token)
    {
        token = token - 1;
        if(token <= 9)
        {
                var val_1 = 7962768 + (7962768 + ((token - 1)) << 2);
            if(token == 9)
        {
                0 = 0 & ((R8) >> 32);
            0 = 0 * 0;
            0 = 0 & (this >> 0);
            0 = 0 * 0;
            0 = 0 * 0;
            0 = 0 * 0;
            0 = 0 & (0 >> 32);
            0 = 0 & (((int)IP) >> 32);
            0 = 0 & (((int)IP) >> ((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & (R);
            0 = 0 & (((this) << (32-(((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & ()) | ((this) << (((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & ());
        }
        
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.ParseObject();
        }
        
        var val_5 = FP - 16;
    }
    private string ParseString()
    {
        var val_6;
        label_18:
        if(this.json == 1)
        {
            goto label_8;
        }
        
        char val_2 = this.NextChar;
        if(val_2 == '\')
        {
            goto label_4;
        }
        
        val_6 = val_2;
        if(val_2 != '"')
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(this.json == 1)
        {
            goto label_8;
        }
        
        char val_3 = this.NextChar;
        if(val_3 > '\')
        {
            goto label_9;
        }
        
        if(val_3 != ('/'))
        {
            goto label_10;
        }
        
        label_5:
        label_17:
        System.Text.StringBuilder val_4 = Append(value:  val_3);
        goto label_18;
        label_9:
        if(val_3 > 'f')
        {
            goto label_13;
        }
        
        if(val_3 == 'b')
        {
            goto label_14;
        }
        
        if(val_3 != 'f')
        {
            goto label_18;
        }
        
        if(new System.Text.StringBuilder() != 0)
        {
            goto label_17;
        }
        
        goto label_17;
        label_13:
        val_3 = val_3 - 110;
        if(val_3 > '')
        {
            goto label_18;
        }
        
        var val_5 = 7962044 + (7962044 + ((val_3 - 110)) << 2);
        if(val_3 == '')
        {
                7962044 + ((val_3 - 110)) << 2 = (7962044 + ((val_3 - 110)) << 2) & ((7962044 + ((val_3 - 110)) << 2) >> 32);
        }
    
    }
    private object ParseNumber()
    {
        string val_1 = this.NextWord;
        if((this.IndexOf(value:  '.')) >= 0)
        {
                System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
            float val_4 = System.Single.Parse(s:  1162186800, provider:  0);
            return;
        }
        
        if((System.Int32.TryParse(s:  1162186800, style:  511, provider:  0, result: out  int val_5 = 1162174772)) != false)
        {
                return;
        }
        
        System.Globalization.CultureInfo val_7 = System.Globalization.CultureInfo.InvariantCulture;
        decimal val_8 = System.Decimal.Parse(s:  1162174752, provider:  1162186800);
    }
    private void EatWhitespace()
    {
        do
        {
            if((IndexOf(value:  this.PeekChar)) == 1)
        {
                return;
        }
        
        }
        while(this.json != 1);
    
    }
    private char get_PeekChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    private char get_NextChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    private string get_NextWord()
    {
        char val_6;
        label_5:
        val_6 = this.PeekChar;
        if((IndexOf(value:  val_6)) != 1)
        {
            goto label_2;
        }
        
        System.Text.StringBuilder val_5 = Append(value:  this.NextChar);
        val_6 = this.json;
        if(val_6 != 1)
        {
            goto label_5;
        }
        
        label_2:
        if(new System.Text.StringBuilder() == 0)
        {
            
        }
    
    }
    private MiniJSON.Json.Parser.TOKEN get_NextToken()
    {
        this.EatWhitespace();
        if(this.json == 1)
        {
                return;
        }
        
        char val_1 = this.PeekChar;
        if(val_1 > '[')
        {
            goto label_3;
        }
        
        char val_2 = val_1 - 34;
        if(val_2 > '')
        {
            goto label_4;
        }
        
        var val_3 = 7961200 + (7961200 + ((val_1 - 34)) << 2);
        if(val_2 == '')
        {
                5 = 0;
            mem2[0] = 5 + IP;
            mem2[0] = 5 + IP + IP;
            mem2[0] = 5 + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP + IP + IP + IP + IP;
            mem2[0] = 5 + IP + IP + IP + IP + IP + IP + IP + IP + IP;
            (5 + IP + IP + IP + IP + IP + IP + IP + IP + IP) & ((R8) << 3) = ((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP) & ((R8) << 3)) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            mem2[0] = ((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP;
            mem2[0] = ((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP;
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((5 + IP + IP + IP + IP + IP + IP + IP + IP + IP & (R8) << 3) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + IP + IP) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((int)R8) >> 7961200 + ((val_1 - 34)) << 2);
        }
        
        return;
        label_3:
        if(val_1 == ']')
        {
            goto label_5;
        }
        
        if(val_1 == '{')
        {
                return;
        }
        
        if(val_1 != '}')
        {
            goto label_10;
        }
        
        if(this.json != 0)
        {
                return;
        }
        
        return;
        label_5:
        if(this.json != 0)
        {
                return;
        }
        
        return;
        label_4:
        if(val_1 == '[')
        {
                return;
        }
        
        label_10:
        string val_4 = this.NextWord;
        if((System.String.op_Equality(a:  1162800048, b:  1295406272)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  1162800048, b:  1295406192)) != false)
        {
                return;
        }
        
        bool val_7 = System.String.op_Equality(a:  1162800048, b:  1295406352);
        if(val_7 == true)
        {
                val_7 = 11;
        }
    
    }

}
