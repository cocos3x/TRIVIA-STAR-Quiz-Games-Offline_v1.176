using UnityEngine;
public class WGLevelChallengeProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text levelsCompleteText;
    private UnityEngine.UI.Text prizeCoinsText;
    private UnityEngine.UI.Text prizeGoldenCurrencyText;
    private UnityEngine.UI.Text winsRemainingText;
    private UnityEngine.GameObject windowGroup;
    private const float DEFAULT_DELAY_BEFORE_SHOW_POPUP_IN_SECONDS = 2.5;
    private const float DEFAULT_SHOW_POPUP_IN_SECONDS = 3;
    private const float FROM_GAME_BUTTON_SHOW_POPUP_DELAY_IN_SECONDS = 0;
    private const float FROM_GAME_BUTTON_SHOW_POPUP_DURATION_IN_SECONDS = 3.5;
    private float delayShowInSeconds;
    private float durationInSeconds;
    
    // Methods
    private void Awake()
    {
        this.windowGroup.SetActive(value:  false);
    }
    private void OnEnable()
    {
        this.UpdateUI();
        this.delayShowInSeconds = 2.5f;
        this.durationInSeconds = 3f;
        System.Collections.IEnumerator val_1 = this.ShowPopup(delay:  null, duration:  null);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  356640);
    }
    private System.Collections.IEnumerator PlayFallAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGLevelChallengeProgressPopup.<PlayFallAnimation>d__13).__il2cppRuntimeField_8 = 0;
        typeof(WGLevelChallengeProgressPopup.<PlayFallAnimation>d__13).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ShowPopup(float delay, float duration)
    {
        typeof(WGLevelChallengeProgressPopup.<ShowPopup>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGLevelChallengeProgressPopup.<ShowPopup>d__14).__il2cppRuntimeField_10 = R1;
            typeof(WGLevelChallengeProgressPopup.<ShowPopup>d__14).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = R1;
        }
        
        typeof(WGLevelChallengeProgressPopup.<ShowPopup>d__14).__il2cppRuntimeField_18 = R2;
    }
    private System.Collections.IEnumerator PlayUnFallAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGLevelChallengeProgressPopup.<PlayUnFallAnimation>d__15).__il2cppRuntimeField_8 = 0;
        typeof(WGLevelChallengeProgressPopup.<PlayUnFallAnimation>d__15).__il2cppRuntimeField_10 = this;
    }
    private void UpdateUI()
    {
        string val_2 = LevelChallengeHandler.CompletedLevels.ToString();
        typeof(System.String[]).__il2cppRuntimeField_10 = ;
        typeof(System.String[]).__il2cppRuntimeField_14 = "/";
        string val_4 = LevelChallengeHandler.RequiredLevels.ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = ;
        typeof(System.String[]).__il2cppRuntimeField_1C = " ";
        string val_5 = Localization.Localize(key:  -1630882544, defaultValue:  -1630882464, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_20 = "levels";
        string val_6 = +477709520;
        string val_8 = LevelChallengeHandler.Reward.ToString();
        string val_10 = LevelChallengeHandler.RewardGoldenCurrency.ToString();
        string val_12 = LevelChallengeHandler.GetWinsRemaining().ToString();
        if(this.winsRemainingText != 0)
        {
                return;
        }
    
    }
    private void Update()
    {
        var val_6 = this;
        if(UnityEngine.Input.touchCount <= 0)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        }
        
        R4.StopAllCoroutines();
        UnityEngine.GameObject val_3 = R4.gameObject;
        R4.SetActive(value:  false);
        UnityEngine.GameObject val_4 = R4.gameObject;
        SLCWindow.CloseWindow(window:  R4, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  1061408, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGLevelChallengeProgressPopup()
    {
    
    }

}
