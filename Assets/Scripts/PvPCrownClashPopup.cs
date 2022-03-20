using UnityEngine;
public class PvPCrownClashPopup : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.UI.Text primaryWindowText;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Text secondaryButtonText;
    private UnityEngine.UI.Text rewardHeaderText;
    private UnityEngine.UI.Text coinRewardText;
    private UnityEngine.UI.Text appleRewardText;
    private UnityEngine.UI.Text playerNameText;
    private UnityEngine.UI.Text opposingNameText;
    private UnityEngine.UI.Text playerPointsText;
    private UnityEngine.UI.Text opposingPointsText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.GameObject rewardBox;
    private UnityEngine.GameObject timerParent;
    private UnityEngine.GameObject infoPopup;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button primaryButton;
    private UnityEngine.UI.Button secondaryButton;
    private UnityEngine.UI.Image playerBarImage;
    private UnityEngine.UI.Image playerClubImage;
    private UnityEngine.UI.Image opposingClubImage;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoReqText;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoRewardText;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoAppleRewardText;
    public SLC.Social.AvatarConfig playerAvatarHandler;
    public System.Action onStartAction;
    public GameEventV2 myEvent;
    private FrameSkipper mySkipper;
    private GridCoinCollectAnimationInstantiator coinCollector;
    private GoldenCurrencyCollectAnimationInstantiator appleCollector;
    private UnityEngine.UI.RawImage facebookImage;
    private UnityEngine.ParticleSystem victorySystem;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1458364576);
        this.mySkipper = this;
        this.secondaryButtonText = 10;
        if(this.onStartAction != 0)
        {
                this.onStartAction.Invoke();
        }
        
        var val_5 = 25890291;
        val_5 = 9739708 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.SetWindowSeen();
        }
        
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.UpdateFeaturePoint();
        if(this.coinCollector == 0)
        {
                return;
        }
        
        if(this.coinCollector == 0)
        {
                return;
        }
        
        mem2[0] = 0;
    }
    public void SetUpWindow(bool fromGameButton = False)
    {
        var val_5;
        var val_6;
        System.Action val_7;
        System.Action val_8;
        var val_9;
        System.Delegate val_10;
        var val_5 = 25889407;
        val_5 = 9740592 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.CheckCalculateReward();
        if(this.myEvent == 0)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            this.myEvent = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.m_stringLength;
        }
        
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.canCollectReward() == false)
        {
            goto label_11;
        }
        
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        object val_2 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.rewardData;
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
            goto label_11;
        }
        
        val_5 = this;
        val_6 = 1152921504614301696;
        val_7 = this.onStartAction;
        val_8 = null;
        val_9 = 1152921511738529568;
        goto label_12;
        label_11:
        val_5 = this;
        val_6 = 1152921504614301696;
        val_7 = this.onStartAction;
        val_8 = null;
        val_9 = 1152921511738534688;
        label_12:
        val_8 = new System.Action(object:  -1458221856, method:  new IntPtr(2836720416));
        val_10 = val_7;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_10, b:  7454720);
        if(val_10 != 0)
        {
                if(null == val_6)
        {
            goto label_14;
        }
        
        }
        
        val_10 = 0;
        label_14:
        this.onStartAction = val_10;
    }
    public void DisplayEvent()
    {
        System.Action val_19;
        System.Action val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Events.UnityAction val_25;
        UnityEngine.UI.Button val_26;
        this.CleanUI();
        this.timerParent.SetActive(value:  true);
        System.Action val_1 = new System.Action(object:  -1458005872, method:  new IntPtr(2836853920));
        this.mySkipper.updateLogic = null;
        this.DisplayPlayerValues();
        System.Action val_2 = new System.Action(object:  -1458005872, method:  new IntPtr(2836863136));
        System.Delegate val_3 = System.Delegate.Combine(a:  this.mySkipper.updateLogic, b:  7454720);
        val_19 = this.mySkipper.updateLogic;
        if(val_19 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_19 = 0;
        label_6:
        this.mySkipper.updateLogic = val_19;
        string val_4 = Localization.Localize(key:  -1468958544, defaultValue:  -1468958640, useSingularKey:  false);
        System.Action val_5 = new System.Action(object:  -1458005872, method:  new IntPtr(2836876448));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.mySkipper.updateLogic, b:  7454720);
        val_20 = this.mySkipper.updateLogic;
        if(val_20 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_20 = 0;
        label_11:
        this.mySkipper.updateLogic = val_20;
        var val_19 = 25885745;
        val_19 = 9741680 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                val_22 = "The player that earns the most Golden Apples wins!";
            val_23 = "apple_picking_popup_info";
        }
        else
        {
                val_22 = "Internet required for updates!";
            val_23 = "internet_required_updates";
        }
        
        string val_7 = Localization.Localize(key:  -1458085296, defaultValue:  -1458085424, useSingularKey:  false);
        this.rewardBox.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.infoButton.gameObject;
        this.infoButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -1458005872, method:  new IntPtr(2836898512));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        val_24 = 1152921504892043264;
        GameBehavior val_10 = App.getBehavior;
        if(0 == 1)
        {
                string val_11 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
            Player val_12 = App.Player;
            val_24 = 0;
            string val_13 = System.String.Format(format:  -1672741904, arg0:  13152256);
            val_25 = null;
            val_25 = new UnityEngine.Events.UnityAction(object:  -1458005872, method:  new IntPtr(2836911824));
            this.primaryButton.m_OnClick.AddListener(call:  162246656);
            val_26 = this.primaryButton;
        }
        else
        {
                string val_15 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
            val_25 = null;
            val_25 = new UnityEngine.Events.UnityAction(object:  -1458005872, method:  new IntPtr(2836911824));
            this.secondaryButton.m_OnClick.AddListener(call:  162246656);
            val_26 = this.secondaryButton;
        }
        
        UnityEngine.GameObject val_17 = val_26.gameObject;
        val_26.SetActive(value:  true);
        UnityEngine.GameObject val_18 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  true);
    }
    public void DisplayCrownClashResult()
    {
        var val_21 = 25884495;
        val_21 = 9745504 + val_21;
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        object val_1 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.rewardData;
        UnityEngine.Debug.LogError(message:  -1457831856);
        this.CloseWindow();
    }
    private void DisplayPlayerValues()
    {
        float val_17;
        var val_18;
        var val_19;
        float val_20;
        var val_17 = 25885935;
        val_17 = 9744064 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_1 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.playerName;
        UnityEngine.GameObject val_2 = this.playerPointsText.gameObject;
        this.playerPointsText.SetActive(value:  true);
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24) >= 1000)
        {
                val_17 = 1000f;
            float val_18 = (float)PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24;
            val_18 = val_18 / val_17;
            string val_3 = val_18.ToString(format:  -1465186192);
            val_18 = "{0}K";
            string val_4 = System.String.Format(format:  -1465186096, arg0:  -1457480908);
        }
        else
        {
                string val_5 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24.ToString();
        }
        
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        UnityEngine.Sprite val_7 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.playerSprite);
        this.playerClubImage.sprite = this.playerAvatarHandler;
        this.OnMyProfileUpdate();
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_8 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.getOpponentCrowns();
        if(val_8 >= 1000)
        {
                val_17 = 1000f;
            float val_19 = (float)val_8;
            val_19 = val_19 / val_17;
            string val_9 = val_19.ToString(format:  -1465186192);
            val_19 = "{0}K";
            string val_10 = System.String.Format(format:  -1465186096, arg0:  -1457480912);
        }
        else
        {
                string val_11 = val_8.ToString();
        }
        
        UnityEngine.GameObject val_12 = this.opposingPointsText.gameObject;
        this.opposingPointsText.SetActive(value:  true);
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_13 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.opponentName;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        UnityEngine.Sprite val_15 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.opponentPlayerSprite);
        this.opposingClubImage.sprite = this.playerAvatarHandler;
        val_20 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24;
        if(this.opposingClubImage != 0)
        {
                val_20 = val_20 + (float)val_8;
            val_20 = val_20 / val_20;
            float val_16 = UnityEngine.Mathf.Clamp(value:  val_20, min:  null, max:  null);
            if(this.playerBarImage != 0)
        {
            goto label_34;
        }
        
        }
        
        label_34:
        this.playerBarImage.fillAmount = val_20;
    }
    private void OnMyProfileUpdate()
    {
        UnityEngine.GameObject val_1 = this.facebookImage.gameObject;
        this.facebookImage.SetActive(value:  false);
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_3 = 0.MyProfile;
        if((System.String.IsNullOrEmpty(value:  2097204)) == true)
        {
                return;
        }
        
        if(8 == 0)
        {
                return;
        }
        
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1457305664, method:  new IntPtr(2837635584));
        System.Action val_6 = new System.Action(object:  -1457305664, method:  new IntPtr(2837636608));
        FacebookAvatarHelper.RequestProfilePic(fbid:  2097204, successCallback:  7507968, failureCallback:  7454720);
    }
    public void OnResponseSuccess(string fileName, UnityEngine.Texture2D texture)
    {
        UnityEngine.UI.RawImage val_9;
        if(texture != 0)
        {
                if(texture.width > 255)
        {
            goto label_5;
        }
        
        }
        
        label_13:
        this.OnResponseFail();
        return;
        label_5:
        UnityEngine.GameObject val_3 = this.gameObject;
        val_9 = this;
        if((-1457169088) == 0)
        {
                return;
        }
        
        val_9 = this.facebookImage;
        if(val_9 == 0)
        {
                return;
        }
        
        string val_6 = fileName.Replace(oldValue:  -1856587728, newValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  fileName)) == true)
        {
            goto label_13;
        }
        
        this.facebookImage.texture = texture;
        UnityEngine.GameObject val_8 = this.facebookImage.gameObject;
        this.facebookImage.SetActive(value:  true);
    }
    public void OnResponseFail()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if((-1457028416) == 0)
        {
                return;
        }
        
        if(this.facebookImage == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.facebookImage.gameObject;
        this.facebookImage.SetActive(value:  false);
    }
    private void CollectReward()
    {
        this.primaryButton.interactable = false;
        object val_1 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.rewardData;
        UnityEngine.Debug.LogError(message:  -1456928128);
        this.CloseWindow();
    }
    private void LoadGameplayScene()
    {
        var val_4;
        this.UpdateFeaturePoint();
        val_4 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1456753952, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void UpdateFeaturePoint()
    {
        var val_4;
        var val_5;
        FeatureAccessPoints val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                val_4 = 1152921504895770624;
            var val_3 = 25885583;
            val_3 = 9740208 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 41;
        }
        else
        {
                GameBehavior val_2 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_4 = 1152921504895770624;
            var val_4 = 25885387;
            val_4 = 9740404 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 42;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
    }
    private void UpdateTimerText()
    {
        int val_3;
        var val_5;
        FrameSkipper val_25;
        var val_26;
        System.Action val_27;
        System.Action val_28;
        var val_29;
        var val_30;
        var val_31;
        if(this.myEvent == 0)
        {
                return;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511740264120}, d2:  new System.DateTime() {dateData = this.myEvent.timeEnd});
        double val_7 = val_5.TotalSeconds;
        this.closeButton.interactable = false;
        this.primaryButton.interactable = false;
        double val_8 = val_5.TotalSeconds;
        if(this.primaryButton >= 0)
        {
            goto label_9;
        }
        
        this.CleanUI();
        val_25 = this.mySkipper;
        val_26 = 1152921504614301696;
        val_27 = null;
        val_27 = new System.Action(object:  -1456505376, method:  new IntPtr(2836853920));
        System.Delegate val_10 = System.Delegate.Remove(source:  this.mySkipper.updateLogic, value:  7454720);
        val_28 = this.mySkipper.updateLogic;
        if(val_28 != 0)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_28 = 0;
        label_13:
        var val_25 = 25879283;
        this.mySkipper.updateLogic = val_28;
        val_25 = 9750716 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.CheckCalculateReward();
        return;
        label_9:
        int val_12 = val_5.Seconds;
        if(val_5.Seconds > 9)
        {
                string val_13 = val_12.ToString();
        }
        else
        {
                val_3 = val_12;
            val_29 = "0";
            string val_14 = 1254115712 + 13152256;
        }
        
        val_26 = val_29;
        int val_16 = val_5.Minutes;
        if(val_5.Minutes > 9)
        {
                string val_17 = val_16.ToString();
        }
        else
        {
                val_3 = val_16;
            val_30 = "0";
            string val_18 = 1254115712 + 13152256;
        }
        
        string val_21 = val_5.Hours.ToString();
        val_31;
        if(val_5.Hours <= 9)
        {
                string val_22 = 1254115712 + -1456517428(-1456517428);
            val_31 = "0";
        }
        
        val_25 = null;
        val_3 = val_5.Days;
        val_27 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_27;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_31;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_30;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_26;
        string val_24 = System.String.Format(format:  -1467818752, args:  472754880);
    }
    private void DisplayCurrentPrize()
    {
        var val_14;
        float val_15;
        float val_15 = 5.10134E-38f;
        val_15 = 9751688 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_1 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.getOpponentCrowns();
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                int val_2 = (PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24) + val_1;
        }
        else
        {
                if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_4 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Keys;
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44);
        val_14 = 4;
        val_15 = "0";
        goto label_9;
        label_15:
        if("0" <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24) + val_1) >= (System.Int32.Parse(s:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16)))
        {
                if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = mem[PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16];
            val_15 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16;
        }
        
        val_14 = 5;
        label_9:
        if((val_14 - 4) < (PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12))
        {
            goto label_15;
        }
        
        System.Text.StringBuilder val_8 = new System.Text.StringBuilder();
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8;
        val_16 = val_16 + (((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) - 1) << 2);
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_11 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Item[val_15];
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_12 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 48.Item[val_15];
        if((System.String.op_Equality(a:  val_15, b:  (PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + ((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12 - 1)) << 2) + 16)) != false)
        {
                return;
        }
        
        string val_13 = mem[1152921511740412796] + -1467947360(-1467947360);
        string val_14 = mem[1152921511740412800] + -1467947360(-1467947360);
        if(mem[1152921511740412800] == 0)
        {
            
        }
    
    }
    public void ToggleInfo()
    {
        var val_14;
        var val_15;
        var val_16;
        if(this.infoPopup != 0)
        {
                val_14 = this.infoPopup.activeSelf;
        }
        else
        {
                val_14 = 0.activeSelf;
        }
        
        this.infoPopup.SetActive(value:  val_14 ^ 1);
        if(this.infoPopup.activeSelf == false)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_5 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Keys;
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44);
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Contains(item:  1254115712)) != false)
        {
                bool val_8 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Remove(item:  1254115712);
        }
        
        var val_15 = 25876735;
        val_15 = 9753264 + val_15;
        val_15 = 0;
        int val_9 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.getOpponentCrowns();
        val_16 = 4;
        goto label_13;
        label_47:
        if((R8 >= 23204) || (R8 >= 23204))
        {
            goto label_17;
        }
        
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_11 = System.Int32.TryParse(s:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16, result: out  int val_10 = -1456240168);
        if(val_11 == false)
        {
            goto label_43;
        }
        
        if(val_11 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_12 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Item[PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16];
        if(2621443 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_13 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 48.Item[PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16];
        val_15 = 0;
        goto label_43;
        label_17:
        UnityEngine.Debug.LogError(message:  -1468081184);
        label_43:
        val_16 = 5;
        label_13:
        if((val_16 - 4) < (PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12))
        {
            goto label_47;
        }
    
    }
    private void CleanUI()
    {
        UnityEngine.GameObject val_1 = this.rewardBox.gameObject;
        this.rewardBox.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.infoButton.gameObject;
        this.infoButton.SetActive(value:  false);
        this.infoPopup.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.playerPointsText.gameObject;
        this.playerPointsText.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.opposingPointsText.gameObject;
        this.opposingPointsText.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        this.timerParent.SetActive(value:  false);
        this.primaryButton.m_OnClick.RemoveAllListeners();
        UnityEngine.GameObject val_6 = this.primaryButton.gameObject;
        this.primaryButton.SetActive(value:  false);
        UnityEngine.GameObject val_7 = this.secondaryButton.gameObject;
        this.secondaryButton.SetActive(value:  false);
        this.mySkipper.updateLogic = 0;
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -1455993248, method:  new IntPtr(2838047648));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_9 = this.victorySystem.gameObject;
        this.victorySystem.SetActive(value:  false);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1455787040, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                return;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
            
        }
    
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.GameObject val_8 = this.infoPopup;
        if(val_8.activeSelf == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = eventData.selectedObject;
        val_8 = eventData;
        UnityEngine.GameObject val_3 = this.infoButton.gameObject;
        if(val_8 == this.infoButton)
        {
                return;
        }
        
        UnityEngine.GameObject val_5 = eventData.selectedObject;
        UnityEngine.GameObject val_6 = this.infoPopup.gameObject;
        val_8 = this.infoPopup;
        if(eventData == val_8)
        {
                return;
        }
        
        this.infoPopup.SetActive(value:  false);
    }
    public PvPCrownClashPopup()
    {
        this.infoReqText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.infoRewardText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.infoAppleRewardText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
