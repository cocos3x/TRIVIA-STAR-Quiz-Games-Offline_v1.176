using UnityEngine;
public class WGLaunchSceneManager : MonoBehaviour
{
    // Fields
    private bool doneThisBefore;
    
    // Methods
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -4558272, name:  -2037002944);
    }
    private void Start()
    {
        var val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  0);
        var val_2 = 28716149;
        val_2 = 6909640 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(WordApp.deferredEventHasFired == false)
        {
                return;
        }
        
        if(this.doneThisBefore == true)
        {
                return;
        }
        
        R4.OnDeferredReady();
    }
    private void OnDeferredReady()
    {
        if(this.doneThisBefore == true)
        {
                return;
        }
        
        mem2[0] = 1;
        this.DoLevelsDataRequest();
        TheLibraryLogic.InitializePlayerData();
    }
    private void DoLevelsDataRequest()
    {
        var val_4;
        var val_4 = 28715759;
        val_4 = 6910028 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.game <= 4)
        {
            goto label_6;
        }
        
        if(App.game > 18)
        {
                return;
        }
        
        if(263296 != (1 << App.game))
        {
            goto label_8;
        }
        
        return;
        label_6:
        if(App.game != 4)
        {
                return;
        }
        
        label_8:
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            CallEmptyMethod();
            return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        CallEmptyMethod();
    }
    public WGLaunchSceneManager()
    {
    
    }

}
