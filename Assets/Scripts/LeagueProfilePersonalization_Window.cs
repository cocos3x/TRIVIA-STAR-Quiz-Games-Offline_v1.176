using UnityEngine;
public class LeagueProfilePersonalization_Window : MonoBehaviour
{
    // Fields
    public System.Action onCloseAction;
    private UnityEngine.GameObject changeNameWindow;
    private UnityEngine.GameObject changeImageWindow;
    private UnityEngine.GameObject avatarButtonPrefab;
    private UnityEngine.UI.InputField nameChangeInputField;
    private UnityEngine.RectTransform gridTransform;
    private UnityEngine.UI.Button confirmNameButton;
    private UnityEngine.UI.Button randomNameButton;
    private UnityEngine.UI.Button nameCloseButton;
    private UnityEngine.UI.Button avatarCloseButton;
    private bool randomName;
    
    // Methods
    public void ShowAvatarWindow()
    {
        UnityEngine.Events.UnityAction val_16;
        var val_17;
        this.changeNameWindow.SetActive(value:  false);
        this.changeImageWindow.SetActive(value:  true);
        val_16 = null;
        val_17 = 0;
        val_16 = new UnityEngine.Events.UnityAction(object:  -1727442080, method:  new IntPtr(2567490880));
        this.avatarCloseButton.m_OnClick.AddListener(call:  162246656);
        goto label_5;
        label_29:
        object val_2 = null;
        val_16 = val_2;
        val_2 = new System.Object();
        typeof(LeagueProfilePersonalization_Window.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
        Player val_3 = App.Player;
        if(0 != 35143908)
        {
                object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.avatarButtonPrefab, parent:  this.gridTransform);
            string val_5 = 0.ToString();
            string val_6 = -1727467200(-1727467200) + -1727454120(-1727454120);
            if(this.avatarButtonPrefab != 0)
        {
                this.avatarButtonPrefab.name = -1727467200;
        }
        else
        {
                0.name = -1727467200;
        }
        
            object val_7 = this.avatarButtonPrefab.GetComponent<System.Object>();
            UnityEngine.GameObject val_8 = this.avatarButtonPrefab.gameObject;
            object val_9 = this.avatarButtonPrefab.GetComponent<System.Object>();
            typeof(LeagueProfilePersonalization_Window.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = 0;
            object val_10 = this.avatarButtonPrefab.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  298455040, method:  new IntPtr(2567500192));
            this.avatarButtonPrefab.AddListener(call:  162246656);
            SLC.Social.AvatarConfig val_12 = SLC.Social.Leagues.LeaguesUIManager.memberAvatarHandler;
            UnityEngine.Sprite val_13 = 0.GetAvatarSpriteByID(id:  0);
            this.avatarButtonPrefab.sprite = 0;
        }
        
        val_17 = 0 + 1;
        label_5:
        SLC.Social.AvatarConfig val_14 = SLC.Social.Leagues.LeaguesUIManager.memberAvatarHandler;
        if(val_17 < 0.AvatarSpritesCount)
        {
            goto label_29;
        }
    
    }
    public void ShowNameWindow()
    {
        this.changeImageWindow.SetActive(value:  false);
        this.changeNameWindow.SetActive(value:  true);
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -1727255328, method:  new IntPtr(2567654176));
        this.nameChangeInputField.m_OnValueChanged.AddListener(call:  162353152);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1727255328, method:  new IntPtr(2567665440));
        this.confirmNameButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1727255328, method:  new IntPtr(2567490880));
        this.nameCloseButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1727255328, method:  new IntPtr(2567682848));
        this.randomNameButton.m_OnClick.AddListener(call:  162246656);
        this.nameChangeInputField.text = 1098586544;
        this.OnInputUpdated(newValue:  1098586544);
    }
    private void OnInputUpdated(string newValue)
    {
        if(newValue.m_stringLength > 0)
        {
                0 = 1;
        }
        
        this.confirmNameButton.interactable = true;
        this.randomName = false;
    }
    private void RollRandomName()
    {
        string val_1 = SLC.Social.SocialManager.GetRandomProfileName();
        this.nameChangeInputField.text = null;
        this.randomName = true;
    }
    private void ConfirmNameChange()
    {
        ulong val_14;
        string val_16;
        var val_17;
        var val_18;
        int val_19;
        var val_20;
        val_16 = this.nameChangeInputField.m_Text;
        if(this.randomName != true)
        {
                string val_1 = val_16.ToLower();
            if((Objectionable.Valid(words:  val_16)) != true)
        {
                string val_3 = val_16.ToLower();
            string val_4 = Objectionable.FoundObjectionable(words:  val_16);
            string val_5 = System.Text.RegularExpressions.Regex.Replace(input:  val_16, pattern:  val_16, replacement:  1098586544, options:  1);
            val_16 = val_16;
        }
        
        }
        
        val_17 = 0;
        val_18 = 0;
        goto label_12;
        label_14:
        if(val_17 >= this.nameChangeInputField.m_Text.m_stringLength)
        {
            goto label_13;
        }
        
        label_15:
        val_17 = 1;
        if(val_16.Chars[0] == ' ')
        {
                val_18 = 1;
        }
        
        label_12:
        if(val_16 == null)
        {
            goto label_14;
        }
        
        val_19 = this.nameChangeInputField.m_Text.m_stringLength;
        if(val_17 < val_19)
        {
            goto label_15;
        }
        
        goto label_16;
        label_13:
        val_19 = 0;
        label_16:
        if(val_18 != val_19)
        {
                val_18 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_8 = 0.MyProfile;
            val_17 = 0;
            if((val_17.Equals(value:  val_16)) != true)
        {
                SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_11 = 0.MyProfile;
            mem[12] = val_16;
            this.SaveChanges();
            Player val_12 = App.Player;
            val_20 = 2621448;
            if(val_20 != 0)
        {
                val_17 = 23;
        }
        else
        {
                val_20 = 368;
            val_17 = 0;
        }
        
            mem[368] = 1;
            System.DateTime val_13 = ServerHandler.ServerTime;
            SLC.Social.Leagues.LeaguesTracker.LastNameChange = new System.DateTime() {dateData = val_14};
        }
        
        }
        
        this.Close();
    }
    private void OnAvatarClicked(int selectedAvatar)
    {
        var val_7;
        var val_8;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        val_7 = 0;
        if(83886592 != selectedAvatar)
        {
                SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_4 = 0.MyProfile;
            mem[36] = selectedAvatar;
            this.SaveChanges();
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
        }
        
        this.Close();
    }
    private void SaveChanges()
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateMyProfileInfo(force:  true);
    }
    private void Close()
    {
        if(this.onCloseAction != 0)
        {
                this.onCloseAction.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1726493216, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public LeagueProfilePersonalization_Window()
    {
    
    }

}
