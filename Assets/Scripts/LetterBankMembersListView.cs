using UnityEngine;
public class LetterBankMembersListView : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.LoopVerticalScrollRect loopScrollRect;
    private UnityEngine.GameObject parentWindow;
    private System.Collections.Generic.List<LetterBankEventPlayer> eventPlayers;
    private SLC.Social.Profile myProfile;
    private bool initialized;
    private static UnityEngine.UI.LoopScrollPrefabSource _prefabSource;
    private UnityEngine.GameObject _letterBankMemberGridItemPrefab;
    
    // Properties
    private UnityEngine.GameObject letterBankMemberGridItemPrefab { get; }
    
    // Methods
    private UnityEngine.GameObject get_letterBankMemberGridItemPrefab()
    {
        if(this._letterBankMemberGridItemPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1330624784);
        UnityEngine.GameObject val_3 = gameObject;
        this._letterBankMemberGridItemPrefab = "LetterBankEvent";
    }
    private void OnEnable()
    {
        this.DoInit();
    }
    private void OnDisable()
    {
        this.loopScrollRect.ClearCells();
    }
    public void Refresh(UnityEngine.GameObject parentWindowObject, System.Collections.Generic.List<LetterBankEventPlayer> eventPlayers, bool refillCells = False)
    {
        this.DoInit();
        this.parentWindow = parentWindowObject;
        if(eventPlayers == 0)
        {
                eventPlayers = 0;
        }
        
        if(eventPlayers != 0)
        {
                this.eventPlayers = eventPlayers;
            eventPlayers = 0;
        }
        
        mem2[0] = eventPlayers;
        System.Collections.IEnumerator val_1 = this.RefreshMyCells(refill:  refillCells);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1330231904);
    }
    public System.Collections.IEnumerator RefreshMyCells(bool refill)
    {
        typeof(LetterBankMembersListView.<RefreshMyCells>d__12).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LetterBankMembersListView.<RefreshMyCells>d__12).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(LetterBankMembersListView.<RefreshMyCells>d__12).__il2cppRuntimeField_10 = refill;
    }
    public void SetupGridItem(LetterBankMemberGridItem memberGridItem, int itemIndex)
    {
        System.Action<System.Int32> val_5;
        SLC.Social.Profile val_6;
        if(true <= itemIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        memberGridItem = memberGridItem + (itemIndex << 2);
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_5 = 0;
        SLC.Social.Profile val_2 = 0.GetGuildMember(memberId:  this.eventPlayers);
        val_6 = 0;
        if(0 == 0)
        {
                SLC.Social.Profile val_3 = (memberGridItem + (itemIndex) << 2).text_rank.ToProfile();
            val_6 = (memberGridItem + (itemIndex) << 2).text_rank;
        }
        
        if(this.eventPlayers != 0)
        {
                val_5 = null;
            val_5 = new System.Action<System.Int32>(object:  -1329982304, method:  new IntPtr(2964959968));
            this.myProfile = val_6;
        }
        
        if(this.eventPlayers != 0)
        {
                this.eventPlayers = 1;
        }
        
        memberGridItem.UpdateUIFromMember(memberProfile:  val_6, rankIndex:  itemIndex, rankedWinnings:  (memberGridItem + (itemIndex) << 2).text_rank, clickAction:  val_5, isMe:  true);
    }
    private void DoInit()
    {
        UnityEngine.UI.LoopScrollPrefabSource val_3;
        var val_4;
        var val_5;
        if(this.initialized == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(LetterBankMembersListView._prefabSource == 0)
        {
                val_5 = null;
            val_5 = null;
            LetterBankMembersListView._prefabSource = new UnityEngine.UI.LoopScrollPrefabSource();
            val_3 = LetterBankMembersListView._prefabSource;
            UnityEngine.GameObject val_2 = R4.letterBankMemberGridItemPrefab;
            typeof(UnityEngine.UI.LoopScrollPrefabSource).__il2cppRuntimeField_8 = R4;
            val_4 = null;
            if(LetterBankMembersListView._prefabSource == 0)
        {
                val_4 = null;
        }
        
            typeof(UnityEngine.UI.LoopScrollPrefabSource).__il2cppRuntimeField_C = 3;
        }
        
        val_4 = null;
        mem2[0] = LetterBankMembersListView._prefabSource;
    }
    private bool IsMe(int serverId)
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        var val_3 = 0;
        val_3 = val_3 - serverId;
        val_3 = val_3 >> 5;
        return (bool)val_3;
    }
    private void OnMemberClickedCallback(int memberId)
    {
        SLC.Social.Leagues.LeaguesUIManager.ShowPlayerProfile(serverId:  this.myProfile.ServerId, gridItem:  0);
    }
    public LetterBankMembersListView()
    {
    
    }
    private static LetterBankMembersListView()
    {
    
    }

}
