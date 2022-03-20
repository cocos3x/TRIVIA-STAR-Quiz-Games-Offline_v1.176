using UnityEngine;
private sealed class WPTGameUIController.<AddLettersToColumn>d__115 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameColumn column;
    public WordPets.WPTGameUIController <>4__this;
    private WordPets.WPTGameUIController.<>c__DisplayClass115_0 <>8__1;
    public System.Collections.Generic.List<char> characters;
    public bool isInitialPopulation;
    private WordPets.ColData <backupOriginalColData>5__2;
    private bool <isColumnAddedByPowerup>5__3;
    private int <letter>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<AddLettersToColumn>d__115(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        WordPets.WPTGameUIController val_18;
        WPTGameUIController.<>c__DisplayClass115_0 val_19;
        int val_20;
        System.Collections.Generic.List<System.Char> val_21;
        int val_22;
        object val_23;
        val_17 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        val_18 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(WPTGameUIController.<>c__DisplayClass115_0).__il2cppRuntimeField_8 = this.column;
        val_19 = this.<>8__1;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  val_19, method:  new IntPtr(178673584));
        System.Collections.Generic.List<WordPets.ColData> val_16 = this.<>4__this.gamemode.backupLevelData.colData;
        WordPets.ColData val_3 = val_16.Find(match:  8040448);
        this.<backupOriginalColData>5__2 = val_16;
        val_20 = 0;
        val_21 = this.characters;
        val_16 = val_16 >> 5;
        this.<letter>5__4 = val_20;
        this.<isColumnAddedByPowerup>5__3 = val_16;
        goto label_9;
        label_1:
        val_22 = 0;
        goto label_10;
        label_2:
        this.<>1__state = 0;
        UnityEngine.Transform val_4 = this.<>8__1.column.transform;
        object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.WPTTile, parent:  this.<>8__1.column);
        object val_6 = this.<>4__this.WPTTile.GetComponent<System.Object>();
        val_21 = this;
        if((this.<>4__this.WPTTile) <= (this.<letter>5__4))
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = val_17 + 0;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector2 val_8 = CurrentTileSize;
        val_19 = this.<>8__1.column;
        if(this.isInitialPopulation == true)
        {
                this.isInitialPopulation = 1;
        }
        
        val_19.AddTile(newTile:  this.<>4__this.WPTTile, dontUpdateData:  true);
        if(this.isInitialPopulation == false)
        {
            goto label_25;
        }
        
        this.<>4__this.WPTTile.HasBalloon = this.<>8__1.column.<myData>k__BackingField.IsTileBalloon(rowIndex:  this.<letter>5__4);
        this.<>4__this.WPTTile.HasCrate = this.<>8__1.column.<myData>k__BackingField.IsTileCrate(rowIndex:  this.<letter>5__4);
        val_19 = this.<>8__1.column.<myData>k__BackingField;
        label_43:
        this.<>4__this.WPTTile.HasSpiderWeb = val_19.IsTileSpiderweb(rowIndex:  this.<letter>5__4);
        goto label_35;
        label_25:
        if((this.<isColumnAddedByPowerup>5__3) == false)
        {
            goto label_36;
        }
        
        label_35:
        val_20 = (this.<letter>5__4) + 1;
        this.<letter>5__4 = val_20;
        label_9:
        val_18 = null;
        if(val_20 < (mem[this.characters + 12]))
        {
                UnityEngine.WaitForSeconds val_12 = null;
            val_23 = val_12;
            val_12 = new UnityEngine.WaitForSeconds(seconds:  val_8.x);
            val_22 = 1;
        }
        else
        {
                UnityEngine.WaitForFixedUpdate val_13 = null;
            val_23 = val_13;
            val_13 = new UnityEngine.WaitForFixedUpdate();
            val_22 = 2;
        }
        
        val_17 = 1;
        this.<>2__current = val_23;
        label_10:
        this.<>1__state = val_22;
        return (bool)val_17;
        label_36:
        this.<>4__this.WPTTile.HasCrate = this.<backupOriginalColData>5__2.IsTileCrate(rowIndex:  this.<letter>5__4);
        this.<>4__this.WPTTile.HasBalloon = this.<backupOriginalColData>5__2.IsTileBalloon(rowIndex:  this.<letter>5__4);
        if((this.<backupOriginalColData>5__2) != 0)
        {
            goto label_43;
        }
        
        goto label_43;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
