using UnityEngine;
public class WGZooTileRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image tileImage;
    private UnityEngine.UI.Text tileName;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button collectButton;
    private DailyChallengeZooTilesConfig zooTilesConfig;
    public System.Action OnZooTileRewardCollected;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  88502864, method:  new IntPtr(88477840));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(ZooTile tile)
    {
        UnityEngine.Sprite val_1 = this.zooTilesConfig.GetSprite(type:  1, name:  tile.name);
        this.tileImage.sprite = this.zooTilesConfig;
        string val_2 = Localization.Localize(key:  88627904, defaultValue:  88627728, useSingularKey:  false);
        string val_3 = tile.name.ToUpper();
        string val_4 = System.String.Format(format:  88627904, arg0:  tile.name);
        if(this.description == 0)
        {
            
        }
    
    }
    private void OnRewardCollected()
    {
        if(this.OnZooTileRewardCollected != 0)
        {
                this.OnZooTileRewardCollected.Invoke();
        }
        
        this.Close();
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGZooTileRewardPopup()
    {
    
    }

}
