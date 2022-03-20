using UnityEngine;
public class ClubClashEventWindow : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.UI.Text primaryWindowText;
    private UnityEngine.UI.Text rewardHeaderText;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Text rewardGoldenCurrencyText;
    private UnityEngine.UI.Text playerContributionText;
    private UnityEngine.UI.Text playerTeamNameText;
    private UnityEngine.UI.Text opposingTeamNameText;
    private UnityEngine.UI.Text playerPointsText;
    private UnityEngine.UI.Text opposingPointsText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.GameObject rewardBox;
    private UnityEngine.GameObject playerTeamNameBox;
    private UnityEngine.GameObject opposingTeamNameBox;
    private UnityEngine.GameObject timerParent;
    private UnityEngine.GameObject infoPopup;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoButton;
    private UGUINetworkedButton primaryButton;
    private UnityEngine.UI.Text buttonText;
    private UGUINetworkedButton secondaryButton;
    private UnityEngine.UI.Text secondaryButtonText;
    private UnityEngine.UI.Image playerBarImage;
    private UnityEngine.UI.Image playerClubImage;
    private UnityEngine.UI.Image opposingClubImage;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoReqText;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoRewardText;
    private System.Collections.Generic.List<UnityEngine.UI.Text> infoRewardGoldenCurrencyText;
    public SLC.Social.AvatarConfig guildAvatarHandler;
    public System.Action onStartAction;
    public GameEventV2 myEvent;
    private FrameSkipper mySkipper;
    private GridCoinCollectAnimationInstantiator coinCollector;
    private GoldenCurrencyCollectAnimationInstantiator goldenCollector;
    private UnityEngine.Sprite missingOpponentClubImage;
    private UnityEngine.ParticleSystem victorySystem;
    
    // Methods
    private void Start()
    {
        var val_6;
        var val_7;
        FeatureAccessPoints val_8;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1469216192);
        this.mySkipper = this;
        this.rewardText = 10;
        if(this.onStartAction != 0)
        {
                this.onStartAction.Invoke();
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 1)
        {
                val_6 = 1152921504895770624;
            var val_5 = 21299615;
            val_5 = 14326176 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_8 = 39;
        }
        else
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_6 = 1152921504895770624;
            var val_6 = 21299419;
            val_6 = 14326372 + val_6;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_8 = 40;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_8;
    }
    public void SetUpWindow(bool fromGameButton = False)
    {
        ulong val_4;
        var val_11;
        System.Action val_12;
        System.Action val_13;
        var val_14;
        System.Delegate val_15;
        var val_11 = 21316944;
        val_11 = 14314232 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 44) == 0)
        {
            goto label_3;
        }
        
        val_11 = 1152921504614301696;
        val_12 = this.onStartAction;
        val_13 = null;
        val_14 = 1152921511727661568;
        goto label_31;
        label_3:
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
            goto label_10;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) != 0)
        {
            goto label_10;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 40, b:  -1472496784)) == true)
        {
            goto label_13;
        }
        
        label_10:
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.m_stringLength + 32}, t2:  new System.DateTime() {dateData = val_4})) == false)
        {
            goto label_21;
        }
        
        label_13:
        val_11 = 1152921504614301696;
        val_12 = this.onStartAction;
        val_13 = null;
        val_14 = 1152921511727666688;
        label_31:
        val_13 = new System.Action(object:  -1469084736, method:  new IntPtr(2825852416));
        val_15 = val_12;
        System.Delegate val_8 = System.Delegate.Combine(a:  val_15, b:  7454720);
        if(val_15 != 0)
        {
                if(null == val_11)
        {
            goto label_23;
        }
        
        }
        
        val_15 = 0;
        label_23:
        this.onStartAction = val_15;
        return;
        label_21:
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY.m_stringLength + 62) != 0)
        {
            goto label_30;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 40, b:  -1472496784)) == false)
        {
            goto label_30;
        }
        
        goto label_31;
        label_30:
        UnityEngine.GameObject val_10 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void DisplayCrownClashResult()
    {
        string val_32;
        string val_33;
        float val_32 = 3.619832E-38f;
        val_32 = 14326576 + val_32;
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 44) != 0)
        {
                val_32 = "reward";
            if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 44.ContainsKey(key:  -1470584448)) != false)
        {
                if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
            int val_2 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.baseRewardCoins;
            if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
            int val_3 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.baseRewardGoldenCurrency;
            val_32 = 1152921510385703632;
            string val_4 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Item[-1470584448];
            if((0.ContainsKey(key:  -1987496016)) != false)
        {
                string val_6 = 0.Item[-1987496016];
            bool val_8 = System.Int32.TryParse(s:  null, result: out  int val_7 = -1468892632);
        }
        
            if((0.ContainsKey(key:  -1812169936)) != false)
        {
                string val_10 = 0.Item[-1812169936];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = -1468892636);
        }
        
        }
        
        }
        
        this.CleanUI();
        if(val_2 <= 0)
        {
                val_2 = val_3;
        }
        
        if(val_2 >= 1)
        {
                UnityEngine.GameObject val_13 = this.coinCollector.gameObject;
            this.coinCollector.SetActive(value:  true);
            UnityEngine.GameObject val_14 = this.goldenCollector.gameObject;
            this.goldenCollector.SetActive(value:  true);
            string val_15 = Localization.Localize(key:  -1468972064, defaultValue:  -1468972160, useSingularKey:  false);
            UnityEngine.GameObject val_16 = this.primaryButton.gameObject;
            this.primaryButton.SetActive(value:  true);
            System.Action<System.Boolean> val_17 = new System.Action<System.Boolean>(object:  -1468880592, method:  new IntPtr(2826003536));
            this.primaryButton.OnConnectionClick = null;
            string val_18 = Localization.Localize(key:  -1468958544, defaultValue:  -1468958640, useSingularKey:  false);
            string val_19 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
            this.DisplayClubValues();
            string val_20 = Localization.Localize(key:  -1468950064, defaultValue:  -1468950240, useSingularKey:  false);
            if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
            val_32 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY;
            string val_21 = System.String.Format(format:  -1468950064, arg0:  13152256);
            string val_22 = val_2.ToString();
            string val_23 = val_3.ToString();
            val_33;
            this.rewardBox.SetActive(value:  true);
            if(this.victorySystem == 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_25 = this.victorySystem.gameObject;
            this.victorySystem.SetActive(value:  true);
            this.victorySystem.Play();
            return;
        }
        
        string val_26 = Localization.Localize(key:  -1468925264, defaultValue:  -1468925376, useSingularKey:  false);
        UnityEngine.GameObject val_27 = this.secondaryButton.gameObject;
        this.secondaryButton.SetActive(value:  true);
        System.Action<System.Boolean> val_28 = new System.Action<System.Boolean>(object:  -1468880592, method:  new IntPtr(2826003536));
        this.secondaryButton.OnConnectionClick = null;
        string val_29 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        this.DisplayClubValues();
        string val_30 = Localization.Localize(key:  -1468950064, defaultValue:  -1468950240, useSingularKey:  false);
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY;
        string val_31 = System.String.Format(format:  -1468950064, arg0:  13152256);
    }
    public void DisplayEvent()
    {
        string val_22;
        float val_28;
        var val_39;
        System.Action val_40;
        System.Action val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        this.CleanUI();
        val_39 = 35631176;
        this.myEvent = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.m_stringLength;
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY.m_stringLength != 0)
        {
                if((CPlayerPrefs.GetInt(key:  -1472496896, defaultValue:  0)) != 0)
        {
                if((CPlayerPrefs.GetInt(key:  -1472496896, defaultValue:  0)) == this.myEvent.id)
        {
            goto label_10;
        }
        
        }
        
            CPlayerPrefs.SetInt(key:  -1472496896, val:  this.myEvent.id);
        }
        
        label_10:
        this.timerParent.SetActive(value:  true);
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
            goto label_17;
        }
        
        System.Action val_4 = new System.Action(object:  -1468607856, method:  new IntPtr(2826268912));
        this.mySkipper.updateLogic = null;
        this.DisplayClubValues();
        System.Action val_5 = new System.Action(object:  -1468607856, method:  new IntPtr(2826278128));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.mySkipper.updateLogic, b:  7454720);
        val_40 = this.mySkipper.updateLogic;
        if(val_40 != 0)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        val_40 = 0;
        label_22:
        this.mySkipper.updateLogic = val_40;
        string val_7 = Localization.Localize(key:  -1468958544, defaultValue:  -1468958640, useSingularKey:  false);
        System.Action val_8 = new System.Action(object:  -1468607856, method:  new IntPtr(2826291440));
        System.Delegate val_9 = System.Delegate.Combine(a:  this.mySkipper.updateLogic, b:  7454720);
        val_41 = this.mySkipper.updateLogic;
        if(val_41 != 0)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        val_41 = 0;
        label_27:
        this.mySkipper.updateLogic = val_41;
        var val_39 = 21294073;
        val_39 = 14333352 + val_39;
        if(val_39 == 0)
        {
                mem2[0] = 1;
        }
        
        val_42 = null;
        val_42 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_17:
        if(SLC.Social.Leagues.LeaguesManager.IsAvailable() == false)
        {
            goto label_37;
        }
        
        System.Action val_11 = new System.Action(object:  -1468607856, method:  new IntPtr(2826268912));
        this.mySkipper.updateLogic = null;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 52) < 0)
        {
                ClubClashEvent.LAST_PROGRESS_STAMP_KEY.__unknownFiledOffset_34 = UnityEngine.Random.Range(min:  0, max:  this.guildAvatarHandler.AvatarSpritesCount);
            ClubClashEvent.LAST_PROGRESS_STAMP_KEY.__unknownFiledOffset_38 = UnityEngine.Random.Range(min:  0, max:  this.guildAvatarHandler.AvatarSpritesCount);
        }
        
        UnityEngine.Sprite val_16 = this.guildAvatarHandler.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 52);
        this.playerClubImage.sprite = this.guildAvatarHandler;
        UnityEngine.Sprite val_17 = this.guildAvatarHandler.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 56);
        this.opposingClubImage.sprite = this.guildAvatarHandler;
        string val_18 = Localization.Localize(key:  -1468637696, defaultValue:  -1468670736, useSingularKey:  false);
        string val_19 = Localization.Localize(key:  -1468633392, defaultValue:  -1468633488, useSingularKey:  false);
        Dictionary.KeyCollection<TKey, TValue> val_20 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_21 = GetEnumerator();
        goto label_69;
        label_76:
        string val_23 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Item[val_22];
        val_43 = 0;
        val_39 = 35631176;
        if( > 0)
        {
                string val_24 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Item[val_22];
            val_44 = 0;
        }
        
        label_69:
        if(MoveNext() == true)
        {
            goto label_76;
        }
        
        Dispose();
        string val_26 = ToString();
        Dictionary.Enumerator<TKey, TValue> val_27 = GetEnumerator();
        goto label_81;
        label_85:
        val_45 = 0;
        if( > 0)
        {
                0 = ;
        }
        
        label_81:
        if(0.MoveNext() == true)
        {
            goto label_85;
        }
        
        0.Dispose();
        string val_31 = 0.ToString();
        string val_32 = Localization.Localize(key:  -1468633184, defaultValue:  -1468633280, useSingularKey:  false);
        UnityEngine.GameObject val_33 = mem[1152921511728173800].gameObject;
        mem[1152921511728173800].SetActive(value:  true);
        System.Action<System.Boolean> val_34 = new System.Action<System.Boolean>(object:  -1468607856, method:  new IntPtr(2826334224));
        mem2[0] = null;
        UnityEngine.GameObject val_35 = mem[1152921511728173784].gameObject;
        mem[1152921511728173784].SetActive(value:  true);
        mem[1152921511728173764].SetActive(value:  true);
        string val_36 = Localization.Localize(key:  -1468950064, defaultValue:  -1468950240, useSingularKey:  false);
        val_28 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 32;
        string val_37 = System.String.Format(format:  -1468950064, arg0:  13152256);
        mem[1152921511728173808].fillAmount = null;
        goto label_98;
        label_37:
        UnityEngine.Debug.LogError(message:  -1468632048);
        UnityEngine.GameObject val_38 = this.gameObject;
        if(this == 0)
        {
            
        }
    
    }
    private void SetTimerSpecialBoyPlacement()
    {
    
    }
    public void DisplayInBetweenState()
    {
        UnityEngine.UI.Text val_20;
        var val_21;
        UnityEngine.UI.Image val_22;
        SLC.Social.AvatarConfig val_23;
        UnityEngine.Sprite val_24;
        this.CleanUI();
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() != false)
        {
                if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) == 0)
        {
            goto label_45;
        }
        
        }
        
        label_45:
        string val_2 = Localization.Localize(key:  -1468329856, defaultValue:  -1468330032, useSingularKey:  false);
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
            goto label_10;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 1)
        {
            goto label_17;
        }
        
        UnityEngine.GameObject val_5 = this.primaryButton.gameObject;
        this.primaryButton.SetActive(value:  true);
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -1468247008, method:  new IntPtr(2826649840));
        this.primaryButton.OnConnectionClick = null;
        val_20 = this.buttonText;
        string val_7 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_8 = App.Player;
        val_21 = "level_#_upper";
        string val_9 = System.String.Format(format:  -1672741904, arg0:  13152256);
        goto label_24;
        label_10:
        UnityEngine.GameObject val_10 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_17:
        UnityEngine.GameObject val_11 = this.secondaryButton.gameObject;
        this.secondaryButton.SetActive(value:  true);
        System.Action<System.Boolean> val_12 = new System.Action<System.Boolean>(object:  -1468247008, method:  new IntPtr(2826649840));
        this.secondaryButton.OnConnectionClick = null;
        val_20 = this.secondaryButtonText;
        val_21 = "continue_upper";
        string val_13 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        label_24:
        val_22 = this.playerClubImage;
        val_23 = this.guildAvatarHandler;
        SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_15 = 0.MyGuild;
        UnityEngine.Sprite val_16 = val_23.GetAvatarSpriteByID(id:  0);
        val_22.sprite = val_23;
        if(((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) == 0) || ((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.ContainsKey(key:  -1468287760)) == false))
        {
            goto label_38;
        }
        
        val_22 = this.opposingClubImage;
        string val_18 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1468287760];
        val_23 = null;
        ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        UnityEngine.Sprite val_19 = this.guildAvatarHandler.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36);
        val_24 = this.guildAvatarHandler;
        if(val_22 != 0)
        {
            goto label_43;
        }
        
        goto label_43;
        label_38:
        val_24 = this.missingOpponentClubImage;
        label_43:
        this.opposingClubImage.sprite = val_24;
    }
    public void ToggleInfo()
    {
        string val_21;
        var val_22;
        var val_24;
        if(this.infoPopup != 0)
        {
                val_21 = this.infoPopup.activeSelf;
        }
        else
        {
                val_21 = 0.activeSelf;
        }
        
        this.infoPopup.SetActive(value:  val_21 ^ 1);
        if(this.infoPopup.activeSelf == false)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_5 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Keys;
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64);
        string val_7 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[1915417424];
        val_21 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36;
        if((System.Int32.TryParse(s:  val_21, result: out  int val_8 = -1468068924)) == false)
        {
            goto label_12;
        }
        
        val_21 = "0";
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Contains(item:  1254115712)) != false)
        {
                bool val_11 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Remove(item:  1254115712);
        }
        
        val_22 = 4;
        val_24 = 1152921504758390784;
        goto label_16;
        label_54:
        val_21 = this.infoReqText;
        if(SL >= 6236)
        {
            goto label_22;
        }
        
        val_21 = this.infoRewardText;
        if(SL >= 6236)
        {
            goto label_22;
        }
        
        val_21 = this.infoRewardGoldenCurrencyText;
        if(SL >= 6236)
        {
            goto label_22;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 12) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 8 + 16, result: out  int val_12 = -1468068928)) == false)
        {
            goto label_50;
        }
        
        var val_15 = (0 + (ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 24)) * 0;
        decimal val_16 = System.Decimal.op_Implicit(value:  -1468068928);
        decimal val_17 = new System.Decimal(value:  1000);
        string val_18 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, useRichText:  false, withSpaces:  false);
        if(0 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 12) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_19 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Item[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 8 + 16];
        if(2621443 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 12) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_20 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68.Item[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 8 + 16];
        val_21 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68;
        val_24 = 1152921504758390784;
        goto label_50;
        label_22:
        UnityEngine.Debug.LogError(message:  -1468081184);
        label_50:
        val_22 = 5;
        label_16:
        if((val_22 - 4) < (ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64 + 12))
        {
            goto label_54;
        }
        
        return;
        label_12:
        UnityEngine.Debug.LogError(message:  -1468081008);
    }
    private void DisplayCurrentPrize()
    {
        string val_10;
        var val_33;
        var val_34;
        var val_35;
        var val_33 = 21289736;
        val_33 = 14341440 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) == 0)
        {
                return;
        }
        
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                val_33 = mem[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 24];
            val_33 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 24;
        }
        else
        {
                val_33 = mem[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 24];
            val_33 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 24;
            if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        string val_1 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[1915417424];
        if((System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36, result: out  int val_2 = -1467935176)) == false)
        {
            goto label_11;
        }
        
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
            goto label_13;
        }
        
        val_34 = mem[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28];
        val_34 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28;
        goto label_18;
        label_11:
        val_35 = "unable to parse opposing club capacity";
        goto label_17;
        label_13:
        val_34 = mem[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28];
        val_34 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        label_18:
        string val_4 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1471390128];
        if((System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36, result: out  int val_5 = -1467935180)) == false)
        {
            goto label_22;
        }
        
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_7 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Keys;
        var val_8 = 0 + val_33;
        val_34 = 0 + val_34;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_9 = GetEnumerator();
        val_33 = 0;
        goto label_27;
        label_36:
        int val_11 = System.Int32.Parse(s:  val_10);
        val_11 = val_11 * val_8;
        if(val_34 < val_11)
        {
            goto label_28;
        }
        
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_12 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Item[val_10];
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_14 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64.Keys;
        object val_15 = System.Linq.Enumerable.Last<System.Object>(source:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64);
        val_33 = val_33 | (System.String.op_Equality(a:  val_10, b:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64));
        label_27:
        if(MoveNext() == true)
        {
            goto label_36;
        }
        
        label_28:
        Dispose();
        if((System.Int32.Parse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 64)) <= 0)
        {
                if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_19 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_20 = GetEnumerator();
        goto label_45;
        label_53:
        int val_21 = System.Int32.Parse(s:  val_10);
        val_21 = val_21 * val_8;
        if(val_34 >= val_21)
        {
                if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
            string val_22 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68.Item[val_10];
            if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
            Dictionary.KeyCollection<TKey, TValue> val_24 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68.Keys;
            object val_25 = System.Linq.Enumerable.Last<System.Object>(source:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68);
            bool val_34 = false;
            val_34 = val_34 | (System.String.op_Equality(a:  val_10, b:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68));
        }
        
        label_45:
        if(MoveNext() == true)
        {
            goto label_53;
        }
        
        Dispose();
        if((System.Int32.Parse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 68)) <= 0)
        {
                if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        string val_29 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.baseRewardCoins.ToString();
        if(val_33 == true)
        {
                string val_30 = mem[1152921511728858452] + -1467947360(-1467947360);
        }
        
        string val_31 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.baseRewardGoldenCurrency.ToString();
        if(val_34 != true)
        {
                return;
        }
        
        string val_32 = mem[1152921511728858456] + -1467947360(-1467947360);
        if(mem[1152921511728858456] != 0)
        {
                return;
        }
        
        return;
        label_22:
        val_35 = "unable to parse opposing club crowns";
        label_17:
        UnityEngine.Debug.LogError(message:  -1467947280);
    }
    private void UpdateTimerText()
    {
        var val_5;
        FrameSkipper val_24;
        var val_25;
        System.Action val_26;
        System.Action val_27;
        if(this.myEvent == 0)
        {
                return;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511728974856}, d2:  new System.DateTime() {dateData = this.myEvent.timeEnd});
        double val_7 = val_5.TotalSeconds;
        ClubClashEvent.LAST_PROGRESS_STAMP_KEY.PutData(crownsCollected:  0);
        this.CleanUI();
        this.DisplayInBetweenState();
        val_24 = this.mySkipper;
        val_25 = 1152921504614301696;
        val_26 = null;
        val_26 = new System.Action(object:  -1467794640, method:  new IntPtr(2826268912));
        System.Delegate val_9 = System.Delegate.Remove(source:  this.mySkipper.updateLogic, value:  7454720);
        val_27 = this.mySkipper.updateLogic;
        if(val_27 != 0)
        {
                if(null == null)
        {
            goto label_12;
        }
        
        }
        
        val_27 = 0;
        label_12:
        this.mySkipper.updateLogic = val_27;
    }
    private void FindClubButtonClick(bool result)
    {
        var val_14;
        ClubClashEventWindow val_15;
        System.Func<System.Boolean> val_17;
        var val_18;
        if((result != false) && (SLC.Social.Leagues.LeaguesManager.IsAvailable() != false))
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
            this.CloseWindow(connected:  false);
            return;
        }
        
        }
        
        GameBehavior val_7 = App.getBehavior;
        string val_9 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_10 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_11 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_14 = null;
        val_15 = this;
        val_17 = ClubClashEventWindow.<>c.<>9__44_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<System.Boolean>(object:  ClubClashEventWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2827278064));
            ClubClashEventWindow.<>c.<>9__44_0 = val_17;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_17;
        val_18 = null;
        val_18 = null;
        0f.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        UnityEngine.GameObject val_13 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1467664208, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void DisplayClubValues()
    {
        int val_20;
        int val_21;
        int val_22;
        int val_23;
        SLC.Social.AvatarConfig val_31;
        float val_32;
        var val_33;
        var val_34;
        UnityEngine.UI.Text val_36;
        val_31 = 14330320 + 21300856;
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        val_32 = 1152921504919678976;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) == 0)
        {
                return;
        }
        
        val_33 = 1152921505048485888;
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
                return;
        }
        
        this.playerTeamNameBox.SetActive(value:  true);
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_3 = 0.MyGuild;
        UnityEngine.GameObject val_4 = this.playerPointsText.gameObject;
        this.playerPointsText.SetActive(value:  true);
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28) < 1000)
        {
                string val_5 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28.ToString();
            val_34;
        }
        else
        {
                decimal val_6 = System.Decimal.op_Implicit(value:  -1467506924);
            decimal val_7 = new System.Decimal(value:  1000);
            string val_8 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid}, useRichText:  false, withSpaces:  false);
            val_34 = R0;
            val_33 = 1152921505048485888;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_10 = 0.MyGuild;
        UnityEngine.Sprite val_11 = this.guildAvatarHandler.GetAvatarSpriteByID(id:  0);
        this.playerClubImage.sprite = this.guildAvatarHandler;
        this.opposingTeamNameBox.SetActive(value:  true);
        val_32 = 1152921510392296080;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.ContainsKey(key:  1679334848)) != false)
        {
                string val_13 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[1679334848];
        }
        
        UnityEngine.GameObject val_14 = this.opposingPointsText.gameObject;
        this.opposingPointsText.SetActive(value:  true);
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.ContainsKey(key:  -1471390128)) == false)
        {
            goto label_38;
        }
        
        string val_16 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1471390128];
        int val_17 = System.Int32.Parse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36);
        val_36 = this.opposingPointsText;
        if(val_17 < 1000)
        {
            goto label_40;
        }
        
        decimal val_18 = System.Decimal.op_Implicit(value:  -1467506924);
        decimal val_19 = new System.Decimal(value:  1000);
        string val_24 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = val_21, hi = val_20, lo = val_22, mid = val_23}, maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_19.flags, hi = val_19.hi, lo = val_19.lo, mid = val_19.mid}, useRichText:  false, withSpaces:  false);
        val_31 = val_21;
        val_32 = 1152921510392296080;
        goto label_46;
        label_38:
        val_36 = this.opposingPointsText;
        label_40:
        string val_25 = val_17.ToString();
        val_31;
        label_46:
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.ContainsKey(key:  -1468287760)) != false)
        {
                val_31 = this.guildAvatarHandler;
            string val_27 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1468287760];
            ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Sprite val_28 = val_31.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36);
            this.opposingClubImage.sprite = val_31;
        }
        
        if(this.opposingClubImage == 0)
        {
                return;
        }
        
        float val_31 = (float)ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28;
        val_31 = val_31 / ((float)val_17 + (ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28));
        this.playerBarImage.fillAmount = UnityEngine.Mathf.Clamp(value:  val_31, min:  null, max:  (float)val_17 + (ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28));
    }
    private void CollectReward(bool connected)
    {
        object val_1 = new System.Object();
        var val_17 = 21283976;
        typeof(ClubClashEventWindow.<>c__DisplayClass46_0).__il2cppRuntimeField_8 = this;
        val_17 = 14347200 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Collections.Generic.Dictionary<GameEventRewardType, System.Object> val_2 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.CollectReward();
        typeof(ClubClashEventWindow.<>c__DisplayClass46_0).__il2cppRuntimeField_10 = 0;
        ClubClashEventWindow.<>c__DisplayClass46_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = 0;
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY.ContainsKey(key:  1)) != false)
        {
                object val_4 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.Item[1];
            bool val_6 = System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY, result: out  int val_5 = 313045004);
        }
        
            if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY.ContainsKey(key:  2)) != false)
        {
                object val_8 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY.Item[2];
            bool val_10 = System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY, result: out  int val_9 = 313045008);
        }
        
            if((ClubClashEventWindow.<>c__DisplayClass46_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC) <= 0)
        {
                ClubClashEventWindow.<>c__DisplayClass46_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = typeof(ClubClashEventWindow.<>c__DisplayClass46_0).__il2cppRuntimeField_10;
        }
        
            this.primaryButton.interactable = false;
            this.secondaryButton.interactable = false;
            System.Action val_11 = new System.Action(object:  -1467310160, method:  new IntPtr(2827630064));
            mem2[0] = null;
            DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  313044992, method:  new IntPtr(2827631088));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  null, callback:  0);
            DG.Tweening.TweenCallback val_15 = new DG.Tweening.TweenCallback(object:  313044992, method:  new IntPtr(2827632112));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  null, callback:  1066192077);
            return;
        }
        
        this.CloseWindow(connected:  false);
    }
    private void LoadGameplayScene(bool connected)
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
            goto label_5;
        }
        
        var val_5 = 21277639;
        val_5 = 14348152 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 39;
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
            goto label_15;
        }
        
        goto label_15;
        label_5:
        GameBehavior val_3 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        val_5 = 14348488 + 21277303;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 40;
        label_15:
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1467185872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void CloseWindow()
    {
        this.CloseWindow(connected:  false);
    }
    private void CloseWindow(bool connected = True)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1466961872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
            
        }
    
    }
    private void CleanUI()
    {
        UnityEngine.GameObject val_1 = this.rewardBox.gameObject;
        this.rewardBox.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.infoButton.gameObject;
        this.infoButton.SetActive(value:  false);
        this.infoPopup.SetActive(value:  false);
        this.playerTeamNameBox.SetActive(value:  false);
        this.opposingTeamNameBox.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.playerPointsText.gameObject;
        this.playerPointsText.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.opposingPointsText.gameObject;
        this.opposingPointsText.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        this.timerParent.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1466739280, method:  new IntPtr(2827630064));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.primaryButton.OnConnectionClick = 0;
        this.secondaryButton.OnConnectionClick = 0;
        UnityEngine.GameObject val_7 = this.primaryButton.gameObject;
        this.primaryButton.SetActive(value:  false);
        UnityEngine.GameObject val_8 = this.secondaryButton.gameObject;
        this.secondaryButton.SetActive(value:  false);
        if(this.victorySystem == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_10 = this.victorySystem.gameObject;
        this.victorySystem.SetActive(value:  false);
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
    public ClubClashEventWindow()
    {
        this.infoReqText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.infoRewardText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.infoRewardGoldenCurrencyText = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
