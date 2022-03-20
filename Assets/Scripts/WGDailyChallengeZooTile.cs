using UnityEngine;
public class WGDailyChallengeZooTile : MonoBehaviour
{
    // Fields
    private TMPro.TMP_Text animalName;
    private UnityEngine.UI.Image animal;
    private UnityEngine.Sprite tileBackground;
    private UnityEngine.UI.Image lockOverlay;
    private UnityEngine.GameObject lockIcon;
    private UnityEngine.UI.Text comingSoonText;
    private UnityEngine.GameObject requiredStarsGroup;
    private UnityEngine.UI.Text requiredStars;
    private UnityEngine.UI.Button tileBtn;
    private WGDailyChallengeFunFact funFact;
    private DailyChallengeZooTilesConfig zooTilesConfig;
    public ZooTile tile;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -62434672, method:  new IntPtr(4232507600));
        this.tileBtn.m_OnClick.AddListener(call:  162246656);
    }
    private void OnTileClicked()
    {
        this.funFact.ShowFunFact(info:  this.tile);
    }
    public void Setup(int lockCompValue, bool isMonthTileInCollection = False)
    {
        string val_11;
        var val_12;
        if(this.tile == 0)
        {
            goto label_1;
        }
        
        string val_1 = this.tile.name.ToLower();
        string val_2 = this.tile.name + -1670756832(-1670756832);
        string val_3 = this.tile.name.ToUpper();
        string val_4 = Localization.Localize(key:  this.tile.name, defaultValue:  this.tile.name, useSingularKey:  false);
        string val_5 = this.tile.requiredStars.ToString();
        val_11 = this.tile.name;
        UnityEngine.Sprite val_6 = this.zooTilesConfig.GetSprite(type:  0, name:  val_11);
        this.animal.sprite = this.zooTilesConfig;
        val_12 = 1;
        if(isMonthTileInCollection == true)
        {
            goto label_13;
        }
        
        if(this.tile.requiredStars <= lockCompValue)
        {
                val_12 = 1;
        }
        
        goto label_13;
        label_1:
        this.requiredStarsGroup.SetActive(value:  false);
        this.lockIcon.SetActive(value:  false);
        this.animal.sprite = this.tileBackground;
        string val_7 = Localization.Localize(key:  -62140368, defaultValue:  -62140464, useSingularKey:  false);
        val_11 = "coming_soon_upper";
        val_12 = 0;
        UnityEngine.GameObject val_8 = this.comingSoonText.gameObject;
        this.comingSoonText.SetActive(value:  true);
        label_13:
        UnityEngine.GameObject val_9 = this.lockOverlay.gameObject;
        this.lockOverlay.SetActive(value:  val_12 ^ 1);
        UnityEngine.GameObject val_11 = this.animalName.gameObject;
        this.animalName.SetActive(value:  false);
        this.tileBtn.interactable = false;
    }
    public WGDailyChallengeZooTile()
    {
        ZooTile val_1 = new ZooTile(name:  -61925856, requiredStars:  200, funFact:  -61925776);
        this.tile = null;
    }

}
