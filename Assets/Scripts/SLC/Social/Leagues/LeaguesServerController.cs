using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesServerController : MonoBehaviour
    {
        // Fields
        private static int REQUEST_TIMEOUT;
        private static object BlockingRequest;
        protected System.Action<System.Collections.Generic.Dictionary<string, object>> dataFilter;
        protected const string api_ns = "/api/league";
        protected const string clubs_index = "/clubs/";
        protected const string clubs_open = "/clubs/open/";
        protected const string clubs_ranks = "/ranks/";
        protected const string clubs_search = "/clubs/search/";
        protected const string clubs_join = "/join/";
        protected const string clubs_private_join = "/invites/";
        protected const string clubs_members = "/members/";
        protected const string accept_invite = "/accept/";
        protected const string reject_invite = "/reject/";
        protected const string co_leaders = "/co_leaders/";
        protected const string points_index = "/points/";
        protected const string memberships_index = "/memberships/";
        protected const string coins_index = "/coins/";
        protected const string reset_index = "/resets/";
        protected const string multiplier_index = "/points_multiplier/";
        
        // Methods
        public void ContributePoints(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, int pointsToContribute, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1812169856, value:  13152256);
            Add(key:  804185472, value:  13152256);
            string val_2 = 804185568 + 13152256 + 835579808;
        }
        public void ContributePointsNoGuild(SLC.Social.Profile myself, int pointsToContribute, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1812169856, value:  13152256);
            Add(key:  804185472, value:  13152256);
        }
        public void ContributeCoins(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, decimal coinsToContribute, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = coinsToContribute.flags.ToString();
            Add(key:  -1987496016, value:  835857052);
            Add(key:  804185472, value:  13152256);
            string val_3 = 804185568 + 13152256 + 835845008;
        }
        public void ContributeMultiplier(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, decimal multiplierToContribute, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            string val_3 = multiplierToContribute.flags.ToString(provider:  0);
            Add(key:  835981680, value:  835993836);
            Add(key:  804185472, value:  13152256);
            string val_4 = 804185568 + 13152256 + 835981776;
        }
        public void UpdateUserInfo(SLC.Social.Profile myself, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback, bool hasCollectedFirstGuildReward)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  1679334848, value:  myself.Name);
            Add(key:  -1468287760, value:  13152256);
            Add(key:  -256444704, value:  myself.FacebookId);
            Add(key:  -1988561632, value:  13152256);
            Add(key:  804820688, value:  8945664);
            Add(key:  -1825935328, value:  13152256);
            Add(key:  -1668993344, value:  13152256);
            string val_3 = 836122560 + 13152256;
        }
        public void UpdateGuildInfo(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = myGuild.Encode(destination:  0);
            Add(key:  812296960, value:  myGuild);
            Add(key:  804185472, value:  13152256);
            string val_3 = 804185568 + 13152256;
        }
        public void DemoteMember(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, SLC.Social.Profile toDemote, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            Add(key:  836404032, value:  13152256);
            string val_2 = 804185568 + 13152256 + 836404160;
        }
        public void PromoteMember(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, SLC.Social.Profile toPromote, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            Add(key:  836404032, value:  13152256);
            string val_2 = 804185568 + 13152256 + 836404160;
        }
        public void RemoveGuildMember(SLC.Social.Profile myself, SLC.Social.Leagues.Guild myGuild, SLC.Social.Profile toDelete, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_4 = null;
            SLC.Social.Leagues.LeaguesServerController.BlockingRequest = new UnityEngine.GameObject();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            Add(key:  836693792, value:  13152256);
            string val_3 = 804185568 + 13152256 + 836693920;
        }
        public void RejectInviteRequest(SLC.Social.Profile myself, SLC.Social.Leagues.GuildJoinRequest requested, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            string val_2 = 836834688 + 13152256 + 836834800;
        }
        public void AcceptInviteRequest(SLC.Social.Profile myself, SLC.Social.Leagues.GuildJoinRequest requested, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            string val_2 = 836834688 + 13152256 + 836971472;
        }
        public void GetOtherGuild(SLC.Social.Profile member, int guildServerId, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_4;
            var val_5;
            var val_6;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(member.ServerId != 1)
            {
                    val_4 = null;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
                val_6 = "membership_id";
            }
            else
            {
                    Player val_2 = App.Player;
                val_4 = 1835037;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
                val_6 = "user_id";
            }
            
            Add(key:  1618311216, value:  1835037);
            string val_3 = 804185568 + 13152256;
        }
        public void JoinPrivateGuild(SLC.Social.Leagues.Guild toJoin, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  805059808, value:  13152256);
        }
        public void JoinGuild(SLC.Social.Leagues.Guild toJoin, SLC.Social.Leagues.Guild oldGuild, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            string val_3 = 804185568 + 13152256 + 837364912;
        }
        public void InitialRequest(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_5;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6;
            val_5 = 1152921504892043264;
            Player val_1 = App.Player;
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_4 = App.Player;
            Add(key:  1618311216, value:  1835037);
        }
        public void CreateGuild(SLC.Social.Profile member, SLC.Social.Leagues.Guild guild, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = guild.Encode(destination:  0);
            Add(key:  812296960, value:  guild);
            Player val_3 = App.Player;
            Add(key:  1618311216, value:  1835037);
        }
        public void GetEligibleGuildsToJoin(SLC.Social.Profile member, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
        }
        public void GetMyGuildInvites(SLC.Social.Profile member, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = 836122560 + 13152256 + 837882752;
        }
        public void InviteToMyGuild(SLC.Social.Profile me, int myClubId, int idToInvite, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            Add(key:  838011232, value:  13152256);
            string val_2 = 804185568 + 13152256 + 837882752;
        }
        public void ConsumeClubInvite(SLC.Social.Profile me, int inviteClubId, bool accepted, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  805059808, value:  13152256);
            if(accepted == true)
            {
                    "reject" = "accept";
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = "/api/league/memberships/";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "/invites/";
            typeof(System.Object[]).__il2cppRuntimeField_1C = "accept";
            string val_3 = +472754880;
        }
        public void GetGuildsByName(SLC.Social.Profile member, string queryString, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            if(null != 0)
            {
                    Add(key:  1618311216, value:  1835037);
            }
            else
            {
                    Add(key:  1618311216, value:  1835037);
            }
            
            Add(key:  838272368, value:  queryString);
        }
        public void GetGuildsInMyTier(int serverId, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = serverId.ToString();
            string val_3 = 804185568 + 838413020 + 838400960;
        }
        public void GetGuildsInThisTier(int tier, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  -1376590640, value:  13152256);
        }
        public void PurchaseProMembership(SLC.Social.Profile myself, string membershipLevel, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1988561632, value:  membershipLevel);
            string val_2 = 836122560 + 13152256 + 838649760;
        }
        public void CollectProMembershipBonus(SLC.Social.Profile myself, string membershipLevel, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = 836122560 + 13152256 + 838786416;
        }
        public void ResetMembership(SLC.Social.Profile member, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback, string fields)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            Add(key:  1618311216, value:  1835037);
            if((System.String.IsNullOrEmpty(value:  fields)) != true)
            {
                    Add(key:  1681021520, value:  fields);
            }
            
            string val_4 = 838923088 + 13152256;
        }
        protected virtual bool PreProcessFilter(string apiCall, System.Collections.Generic.Dictionary<string, object> response)
        {
            object val_10;
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_10 = response;
            val_11 = apiCall;
            if(((val_11.Contains(value:  804185680)) != true) && ((val_11.Contains(value:  804318240)) != true))
            {
                    val_12 = null;
                val_12 = null;
                if(Logger.Leagues != false)
            {
                    string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_10, formatting:  1);
                string val_4 = 839055680 + val_11 + 839055792 + val_10;
                val_13 = "LEAGUES API RESPONSE: ";
                UnityEngine.Debug.Log(message:  839055680);
            }
            
            }
            
            if(val_10 == 0)
            {
                goto label_16;
            }
            
            val_14 = "success";
            if((val_10.ContainsKey(key:  1616271776)) == false)
            {
                goto label_13;
            }
            
            object val_6 = val_10.Item[1616271776];
            val_13 = val_10;
            val_14 = null;
            val_13.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null == 0)
            {
                goto label_16;
            }
            
            label_13:
            if(this.dataFilter != 0)
            {
                    this.dataFilter.Invoke(obj:  val_10);
            }
            
            if((val_10.ContainsKey(key:  48658960)) == false)
            {
                goto label_18;
            }
            
            object val_8 = val_10.Item[48658960];
            val_10 = val_10;
            val_11 = null;
            val_10.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null == 0)
            {
                    val_15 = 1;
            }
            
            return (bool)val_15;
            label_16:
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance();
            HandleError(apiCall:  val_11, responseObject:  val_10);
            val_15 = 0;
            return (bool)val_15;
            label_18:
            val_15 = 1;
            return (bool)val_15;
        }
        public virtual void RegisterDataFilter(System.Action<System.Collections.Generic.Dictionary<string, object>> callback)
        {
            this.dataFilter = callback;
        }
        protected virtual void DoRequest(SLC.Social.Leagues.RequestType verb, string uri, System.Collections.Generic.Dictionary<string, object> requestParameters, System.Action<System.Collections.Generic.Dictionary<string, object>> onCompleteCallback, bool doPostUpdate = True, object request, System.Action<string> onRequestFails)
        {
            SLC.Social.Leagues.RequestType val_11;
            bool val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = verb;
            val_12 = doPostUpdate;
            if(new System.Object() != 0)
            {
                    typeof(LeaguesServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = this;
                typeof(LeaguesServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_C = onCompleteCallback;
                typeof(LeaguesServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_10 = val_12;
                typeof(LeaguesServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_14 = request;
            }
            else
            {
                    mem[8] = this;
                mem[12] = onCompleteCallback;
                mem[16] = val_12;
                mem[20] = request;
            }
            
            typeof(LeaguesServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_18 = onRequestFails;
            if(((uri.Contains(value:  804185680)) != true) && ((uri.Contains(value:  804318240)) != true))
            {
                    val_12 = 1152921504891777024;
                val_13 = null;
                val_13 = null;
                if(Logger.Leagues != false)
            {
                    typeof(System.String[]).__il2cppRuntimeField_10 = "LEAGUES API REQUEST ";
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                typeof(System.String[]).__il2cppRuntimeField_14 = null;
                typeof(System.String[]).__il2cppRuntimeField_18 = ": ";
                typeof(System.String[]).__il2cppRuntimeField_1C = uri;
                typeof(System.String[]).__il2cppRuntimeField_20 = " ";
                string val_4 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  requestParameters);
                typeof(System.String[]).__il2cppRuntimeField_24 = requestParameters;
                string val_5 = +477709520;
                val_12 = null;
                UnityEngine.Debug.Log(message:  477709520);
                val_11 = ;
            }
            
            }
            
            if(val_11 > 3)
            {
                    return;
            }
            
            var val_6 = 11122188 + (11122188 + (val_11) << 2);
            if(val_11 == 3)
            {
                    11122188 = 11122188;
                11122188 = 11122188 & ((IP) >> 11122188 + (val_11) << 2);
                11122188 = 11122188 & 29856845;
                11122188 = 11122188 & 838336512;
            }
            
            var val_11 = 24503802;
            val_11 = 11122256 + val_11;
            if(val_11 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_14 = null;
            val_14 = null;
            val_11 = App.networkManager;
            System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  442757120, method:  new IntPtr(839329136));
            val_15 = null;
            val_15 = null;
            val_11.DoPost(path:  uri, postBody:  requestParameters, onCompleteFunction:  7507968, timeout:  SLC.Social.Leagues.LeaguesServerController.multiplier_index, destroy:  true, immediate:  false, serverType:  0);
        }
        private void TryPostUpdate(System.Collections.Generic.Dictionary<string, object> responseObject, object request)
        {
            var val_24;
            var val_25;
            var val_26;
            object val_27;
            var val_28;
            var val_29;
            val_24 = responseObject;
            val_25 = 1152921505049550848;
            val_26 = null;
            val_26 = null;
            val_27 = SLC.Social.Leagues.LeaguesServerController.BlockingRequest;
            if(val_27 != 0)
            {
                    val_27 = SLC.Social.Leagues.LeaguesServerController.BlockingRequest;
                if(val_27 != request)
            {
                    return;
            }
            
            }
            
            if((R4.ContainsKey(key:  263071328)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_2 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  1);
            }
            
            if((R4.ContainsKey(key:  812296960)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_4 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  2);
            }
            
            if((R4.ContainsKey(key:  812964736)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_6 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  4);
            }
            
            if((R4.ContainsKey(key:  1788750416)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_8 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  5);
            }
            
            if((R4.ContainsKey(key:  1956399680)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_10 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  6);
            }
            
            if((R4.ContainsKey(key:  1642388960)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_12 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  6);
            }
            
            if((R4.ContainsKey(key:  839478000)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_14 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  6);
                SLC.Social.Leagues.LeaguesNotifyController val_15 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  10);
            }
            
            if((R4.ContainsKey(key:  812434640)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_17 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  7);
            }
            
            if((R4.ContainsKey(key:  816464368)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_19 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  3);
            }
            
            if((R4.ContainsKey(key:  -256444880)) != false)
            {
                    SLC.Social.Leagues.LeaguesNotifyController val_21 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  3);
            }
            
            SLC.Social.Leagues.LeaguesNotifyController val_22 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
            Notify(note:  0);
            val_28 = mem[R6];
            val_28 = R6;
            if((((R6 + 187) & 2) == 0) && ((R6 + 116) == 0))
            {
                    val_28 = mem[R6];
                val_28 = R6;
            }
            
            val_29 = 0;
            if((R6 + 92 + 4) != 0)
            {
                    if((R6 + 92 + 4) != null)
            {
                    R6 + 92 + 4 = 0;
            }
            
                val_29 = R6 + 92 + 4;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  0);
            mem2[0] = 0;
        }
        private void Awake()
        {
            goto typeof(SLC.Social.Leagues.LeaguesServerController).__il2cppRuntimeField_F4;
        }
        protected virtual void AwakeLogic()
        {
        
        }
        public LeaguesServerController()
        {
        
        }
        private static LeaguesServerController()
        {
            SLC.Social.Leagues.LeaguesServerController.multiplier_index = 20;
            SLC.Social.Leagues.LeaguesServerController.BlockingRequest = 0;
        }
    
    }

}
