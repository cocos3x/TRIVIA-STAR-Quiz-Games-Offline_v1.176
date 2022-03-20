using UnityEngine;
private sealed class UnlockableUILeagues.<playUnlockAnimation>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnlockableUILeagues <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UnlockableUILeagues.<playUnlockAnimation>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_38;
        int val_46;
        UnityEngine.GameObject val_47;
        object val_48;
        int val_49;
        if((this.<>1__state) > 6)
        {
            goto label_1;
        }
        
        var val_1 = 7617404 + (7617404 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & ((R8) >> 1);
            7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & ((IP) << (7617404 + (this.<>1__state) << 2 & (R8) >> 1));
            7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & ((IP) << ((7617404 + (this.<>1__state) << 2 & (R8) >> 1) & (IP) << (7617404 + (this.<>1__state) << 2 & (R8) >> 1)));
            7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & (((int)R4) >> 1);
            7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & ((IP) >> 3);
            7617404 + (this.<>1__state) << 2 = R8 * R2;
            7617404 + (this.<>1__state) << 2 = (7617404 + (this.<>1__state) << 2) & ((7617404 + (this.<>1__state) << 2) >> 6);
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() <= 0)
        {
            goto label_5;
        }
        
        this.<>1__state = 2;
        val_46 = 1;
        this.<>2__current = 0;
        return (bool)val_46;
        label_1:
        val_46 = 0;
        return (bool)val_46;
        label_5:
        if((this.<>4__this) != 0)
        {
                mem2[0] = 9999;
        }
        else
        {
                mem[20] = 9999;
        }
        
        UnityEngine.GameObject val_31 = gameObject;
        SetActive(value:  true);
        UnityEngine.Color val_32 = UnityEngine.Color.white;
        twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_36 = new UnityEngine.Color(r:  val_32.r, g:  val_32.g, b:  val_32.b, a:  val_32.a);
        System.Nullable<UnityEngine.Color> val_37 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.r});
        val_47 = val_38;
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_37.HasValue}, fadeInDuration:  val_32.r, fadeOutDuration:  val_32.g);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_40 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_41 = this.<>4__this.gameObject;
        UnityEngine.Transform val_42 = this.<>4__this.transform;
        Add(item:  this.<>4__this);
        twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_44 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        UnityEngine.WaitForSeconds val_45 = null;
        val_48 = val_45;
        val_45 = new UnityEngine.WaitForSeconds(seconds:  val_32.r);
        val_49 = 3;
        this.<>1__state = val_49;
        val_46 = 1;
        this.<>2__current = val_48;
        return (bool)val_46;
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
