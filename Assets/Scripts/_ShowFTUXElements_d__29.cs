using UnityEngine;
private sealed class WordFillFTUXManager.<ShowFTUXElements>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordFillFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordFillFTUXManager.<ShowFTUXElements>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_19;
        object val_20;
        System.Int32[] val_21;
        int val_22;
        int val_23;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_19 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_19;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_20 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_19 = 1;
        this.<>1__state = val_19;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        bool val_2 = System.String.op_Inequality(a:  this.<>4__this.FTUXText, b:  1098586544);
        if(val_2 != false)
        {
                int val_3 = (this.<>4__this.ftuxPhase) + ((this.<>4__this.ftuxPhase) << 1);
            val_3 = val_3 << 1;
            if(val_3 < val_2)
        {
                int val_5 = ((this.<>4__this.ftuxPhase) + ((this.<>4__this.ftuxPhase) << 1)) << 1;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_8 = GetGridPos(x:  this.<>4__this.ftuxLetterPos[val_5], y:  this.<>4__this.ftuxLetterPos[val_5 | 1]);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_12 = GetGridPos(x:  this.<>4__this.ftuxLetterPos[val_5 + 2], y:  this.<>4__this.ftuxLetterPos[val_5 + 3]);
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = this.<>4__this.ftuxLetterPos;
            val_5 = val_5 + 5;
            val_22 = this.<>4__this.ftuxLetterPos[val_5];
            UnityEngine.Transform val_15 = GetGridPos(x:  val_21[val_5 + 4], y:  val_22);
            this.<>4__this.ShowHand(one:  -1729655760, two:  -1729655760, three:  -1729655760);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_19 = 0;
        public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_5E = val_19;
        return (bool)val_19;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_21 = this.<>4__this;
            val_23 = this.<>4__this.ftuxPhase;
        }
        else
        {
                val_21 = 64;
            val_23 = 52;
        }
        
        val_22 = this.<>4__this.ftuxMessages;
        if(val_23 < 0)
        {
                val_22 = this.<>4__this.FTUXText;
            val_21 = this.<>4__this.ftuxMessages[val_21];
            UnityEngine.GameObject val_17 = this.<>4__this.FTUXText.gameObject;
            this.<>4__this.FTUXText.SetActive(value:  true);
        }
        
        UnityEngine.WaitForSeconds val_18 = null;
        val_20 = val_18;
        val_18 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 2;
        val_19 = 1;
        label_4:
        this.<>2__current = val_20;
        return (bool)val_19;
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
