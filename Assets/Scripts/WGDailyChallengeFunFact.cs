using UnityEngine;
public class WGDailyChallengeFunFact : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image animalIcon;
    private UnityEngine.UI.Text funFactText;
    private DailyChallengeZooTilesConfig zooTilesConfig;
    private const float FLYOUT_DURATION = 3;
    private UnityEngine.Coroutine hideFunFact;
    
    // Methods
    private void OnEnable()
    {
        var val_5;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -102115760, aName:  -1450078832);
        System.Action val_2 = new System.Action(object:  -102115760, method:  new IntPtr(4192826512));
        val_5 = null;
        val_5 = null;
        WGDailyChallengeV2Popup.onMainScreenBtnClicked = null;
        System.Collections.IEnumerator val_3 = this.HideFunFactCoroutine();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -102115760);
        this.hideFunFact = this;
    }
    private void OnDisable()
    {
        var val_2;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -102003760, aName:  -1451370720);
        val_2 = null;
        val_2 = null;
        WGDailyChallengeV2Popup.onMainScreenBtnClicked = 0;
    }
    public void ShowFunFact(ZooTile info)
    {
        this.HideFunFact();
        UnityEngine.Sprite val_1 = this.zooTilesConfig.GetSprite(type:  1, name:  info.name);
        this.animalIcon.sprite = this.zooTilesConfig;
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  true);
    }
    public void HideFunFact()
    {
        if(this.hideFunFact != 0)
        {
                this.StopCoroutine(routine:  this.hideFunFact);
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private System.Collections.IEnumerator HideFunFactCoroutine()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeFunFact.<HideFunFactCoroutine>d__9).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeFunFact.<HideFunFactCoroutine>d__9).__il2cppRuntimeField_10 = this;
    }
    public WGDailyChallengeFunFact()
    {
    
    }

}
