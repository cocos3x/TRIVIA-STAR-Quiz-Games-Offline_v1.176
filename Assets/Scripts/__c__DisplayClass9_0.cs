using UnityEngine;
private sealed class WGHelpMenuPopup.<>c__DisplayClass9_0
{
    // Fields
    public System.Action prevOnClose;
    public System.Action <>9__1;
    
    // Methods
    public WGHelpMenuPopup.<>c__DisplayClass9_0()
    {
    
    }
    internal void <OnClickHowToPlay>b__0()
    {
        System.Action val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        val_5 = this.<>9__1;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Action(object:  -29985856, method:  new IntPtr(4264956416));
            this.<>9__1 = val_5;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_5;
    }
    internal void <OnClickHowToPlay>b__1()
    {
        GameBehavior val_1 = App.getBehavior;
        object val_2 = 0.GetComponent<System.Object>();
        mem[20] = this.prevOnClose;
    }

}
