using UnityEngine;
public class WPTLevelClear : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject upperGroup;
    private UnityEngine.GameObject centerGroup;
    private UnityEngine.GameObject levelDisplay;
    private UnityEngine.GameObject chapterDisplay;
    private UnityEngine.UI.Text chapterText;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Slider progressSlider;
    private UnityEngine.Transform petCapturedTransform;
    private UnityEngine.GameObject petCapturedPrefab;
    private UnityEngine.UI.Text journalButtonText;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button journalButton;
    private System.Collections.Generic.List<WordPets.WordPetType> petList;
    private System.Collections.Generic.List<WordPets.WPTCapturedPetDisplay> petDisplayList;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  121167328, method:  new IntPtr(121133088));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  121167328, method:  new IntPtr(121142304));
        this.journalButton.m_OnClick.AddListener(call:  162246656);
        this.LoadPetsCaptured();
        this.SetInitialProgressUI();
    }
    private void SetInitialProgressUI()
    {
        var val_26;
        var val_27;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        int val_3 = 0.GetCurrentChapter(level:  -1);
        string val_4 = System.String.Format(format:  121275808, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_7 = System.String.Format(format:  121281024, arg0:  13152256, arg1:  13152256);
        if(1 != 0)
        {
                val_26 = 0.GetLastLevelInChapter(chapter:  val_3);
        }
        else
        {
                val_26 = 0.GetLastLevelInChapter(chapter:  val_3);
        }
        
        var val_27 = 0;
        var val_10 = 0 + 1312;
        float val_30 = 1f;
        val_27 = 1 - val_27;
        val_27 = val_27 + val_26;
        val_27 = val_27 + 1;
        if(1 != 0)
        {
                val_27 = 0.GetLastLevelInChapter(chapter:  val_3);
        }
        else
        {
                int val_13 = 0.GetLastLevelInChapter(chapter:  val_3);
            val_27 = val_13;
        }
        
        val_13 = val_27 - (-1);
        float val_29 = (float)val_13;
        float val_28 = 100f;
        val_28 = (val_30 - ((float)val_27 / (float)val_10)) * val_28;
        string val_15 = System.String.Format(format:  2124591920, arg0:  13152256);
        this.levelDisplay.SetActive(value:  (0.IsLastLevelInChapter(level:  -1)) ^ 1);
        this.chapterDisplay.SetActive(value:  0.IsLastLevelInChapter(level:  -1));
        UnityEngine.Transform val_19 = this.upperGroup.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        this.upperGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_21 = this.centerGroup.transform;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        val_29 = val_29 / (float)val_10;
        this.centerGroup.localScale = new UnityEngine.Vector3();
        val_30 = val_30 - val_29;
        UnityEngine.Transform val_23 = this.continueButton.transform;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
        this.continueButton.localScale = new UnityEngine.Vector3();
        this.HidePets();
        System.Collections.IEnumerator val_25 = this.ShowProgress(initialProgress:  val_24.x, currentProgress:  val_24.y);
        UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  121333808);
    }
    private System.Collections.IEnumerator ShowProgress(float initialProgress, float currentProgress)
    {
        typeof(WPTLevelClear.<ShowProgress>d__16).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WPTLevelClear.<ShowProgress>d__16).__il2cppRuntimeField_1C = R1;
            typeof(WPTLevelClear.<ShowProgress>d__16).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
            mem[28] = R1;
        }
        
        typeof(WPTLevelClear.<ShowProgress>d__16).__il2cppRuntimeField_14 = R2;
    }
    private void OnContinueButtonClicked()
    {
        var val_12;
        System.Action val_13;
        var val_14;
        val_12 = 1152921504892043264;
        Player val_1 = App.Player;
        if(0 < 2)
        {
            goto label_9;
        }
        
        WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
        Player val_3 = App.Player;
        val_13 = 0;
        if((0.IsLastLevelInChapter(level:  -1)) == false)
        {
            goto label_9;
        }
        
        GameBehavior val_5 = App.getBehavior;
        val_14 = null;
        val_14 = null;
        val_13 = WPTLevelClear.<>c.<>9__17_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Action(object:  WPTLevelClear.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(121571696));
            WPTLevelClear.<>c.<>9__17_0 = val_13;
        }
        
        0.SetOnCloseCallback(popupClosed:  7454720);
        goto label_20;
        label_9:
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_9 = currentGame;
        label_20:
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  11, oneshot:  true, pitch:  null, vol:  null);
        UnityEngine.GameObject val_11 = this.gameObject;
        SLCWindow.CloseWindow(window:  121596720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnJournalButtonClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void LoadPetsCaptured()
    {
        char* val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_2 = currentGame;
        this.petList = null;
        if(new System.Object() != 0)
        {
                typeof(WPTLevelClear.<>c__DisplayClass19_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        val_11 = 0;
        typeof(WPTLevelClear.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = ;
        if(this.petList != 0)
        {
                return;
        }
    
    }
    private void HidePets()
    {
        var val_3 = 0;
        goto label_1;
        label_9:
        if(true <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        UnityEngine.Transform val_1 = (0 + 0) + 16.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        (0 + 0) + 16.localScale = new UnityEngine.Vector3();
        val_3 = 1;
        label_1:
        if(val_3 < ((0 + 0) + 16))
        {
            goto label_9;
        }
    
    }
    private System.Collections.IEnumerator ShowPets()
    {
        object val_1 = new System.Object();
        typeof(WPTLevelClear.<ShowPets>d__21).__il2cppRuntimeField_8 = 0;
        typeof(WPTLevelClear.<ShowPets>d__21).__il2cppRuntimeField_10 = this;
    }
    public WPTLevelClear()
    {
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.petList = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.petDisplayList = null;
    }

}
