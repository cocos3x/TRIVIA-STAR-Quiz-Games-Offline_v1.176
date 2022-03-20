using UnityEngine;
public class EditProfileAvatarSelectionItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Image avatarImage;
    private UnityEngine.GameObject selectedAvatarIdentifier;
    private int thisAvatarId;
    public System.Action<EditProfileAvatarSelectionItem> OnAvatarSelection;
    
    // Properties
    public int AvatarId { get; }
    
    // Methods
    public int get_AvatarId()
    {
        return (int)this.thisAvatarId;
    }
    private void Awake()
    {
    
    }
    public void Setup(int avatarId)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        string val_2 = avatarId.ToString();
        string val_3 = -1727467200(-1727467200) + -1721244412(-1721244412);
        this.name = -1727467200;
        this.thisAvatarId = avatarId;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1721232384, method:  new IntPtr(2573705792));
        this.button.m_OnClick.AddListener(call:  162246656);
        SLC.Social.AvatarConfig val_5 = SLC.Social.Leagues.LeaguesUIManager.memberAvatarHandler;
        UnityEngine.Sprite val_6 = 0.GetAvatarSpriteByID(id:  avatarId);
        this.avatarImage.sprite = 0;
    }
    public void Refresh()
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        this.selectedAvatarIdentifier.SetActive(value:  (83886592 - this.thisAvatarId) >> 5);
    }
    private void OnAvatarClicked()
    {
        if(this.OnAvatarSelection == 0)
        {
                return;
        }
        
        this.OnAvatarSelection.Invoke(obj:  -1720982784);
    }
    public EditProfileAvatarSelectionItem()
    {
        this.thisAvatarId = 0;
    }

}
