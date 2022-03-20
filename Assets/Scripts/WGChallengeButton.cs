using UnityEngine;
public class WGChallengeButton : MyButton
{
    // Fields
    private UnityEngine.ParticleSystem challengeProgressParticle;
    private bool hasShownCompletedThisScene;
    
    // Methods
    private void Awake()
    {
        var val_10;
        Player val_1 = App.Player;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(featureEnabled == false)
        {
            goto label_11;
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1607827792, method:  new IntPtr(2687112432));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_7 = new System.Action<System.Boolean, collectResultStatus>(object:  -1607827792, method:  new IntPtr(2687113456));
        System.Delegate val_8 = System.Delegate.Combine(a:  public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28, b:  7507968);
        val_10 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_19;
        }
        
        }
        
        val_10 = 0;
        label_19:
        public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28 = val_10;
        return;
        label_11:
        UnityEngine.GameObject val_9 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnProgressGained(bool isComplete, ChallengeType cType)
    {
        if(isComplete != false)
        {
                if(this.hasShownCompletedThisScene == false)
        {
            goto label_1;
        }
        
        }
        
        this.challengeProgressParticle.Play();
        return;
        label_1:
        UnityEngine.Transform val_1 = R5.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  R5, duration:  null, strength:  null, vibrato:  1060320051, randomness:  null, fadeOut:  false);
        this.hasShownCompletedThisScene = true;
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.hasShownCompletedThisScene = false;
    }
    public override void OnButtonClick()
    {
        var val_6;
        FeatureAccessPoints val_7;
        this.OnButtonClick();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                var val_6 = 28926267;
            val_6 = 6699524 + val_6;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_7 = 37;
        }
        else
        {
                var val_7 = 28926187;
            val_7 = 6699604 + val_7;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_7 = 36;
        }
        
        val_6 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = val_7;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnDestroy()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_2 = new System.Action<System.Boolean, collectResultStatus>(object:  -1607354192, method:  new IntPtr(2687113456));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28, value:  7507968);
        val_5 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_28 = val_5;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_4 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1607354192, method:  new IntPtr(2687112432));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    public WGChallengeButton()
    {
    
    }

}
