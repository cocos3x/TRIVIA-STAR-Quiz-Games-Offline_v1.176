using UnityEngine;
private sealed class SnakeBlockLevelStreamer.<SpawnNext>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.SnackBlock.SnakeBlockLevelStreamer <>4__this;
    private UnityEngine.GameObject <sectionHolder>5__2;
    private int <row>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SnakeBlockLevelStreamer.<SpawnNext>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        SLC.Minigames.SnackBlock.SnakeBlockLevelStreamer val_25;
        int val_26;
        var val_27;
        var val_28;
        var val_29;
        int val_33;
        val_24 = 0;
        val_25 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool);
        }
        
            this.<>1__state = 0;
            if(((this.<>4__this.sectionHolders) != 0) && (R1 >= 3))
        {
                UnityEngine.GameObject val_1 = this.<>4__this.sectionHolders.Dequeue();
            UnityEngine.Object.Destroy(obj:  this.<>4__this.sectionHolders);
        }
        
            string val_2 = this.<>4__this.lastRowSpawned.ToString();
            string val_3 = 1027163024 + this.<>4__this.lastRowSpawned(this.<>4__this.lastRowSpawned);
            this.<sectionHolder>5__2 = new UnityEngine.GameObject(name:  1027163024);
            UnityEngine.Transform val_5 = transform;
            UnityEngine.Transform val_6 = val_25.transform;
            SetParent(p:  val_25);
            this.<>4__this.sectionHolders.Enqueue(item:  this.<sectionHolder>5__2);
            val_26 = (this.<>4__this.lastRowSpawned) + 1;
            this.<row>5__3 = val_26;
        }
        else
        {
                val_26 = (this.<row>5__3) + 1;
            this.<>1__state = 0;
            this.<row>5__3 = val_26;
        }
        
        val_27 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = this.<row>5__3.ToString();
        string val_9 = 1027163120 + 1028008104;
        UnityEngine.GameObject val_10 = null;
        val_28 = val_10;
        val_10 = new UnityEngine.GameObject(name:  1027163120);
        if(val_28 == 0)
        {
                val_28 = val_28;
        }
        
        UnityEngine.Transform val_11 = transform;
        val_29 = 0;
        UnityEngine.Transform val_12 = transform;
        SetParent(p:  157720576);
        val_26 = 1152921514219678720;
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = this.<row>5__3;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_24 = 1;
        this.<>1__state = val_24;
        mem[1152921514224789660] = 0;
        return (bool);
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
