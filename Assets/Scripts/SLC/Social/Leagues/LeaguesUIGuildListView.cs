using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIGuildListView : UIListViewController
    {
        // Fields
        private SLC.Social.Leagues.GuildsListType viewType;
        private bool updateOnEnable;
        private bool listenForGuildListUpdate;
        private string guildGridItemPrefabName;
        private UnityEngine.GameObject _leaguesUIGuildGridItemPrefab;
        private UnityEngine.UI.ScrollRect _GridScrollRect;
        public System.Action<UnityEngine.UI.ScrollRect> OnGuildListFinishedUIUpdate;
        protected bool actionableItems;
        private string _SearchTerm;
        private float nextSlowRefresh;
        
        // Properties
        private UnityEngine.GameObject leaguesUIGuildGridItemPrefab { get; }
        protected UnityEngine.UI.ScrollRect GridScrollRect { get; }
        public string SearchTerm { set; }
        
        // Methods
        private UnityEngine.GameObject get_leaguesUIGuildGridItemPrefab()
        {
            if(this._leaguesUIGuildGridItemPrefab != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -1146455072, prefabName:  this.guildGridItemPrefabName);
            this._leaguesUIGuildGridItemPrefab = "Leagues";
        }
        protected override UnityEngine.GameObject GetMemberItemPrefab()
        {
            return this.leaguesUIGuildGridItemPrefab;
        }
        protected UnityEngine.UI.ScrollRect get_GridScrollRect()
        {
            if(this._GridScrollRect != 0)
            {
                    return;
            }
            
            object val_2 = this._GridScrollRect.GetComponent<System.Object>();
            this._GridScrollRect = this._GridScrollRect;
        }
        private void Awake()
        {
            if(this.listenForGuildListUpdate == false)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  855815216, name:  442544128);
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -747685408, method:  new IntPtr(855903216));
            mem[1152921514052710864] = null;
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  855929264, method:  new IntPtr(855904240));
            mem[1152921514052710868] = null;
        }
        private void FinishedUIUpdate(bool state)
        {
            if(this.OnGuildListFinishedUIUpdate == 0)
            {
                    return;
            }
            
            UnityEngine.UI.ScrollRect val_1 = this.GridScrollRect;
            this.OnGuildListFinishedUIUpdate.Invoke(obj:  856046384);
        }
        private void OnGuildListUpdate()
        {
            this.StopCoroutines();
            this.SetupUI();
        }
        public void set_SearchTerm(string value)
        {
            this._SearchTerm = value;
            this.SearchForGuildByName(nameEntry:  value);
        }
        private void SearchForGuildByName(string nameEntry)
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.Dictionary<System.Int32, SLC.Social.Leagues.Guild> val_2 = GetGuildsByName(queryString:  nameEntry);
            System.Collections.IEnumerator val_3 = this.UpdateWithSearch(term:  nameEntry);
        }
        private void OnEnable()
        {
            UnityEngine.UI.ScrollRect val_1 = this.GridScrollRect;
            this.verticalNormalizedPosition = null;
            if(this.updateOnEnable == false)
            {
                    return;
            }
            
            this.SetupUI();
        }
        private void Update()
        {
            var val_3;
            if(this.viewType != 1)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            if(this.viewType <= 1)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_3 = null;
            val_3 = null;
            float val_3 = SLC.Social.Leagues.LeaguesManager.SlowRefreshRequestInterval;
            val_3 = 0 + val_3;
            this.nextSlowRefresh = val_3;
            this.SearchForGuildByName(nameEntry:  this._SearchTerm);
        }
        public void ReadySetupUI()
        {
            this.SetupUI();
        }
        private void SetupUI()
        {
            var val_11;
            var val_12;
            var val_13;
            if(this.viewType > 5)
            {
                goto label_1;
            }
            
            var val_1 = 11164804 + (11164804 + (this.viewType) << 2);
            if(this.viewType == 5)
            {
                    11164804 + (this.viewType) << 2 = (11164804 + (this.viewType) << 2) & ((R8) << 11164804 + (this.viewType) << 2);
                11164804 + (this.viewType) << 2 = (11164804 + (this.viewType) << 2) & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                11164804 + (this.viewType) << 2 = (11164804 + (this.viewType) << 2) & (((this) << (32-((11164804 + (this.viewType) << 2 & (R8) << 11164804 + (this.viewType) << 2) & ((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            )))) | ((this) << ((11164804 + (this.viewType) << 2 & (R8) << 11164804 + (this.viewType) << 2) & ((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ))));
                11164804 + (this.viewType) << 2 = (11164804 + (this.viewType) << 2) & ((R8) >> 2);
                11164804 + (this.viewType) << 2 = (11164804 + (this.viewType) << 2) & 856871344;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_11 = null;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_3 = GuildsToJoin;
            goto label_21;
            label_1:
            val_12 = 0;
            goto label_12;
            label_21:
            val_13 = ;
            label_12:
            mem[1152921514053652932] = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_namespaze;
            this.UpdateMembersGrid();
        }
        private void UpdateItemWithOpen(int i)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_2 = GuildsToJoin;
            if(null <= i)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (i << 2);
            object val_3 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_5 = GuildsToJoin;
            val_6 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_7 = (SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 44;
            val_8 = 0;
            val_9 = 1;
            (0 + (i) << 2) + 16.UpdateUIFromGuild(guildId:  0, rankingView:  false, showMemberCount:  false, finalSeasonRank:  0);
        }
        private System.Collections.IEnumerator UpdateWithSearch(string term)
        {
            typeof(LeaguesUIGuildListView.<UpdateWithSearch>d__27).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(LeaguesUIGuildListView.<UpdateWithSearch>d__27).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(LeaguesUIGuildListView.<UpdateWithSearch>d__27).__il2cppRuntimeField_10 = term;
        }
        private void UpdateItemWithRanking(int i, bool actionableItems)
        {
            var val_14;
            System.Func<SLC.Social.Leagues.Guild, System.Decimal> val_16;
            var val_17;
            System.Func<SLC.Social.Leagues.Guild, System.Int32> val_19;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_2 = GuildsInMyTier;
            string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  441638912);
            object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  441638912);
            val_14 = null;
            val_14 = null;
            val_16 = LeaguesUIGuildListView.<>c.<>9__28_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<TRVDailyBonusRewardContainer, System.Decimal>(object:  LeaguesUIGuildListView.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(857197680));
                LeaguesUIGuildListView.<>c.<>9__28_0 = val_16;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_6 = System.Linq.Enumerable.OrderBy<System.Object, System.Decimal>(source:  441638912, keySelector:  7720960);
            val_17 = null;
            val_17 = null;
            val_19 = LeaguesUIGuildListView.<>c.<>9__28_1;
            if(val_19 == 0)
            {
                    val_19 = null;
                val_19 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  LeaguesUIGuildListView.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(857200752));
                LeaguesUIGuildListView.<>c.<>9__28_1 = val_19;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_8 = System.Linq.Enumerable.ThenBy<System.Object, System.Int32>(source:  441638912, keySelector:  7720960);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            mem2[0] = i + 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            object val_10 = ((SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 8 + (i) << 2) + 16.GetComponent<System.Object>();
            mem2[0] = actionableItems;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            object val_11 = (((SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 8 + (i) << 2) + 16 + 8 + (i) << 2) + 16.GetComponent<System.Object>();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (((SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 8 + (i) << 2) + 16 + 8 + (i) << 2) + 16.UpdateUIFromGuild(guild:  (SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16, rankingView:  true, showMemberCount:  false, finalSeasonRank:  0);
        }
        private void UpdateItemWithRankingTier(int i)
        {
            var val_6;
            int val_7;
            var val_8;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_2 = GuildsInSearchedTier;
            if(null <= i)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (i << 2);
            object val_3 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_5 = GuildsInSearchedTier;
            val_6 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_7 = 0;
            val_8 = (SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 44;
            (0 + (i) << 2) + 16.UpdateUIFromGuild(guildId:  0, rankingView:  true, showMemberCount:  false, finalSeasonRank:  null);
        }
        private void UpdateItemWithFinalSeasonRanking(int i)
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(null <= i)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (i << 2);
            object val_2 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (0 + (i) << 2) + 16.UpdateUIFromGuild(guild:  (0x100000001A539000.__il2cppRuntimeField_8 + (i) << 2) + 16, rankingView:  true, showMemberCount:  false, finalSeasonRank:  i);
        }
        private void UpdateItemWithInvites(int i)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_2 = GuildsInvited;
            if(null <= i)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (i << 2);
            object val_3 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_5 = GuildsInvited;
            val_6 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_7 = (SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_name + (i) << 2) + 16 + 44;
            val_8 = 0;
            val_9 = 1;
            (0 + (i) << 2) + 16.UpdateUIFromGuild(guildId:  0, rankingView:  false, showMemberCount:  false, finalSeasonRank:  0);
        }
        protected override void SetupGridItem(int i)
        {
            SLC.Social.Leagues.GuildsListType val_3 = this.viewType;
            if(val_3 == 0)
            {
                    this.UpdateItemWithOpen(i:  i);
                val_3 = this.viewType;
            }
            
            if(val_3 == 2)
            {
                    this.UpdateItemWithRanking(i:  i, actionableItems:  this.actionableItems);
                val_3 = this.viewType;
            }
            
            if(val_3 == 4)
            {
                    this.UpdateItemWithRankingTier(i:  i);
                val_3 = this.viewType;
            }
            
            if(val_3 == 3)
            {
                    this.UpdateItemWithFinalSeasonRanking(i:  i);
                val_3 = this.viewType;
            }
            
            if(val_3 == 1)
            {
                    System.Collections.IEnumerator val_1 = this.UpdateWithSearch(term:  this._SearchTerm);
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  857704496);
                val_3 = this.viewType;
            }
            
            if(val_3 != 5)
            {
                    return;
            }
            
            R5.UpdateItemWithInvites(i:  R4);
        }
        public LeaguesUIGuildListView()
        {
            this.updateOnEnable = true;
            this.listenForGuildListUpdate = true;
            this.actionableItems = true;
            this.guildGridItemPrefabName = "club_grid_item";
            this._SearchTerm = "";
            this.nextSlowRefresh = 30f;
        }
    
    }

}
