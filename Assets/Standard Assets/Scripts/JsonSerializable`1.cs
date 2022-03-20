using UnityEngine;
public abstract class JsonSerializable<T>
{
    // Methods
    public string Serialize(Newtonsoft.Json.Formatting format = 1)
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  1823670080, formatting:  format);
    }
    public static T Deserialize(string serialized)
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        val_2 = __RuntimeMethodHiddenParam + 12;
        if(val_1 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12];
            val_2 = __RuntimeMethodHiddenParam + 12;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96];
        val_3 = __RuntimeMethodHiddenParam + 12 + 96;
        if(val_1 == 1)
        {
                val_3 = val_3;
        }
    
    }
    protected JsonSerializable<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }

}
