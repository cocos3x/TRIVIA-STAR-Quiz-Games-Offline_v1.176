using UnityEngine;
public class PluginObserverManager : MonoSingletonSelfGenerating<PluginObserverManager>
{
    // Fields
    private System.Collections.Generic.List<PluginObserver> pluginObservers;
    public static bool isPurchaseValidationWorking;
    
    // Properties
    public System.Collections.Generic.List<PluginObserver> Observers { get; }
    
    // Methods
    public System.Collections.Generic.List<PluginObserver> get_Observers()
    {
    
    }
    private void _init()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.pluginObservers = null;
    }
    private void Awake()
    {
        this._init();
    }
    public void AddObserver(PluginObserver observer)
    {
        if(this.pluginObservers == 0)
        {
                this._init();
        }
        
        0.Add(item:  observer);
    }
    public System.Collections.Generic.Dictionary<string, string> Status(PluginObserverManager.ObserverType _type)
    {
        WordPets.WPTLetterTile val_4;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = this;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(this.pluginObservers == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        var val_10 = val_4;
        if((val_4 + 178) == 0)
        {
            goto label_4;
        }
        
        var val_9 = 0;
        label_6:
        if((val_4 + 88 + 0) == null)
        {
            goto label_5;
        }
        
        val_9 = val_9 + 1;
        if(((uint)val_9 & 65535) < (val_4 + 178))
        {
            goto label_6;
        }
        
        label_4:
        val_10 = val_4;
        goto label_7;
        label_5:
        var val_5 = (val_4 + 88) + 0;
        val_10 = val_10 + (((val_4 + 88 + 0) + 4) << 3);
        val_10 = val_10 + 188;
        label_7:
        if(val_4 == _type)
        {
            goto label_8;
        }
        
        var val_12 = val_4;
        if((val_4 + 178) == 0)
        {
            goto label_10;
        }
        
        var val_11 = 0;
        label_12:
        if((val_4 + 88 + 0) == null)
        {
            goto label_11;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (val_4 + 178))
        {
            goto label_12;
        }
        
        label_10:
        val_11 = val_4;
        goto label_13;
        label_11:
        var val_6 = (val_4 + 88) + 0;
        val_12 = val_12 + (((val_4 + 88 + 0) + 4) << 3);
        val_11 = val_12 + 188;
        label_13:
        if((_type > 1) || (val_4 != 2))
        {
            goto label_27;
        }
        
        label_8:
        var val_14 = val_4;
        if((val_4 + 178) == 0)
        {
            goto label_17;
        }
        
        var val_13 = 0;
        label_19:
        if((val_4 + 88 + 0) == null)
        {
            goto label_18;
        }
        
        val_13 = val_13 + 1;
        if(((uint)val_13 & 65535) < (val_4 + 178))
        {
            goto label_19;
        }
        
        label_17:
        val_12 = val_4;
        goto label_20;
        label_18:
        var val_7 = (val_4 + 88) + 0;
        val_14 = val_14 + (((val_4 + 88 + 0) + 4) << 3);
        val_12 = val_14 + 196;
        label_20:
        var val_16 = val_4;
        if((val_4 + 178) == 0)
        {
            goto label_22;
        }
        
        var val_15 = 0;
        label_24:
        if((val_4 + 88 + 0) == null)
        {
            goto label_23;
        }
        
        val_15 = val_15 + 1;
        if(((uint)val_15 & 65535) < (val_4 + 178))
        {
            goto label_24;
        }
        
        label_22:
        val_13 = val_4;
        goto label_25;
        label_23:
        var val_8 = (val_4 + 88) + 0;
        val_16 = val_16 + (((val_4 + 88 + 0) + 4) << 3);
        val_13 = val_16 + 204;
        label_25:
        Add(key:  val_4, value:  val_4);
        goto label_27;
        label_2:
        Dispose();
    }
    public PluginObserverManager()
    {
    
    }
    private static PluginObserverManager()
    {
        PluginObserverManager.isPurchaseValidationWorking = true;
    }

}
