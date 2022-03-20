using UnityEngine;
private sealed class WPTLevelEditorUI.<WaitThenRefreshRowButtons>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float startDelay;
    public WordPets.LevelEditor.WPTLevelEditorUI <>4__this;
    private System.Collections.Generic.List<WordPets.WPTGameColumn> <rows>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTLevelEditorUI.<WaitThenRefreshRowButtons>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        float val_17;
        float val_18;
        float val_19;
        float val_21;
        float val_22;
        var val_23;
        int val_24;
        object val_25;
        var val_26;
        System.Collections.Generic.List<WordPets.WPTGameColumn> val_27;
        var val_29;
        var val_30;
        val_23 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_24 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_24;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_25 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_24 = 1;
        this.<>1__state = val_24;
        this.<>2__current = val_25;
        return (bool)val_24;
        label_1:
        val_26 = 0;
        this.<>1__state = 0;
        goto label_5;
        label_11:
        val_27 = this.<rows>5__2;
        if(val_27 != 0)
        {
            
        }
        else
        {
                val_27 = 0;
        }
        
        label_12:
        if(R6 <= val_26)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = 0;
        val_23 = val_23 + 0;
        this.<>4__this.AddColInformation(row:  (0 + 0) + 16);
        val_26 = 1;
        label_5:
        if((this.<rows>5__2) == 0)
        {
            goto label_11;
        }
        
        if(val_26 < ((0 + 0) + 16))
        {
            goto label_12;
        }
        
        UnityEngine.GameObject val_2 = this.<>4__this.AddColButton.gameObject;
        val_25 = this.<>4__this.AddColButton;
        if(((0 + 0) + 16) <= 6)
        {
            goto label_16;
        }
        
        val_24 = 0;
        val_25.SetActive(value:  false);
        return (bool)val_24;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.<rows>5__2 = null;
        this.<>4__this.TryDeleteButtons();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.<>4__this.colButtons = null;
        val_24 = 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_24;
        label_16:
        val_25.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.<>4__this.AddColButton.gameObject;
        UnityEngine.Transform val_7 = this.<>4__this.AddColButton.transform;
        if((this.<rows>5__2) != 0)
        {
                val_30 = this.<>4__this.AddColButton;
        }
        else
        {
                val_23 = 12;
            val_30 = 0;
            val_29 = 0;
        }
        
        if(val_29 <= (-1))
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + 4294967292;
        val_25 = mem[(0 + 4294967292) + 16];
        val_25 = (0 + 4294967292) + 16;
        UnityEngine.GameObject val_8 = this.<>4__this.colButtons.Item[val_25];
        UnityEngine.Transform val_9 = this.<>4__this.colButtons.transform;
        UnityEngine.Vector3 val_10 = position;
        this.<>4__this.AddColButton.position = new UnityEngine.Vector3();
        UnityEngine.Vector2 val_11 = anchoredPosition;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1.326955E-30f, y = val_13}, d:  val_12.x);
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 1.326954E-30f, y = val_17}, b:  new UnityEngine.Vector2() {x = val_18, y = val_19});
        val_24 = 0;
        this.<>4__this.AddColButton.anchoredPosition = new UnityEngine.Vector2() {x = val_21, y = val_22};
        return (bool)val_24;
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
