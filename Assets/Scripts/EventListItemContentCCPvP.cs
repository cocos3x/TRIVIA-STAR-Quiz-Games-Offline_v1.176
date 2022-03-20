using UnityEngine;
public class EventListItemContentCCPvP : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Text rightCrownText;
    private UnityEngine.UI.Image playerAvatarImage;
    private UnityEngine.UI.Image aiAvatarImage;
    private UnityEngine.UI.RawImage facebookImage;
    public SLC.Social.AvatarConfig playerAvatarHandler;
    
    // Methods
    public override void SetupSlider(string sliderText, float sliderValue)
    {
        var val_17;
        var val_18;
        int val_19;
        UnityEngine.Sprite val_20;
        this.SetupSlider(sliderText:  sliderText, sliderValue:  sliderValue);
        if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24) >= 1000)
        {
                float val_17 = (float)PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24;
            val_17 = val_17 / 1000f;
            string val_1 = val_17.ToString(format:  -1465186192);
            val_17 = "{0}K";
            string val_2 = System.String.Format(format:  -1465186096, arg0:  -1465150508);
        }
        else
        {
                string val_3 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 24.ToString();
        }
        
        int val_4 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.getOpponentCrowns();
        if(val_4 >= 1000)
        {
                float val_18 = (float)val_4;
            val_18 = val_18 / 1000f;
            string val_5 = val_18.ToString(format:  -1465186192);
            val_18 = "{0}K";
            string val_6 = System.String.Format(format:  -1465186096, arg0:  -1465150512);
        }
        else
        {
                string val_7 = val_4.ToString();
        }
        
        UnityEngine.Sprite val_9 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.playerSprite);
        this.playerAvatarImage.sprite = this.playerAvatarHandler;
        val_19 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.opponentPlayerSprite;
        UnityEngine.Sprite val_11 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  val_19);
        val_20 = this.playerAvatarHandler;
        this.aiAvatarImage.sprite = val_20;
        SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_13 = 0.MyProfile;
        if((System.String.IsNullOrEmpty(value:  2097204)) == true)
        {
                return;
        }
        
        if(8 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1465138464, method:  new IntPtr(2829801760));
        val_19 = null;
        val_19 = new System.Action(object:  -1465138464, method:  new IntPtr(2829803808));
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
        if((-1464981408) == 0)
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
        if((-1464840736) == 0)
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
    public EventListItemContentCCPvP()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
