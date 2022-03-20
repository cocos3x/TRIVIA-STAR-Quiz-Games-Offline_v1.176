using UnityEngine;
public class DeeplinkAction
{
    // Fields
    private DeeplinkActionState state;
    private string identifier;
    private string encodedAction;
    private string decodedAction;
    private System.Collections.Generic.Dictionary<string, object> parameters;
    private string source;
    private bool forcedJson;
    
    // Properties
    public DeeplinkActionState State { get; set; }
    public string Identifier { get; }
    public string EncodedAction { get; }
    public string DecodedAction { get; }
    public System.Collections.Generic.Dictionary<string, object> Parameters { get; }
    public string Source { get; set; }
    public bool IsForcedJson { get; }
    public bool IsValidAction { get; }
    
    // Methods
    public DeeplinkActionState get_State()
    {
    
    }
    public void set_State(DeeplinkActionState value)
    {
        this.state = value;
    }
    public string get_Identifier()
    {
    
    }
    public string get_EncodedAction()
    {
    
    }
    public string get_DecodedAction()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, object> get_Parameters()
    {
    
    }
    public string get_Source()
    {
    
    }
    public void set_Source(string value)
    {
        this.source = value;
    }
    public bool get_IsForcedJson()
    {
        return (bool)this.forcedJson;
    }
    public bool get_IsValidAction()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.decodedAction);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public DeeplinkAction(string maybeJson)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
        string val_20;
        string val_2 = maybeJson;
        this.identifier = System.String.alignConst;
        this.encodedAction = System.String.alignConst;
        this.decodedAction = System.String.alignConst;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.parameters = null;
        this.source = System.String.alignConst;
        val_2 = new System.Object();
        object val_3 = MiniJSON.Json.Deserialize(json:  val_2);
        this.encodedAction = val_2;
        val_19 = this.parameters;
        if((this.parameters.ContainsKey(key:  -1968282976)) != false)
        {
                object val_5 = val_19.Item[-1968282976];
            val_19 = val_19;
            val_20 = val_19;
            string val_6 = val_20.ToString();
            string val_7 = DeeplinkAction.TryBase64ForUrlDecode(str:  val_20);
        }
        else
        {
                if((val_19.ContainsKey(key:  -1785508240)) != false)
        {
                object val_9 = this.parameters.Item[-1785508240];
            val_19 = this.parameters;
            val_20 = val_19;
            string val_10 = val_20.ToString();
            string val_11 = DeeplinkAction.TryBase64ForUrlDecode(str:  val_20);
        }
        else
        {
                val_20 = this.encodedAction;
            string val_12 = DeeplinkAction.TryBase64ForUrlDecode(str:  val_20);
        }
        
        }
        
        this.decodedAction = val_20;
    }
    public void ForceJson(string forcedJson)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = forcedJson;
        UnityEngine.Debug.LogWarningFormat(format:  -1785363120, args:  472754880);
        this.forcedJson = true;
        this.decodedAction = forcedJson;
    }
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.identifier;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        bool val_1 = System.String.IsNullOrEmpty(value:  this.decodedAction);
        val_1 = val_1 ^ 1;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = this.encodedAction;
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.decodedAction;
        string val_2 = MiniJSON.Json.Serialize(obj:  this.parameters);
        typeof(System.Object[]).__il2cppRuntimeField_24 = this.parameters;
        string val_3 = System.String.Format(format:  -1785222304, args:  472754880);
    }
    public static string Base64ForUrlEncode(string str)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        string val_2 = System.Convert.ToBase64String(inArray:  null);
        return UnityEngine.WWW.EscapeURL(s:  null);
    }
    public static string Base64ForUrlDecode(string str)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.Default;
        System.Byte[] val_2 = DeeplinkAction.UnscapeURLAndDecode(parameter:  str);
        if(0 == 0)
        {
            
        }
    
    }
    private static byte[] UnscapeURLAndDecode(string parameter)
    {
        string val_1 = UnityEngine.WWW.UnEscapeURL(s:  parameter);
        return System.Convert.FromBase64String(s:  parameter);
    }
    public static string TryBase64ForUrlDecode(string str)
    {
        string val_1 = DeeplinkAction.Base64ForUrlDecode(str:  str);
    }

}
