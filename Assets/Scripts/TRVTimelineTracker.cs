using UnityEngine;
public class TRVTimelineTracker : WGTimelineTracker
{
    // Properties
    protected override int LevelGenerationVersion { get; }
    
    // Methods
    protected override int get_LevelGenerationVersion()
    {
        return 1;
    }
    public override void LevelStarted(string levelword, string levelWords, MainController.GameModeForTracking gameMode, string levelLanguage)
    {
        var val_3;
        System.DateTime val_1 = System.DateTime.Now;
        mem[1152921513011604992] = val_3;
        mem[1152921513011605028] = gameMode;
        mem[1152921513011605012] = levelword;
        mem[1152921513011605016] = levelWords;
        mem[1152921513011605020] = levelLanguage;
    }
    public virtual void LevelComplete(System.Collections.Generic.Dictionary<string, object> levelCompleteProperties)
    {
        this.TrackEvent(eventProperties:  levelCompleteProperties, tipo:  4);
    }
    private void TrackEvent(System.Collections.Generic.Dictionary<string, object> eventProperties, TimelineEvent.Type tipo)
    {
        float val_3;
        var val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_4:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        Add(key:  0, value:  R7);
        goto label_4;
        label_2:
        0.Dispose();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Dictionary.Enumerator<TKey, TValue> val_6 = eventProperties.GetEnumerator();
        val_3 = val_6.getEnumeratorRetType;
        if(null != 0)
        {
                Add(key:  1470926528, value:  13152256);
        }
        else
        {
                Add(key:  1470926528, value:  13152256);
        }
        
        Add(key:  -233819456, value:  -184943824);
        GameBehavior val_7 = App.getBehavior;
        string val_8 = 0.GetCurrentLanguage();
        Add(key:  -184943744, value:  0);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        Add(key:  1350676976, value:  394674176);
        var val_11 = 27345180;
        val_11 = 8285072 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        Add(key:  -184943664, value:  TRVDataParser.desiredLocale);
        string val_9 = DeviceProperties.Platform;
        if(null != 0)
        {
                Add(key:  -1928946992, value:  0);
        }
        else
        {
                Add(key:  -1928946992, value:  0);
        }
        
        Add(key:  -184943568, value:  78753792);
        string val_10 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.Debug.LogError(message:  78753792);
        mem[1152921513011862152].DoPut(path:  System.String.alignConst, postBody:  78753792, onCompleteFunction:  0, timeout:  20, destroy:  false, immediate:  false);
    }
    public TRVTimelineTracker()
    {
    
    }

}
