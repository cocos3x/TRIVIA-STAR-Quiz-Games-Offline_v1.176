using UnityEngine;
public class UnlockableUILibrary : WGUnlockableUIElement
{
    // Properties
    protected override bool FeatureHidden { get; }
    protected override int UnlockLevel { get; }
    protected override bool FeatureLocked { get; }
    
    // Methods
    protected override bool get_FeatureHidden()
    {
        return false;
    }
    protected override int get_UnlockLevel()
    {
        return ChapterBookLogic.GetFirstLevelOfSecondBook();
    }
    protected override bool get_FeatureLocked()
    {
        if(TheLibraryLogic.LifetimeBooksEarned < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    protected override void OnClickUnlocked()
    {
        var val_1;
        var val_1 = 28005447;
        val_1 = 7620344 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 52;
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
    }
    public UnlockableUILibrary()
    {
    
    }

}
