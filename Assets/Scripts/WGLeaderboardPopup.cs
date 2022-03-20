using UnityEngine;
public class WGLeaderboardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text rank;
    private AvatarSlotUGUI avatar;
    private UnityEngine.UI.Text playerName;
    private UnityEngine.UI.Text apples;
    private UnityEngine.UI.Text leaderboardEndsText;
    private UnityEngine.UI.Text remainingTime;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Image leaders;
    private UnityEngine.UI.Toggle prizes;
    private UnityEngine.Sprite tab_disable_create;
    private FrameSkipper frameSkipper;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.Text val_8;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -2658000, method:  new IntPtr(4292265840));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.gameObject;
        object val_3 = this.AddComponent<System.Object>();
        this.frameSkipper = this;
        System.Action val_4 = new System.Action(object:  -2658000, method:  new IntPtr(4292270960));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.apples, b:  7454720);
        val_8 = this.apples;
        if(val_8 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_8 = 0;
        label_7:
        this.apples = val_8;
        if(this.prizes == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction<System.Boolean> val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  -2658000, method:  new IntPtr(4292284272));
        this.prizes.onValueChanged.AddListener(call:  162353152);
    }
    private void OnEnable()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_4 = 28710603;
        val_4 = 6915184 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.game == 17)
        {
                "LEADERBOARD ENDS" = "LEADERBOARDS ENDS";
        }
        
        if(App.game == 17)
        {
                "leaderboard_ends_upper" = "leaderboards_ends_upper";
        }
        
        string val_1 = Localization.Localize(key:  -2545200, defaultValue:  -2545424, useSingularKey:  false);
        val_5 = "leaderboards_ends_upper";
        if((Contains(value:  1269544640)) != true)
        {
                string val_3 = -2545200(-2545200) + 1269544640;
            val_5 = val_5;
        }
        
        this.SetupPlayerInfo();
        var val_5 = 28711932;
        val_5 = 6915492 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        typeof(LeaderboardPlayerInfo_Self).__il2cppRuntimeField_1C = 0;
    }
    private void OnDisable()
    {
        System.Action val_3;
        var val_4;
        System.Action val_1 = new System.Action(object:  -2392576, method:  new IntPtr(4292270960));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.frameSkipper.updateLogic, value:  7454720);
        val_3 = this.frameSkipper.updateLogic;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        this.frameSkipper.updateLogic = val_3;
        var val_3 = 28710192;
        val_3 = 6917232 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        LeaderboardEventHandler.instance.OnMyEventPopupClosed();
    }
    private void SetupPlayerInfo()
    {
        var val_6;
        var val_7;
        var val_8;
        AvatarSlotUGUI val_10;
        var val_11;
        var val_12;
        var val_13;
        float val_6 = 6.689478E-38f;
        val_6 = 6915780 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        string val_1 = LeaderboardEventHandler.instance.GetCurrentRankText();
        var val_7 = 28709711;
        val_7 = 6916076 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(App.game == 17)
        {
                string val_2 = LeaderboardEventHandler.instance.playerInfo.ToString(format:  -1774412176);
        }
        else
        {
                decimal val_3 = System.Decimal.op_Implicit(value:  -2268056);
            string val_4 = NumberAbbreviation.GetNumber(num:  new System.Decimal());
        }
        
        val_10 = this.avatar;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        SLC.Social.Profile val_5 = LeaderboardEventHandler.instance.GetPlayerProfile();
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = LeaderboardEventHandler.instance.playerInfo;
        if(this.playerName != 0)
        {
                return;
        }
    
    }
    private void RefreshRemainingTime()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 6917480 + 28709944;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(LeaderboardEventHandler.instance == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        string val_1 = LeaderboardEventHandler.instance.GetRemainingTime();
        if(this.remainingTime == 0)
        {
            
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -2007424, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void HandlePrizesTabValueChanged()
    {
        this.leaders.sprite = this.tab_disable_create;
    }
    public WGLeaderboardPopup()
    {
    
    }
    private void <Awake>b__11_0(bool <p0>)
    {
        this.HandlePrizesTabValueChanged();
    }

}
