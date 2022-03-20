using UnityEngine;

namespace SLC.Social.Leagues
{
    public class Guild : EncodableModel
    {
        // Fields
        public string Name;
        public int AvatarId;
        public string Motto;
        public int tier;
        public int group;
        public int rank;
        public int maximumMembers;
        public bool InviteRequired;
        public int requiredVIPLevel;
        public int ServerId;
        public int MemberCount;
        public decimal LeaguePoints;
        public decimal LeaguePointsMultiplier;
        public string LeagueContributedCoins;
        public string TotalRewardedCoins;
        public decimal TotalPoints;
        public int EventPoints;
        public int TotalLeagues;
        public int guildLevel;
        public int ActiveMemberCount;
        public SLC.Social.Profile guildMaster;
        public SLC.Social.Leagues.GuildMembers members;
        public System.Collections.Generic.List<SLC.Social.Leagues.GuildJoinRequest> pendingRequests;
        public SLC.Social.Leagues.Conversation chat;
        public SLC.Social.Leagues.Conversation log;
        
        // Properties
        public decimal GetLeagueContributedCoins { get; }
        public decimal GetTotalRewardedCoins { get; }
        public SLC.Social.Leagues.GuildLevel Level { get; }
        public SLC.Social.Leagues.GuildLevel NextLevel { get; }
        public decimal LeaguePointsFinal { get; }
        public static int RandomIcon { get; }
        
        // Methods
        public decimal get_GetLeagueContributedCoins()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  829526144, provider:  R1 + 84);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public decimal get_GetTotalRewardedCoins()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  829638144, provider:  R1 + 88);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public SLC.Social.Leagues.GuildLevel get_Level()
        {
            return SLC.Social.Leagues.LeaguesEconomy.GetCurrentLevel(level:  this.guildLevel);
        }
        public SLC.Social.Leagues.GuildLevel get_NextLevel()
        {
            return SLC.Social.Leagues.LeaguesEconomy.GetNextLevel(level:  this.guildLevel);
        }
        public decimal get_LeaguePointsFinal()
        {
            int val_5;
            var val_1 = R1 + 60;
            val_5 = mem[(R1 + 60) + (0)];
            decimal val_2 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 829962092, hi = R1 + 52, lo = R1 + 56, mid = val_5}, d2:  new System.Decimal() {flags = mem[(R1 + 60) + (4)], hi = mem[(R1 + 60) + (8)], lo = mem[(R1 + 60) + (12)], mid = R1 + 76});
            decimal val_4 = System.Decimal.Floor(d:  new System.Decimal() {flags = 829974144});
            return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
        }
        public decimal ProgressThisLevel(int currentLevel)
        {
            int val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_3 = 0;
            val_4 = 0;
            val_5 = 0;
            val_6 = 0;
            val_7 = 0;
            goto label_1;
            label_12:
            val_8 = null;
            val_8 = null;
            decimal val_1 = System.Decimal.op_Implicit(value:  830074092);
            decimal val_2 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 830074076}, d2:  new System.Decimal() {flags = val_3});
            val_7 = 1;
            label_1:
            val_9 = null;
            val_9 = null;
            if(val_7 < (???))
            {
                    ??? = mem[SLC.Social.Leagues.LeaguesEconomy.GuildLevels + 12];
                ??? = SLC.Social.Leagues.LeaguesEconomy.GuildLevels + 12;
                goto label_12;
            }
            
            return new System.Decimal() {flags = 830086144, hi = SLC.Social.Leagues.LeaguesEconomy.__il2cppRuntimeField_cctor_finished, lo = val_2.lo, mid = val_2.mid};
        }
        public static SLC.Social.Leagues.Guild Create(string guildName, int guildIcon, string motto, SLC.Social.Profile guildMaster, bool requiresInvite, int vipLevelRequired)
        {
            if(new SLC.Social.Leagues.Guild() != 0)
            {
                    typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_8 = guildName;
                typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_C = guildIcon;
                typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_10 = motto;
                typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_24 = requiresInvite;
                typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_28 = vipLevelRequired;
            }
            else
            {
                    mem[8] = guildName;
                mem[16] = motto;
                mem[12] = guildIcon;
                mem[36] = requiresInvite;
                mem[40] = vipLevelRequired;
            }
            
            typeof(SLC.Social.Leagues.Guild).__il2cppRuntimeField_7C = guildMaster;
            guildMaster.GuildMaster = true;
        }
        public static int get_RandomIcon()
        {
            return 1;
        }
        public void RemoveMember(SLC.Social.Profile toRemove)
        {
            if((this.members.ContainsKey(key:  toRemove.ServerId)) == false)
            {
                    return;
            }
            
            bool val_2 = this.members.Remove(key:  toRemove.ServerId);
        }
        public void AddMember(SLC.Social.Profile toAdd)
        {
            int val_3;
            if(toAdd == 0)
            {
                    return;
            }
            
            val_3 = toAdd.ServerId;
            if((this.members.ContainsKey(key:  toAdd.ServerId)) != false)
            {
                    System.TimeType val_2 = this.members.Item[val_3];
                val_3 = this.members;
                if(this.members != 0)
            {
                goto label_6;
            }
            
            }
            else
            {
                    this.members.Add(key:  val_3, value:  toAdd);
            }
            
            label_6:
            if(toAdd.GuildMaster == true)
            {
                    this.guildMaster = toAdd;
            }
        
        }
        public void AddInviteRequest(SLC.Social.Leagues.GuildJoinRequest toAdd)
        {
            this.pendingRequests.Add(item:  toAdd);
        }
        public void RemoveInvite(SLC.Social.Leagues.GuildJoinRequest toRemove)
        {
            if((this.pendingRequests.Contains(item:  toRemove)) == false)
            {
                    return;
            }
            
            bool val_2 = this.pendingRequests.Remove(item:  toRemove);
        }
        private void Destroy()
        {
            this.guildMaster = 0;
            this.members = 0;
        }
        public void MergeMembers(SLC.Social.Leagues.GuildMembers toMerge)
        {
            float val_3;
            int val_10;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_9:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if((toMerge.ContainsKey(key:  val_5 + 8)) == false)
            {
                goto label_5;
            }
            
            System.TimeType val_7 = toMerge.Item[val_5 + 8];
            goto label_9;
            label_5:
            Add(item:  0);
            goto label_9;
            label_2:
            0.Dispose();
            List.Enumerator<T> val_8 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            bool val_11 = this.members.Remove(key:  val_10);
            goto label_13;
            label_11:
            Dispose();
            Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
            label_19:
            if(val_3.MoveNext() == false)
            {
                goto label_15;
            }
            
            if((this.members.ContainsKey(key:  val_3)) == true)
            {
                goto label_19;
            }
            
            this.members.Add(key:  val_3, value:  R6);
            goto label_19;
            label_15:
            val_3.Dispose();
        }
        public void MergeInvites(System.Collections.Generic.List<object> invitesToParse)
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pendingRequests = null;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_15:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_6 = 0.Item[-256444880];
            val_9 = 0;
            if(0 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_9 = 0;
            }
            
            Decode(jasonObject:  0, sourceModel:  0);
            object val_7 = new System.Object();
            typeof(SLC.Social.Leagues.GuildJoinRequest).__il2cppRuntimeField_8 = new SLC.Social.Profile();
            typeof(SLC.Social.Leagues.GuildJoinRequest).__il2cppRuntimeField_C = this;
            string val_8 = 0.Item[1624646480];
            val_10 = 0;
            typeof(SLC.Social.Leagues.GuildJoinRequest).__il2cppRuntimeField_10 = ;
            this.pendingRequests.Add(item:  442064896);
            goto label_15;
            label_2:
            Dispose();
        }
        public void MergeChat(System.Collections.Generic.List<object> toParse)
        {
            twelvegigs.sweepstakes.Distribution val_3;
            twelvegigs.sweepstakes.Distribution val_4;
            this.chat.Clear();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_4 = 0;
            if(val_3 != 0)
            {
                    if(val_3 != null)
            {
                
            }
            else
            {
                    val_4 = val_3;
            }
            
            }
            
            this.chat.Add(item:  val_4);
            goto label_8;
            label_3:
            Dispose();
        }
        public void MergeLog(System.Collections.Generic.List<object> toParse)
        {
            twelvegigs.sweepstakes.Distribution val_3;
            twelvegigs.sweepstakes.Distribution val_4;
            this.log.Clear();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_4 = 0;
            if(val_3 != 0)
            {
                    if(val_3 != null)
            {
                
            }
            else
            {
                    val_4 = val_3;
            }
            
            }
            
            this.log.Add(item:  val_4);
            goto label_8;
            label_3:
            Dispose();
        }
        public SLC.Social.Profile[] GetMembers()
        {
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.members.Values;
            return System.Linq.Enumerable.ToArray<System.Object>(source:  this.members);
        }
        public int GetRankInGuildById(int id)
        {
            var val_13;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Profile>, System.Decimal> val_15;
            var val_16;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Profile>, System.Decimal> val_18;
            var val_19;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Profile>, System.Int32> val_21;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Profile>, SLC.Social.Profile> val_23;
            object val_1 = new System.Object();
            typeof(Guild.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = id;
            val_13 = null;
            val_13 = null;
            val_15 = Guild.<>c.<>9__49_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Decimal>(object:  Guild.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(831759808));
                Guild.<>c.<>9__49_0 = val_15;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Decimal>(source:  this.members, keySelector:  7720960);
            val_16 = null;
            val_16 = null;
            val_18 = Guild.<>c.<>9__49_1;
            if(val_18 == 0)
            {
                    val_18 = null;
                val_18 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Decimal>(object:  Guild.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(831762880));
                Guild.<>c.<>9__49_1 = val_18;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_5 = System.Linq.Enumerable.ThenByDescending<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Decimal>(source:  this.members, keySelector:  7720960);
            val_19 = null;
            val_19 = null;
            val_21 = Guild.<>c.<>9__49_2;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_21 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  Guild.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(831764928));
                val_19 = null;
                Guild.<>c.<>9__49_2 = val_21;
            }
            
            val_19 = null;
            val_23 = Guild.<>c.<>9__49_3;
            if(val_23 == 0)
            {
                    val_23 = null;
                val_23 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Object>(object:  Guild.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(831766976));
                Guild.<>c.<>9__49_3 = val_23;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_8 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32, System.Object>(source:  this.members, keySelector:  7720960, elementSelector:  7720960);
            Dictionary.ValueCollection<TKey, TValue> val_9 = this.members.Values;
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<System.Object>(source:  this.members);
            System.Predicate<ZooTile> val_11 = new System.Predicate<ZooTile>(object:  441958400, method:  new IntPtr(831771072));
            int val_12 = this.members.FindIndex(match:  8040448);
            val_12 = val_12 + 1;
            return (int)val_12;
        }
        public override string ToString()
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  831914336);
            return System.String.Format(format:  831890240, arg0:  831914336);
        }
        public Guild()
        {
            this.tier = 15;
            decimal val_1 = new System.Decimal(lo:  10, mid:  0, hi:  0, isNegative:  false, scale:  1);
            this.guildLevel = 1;
            this.members = new SLC.Social.Leagues.GuildMembers();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pendingRequests = null;
            this.chat = new SLC.Social.Leagues.Conversation();
            this.log = new SLC.Social.Leagues.Conversation();
        }
    
    }

}
