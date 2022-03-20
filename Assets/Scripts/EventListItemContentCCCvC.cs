using UnityEngine;
public class EventListItemContentCCCvC : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Text rightCrownText;
    private UnityEngine.UI.Image playerClubImage;
    private UnityEngine.UI.Image aiAvatarImage;
    private UnityEngine.UI.Image playerCrown;
    private UnityEngine.UI.Image aiCrown;
    public SLC.Social.AvatarConfig playerAvatarHandler;
    
    // Methods
    public override void SetupSlider(string sliderText, float sliderValue)
    {
        var val_34;
        float val_35;
        SLC.Social.AvatarConfig val_36;
        UnityEngine.Sprite val_37;
        int val_38;
        var val_39;
        var val_41;
        this.SetupSlider(sliderText:  sliderText, sliderValue:  sliderValue);
        val_34 = 35631176;
        val_35 = 1152921504919678976;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 52) <= 1)
        {
                ClubClashEvent.LAST_PROGRESS_STAMP_KEY.__unknownFiledOffset_34 = UnityEngine.Random.Range(min:  0, max:  this.playerAvatarHandler.AvatarSpritesCount);
            ClubClashEvent.LAST_PROGRESS_STAMP_KEY.__unknownFiledOffset_38 = UnityEngine.Random.Range(min:  0, max:  this.playerAvatarHandler.AvatarSpritesCount);
        }
        
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
            goto label_12;
        }
        
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36) == 0)
        {
            goto label_15;
        }
        
        string val_6 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1471390128];
        if((System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36, result: out  int val_7 = -1465480152)) != true)
        {
                UnityEngine.Debug.LogWarning(message:  -1467947280);
        }
        
        val_36 = this.playerAvatarHandler;
        string val_9 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1468287760];
        ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        UnityEngine.Sprite val_10 = val_36.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36);
        val_37 = val_36;
        if(this.aiAvatarImage != 0)
        {
            goto label_24;
        }
        
        goto label_24;
        label_12:
        UnityEngine.GameObject val_11 = this.playerCrown.gameObject;
        this.playerCrown.SetActive(value:  false);
        UnityEngine.GameObject val_12 = this.aiCrown.gameObject;
        this.aiCrown.SetActive(value:  false);
        UnityEngine.GameObject val_13 = this.rightCrownText.gameObject;
        this.rightCrownText.SetActive(value:  false);
        UnityEngine.GameObject val_14 = this.rightCrownText.gameObject;
        this.rightCrownText.SetActive(value:  false);
        UnityEngine.Sprite val_15 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 52);
        this.playerClubImage.sprite = this.playerAvatarHandler;
        val_38 = mem[ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 56];
        val_38 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 56;
        UnityEngine.Sprite val_16 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  val_38);
        this.aiAvatarImage.sprite = this.playerAvatarHandler;
        return;
        label_15:
        UnityEngine.Sprite val_17 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 56);
        val_37 = this.playerAvatarHandler;
        label_24:
        this.aiAvatarImage.sprite = val_37;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28) < 1000)
        {
                string val_18 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28.ToString();
            val_39;
        }
        else
        {
                decimal val_19 = System.Decimal.op_Implicit(value:  -1465480176);
            decimal val_20 = new System.Decimal(value:  1000);
            val_36 = val_20.flags;
            string val_21 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_36, hi = val_20.hi, lo = val_20.lo, mid = val_20.mid}, useRichText:  false, withSpaces:  false);
            val_39 = R0;
            val_34 = 35631176;
            val_35 = 1152921504919678976;
        }
        
        string val_22 = ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36.Item[-1471390128];
        bool val_24 = System.Int32.TryParse(s:  ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 36, result: out  int val_23 = -1465480160);
        if(0 < 1000)
        {
                string val_25 = 0.ToString();
            val_41;
        }
        else
        {
                decimal val_26 = System.Decimal.op_Implicit(value:  -1465480176);
            decimal val_27 = new System.Decimal(value:  1000);
            val_36 = val_27.flags;
            string val_28 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_36, hi = val_27.hi, lo = val_27.lo, mid = val_27.mid}, useRichText:  false, withSpaces:  false);
            val_41 = R0;
            val_35 = 1152921504919678976;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_29 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_30 = 0.MyGuild;
        UnityEngine.Sprite val_31 = this.playerAvatarHandler.GetAvatarSpriteByID(id:  0);
        this.playerClubImage.sprite = this.playerAvatarHandler;
        UnityEngine.GameObject val_32 = this.playerCrown.gameObject;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28) >= 0)
        {
                0 = 1;
        }
        
        this.playerCrown.SetActive(value:  true);
        UnityEngine.GameObject val_33 = this.aiCrown.gameObject;
        val_38 = 0;
        if((ClubClashEvent.LAST_PROGRESS_STAMP_KEY + 28) < val_38)
        {
                0 = 1;
        }
        
        this.aiCrown.SetActive(value:  true);
    }
    public EventListItemContentCCCvC()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
