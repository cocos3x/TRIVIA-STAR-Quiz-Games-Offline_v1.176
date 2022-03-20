using UnityEngine;
public class WGLevelChallengePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text mainText;
    private UnityEngine.UI.Text coinsRewardText;
    private UnityEngine.UI.Text goldenCurrencyRewardText;
    private UnityEngine.UI.Text winsRemainingText;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.Button button_play;
    private UnityEngine.UI.Button buttonContinue;
    private UnityEngine.UI.Text playButtonText;
    private int players;
    private int levels;
    private int reward;
    private int winsRemaining;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -517792, method:  new IntPtr(4294407072));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -517792, method:  new IntPtr(4294416288));
        this.button_play.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -517792, method:  new IntPtr(4294416288));
        this.buttonContinue.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.UpdateUI();
    }
    private void UpdateUI()
    {
        this.players = LevelChallengeHandler.NumWinners;
        mem[1152921513196541392] = LevelChallengeHandler.RequiredLevels;
        string val_3 = Localization.Localize(key:  -289120, defaultValue:  -288960, useSingularKey:  false);
        string val_4 = this.players.ToString();
        string val_5 = mem[1152921513196541392].ToString();
        string val_6 = System.String.Format(format:  -289120, arg0:  -240180, arg1:  -240176);
        string val_8 = LevelChallengeHandler.Reward.ToString();
        string val_10 = LevelChallengeHandler.RewardGoldenCurrency.ToString();
        string val_12 = LevelChallengeHandler.GetWinsRemaining().ToString();
        UnityEngine.GameObject val_13 = this.button_play.gameObject;
        GameBehavior val_14 = App.getBehavior;
        this.button_play.SetActive(value:  true);
        UnityEngine.GameObject val_15 = this.buttonContinue.gameObject;
        GameBehavior val_16 = App.getBehavior;
        if(this.buttonContinue != 0)
        {
                -1 = 1;
        }
        
        this.buttonContinue.SetActive(value:  true);
        string val_17 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_18 = App.Player;
        string val_19 = System.String.Format(format:  -1672741904, arg0:  13152256);
        if(this.playButtonText != 0)
        {
                return;
        }
    
    }
    private void OnClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -99552, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(LevelChallengeHandler.FALSE == 0)
        {
            
        }
    
    }
    private void OnClick_Play()
    {
        if(LevelChallengeHandler.InGame != true)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGLevelChallengePopup()
    {
    
    }

}
