using UnityEngine;
public class WGUnlockableUIElementByLevel : WGUnlockableUIElement
{
    // Fields
    private int unlockLevel;
    private int unhideLevel;
    
    // Properties
    protected override bool FeatureHidden { get; }
    protected override bool FeatureLocked { get; }
    protected override int UnlockLevel { get; }
    
    // Methods
    protected override bool get_FeatureHidden()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 < this.unhideLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    protected override bool get_FeatureLocked()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 < this.unlockLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    protected override int get_UnlockLevel()
    {
        return (int)this.unlockLevel;
    }
    public WGUnlockableUIElementByLevel()
    {
        mem[1152921513276117468] = 0;
        mem[1152921513276117448] = 1;
        val_1 = new FrameSkipper();
    }

}
