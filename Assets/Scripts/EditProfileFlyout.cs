using UnityEngine;
public class EditProfileFlyout : MonoBehaviour
{
    // Fields
    private EditProfileAvatarSelectionItem avatarButtonPrefab;
    private UnityEngine.RectTransform gridTransform;
    private UnityEngine.UI.InputField nameChangeInputField;
    private UnityEngine.UI.Button button_close;
    private bool saveChanges;
    private System.Collections.Generic.List<EditProfileAvatarSelectionItem> avatarSelectionItems;
    
    // Methods
    private void Awake()
    {
        var val_12;
        System.Action<EditProfileAvatarSelectionItem> val_13;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1720237056, method:  new IntPtr(2574663232));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -1720237056, method:  new IntPtr(2574672448));
        this.nameChangeInputField.m_OnValueChanged.AddListener(call:  162353152);
        this.nameChangeInputField.text = 1098586544;
        UnityEngine.GameObject val_3 = this.nameChangeInputField.m_Placeholder.gameObject;
        object val_4 = this.nameChangeInputField.m_Placeholder.GetComponent<System.Object>();
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_6 = 0.MyProfile;
        this.OnInputUpdated(newValue:  1098586544);
        val_12 = 0;
        goto label_14;
        label_26:
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  this.avatarButtonPrefab, parent:  this.gridTransform);
        if(this.avatarButtonPrefab != 0)
        {
                this.avatarButtonPrefab.Setup(avatarId:  0);
        }
        else
        {
                this.avatarButtonPrefab.Setup(avatarId:  0);
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1720237056, method:  new IntPtr(2574699072));
        System.Delegate val_9 = System.Delegate.Combine(a:  this.avatarButtonPrefab.OnAvatarSelection, b:  7401472);
        val_13 = this.avatarButtonPrefab.OnAvatarSelection;
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        val_13 = 0;
        label_21:
        this.avatarButtonPrefab.OnAvatarSelection = val_13;
        this.avatarSelectionItems.Add(item:  this.avatarButtonPrefab);
        val_12 = 1;
        label_14:
        SLC.Social.AvatarConfig val_10 = SLC.Social.Leagues.LeaguesUIManager.memberAvatarHandler;
        if(val_12 < 0.AvatarSpritesCount)
        {
            goto label_26;
        }
        
        this.RefreshAvatars();
    }
    private void OnInputUpdated(string newValue)
    {
        if(newValue.m_stringLength < 1)
        {
                return;
        }
        
        this.ConfirmNameChange();
    }
    private void ConfirmNameChange()
    {
        ulong val_14;
        string val_16;
        var val_17;
        var val_18;
        int val_19;
        var val_20;
        var val_21;
        val_16 = this.nameChangeInputField.m_Text;
        string val_1 = val_16.ToLower();
        val_17 = 0;
        if((Objectionable.Valid(words:  val_16)) != true)
        {
                string val_3 = val_16.ToLower();
            string val_4 = Objectionable.FoundObjectionable(words:  val_16);
            string val_5 = System.Text.RegularExpressions.Regex.Replace(input:  val_16, pattern:  val_16, replacement:  1098586544, options:  1);
            val_16 = val_16;
        }
        
        val_18 = 0;
        goto label_11;
        label_13:
        if(val_17 >= this.nameChangeInputField.m_Text.m_stringLength)
        {
            goto label_12;
        }
        
        label_14:
        val_17 = 1;
        if(val_16.Chars[0] == ' ')
        {
                val_18 = 1;
        }
        
        label_11:
        if(val_16 == null)
        {
            goto label_13;
        }
        
        val_19 = this.nameChangeInputField.m_Text.m_stringLength;
        if(val_17 < val_19)
        {
            goto label_14;
        }
        
        goto label_15;
        label_12:
        val_19 = 0;
        label_15:
        if(val_18 == val_19)
        {
                return;
        }
        
        val_18 = 1152921505048485888;
        SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_8 = 0.MyProfile;
        val_17 = 0;
        if((val_17.Equals(value:  val_16)) == true)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_11 = 0.MyProfile;
        val_17 = 0;
        mem[12] = val_16;
        this.saveChanges = true;
        Player val_12 = App.Player;
        val_20 = 2621448;
        if(val_20 != 0)
        {
                val_21 = 23;
        }
        else
        {
                val_20 = 368;
            val_21 = 0;
        }
        
        mem[368] = 1;
        System.DateTime val_13 = ServerHandler.ServerTime;
        SLC.Social.Leagues.LeaguesTracker.LastNameChange = new System.DateTime() {dateData = val_14};
    }
    private void OnAvatarClicked(EditProfileAvatarSelectionItem selectedItem)
    {
        int val_7;
        var val_8;
        val_7 = selectedItem.thisAvatarId;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        if(83886592 == val_7)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_4 = 0.MyProfile;
        mem[36] = val_7;
        this.saveChanges = true;
        Player val_5 = App.Player;
        val_8 = 2621448;
        if(val_8 != 0)
        {
                val_7 = 35144012;
        }
        else
        {
                val_8 = 364;
            val_7 = 0;
        }
        
        mem[364] = 1;
        System.DateTime val_6 = ServerHandler.ServerTime;
        SLC.Social.Leagues.LeaguesTracker.LastAvatarChange = new System.DateTime();
        this.RefreshAvatars();
    }
    private void RefreshAvatars()
    {
        var val_1 = 0;
        goto label_1;
        label_6:
        if(true <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + 0;
        (0 + 0) + 16.Refresh();
        val_1 = 1;
        label_1:
        if(val_1 < ((0 + 0) + 16))
        {
            goto label_6;
        }
    
    }
    private void SaveChanges()
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateMyProfileInfo(force:  true);
    }
    private void Close()
    {
        if(this.saveChanges == true)
        {
                this.saveChanges.SaveChanges();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1719470848, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public EditProfileFlyout()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.avatarSelectionItems = null;
    }

}
