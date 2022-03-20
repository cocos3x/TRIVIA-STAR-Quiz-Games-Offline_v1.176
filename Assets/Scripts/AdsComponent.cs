using UnityEngine;
public class AdsComponent : AppComponent
{
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public AdsComponent(string gameName, string gameObjectName)
    {
        mem[1152921511218206832] = "AdsComponent";
    }
    public static bool isComponentRequired()
    {
        return true;
    }
    public override void initializeOnMainThread()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(2124574416 != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  -1978366560);
    }

}
