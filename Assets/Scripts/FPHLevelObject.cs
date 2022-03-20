using UnityEngine;
public class FPHLevelObject
{
    // Fields
    private string <id>k__BackingField;
    private int <levelIndex>k__BackingField;
    private string <phrase>k__BackingField;
    private string <clue>k__BackingField;
    
    // Properties
    public string id { get; set; }
    public int levelIndex { get; set; }
    public string phrase { get; set; }
    public string clue { get; set; }
    
    // Methods
    public string get_id()
    {
    
    }
    private void set_id(string value)
    {
        this.<id>k__BackingField = value;
    }
    public int get_levelIndex()
    {
        return (int)this.<levelIndex>k__BackingField;
    }
    private void set_levelIndex(int value)
    {
        this.<levelIndex>k__BackingField = value;
    }
    public string get_phrase()
    {
    
    }
    private void set_phrase(string value)
    {
        this.<phrase>k__BackingField = value;
    }
    public string get_clue()
    {
    
    }
    private void set_clue(string value)
    {
        this.<clue>k__BackingField = value;
    }
    public FPHLevelObject(string unparsedString)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
        System.String[] val_1 = unparsedString.Split(separator:  478563824);
        this.<id>k__BackingField = unparsedString.m_firstChar;
        bool val_3 = System.Int32.TryParse(s:  unparsedString.m_firstChar, result: out  int val_2 = -1652116940);
        if(val_3 == true)
        {
                val_3 = 0;
            this.<levelIndex>k__BackingField = 0;
        }
        
        string val_4 = ToUpperInvariant();
        this.<clue>k__BackingField = null;
        string val_5 = unparsedString.ToUpperInvariant();
        this.<phrase>k__BackingField = unparsedString;
    }

}
