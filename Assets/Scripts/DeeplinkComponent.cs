using UnityEngine;
public class DeeplinkComponent : AppComponent
{
    // Fields
    protected DeeplinkComponentHelper helper;
    private static DeeplinkComponent instance;
    public static string HACK_actionString;
    protected DeeplinkDelegate listener;
    public const string OnDeeplinkNotification = "OnDeeplinkNotification";
    public const string OnDeeplinkShowScene = "OnDeepLinkShowScene";
    private bool mustUpdate;
    
    // Properties
    public static DeeplinkComponent Instance { get; }
    public override bool RunInMainThread { get; }
    public bool MustUpdate { get; set; }
    public bool HasCurrentReward { get; }
    public System.Collections.Generic.List<ConsumableAmountPair> CurrentReward { get; set; }
    public bool HasScene { get; }
    public string Scene { get; set; }
    public bool HasHelpshift { get; }
    public bool HasLobby { get; }
    public bool HasReferal { get; }
    public string Referal { get; set; }
    public bool HasMonolith { get; }
    public string Monolith { get; set; }
    public bool HasForestNews { get; }
    public bool HasPiggyBankRaid { get; }
    public bool HasNotificationType { get; }
    public string NotificationType { get; set; }
    public bool HasProfileAction { get; }
    public string ProfileAction { get; set; }
    public bool HasPromoCode { get; }
    public string PromoCode { get; set; }
    public bool HasOpenUrl { get; }
    public string OpenUrl { get; set; }
    public bool Consumed { get; set; }
    public bool HasHint { get; }
    public int Hint { get; set; }
    public bool HasDailyChallenge { get; }
    public string DailyChallenge { get; set; }
    public bool HasInviteCode { get; }
    public string InviteCode { get; set; }
    public bool HasMiniGame { get; }
    public int MiniGame { get; set; }
    public bool HasNoAds { get; }
    public int NoAdsDuration { get; set; }
    public float PromoPrice { get; set; }
    public bool HasPerk { get; }
    public int Perk { get; set; }
    public int PerkDuration { get; set; }
    public bool HasChallengeFriendCode { get; }
    public string ChallengeFriendCode { get; set; }
    
    // Methods
    public static DeeplinkComponent get_Instance()
    {
        null = null;
    }
    public DeeplinkComponent(string gameName, string gameObjectName)
    {
        var val_4;
        mem[1152921511227946224] = "DeeplinkComponent";
        val_4 = null;
        val_4 = null;
        DeeplinkComponent.OnDeeplinkShowScene = this;
        this.helper = new DeeplinkComponentHelper();
        object val_3 = AddComponent<System.Object>();
        this.listener = new UnityEngine.GameObject();
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_C = this;
    }
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public override void initializeOnMainThread()
    {
        goto typeof(DeeplinkComponent).__il2cppRuntimeField_114;
    }
    public override void onApplicationPause(bool pauseStatus)
    {
        if(pauseStatus == true)
        {
                return;
        }
        
        goto typeof(DeeplinkComponent).__il2cppRuntimeField_114;
    }
    protected virtual void PerformAction()
    {
        this.CheckForNormalDeeplink();
    }
    public void CheckForDeeplinkUrl(string url, DeeplinkSource source)
    {
        var val_34;
        DeeplinkSource val_35;
        string val_36;
        DeeplinkUri val_37;
        DeeplinkComponent val_38;
        var val_39;
        var val_40;
        val_34 = this;
        val_35 = source;
        val_36 = url;
        if((System.String.IsNullOrEmpty(value:  val_36)) == true)
        {
                return;
        }
        
        val_37 = 1152921504900296704;
        DeeplinkUri val_2 = null;
        val_38 = val_2;
        val_2 = new DeeplinkUri(uri:  val_36, useParser:  false);
        string val_3 = Scheme;
        if((System.String.IsNullOrEmpty(value:  293449728)) == true)
        {
                return;
        }
        
        string val_5 = Host;
        if((System.String.IsNullOrEmpty(value:  293449728)) == true)
        {
                return;
        }
        
        string val_7 = Scheme;
        if((Contains(value:  1466169184)) == false)
        {
            goto label_8;
        }
        
        string val_9 = Query;
        if((System.String.IsNullOrEmpty(value:  293449728)) != true)
        {
                string val_11 = Query;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 63;
            string val_12 = TrimStart(trimChars:  478563824);
            typeof(System.Char[]).__il2cppRuntimeField_10 = 38;
            val_39 = 0;
            System.String[] val_13 = Split(separator:  478563824);
            val_40 = 61;
        }
        
        string val_16 = AbsolutePath;
        val_35 = val_35;
        val_37 = 1152921504900296704;
        if((System.String.IsNullOrEmpty(value:  293449728)) == false)
        {
            goto label_30;
        }
        
        label_8:
        string val_18 = Scheme;
        val_40 = val_38;
        AppConfigs val_19 = App.Configuration;
        if((Contains(value:  52)) != false)
        {
                val_38 = val_37;
            val_37 = new DeeplinkUri(uri:  val_36 = val_36, useParser:  true);
            string val_21 = Scheme;
            if((System.String.IsNullOrEmpty(value:  293449728)) == true)
        {
                return;
        }
        
            string val_23 = Host;
            if((System.String.IsNullOrEmpty(value:  293449728)) == true)
        {
                return;
        }
        
        }
        
        string val_25 = Host;
        DeeplinkAction val_26 = new DeeplinkAction(maybeJson:  293449728);
        this.ParseDeeplink(action:  293396480, source:  val_35);
        return;
        label_30:
        typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
        string val_27 = AbsolutePath;
        string val_28 = TrimStart(trimChars:  478563824);
        string val_29 = TrimEnd(trimChars:  478563824);
        System.String[] val_30 = Split(separator:  478563824);
        DeeplinkAction val_31 = new DeeplinkAction(maybeJson:  DeeplinkUri.__il2cppRuntimeField_byval_arg);
        this.ParseDeeplink(action:  293396480, source:  val_35);
    }
    private void CheckForNormalDeeplink()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        DeeplinkAction val_1 = DeeplinkPlugin.GetAction();
        val_7 = 0;
        val_8 = null;
        val_8 = null;
        if((System.String.IsNullOrEmpty(value:  DeeplinkComponent.HACK_actionString)) != true)
        {
                val_9 = null;
            val_9 = null;
            DeeplinkAction val_3 = null;
            val_7 = val_3;
            val_3 = new DeeplinkAction(maybeJson:  DeeplinkComponent.HACK_actionString);
        }
        
        string val_4 = DeeplinkPlugin.GetNotificationData();
        val_10 = 3;
        if((System.String.IsNullOrEmpty(value:  typeof(DeeplinkAction).__il2cppRuntimeField_14)) != false)
        {
                if((System.String.IsNullOrEmpty(value:  null)) != true)
        {
                ForceJson(forcedJson:  null);
            val_10 = 1;
        }
        
        }
        
        this.ParseDeeplink(action:  293396480, source:  1);
    }
    protected void ParseDeeplink(DeeplinkAction action, DeeplinkSource source)
    {
        if((System.String.IsNullOrEmpty(value:  action.decodedAction)) != false)
        {
                DeeplinkPlugin.NotifyActionConsumed(identifier:  action.identifier);
            return;
        }
        
        35641337 = this.helper;
        35641337.EnqueueAction(action:  action, source:  source);
        this.Notify();
    }
    public void Flush()
    {
        this.helper.Cleanup();
    }
    public bool DequeueDeeplinkAction()
    {
        if(this.helper != 0)
        {
                return this.helper.DequeueAction();
        }
        
        return this.helper.DequeueAction();
    }
    public void TrackDeeplinkParsed()
    {
        if(this.helper != 0)
        {
                this.helper.TrackDeeplinkParsed();
            return;
        }
        
        this.helper.TrackDeeplinkParsed();
    }
    protected void Notify()
    {
        if(this.listener == 0)
        {
                return;
        }
        
        R4 + 24.QueryDeeplinkComponent();
    }
    public bool get_MustUpdate()
    {
        return (bool)this.mustUpdate;
    }
    public void set_MustUpdate(bool value)
    {
        this.mustUpdate = value;
    }
    public bool get_HasCurrentReward()
    {
        var val_1 = 21418630;
        val_1 = 14222712 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(this.helper.currentRewards == 0)
        {
                return false;
        }
        
        if(R1 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.List<ConsumableAmountPair> get_CurrentReward()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_CurrentReward(System.Collections.Generic.List<ConsumableAmountPair> value)
    {
        this.helper.currentRewards = value;
    }
    public bool get_HasScene()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.scene);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Scene()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_Scene(string value)
    {
        this.helper.scene = value;
    }
    public bool get_HasHelpshift()
    {
        if(this.helper != 0)
        {
                return this.helper.HasHelpshift;
        }
        
        return this.helper.HasHelpshift;
    }
    public bool get_HasLobby()
    {
        if(this.helper != 0)
        {
                return this.helper.HasLobby;
        }
        
        return this.helper.HasLobby;
    }
    public bool get_HasReferal()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.referal);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Referal()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_Referal(string value)
    {
        this.helper.referal = value;
    }
    public bool get_HasMonolith()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.monolith);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Monolith()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_Monolith(string value)
    {
        this.helper.monolith = value;
    }
    public bool get_HasForestNews()
    {
        if(this.helper != 0)
        {
                return this.helper.HasForestNews;
        }
        
        return this.helper.HasForestNews;
    }
    public bool get_HasPiggyBankRaid()
    {
        if(this.helper != 0)
        {
                return this.helper.HasPiggyBankRaid;
        }
        
        return this.helper.HasPiggyBankRaid;
    }
    public bool get_HasNotificationType()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.notificationType);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_NotificationType()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_NotificationType(string value)
    {
        this.helper.notificationType = value;
    }
    public bool get_HasProfileAction()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.profileAction);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_ProfileAction()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_ProfileAction(string value)
    {
        this.helper.profileAction = value;
    }
    public bool get_HasPromoCode()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.promoCode);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_PromoCode()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_PromoCode(string value)
    {
        this.helper.promoCode = value;
    }
    public bool get_HasOpenUrl()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.<OpenUrl>k__BackingField);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_OpenUrl()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_OpenUrl(string value)
    {
        this.helper.<OpenUrl>k__BackingField = value;
    }
    public bool get_Consumed()
    {
        if(this.helper != 0)
        {
                return (bool)this.helper.consumed;
        }
        
        return (bool)this.helper.consumed;
    }
    public void set_Consumed(bool value)
    {
        this.helper.Consumed = value;
    }
    public bool get_HasHint()
    {
        if(this.helper.hints != 1)
        {
                this.helper.hints + 1 = 1;
        }
        
        return true;
    }
    public int get_Hint()
    {
        if(this.helper != 0)
        {
                return (int)this.helper.hints;
        }
        
        return (int)this.helper.hints;
    }
    public void set_Hint(int value)
    {
        this.helper.hints = value;
    }
    public bool get_HasDailyChallenge()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.dailyChallenge);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_DailyChallenge()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_DailyChallenge(string value)
    {
        this.helper.dailyChallenge = value;
    }
    public bool get_HasInviteCode()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.<inviteCode>k__BackingField);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_InviteCode()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_InviteCode(string value)
    {
        this.helper.<inviteCode>k__BackingField = value;
    }
    public bool get_HasMiniGame()
    {
        if((this.helper.<MiniGame>k__BackingField) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_MiniGame()
    {
        if(this.helper != 0)
        {
                return (int)this.helper.<MiniGame>k__BackingField;
        }
        
        return (int)this.helper.<MiniGame>k__BackingField;
    }
    public void set_MiniGame(int value)
    {
        this.helper.<MiniGame>k__BackingField = value;
    }
    public bool get_HasNoAds()
    {
        if((this.helper.<NoAds>k__BackingField) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_NoAdsDuration()
    {
        if(this.helper != 0)
        {
                return (int)this.helper.<NoAdsDuration>k__BackingField;
        }
        
        return (int)this.helper.<NoAdsDuration>k__BackingField;
    }
    public void set_NoAdsDuration(int value)
    {
        this.helper.<NoAdsDuration>k__BackingField = value;
    }
    public float get_PromoPrice()
    {
        if(this.helper != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_PromoPrice(float value)
    {
        this.helper.promoPrice = R1;
    }
    public bool get_HasPerk()
    {
        if(this.helper.perk != 1)
        {
                this.helper.perk + 1 = 1;
        }
        
        return true;
    }
    public int get_Perk()
    {
        if(this.helper != 0)
        {
                return (int)this.helper.perk;
        }
        
        return (int)this.helper.perk;
    }
    public void set_Perk(int value)
    {
        this.helper.perk = value;
    }
    public int get_PerkDuration()
    {
        if(this.helper != 0)
        {
                return (int)this.helper.perkDuration;
        }
        
        return (int)this.helper.perkDuration;
    }
    public void set_PerkDuration(int value)
    {
        this.helper.perkDuration = value;
    }
    public bool get_HasChallengeFriendCode()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.helper.<challengeFriendCode>k__BackingField);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_ChallengeFriendCode()
    {
        if(this.helper != 0)
        {
                return;
        }
    
    }
    public void set_ChallengeFriendCode(string value)
    {
        this.helper.<challengeFriendCode>k__BackingField = value;
    }
    private static DeeplinkComponent()
    {
        DeeplinkComponent.OnDeeplinkShowScene = 0;
        DeeplinkComponent.HACK_actionString = "";
    }

}
