using UnityEngine;
public class TournamentsMembersListView : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.LoopVerticalScrollRect loopScrollRect;
    private UnityEngine.GameObject parentWindow;
    private TournamentInfo tournamentInfo;
    private SLC.Social.Profile myProfile;
    private bool initialized;
    private static UnityEngine.UI.LoopScrollPrefabSource _prefabSource;
    private UnityEngine.GameObject _tournamentMemberGridItemPrefab;
    private TournamentsPopup parentTournamentsPopup;
    
    // Properties
    private UnityEngine.GameObject tournamentMemberGridItemPrefab { get; }
    private TournamentsPopup ParentTournamentsPopup { get; }
    
    // Methods
    private UnityEngine.GameObject get_tournamentMemberGridItemPrefab()
    {
        if(this._tournamentMemberGridItemPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1666482848);
        UnityEngine.GameObject val_3 = gameObject;
        this._tournamentMemberGridItemPrefab = "Tournaments";
    }
    private TournamentsPopup get_ParentTournamentsPopup()
    {
        if(this.parentTournamentsPopup != 0)
        {
                return;
        }
        
        object val_2 = this.parentWindow.GetComponent<System.Object>();
        this.parentTournamentsPopup = this.parentWindow;
    }
    private void OnEnable()
    {
        this.DoInit();
    }
    private void OnDisable()
    {
        this.loopScrollRect.ClearCells();
    }
    public void Refresh(UnityEngine.GameObject parentWindowObject, TournamentInfo tournamentInfo, bool refillCells = False)
    {
        this.DoInit();
        this.parentWindow = parentWindowObject;
        this.tournamentInfo = tournamentInfo;
        mem2[0] = tournamentInfo.tournamentPlayers;
        System.Collections.IEnumerator val_1 = this.RefreshMyCells(refill:  refillCells);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1665948288);
    }
    public System.Collections.IEnumerator RefreshMyCells(bool refill)
    {
        typeof(TournamentsMembersListView.<RefreshMyCells>d__15).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TournamentsMembersListView.<RefreshMyCells>d__15).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(TournamentsMembersListView.<RefreshMyCells>d__15).__il2cppRuntimeField_10 = refill;
    }
    public void SetupGridItem(TournamentsMemberGridItem memberGridItem, int itemIndex)
    {
        SLC.Social.Profile val_4;
        float val_5;
        System.Action<System.Int32> val_6;
        if(true <= itemIndex)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (itemIndex << 2);
        if(((0 + (itemIndex) << 2) + 16) != 0)
        {
                SLC.Social.Profile val_1 = (0 + (itemIndex) << 2) + 16.ToProfile();
            val_4 = (0 + (itemIndex) << 2) + 16;
            val_5 = mem[(0 + (itemIndex) << 2) + 16 + 12];
            val_5 = (0 + (itemIndex) << 2) + 16 + 12;
        }
        else
        {
                SLC.Social.Profile val_2 = 0.ToProfile();
            val_4 = 0;
            val_5 = 0f;
        }
        
        if(((0 + (itemIndex) << 2) + 16 + 25) != 0)
        {
                val_6 = null;
            val_6 = new System.Action<System.Int32>(object:  -1665690496, method:  new IntPtr(2629247680));
            this.myProfile = val_4;
        }
        else
        {
                val_6 = 0;
        }
        
        if(((0 + (itemIndex) << 2) + 16 + 25) != 0)
        {
                (0 + (itemIndex) << 2) + 16 + 25 = 1;
        }
        
        memberGridItem.UpdateUIFromMember(memberProfile:  0, tierIndex:  this.tournamentInfo.tierIndex, rankIndex:  itemIndex, rankedWinnings:  0, clickAction:  val_6, isMe:  true);
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
        if(TournamentsMembersListView._prefabSource == 0)
        {
                val_5 = null;
            val_5 = null;
            TournamentsMembersListView._prefabSource = new UnityEngine.UI.LoopScrollPrefabSource();
            val_3 = TournamentsMembersListView._prefabSource;
            UnityEngine.GameObject val_2 = R4.tournamentMemberGridItemPrefab;
            typeof(UnityEngine.UI.LoopScrollPrefabSource).__il2cppRuntimeField_8 = R4;
            val_4 = null;
            if(TournamentsMembersListView._prefabSource == 0)
        {
                val_4 = null;
        }
        
            typeof(UnityEngine.UI.LoopScrollPrefabSource).__il2cppRuntimeField_C = 3;
        }
        
        val_4 = null;
        mem2[0] = TournamentsMembersListView._prefabSource;
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
        if(this.parentWindow != 0)
        {
                TournamentsPopup val_2 = this.ParentTournamentsPopup;
            if((-1665325824) != 0)
        {
                TournamentsPopup val_4 = this.ParentTournamentsPopup;
            if(this.loopScrollRect == 0)
        {
                return;
        }
        
        }
        
        }
        
        SLC.Social.Leagues.LeaguesUIManager.ShowPlayerProfile(serverId:  this.myProfile.ServerId, gridItem:  0);
    }
    public TournamentsMembersListView()
    {
    
    }
    private static TournamentsMembersListView()
    {
    
    }

}
