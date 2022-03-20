using UnityEngine;
[Serializable]
public class AndroidConfig : ProductConfig
{
    // Fields
    public const string GCM_SENDER_ID = "769681372589";
    public string fcmSenderId;
    public string loadingDialogTitle;
    public string loadingDialogMessage;
    public string loadingDialogCurrency;
    public string supportUrl;
    public string supportText;
    public string androidPlatform;
    public string leaderboardId;
    public string googlePlayKey;
    public string cloudzillaKey;
    public string displayName;
    public string[] pushNotificationsIcons;
    
    // Methods
    public AndroidConfig()
    {
        this.fcmSenderId = "408088123253";
        this.loadingDialogTitle = "TODO-SET-THIS";
        this.supportText = "Support text stuff";
        this.androidPlatform = "google|kindle";
        this.leaderboardId = "CgkIm-eQjsIaEAIQBg";
        typeof(System.String[]).__il2cppRuntimeField_10 = "Assets/Game/UI/WordAddict/Icons/24a.png";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Assets/Game/UI/WordAddict/Icons/32a.png";
        this.pushNotificationsIcons = null;
    }

}
