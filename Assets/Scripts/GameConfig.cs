using UnityEngine;
public class GameConfig : ScriptableObject
{
    // Fields
    public string vip_email;
    public string termsOfServiceURL;
    public string privacyPolicyUrl;
    public string facebookRecommenderUrl;
    public string recommenderUrl;
    public string adjustInviteUrl;
    public string twitterInviteURL;
    public string facebookViralText;
    public string twitterViralText;
    public string pinterestViralText;
    public string smsViralText;
    public string emailSubjectViralText;
    public string emailBodyViralText;
    public string appIndexDescription;
    public bool socialEnabled;
    public bool themesEnabled;
    public Themes[] allowedThemes;
    
    // Methods
    public GameConfig()
    {
        this.vip_email = "VIP Support Email";
        this.termsOfServiceURL = "https://www.superluckycasino.com/terms_of_service";
        this.appIndexDescription = "";
        typeof(Themes[]).__il2cppRuntimeField_10 = 1;
        this.allowedThemes = null;
    }

}
