using UnityEngine;
public class LetterBankMemberGridItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button mainButton;
    private UnityEngine.UI.Text text_rank;
    private AvatarSlotUGUI memberAvatar;
    private UnityEngine.UI.Text text_memberName;
    private UnityEngine.UI.Text text_winnings;
    private UnityEngine.GameObject background_me;
    private UnityEngine.GameObject background_others;
    private UnityEngine.UI.Image image_goldenTicket;
    private UnityEngine.Sprite hasGT;
    private UnityEngine.Sprite noGT;
    private UnityEngine.UI.Text text_leadership;
    private SLC.Social.Profile profile;
    private System.Action<int> onClickAction;
    private LetterBankMembersListView _ListViewParent;
    
    // Properties
    private LetterBankMembersListView ListViewParent { get; }
    
    // Methods
    private LetterBankMembersListView get_ListViewParent()
    {
        if(this._ListViewParent != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        object val_3 = this.GetComponentInParent<System.Object>();
        this._ListViewParent = this;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1331329920, method:  new IntPtr(2963612352));
        this.mainButton.m_OnClick.AddListener(call:  162246656);
    }
    public void UpdateUIFromMember(SLC.Social.Profile memberProfile, int rankIndex, int rankedWinnings, System.Action<int> clickAction, bool isMe = False)
    {
        var val_8;
        var val_9;
        val_8 = rankIndex;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_9 = this;
        if(memberProfile != 0)
        {
                this.SetActive(value:  true);
            this.profile = memberProfile;
            string val_3 = val_8 + 1.ToString();
            string val_4 = rankedWinnings.ToString();
            this.onClickAction = clickAction;
            this.background_me.SetActive(value:  isMe);
            this.background_others.SetActive(value:  isMe ^ 1);
            if(this.image_goldenTicket != 0)
        {
                if(memberProfile.hasSubscriptionActive == false)
        {
                this.background_others = this.noGT;
        }
        
            if(memberProfile.hasSubscriptionActive == true)
        {
                this.background_others = this.hasGT;
        }
        
            this.image_goldenTicket.sprite = this.background_others;
        }
        
            UnityEngine.GameObject val_7 = this.text_leadership.gameObject;
            val_8 = this.text_leadership;
            val_9 = 1;
            if(memberProfile.GuildMaster != true)
        {
                if(memberProfile.Officer == true)
        {
                val_9 = 1;
        }
        
        }
        
            val_8.SetActive(value:  true);
            if(memberProfile.GuildMaster == false)
        {
                "LEADER" = "CO-LEADER";
        }
        
            if(this.text_leadership != 0)
        {
                return;
        }
        
            return;
        }
        
        this.SetActive(value:  false);
    }
    private void OnClick()
    {
        if(this.onClickAction == 0)
        {
                return;
        }
        
        this.onClickAction.Invoke(obj:  this.profile.ServerId);
    }
    private void ScrollCellIndex(int index)
    {
        LetterBankMembersListView val_1 = this.ListViewParent;
        this.SetupGridItem(memberGridItem:  -1330829904, itemIndex:  index);
    }
    public LetterBankMemberGridItem()
    {
    
    }

}
