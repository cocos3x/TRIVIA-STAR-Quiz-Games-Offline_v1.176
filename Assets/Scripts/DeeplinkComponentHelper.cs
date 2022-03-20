using UnityEngine;
public class DeeplinkComponentHelper
{
    // Fields
    public const string WallpostNotificationType = "1001";
    public const int CurrentGiftVersion = 5;
    public const float DefaultPromoPrice = 1.99;
    private const int DefaultPromoDuration = 60;
    private const int DefaultPerk = -1;
    private const int DefaultPerkDuration = 60;
    private const string WallPostAction = "wallpost";
    private const string KGift = "v";
    private const string KOneTime = "onetimekey";
    private const string KExpires = "expires";
    private const string KReferal = "ref";
    private const string KPromo = "promo";
    private const string KPromoPrice = "promo_price";
    private const string KPromoDuration = "promo_duration";
    private const string KPerk = "perk";
    private const string KHint = "hint";
    private const string KDailyChallenge = "daily_challenge";
    private const string KPerkDuration = "perk_duration";
    private const string KRPN = "rpn";
    private const string KScene = "scene";
    private const string KNotificationType = "notification_type";
    private const string KCredits = "credits";
    private const string KTickets = "tickets";
    private const string KMonolith = "monolith";
    private const string KTEncoded = "encoded";
    private const string KTSource = "source";
    private const string KTDeeplinkData = "deeplink data";
    private const string KTCampaignType = "campaign_type";
    private const string KPromoCode = "promo_code";
    private const string KInviteCode = "a";
    private const string KMiniGame = "mini_game";
    private const string KUrl = "url";
    private const string KNoAds = "no_ads";
    private const string KNoAdsEnd = "no_ads_end";
    public const string KChallengeFriend = "challenge_friend";
    private System.Collections.Generic.Dictionary<string, DeeplinkAction> actionDictionary;
    private System.Collections.Generic.Dictionary<string, object> json;
    private string referal;
    private float promoPrice;
    private int promoDuration;
    private int perk;
    private int hints;
    private string dailyChallenge;
    private int perkDuration;
    private string notificationType;
    private string scene;
    private string profileAction;
    private System.Collections.Generic.List<ConsumableAmountPair> currentRewards;
    private string monolith;
    private string promoCode;
    private string currentDeeplinkAction;
    private string <OpenUrl>k__BackingField;
    private string <inviteCode>k__BackingField;
    private int <MiniGame>k__BackingField;
    private int <NoAds>k__BackingField;
    private int <NoAdsDuration>k__BackingField;
    private string <challengeFriendCode>k__BackingField;
    private static System.Collections.Generic.Dictionary<string, object> cachedTrackingData;
    private bool consumed;
    
    // Properties
    public bool HasReferal { get; }
    public string Referal { get; set; }
    public float PromoPrice { get; set; }
    public int PromoDuration { get; }
    public bool HasPerk { get; }
    public int Perk { get; set; }
    public bool HasHint { get; }
    public int Hint { get; set; }
    public bool HasDailyChallenge { get; }
    public string DailyChallenge { get; set; }
    public int PerkDuration { get; set; }
    public bool HasNotificationType { get; }
    public string NotificationType { get; set; }
    public bool HasScene { get; }
    public string Scene { get; set; }
    public bool HasHelpshift { get; }
    public bool HasLobby { get; }
    public bool HasProfileAction { get; }
    public string ProfileAction { get; set; }
    public bool HasCurrentRewards { get; }
    public System.Collections.Generic.List<ConsumableAmountPair> CurrentRewards { get; set; }
    public bool HasMonolith { get; }
    public string Monolith { get; set; }
    public bool HasForestNews { get; }
    public bool HasPiggyBankRaid { get; }
    public string PromoCode { get; set; }
    public string OpenUrl { get; set; }
    public string inviteCode { get; set; }
    public int MiniGame { get; set; }
    public int NoAds { get; set; }
    public int NoAdsDuration { get; set; }
    public string challengeFriendCode { get; set; }
    public bool Consumed { get; set; }
    public bool IsValidJSON { get; }
    public string GiftVersion { get; }
    public bool HasOneTimeKey { get; }
    public bool HasExpired { get; }
    
    // Methods
    public bool get_HasReferal()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.referal);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Referal()
    {
    
    }
    public void set_Referal(string value)
    {
        this.referal = value;
    }
    public float get_PromoPrice()
    {
        return (float)S0;
    }
    public void set_PromoPrice(float value)
    {
        this.promoPrice = ;
    }
    public int get_PromoDuration()
    {
        return (int)this.promoDuration;
    }
    public bool get_HasPerk()
    {
        if(this.perk != 1)
        {
                this.perk + 1 = 1;
        }
        
        return true;
    }
    public int get_Perk()
    {
        return (int)this.perk;
    }
    public void set_Perk(int value)
    {
        this.perk = value;
    }
    public bool get_HasHint()
    {
        if(this.hints != 1)
        {
                this.hints + 1 = 1;
        }
        
        return true;
    }
    public int get_Hint()
    {
        return (int)this.hints;
    }
    public void set_Hint(int value)
    {
        this.hints = value;
    }
    public bool get_HasDailyChallenge()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.dailyChallenge);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_DailyChallenge()
    {
    
    }
    public void set_DailyChallenge(string value)
    {
        this.dailyChallenge = value;
    }
    public int get_PerkDuration()
    {
        return (int)this.perkDuration;
    }
    public void set_PerkDuration(int value)
    {
        this.perkDuration = value;
    }
    public bool get_HasNotificationType()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.notificationType);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_NotificationType()
    {
    
    }
    public void set_NotificationType(string value)
    {
        this.notificationType = value;
    }
    public bool get_HasScene()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.scene);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Scene()
    {
    
    }
    public void set_Scene(string value)
    {
        this.scene = value;
    }
    public bool get_HasHelpshift()
    {
        if((System.String.IsNullOrEmpty(value:  this.notificationType)) != false)
        {
                return false;
        }
        
        if(this.notificationType != null)
        {
                return this.notificationType.Equals(value:  -1957517584);
        }
        
        return this.notificationType.Equals(value:  -1957517584);
    }
    public bool get_HasLobby()
    {
        if((System.String.IsNullOrEmpty(value:  this.notificationType)) != false)
        {
                return false;
        }
        
        if(this.notificationType != null)
        {
                return this.notificationType.Equals(value:  -1957389104);
        }
        
        return this.notificationType.Equals(value:  -1957389104);
    }
    public bool get_HasProfileAction()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.profileAction);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_ProfileAction()
    {
    
    }
    public void set_ProfileAction(string value)
    {
        this.profileAction = value;
    }
    public bool get_HasCurrentRewards()
    {
        if(this.currentRewards == 0)
        {
                return false;
        }
        
        if(R1 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.List<ConsumableAmountPair> get_CurrentRewards()
    {
    
    }
    public void set_CurrentRewards(System.Collections.Generic.List<ConsumableAmountPair> value)
    {
        this.currentRewards = value;
    }
    public bool get_HasMonolith()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.monolith);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public string get_Monolith()
    {
    
    }
    public void set_Monolith(string value)
    {
        this.monolith = value;
    }
    public bool get_HasForestNews()
    {
        if((System.String.IsNullOrEmpty(value:  this.notificationType)) != false)
        {
                return false;
        }
        
        if(this.notificationType != null)
        {
                return this.notificationType.Equals(value:  -1956178912);
        }
        
        return this.notificationType.Equals(value:  -1956178912);
    }
    public bool get_HasPiggyBankRaid()
    {
        if((System.String.IsNullOrEmpty(value:  this.notificationType)) != false)
        {
                return false;
        }
        
        if(this.notificationType != null)
        {
                return this.notificationType.Equals(value:  -1956050416);
        }
        
        return this.notificationType.Equals(value:  -1956050416);
    }
    public string get_PromoCode()
    {
    
    }
    public void set_PromoCode(string value)
    {
        this.promoCode = value;
    }
    public string get_OpenUrl()
    {
    
    }
    public void set_OpenUrl(string value)
    {
        this.<OpenUrl>k__BackingField = value;
    }
    public string get_inviteCode()
    {
    
    }
    public void set_inviteCode(string value)
    {
        this.<inviteCode>k__BackingField = value;
    }
    public int get_MiniGame()
    {
        return (int)this.<MiniGame>k__BackingField;
    }
    public void set_MiniGame(int value)
    {
        this.<MiniGame>k__BackingField = value;
    }
    public int get_NoAds()
    {
        return (int)this.<NoAds>k__BackingField;
    }
    public void set_NoAds(int value)
    {
        this.<NoAds>k__BackingField = value;
    }
    public int get_NoAdsDuration()
    {
        return (int)this.<NoAdsDuration>k__BackingField;
    }
    public void set_NoAdsDuration(int value)
    {
        this.<NoAdsDuration>k__BackingField = value;
    }
    public string get_challengeFriendCode()
    {
    
    }
    public void set_challengeFriendCode(string value)
    {
        this.<challengeFriendCode>k__BackingField = value;
    }
    public DeeplinkComponentHelper()
    {
        this.promoPrice = 1.99f;
        this.promoDuration = 60;
        this.perk = 0;
        this.hints = 0;
        this.perkDuration = 60;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.actionDictionary = null;
    }
    public bool get_Consumed()
    {
        return (bool)this.consumed;
    }
    public void set_Consumed(bool value)
    {
        bool val_3 = this.consumed;
        val_3 = val_3 >> 5;
        if(val_3 != value)
        {
                return;
        }
        
        this.consumed = value;
        if(value == true)
        {
                value = this.currentDeeplinkAction;
        }
        
        if(value == null)
        {
                return;
        }
        
        DeeplinkAction val_1 = this.actionDictionary.Item[value];
        DeeplinkPlugin.NotifyActionConsumed(identifier:  this.actionDictionary);
        bool val_2 = this.actionDictionary.Remove(key:  this.currentDeeplinkAction);
        this.currentDeeplinkAction = 0;
    }
    public void Cleanup()
    {
        if(this.consumed == false)
        {
                return;
        }
        
        this.notificationType = 0;
        this.scene = 0;
        this.monolith = 0;
        this.promoCode = 0;
        this.json = 0;
        this.referal = 0;
        this.promoPrice = 1.99f;
        this.promoDuration = 60;
        this.perk = 0;
        this.<MiniGame>k__BackingField = 0;
        this.<NoAds>k__BackingField = 0;
        this.<NoAdsDuration>k__BackingField = 0;
    }
    public bool get_IsValidJSON()
    {
        if(this.json != 0)
        {
                this.json = 1;
        }
        
        return true;
    }
    public void EnqueueAction(DeeplinkAction action, DeeplinkSource source)
    {
        System.Collections.Generic.Dictionary<System.String, DeeplinkAction> val_2;
        string val_3;
        val_2 = this.actionDictionary;
        val_3 = action.identifier;
        if((val_2.ContainsKey(key:  val_3)) == true)
        {
                return;
        }
        
        val_3 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        action.source = val_3;
        val_2 = action.identifier;
        this.actionDictionary.Add(key:  val_2, value:  action);
    }
    public bool DequeueAction()
    {
        string val_3;
        var val_4;
        var val_5;
        string val_6;
        var val_7;
        val_4 = 0;
        if(this.currentDeeplinkAction != null)
        {
                return (bool)val_4;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = val_4.GetEnumerator();
        val_5 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_3;
        }
        
        val_6 = val_3;
        val_7 = 1;
        if(0 == 1)
        {
            goto label_8;
        }
        
        if(this.consumed == true)
        {
                this.consumed = false;
            this.consumed = this.consumed;
        }
        
        mem[8] = 1;
        this.currentDeeplinkAction = val_6;
        val_6 = 1;
        val_7 = 1;
        this.DeserializeJson(serializedJson:  1, source:  52, encodedJson:  2621443);
        val_5 = 1;
        goto label_8;
        label_3:
        val_7 = 0;
        label_8:
        val_4.Dispose();
        val_4 = val_5 & val_7;
        return (bool)val_4;
    }
    public void DeserializeJson(string serializedJson, string source, string encodedJson)
    {
        var val_63;
        string val_64;
        val_63 = source;
        val_64 = serializedJson;
        this.Cleanup();
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                string val_3 = -1953385600(-1953385600) + val_64;
            UnityEngine.Debug.Log(message:  -1953385600);
        }
        
        object val_4 = MiniJSON.Json.Deserialize(json:  val_64);
        this.json = 0;
        this.Consumed = true;
    }
    public string get_GiftVersion()
    {
        if(this.json == 0)
        {
                return;
        }
        
        if((this.HasKey(key:  -1953212128, dict:  this.json)) == false)
        {
                return;
        }
        
        object val_2 = this.json.Item[-1953212128];
        string val_3 = this.json.ToString();
    }
    public bool get_HasOneTimeKey()
    {
        var val_7 = 0;
        if(this.json == 0)
        {
                return (bool)val_7;
        }
        
        if((this.HasKey(key:  -1953083664, dict:  this.json)) == false)
        {
                return (bool)val_7;
        }
        
        object val_2 = this.json.Item[-1953083664];
        string val_3 = this.json.ToString();
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1953079472, defaultValue:  1098586544);
        val_7 = 1;
        if((Contains(value:  this.json)) == true)
        {
                return (bool)val_7;
        }
        
        string val_6 = System.String.Format(format:  -1953079376, arg0:  -1953079472, arg1:  this.json);
        UnityEngine.PlayerPrefs.SetString(key:  -1953079472, value:  -1953079376);
        val_7 = 0;
        return (bool)val_7;
    }
    public bool get_HasExpired()
    {
        ulong val_8;
        ulong val_10;
        if(this.json == 0)
        {
                return (bool)0;
        }
        
        if((this.HasKey(key:  -1952954992, dict:  this.json)) == false)
        {
                return (bool)0;
        }
        
        object val_2 = this.json.Item[-1952954992];
        string val_3 = this.json.ToString();
        int val_4 = System.Int32.Parse(s:  this.json);
        System.DateTime val_5 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
        System.DateTime val_6 = System.DateTime.UtcNow;
        System.DateTime val_7 = AddSeconds(value:  null);
        0 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
        return (bool)0;
    }
    private void CacheTrackingData(string dataJson, string source, string base64EncodedJson)
    {
        WordPets.WPTPetTile val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = source;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1952818320, value:  base64EncodedJson);
        }
        else
        {
                Add(key:  -1952818320, value:  base64EncodedJson);
        }
        
        Add(key:  1392732736, value:  val_6);
        Add(key:  -1952818224, value:  dataJson);
        val_7 = null;
        val_7 = null;
        DeeplinkComponentHelper.cachedTrackingData = null;
        if(this.json == 0)
        {
                return;
        }
        
        if((DeeplinkComponentHelper.cachedTrackingData.HasKey(key:  1392732736, dict:  this.json)) != false)
        {
                val_8 = null;
            val_8 = null;
            object val_3 = this.json.Item[1392732736];
            set_Item(key:  1392732736, value:  this.json);
        }
        
        if(this.json == 0)
        {
                return;
        }
        
        val_6 = "campaign_type";
        if((HasKey(key:  -1952805840, dict:  this.json)) == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        object val_5 = this.json.Item[-1952805840];
        set_Item(key:  -1952805840, value:  this.json);
    }
    public void TrackDeeplinkParsed()
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = null;
        val_1 = null;
        if(DeeplinkComponentHelper.cachedTrackingData == 0)
        {
                return;
        }
        
        var val_1 = 21403090;
        val_1 = 14222448 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        App.trackerManager.track(eventName:  -1952660976, data:  DeeplinkComponentHelper.cachedTrackingData);
        DeeplinkComponentHelper.cachedTrackingData = 0;
    }
    private bool HasKey(string key)
    {
        if(this.json == 0)
        {
                this = 0;
            return (bool)this;
        }
        
        return this.HasKey(key:  key, dict:  this.json);
    }
    private bool HasKey(string key, System.Collections.Generic.Dictionary<string, object> dict)
    {
        if((dict.ContainsKey(key:  key)) == false)
        {
                return false;
        }
        
        object val_2 = dict.Item[key];
        string val_3 = dict.ToString();
        bool val_4 = System.String.IsNullOrEmpty(value:  dict);
        val_4 = val_4 ^ 1;
        return (bool)val_4;
    }
    private int ParseInt(string sInt)
    {
        return System.Int32.Parse(s:  sInt, style:  511);
    }
    private static DeeplinkComponentHelper()
    {
    
    }

}
