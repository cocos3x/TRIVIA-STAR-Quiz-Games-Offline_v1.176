using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIMembersView : UIListViewController
    {
        // Fields
        private bool showRequestsLeadersOptions;
        private bool myMainGuildView;
        private bool MVPsView;
        private string memberGridItemPrefabName;
        private UnityEngine.GameObject _leaguesUIMemberGridItemPrefab;
        private int curr_invites;
        private int curr_members;
        private bool showingOtherGuild;
        private int currentGuildId;
        
        // Properties
        private UnityEngine.GameObject leaguesUIMemberGridItemPrefab { get; }
        private SLC.Social.Leagues.Guild CurrentGuild { get; }
        
        // Methods
        private UnityEngine.GameObject get_leaguesUIMemberGridItemPrefab()
        {
            if(this._leaguesUIMemberGridItemPrefab != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -1146455072, prefabName:  this.memberGridItemPrefabName);
            this._leaguesUIMemberGridItemPrefab = "Leagues";
        }
        protected override UnityEngine.GameObject GetMemberItemPrefab()
        {
            return this.leaguesUIMemberGridItemPrefab;
        }
        private SLC.Social.Leagues.Guild get_CurrentGuild()
        {
            if(this.currentGuildId == 1)
            {
                goto label_1;
            }
            
            label_5:
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    return 0.GetGuild(guildId:  this.currentGuildId);
            }
            
            return 0.GetGuild(guildId:  this.currentGuildId);
            label_1:
            if(this.myMainGuildView == false)
            {
                goto label_5;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    return 0.MyGuild;
            }
            
            return 0.MyGuild;
        }
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  861901728, name:  442544128);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  861901728, name:  442544128);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  861901728, name:  442544128);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  861901728, name:  442544128);
        }
        private void OnMyProfileUpdate()
        {
            if(this.showingOtherGuild == true)
            {
                    return;
            }
            
            R4.StopCoroutines();
            R4.Refresh(guildId:  R4 + 68);
        }
        private void OnGuildListUpdate()
        {
            if(this.showingOtherGuild == false)
            {
                    return;
            }
            
            this.StopCoroutines();
            this.Refresh(guildId:  this.currentGuildId);
        }
        private void OnMyGuildUpdate()
        {
            if(this.showingOtherGuild == true)
            {
                    return;
            }
            
            R4.StopCoroutines();
            R4.Refresh(guildId:  R4 + 68);
        }
        private void OnGuildMembersUpdate()
        {
            this.StopCoroutines();
            this.Refresh(guildId:  this.currentGuildId);
        }
        public void Refresh(int guildId)
        {
            this.currentGuildId = guildId;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeInHierarchy == false)
            {
                    return;
            }
            
            R4.DoRefresh();
        }
        private void OnEnable()
        {
            object val_1 = static_value_021FC279.GetComponent<System.Object>();
            static_value_021FC279.verticalNormalizedPosition = null;
            this.DoRefresh();
        }
        private void OnSceneLoaded()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-747685408) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            1152921504901095424 = null;
            1152921504901095424 = new System.Action<System.Boolean>(object:  -747685408, method:  new IntPtr(855903216));
            mem[1152921514059467328] = 1152921504901095424;
        }
        private void DoRefresh()
        {
            bool val_15;
            int val_16;
            SLC.Social.Leagues.Guild val_1 = this.CurrentGuild;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_15 = false;
            SLC.Social.Leagues.Guild val_3 = 0.MyGuild;
            if(0 == 0)
            {
                goto label_11;
            }
            
            SLC.Social.Leagues.Guild val_4 = this.CurrentGuild;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
            if(this.showRequestsLeadersOptions != false)
            {
                goto label_11;
            }
            
            val_15 = false;
            this.showingOtherGuild = val_15;
            if(this.showRequestsLeadersOptions == false)
            {
                goto label_23;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0.IsOfficer == true)
            {
                goto label_16;
            }
            
            val_15 = 0;
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0.IsMaster == false)
            {
                goto label_23;
            }
            
            label_16:
            SLC.Social.Leagues.Guild val_11 = this.CurrentGuild;
            if(this != 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_11:
            this.showRequestsLeadersOptions = val_15;
            this.showingOtherGuild = true;
            label_23:
            this.curr_invites = val_15;
            SLC.Social.Leagues.Guild val_12 = this.CurrentGuild;
            this.curr_members = this.memberGridItemPrefabName;
            if(this.MVPsView != false)
            {
                    SLC.Social.Leagues.LeaguesDataController val_13 = SLC.Social.Leagues.LeaguesManager.DAO;
                int val_14 = 0.Count;
            }
            else
            {
                    val_16 = this.curr_invites + this.memberGridItemPrefabName;
            }
            
            mem[1152921514059584436] = val_16;
            this.UpdateMembersGrid();
        }
        private void OnMemberClickedCallback(int memberId)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(memberId != 1)
            {
                    SLC.Social.Leagues.LeaguesUIManager.ShowPlayerProfile(serverId:  memberId, gridItem:  862918944);
                return;
            }
            
            this.SetActive(value:  false);
        }
        protected override void SetupGridItem(int i)
        {
            System.Action<System.Int32> val_19;
            var val_20;
            var val_21;
            var val_22;
            val_19 = 0;
            if(this.myMainGuildView != true)
            {
                    val_19 = null;
                val_19 = new System.Action<System.Int32>(object:  863032992, method:  new IntPtr(863006944));
            }
            
            if(this.curr_invites > i)
            {
                    if(this.MVPsView == false)
            {
                goto label_3;
            }
            
            }
            
            SLC.Social.Leagues.Guild val_2 = this.CurrentGuild;
            val_20 = 0;
            if((i - this.curr_invites) >= this.Count)
            {
                goto label_6;
            }
            
            if(this.MVPsView == false)
            {
                goto label_7;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile[] val_6 = this.GetMembers(memberships:  0);
            val_21 = 0 + (i << 2);
            goto label_13;
            label_3:
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_8 = 0.MyGuild;
            if(34895020 <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = 23;
            val_18 = val_18 + (i << 2);
            if(((23 + (i) << 2) + 16) == 0)
            {
                goto label_20;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_10 = 0.MyGuild;
            if(34895020 <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = 23;
            val_19 = val_19 + (i << 2);
            val_22 = mem[(23 + (i) << 2) + 16 + 8];
            val_22 = (23 + (i) << 2) + 16 + 8;
            goto label_28;
            label_7:
            SLC.Social.Leagues.Guild val_11 = this.CurrentGuild;
            SLC.Social.Profile[] val_12 = this.GetMembers();
            int val_20 = this.curr_invites;
            val_20 = i - val_20;
            val_21 = this + (val_20 << 2);
            label_13:
            val_21 = val_21 + 16;
            label_6:
            if(((i - this.curr_invites) + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = (i - this.curr_invites) + 8;
            val_21 = val_21 + (i << 2);
            object val_13 = ((i - this.curr_invites) + 8 + (i) << 2) + 16.GetComponent<System.Object>();
            if(this.MVPsView == true)
            {
                    this.MVPsView = 1;
            }
            
            if(this.showRequestsLeadersOptions == true)
            {
                    this.showRequestsLeadersOptions = 1;
            }
            
            label_40:
            ((i - this.curr_invites) + 8 + (i) << 2) + 16.UpdateUIFromMember(member:  443822080, rank:  (i + 1) - this.curr_invites, showLeadersOptions:  true, request:  0, showMVP:  false, specialMVPMode:  true, clickOutAction:  val_19);
            return;
            label_20:
            val_22 = 0;
            label_28:
            if(34895020 <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = 23;
            val_22 = val_22 + (i << 2);
            int val_16 = 0 - i;
            object val_17 = (23 + (i) << 2) + 16.GetComponent<System.Object>();
            if(this.showRequestsLeadersOptions == true)
            {
                    this.showRequestsLeadersOptions = 1;
            }
            
            goto label_40;
        }
        private SLC.Social.Profile[] GetMembers(SLC.Social.Leagues.GuildMembers memberships)
        {
            Dictionary.ValueCollection<TKey, TValue> val_1 = memberships.Values;
            return System.Linq.Enumerable.ToArray<System.Object>(source:  memberships);
        }
        public LeaguesUIMembersView()
        {
            this.showRequestsLeadersOptions = true;
            this.myMainGuildView = true;
            this.currentGuildId = 0;
            this.memberGridItemPrefabName = "member_grid_item";
        }
    
    }

}
