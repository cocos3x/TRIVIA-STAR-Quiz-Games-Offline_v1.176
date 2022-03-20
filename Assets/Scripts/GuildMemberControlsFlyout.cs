using UnityEngine;
public class GuildMemberControlsFlyout : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_kick;
    private UnityEngine.UI.Button button_promote;
    private UnityEngine.UI.Button button_demote;
    private SLC.Social.Profile currentProfile;
    
    // Properties
    private bool checkTouchedMe { get; }
    
    // Methods
    private bool get_checkTouchedMe()
    {
        var val_15;
        var val_16;
        UnityEngine.Object val_17;
        val_15 = 0;
        if(UnityEngine.Input.touchCount <= 0)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return (bool)val_15;
        }
        
        }
        
        UnityEngine.EventSystems.EventSystem val_3 = UnityEngine.EventSystems.EventSystem.current;
        val_16 = 35615780;
        val_15 = 0;
        UnityEngine.GameObject val_4 = this.gameObject;
        val_17 = this;
        if(35615780 == (-1719233536))
        {
                return (bool)val_15;
        }
        
        UnityEngine.EventSystems.EventSystem val_6 = UnityEngine.EventSystems.EventSystem.current;
        val_16 = 35615780;
        val_15 = 0;
        UnityEngine.GameObject val_7 = this.button_kick.gameObject;
        val_17 = this.button_kick;
        if(35615780 == val_17)
        {
                return (bool)val_15;
        }
        
        UnityEngine.EventSystems.EventSystem val_9 = UnityEngine.EventSystems.EventSystem.current;
        val_16 = 35615780;
        val_15 = 0;
        UnityEngine.GameObject val_10 = this.button_promote.gameObject;
        val_17 = this.button_promote;
        if(35615780 == val_17)
        {
                return (bool)val_15;
        }
        
        UnityEngine.EventSystems.EventSystem val_12 = UnityEngine.EventSystems.EventSystem.current;
        val_16 = 0;
        UnityEngine.GameObject val_13 = this.button_demote.gameObject;
        val_15 = (UnityEngine.Object.op_Equality(x:  35615780, y:  this.button_demote)) ^ 1;
        return (bool)val_15;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1719081600, method:  new IntPtr(2575842240));
        this.button_kick.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1719081600, method:  new IntPtr(2575851456));
        this.button_promote.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1719081600, method:  new IntPtr(2575860672));
        this.button_demote.m_OnClick.AddListener(call:  162246656);
    }
    private void Update()
    {
        if(this.checkTouchedMe == false)
        {
                return;
        }
        
        R4.enabled = false;
        UnityEngine.GameObject val_2 = R4.gameObject;
        SLCWindow.CloseWindow(window:  R4, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void SetupControls(UnityEngine.GameObject gridItem, SLC.Social.Profile profile, bool promoteButton, bool demoteButton)
    {
        float val_9;
        float val_10;
        object val_1 = gridItem.GetComponentInChildren<System.Object>();
        UnityEngine.Canvas val_2 = gridItem.canvas;
        object val_3 = this.GetComponentInChildren<System.Object>();
        UnityEngine.Canvas val_4 = this.canvas;
        UnityEngine.Transform val_5 = gridItem.transform;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.455537E-23f}, b:  new UnityEngine.Vector3() {y = val_10, z = val_9});
        UnityEngine.Transform val_13 = this.transform;
        UnityEngine.Transform val_14 = gridItem.transform;
        UnityEngine.Vector3 val_15 = position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.455533E-23f}, b:  new UnityEngine.Vector3());
        this.position = new UnityEngine.Vector3();
        this.currentProfile = profile;
        UnityEngine.GameObject val_17 = this.button_promote.gameObject;
        this.button_promote.SetActive(value:  promoteButton);
        UnityEngine.GameObject val_18 = this.button_demote.gameObject;
        this.button_demote.SetActive(value:  demoteButton);
    }
    private void OnClick_Kick()
    {
        var val_5;
        if(this.currentProfile != 0)
        {
                SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            val_5 = 0;
            if(this.currentProfile.GuildServerId == 2621448)
        {
                SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_5 = 0;
            val_5.RemoveGuildMember(toRemove:  this.currentProfile);
            this.currentProfile.GuildServerId = 0;
        }
        
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1718683136, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Promote()
    {
        var val_13;
        int val_14;
        int val_15;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_13 = 0.IsMaster;
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        if((0.IsOfficer != false) && (this.currentProfile.Officer != true))
        {
                bool val_13 = this.currentProfile.GuildMaster;
            val_13 = val_13 >> 5;
            val_13 = val_13 | val_13;
        }
        
        val_14 = this.currentProfile.GuildServerId;
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
        val_15 = 0;
        var val_14 = 2621448;
        bool val_7 = val_13 ^ 1;
        val_14 = val_14 - val_14;
        if(0 != 0)
        {
                val_14 = 1;
        }
        
        if((0 == 0) && (this.currentProfile != 0))
        {
                val_15 = this.currentProfile.GuildServerId;
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
            if(val_15 == 2621448)
        {
                SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_15 = this.currentProfile;
            val_14 = null;
            val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1718544512, method:  new IntPtr(2576396736));
            0.PromoteMember(toPromote:  val_15, responseCallback:  7401472);
        }
        
        }
        
        UnityEngine.GameObject val_12 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1718544512, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Demote()
    {
        var val_13;
        int val_14;
        int val_15;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_13 = 0.IsMaster;
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        if((0.IsOfficer != false) && (this.currentProfile.Officer != true))
        {
                bool val_13 = this.currentProfile.GuildMaster;
            val_13 = val_13 >> 5;
            val_13 = val_13 | val_13;
        }
        
        val_14 = this.currentProfile.GuildServerId;
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
        val_15 = 0;
        var val_14 = 2621448;
        bool val_7 = val_13 ^ 1;
        val_14 = val_14 - val_14;
        if(0 != 0)
        {
                val_14 = 1;
        }
        
        if(0 == 0)
        {
                val_15 = this.currentProfile.GuildServerId;
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
            if(val_15 == 2621448)
        {
                SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_15 = this.currentProfile;
            val_14 = null;
            val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1718390528, method:  new IntPtr(2576551744));
            0.DemoteMember(toDemote:  val_15, responseCallback:  7401472);
        }
        
        }
        
        UnityEngine.GameObject val_12 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1718390528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void CloseFlyout()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1718258048, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public GuildMemberControlsFlyout()
    {
    
    }
    private void <OnClick_Promote>b__10_0(System.Collections.Generic.Dictionary<string, object> result)
    {
        if((result.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        string val_4 = Localization.Localize(key:  -1718052928, defaultValue:  -1718052800, useSingularKey:  false);
        35641582 = "member_promoted_co_leader";
        string val_5 = System.String.Format(format:  -1718052928, arg0:  this.currentProfile.Name);
        0.SetupMessage(message:  -1718052928, displaySeconds:  null, startAction:  1077936128);
    }
    private void <OnClick_Demote>b__11_0(System.Collections.Generic.Dictionary<string, object> result)
    {
        object val_7;
        string val_1 = PrettyPrint.printJSON(obj:  result, types:  false, singleLineOutput:  false);
        val_7 = result;
        UnityEngine.Debug.Log(message:  val_7);
        if((result.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  -1717916096, defaultValue:  -1717915968, useSingularKey:  false);
        val_7 = "member_no_longer_co_leader";
        string val_6 = System.String.Format(format:  -1717916096, arg0:  this.currentProfile.Name);
        0.SetupMessage(message:  -1717916096, displaySeconds:  null, startAction:  1077936128);
    }

}
