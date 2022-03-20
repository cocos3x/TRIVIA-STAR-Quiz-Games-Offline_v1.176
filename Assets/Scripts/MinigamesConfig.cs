using UnityEngine;
public class MinigamesConfig : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<MiniGame> minigames;
    
    // Properties
    public string[] MiniGamesScenes { get; }
    public string[] MiniGamesIds { get; }
    
    // Methods
    public string[] get_MiniGamesScenes()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 36) == 0)
        {
            goto label_6;
        }
        
        Add(item:  val_4 + 16);
        goto label_6;
        label_2:
        Dispose();
        T[] val_5 = ToArray();
    }
    public string[] get_MiniGamesIds()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 36) == 0)
        {
            goto label_6;
        }
        
        Add(item:  val_4 + 8);
        goto label_6;
        label_2:
        Dispose();
        T[] val_5 = ToArray();
    }
    public MiniGame GetMiniGameById(string id)
    {
        var val_3;
        var val_5;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_5 = val_3;
        if((System.String.op_Equality(a:  val_3 + 8, b:  id)) == false)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        Dispose();
    }
    public MiniGame GetMiniGameByIndex(int index)
    {
        var val_3;
        var val_4;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_4 = val_3;
        if((val_3 + 32) != index)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        Dispose();
    }
    public MinigamesConfig()
    {
    
    }

}
