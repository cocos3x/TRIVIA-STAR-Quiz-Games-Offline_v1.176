using UnityEngine;
private sealed class WFOWordChestDisplay.<BeginChestFtuxFlow>d__59 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.WFOWordChestDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOWordChestDisplay.<BeginChestFtuxFlow>d__59(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        var val_14;
        var val_15;
        if((this.<>1__state) != 1)
        {
                val_13 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
            this.<>1__state = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_2 = UnityEngine.Color.clear;
            System.Nullable<UnityEngine.Color> val_3 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {a = ???});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_3.HasValue}, fadeInDuration:  val_2.r, fadeOutDuration:  val_2.g);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = true;
            BlockRaycasts = true;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
            if(val_14 == 1)
        {
                val_14 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
        }
        
            ShowOverlay(contentToOverlay:  public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92);
            UnityEngine.WaitForSeconds val_9 = null;
            val_9 = new UnityEngine.WaitForSeconds(seconds:  val_2.r);
            val_13 = 1;
            this.<>1__state = val_13;
            this.<>2__current = val_9;
            return (bool)val_13;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_10 = this.<>4__this.DoNewChestAnimationSequence(isFtux:  true);
            val_15 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_11 = 0.DoNewChestAnimationSequence(isFtux:  true);
            val_15 = 0;
        }
        
        val_13 = 0;
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_13;
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
