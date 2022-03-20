using UnityEngine;
public class FrameSkipper : MonoBehaviour
{
    // Fields
    protected bool disableSkip;
    private int frameSkipper;
    protected int _framesToSkip;
    public System.Action updateLogic;
    
    // Properties
    public int framesToSkip { get; set; }
    
    // Methods
    public int get_framesToSkip()
    {
        return (int)this._framesToSkip;
    }
    public void set_framesToSkip(int value)
    {
        this._framesToSkip = value;
    }
    private void Update()
    {
        var val_1;
        if(this.disableSkip == true)
        {
                return;
        }
        
        val_1 = mem[R4 + 16];
        val_1 = R4 + 16;
        if((R4 + 20) == 0)
        {
                if((R4 + 24) != 0)
        {
                R4 + 24.Invoke();
        }
        
            val_1 = 0;
            mem2[0] = val_1;
        }
        
        mem2[0] = val_1 + 1;
    }
    protected virtual void UpdateLogic()
    {
    
    }
    public FrameSkipper()
    {
        var val_2;
        System.Action val_4;
        this._framesToSkip = 30;
        val_2 = null;
        val_2 = null;
        val_4 = FrameSkipper.<>c.<>9__9_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Action(object:  FrameSkipper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2515476752));
            FrameSkipper.<>c.<>9__9_0 = val_4;
        }
        
        this.updateLogic = val_4;
    }

}
