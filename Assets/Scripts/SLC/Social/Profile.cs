using UnityEngine;

namespace SLC.Social
{
    public class Profile : EncodableModel
    {
        // Fields
        public int ServerId;
        public string Name;
        public int Level;
        public int LifetimeLeaguePoints;
        public int LastSeasonLeaguePoints;
        public int BestSeasonLeaguePoints;
        public int LastSeasonRankInClub;
        public int AvatarId;
        public string FacebookId;
        public bool UseFacebook;
        public bool IsAdmin;
        public int GuildServerId;
        public int UserId;
        public int firstJoinedClubAt;
        public decimal leaguePoints;
        public bool GuildMaster;
        public bool Officer;
        public int contributedAt;
        public string leagueCoins;
        public int PendingGuildRequestId;
        public bool mvp;
        public decimal mvpReward;
        public int goldenCurrency;
        public bool hasSubscriptionActive;
        public bool isMemberActive;
        public string _wordIQ;
        
        // Properties
        public bool hasJoinedClub { get; }
        public float WordIQ { get; set; }
        public int GuildMemberId { get; set; }
        public System.DateTime GetContributedAt { get; }
        public decimal GetLeagueCoins { get; }
        
        // Methods
        public bool get_hasJoinedClub()
        {
            if(this.firstJoinedClubAt != 0)
            {
                    this.firstJoinedClubAt = 1;
            }
            
            return true;
        }
        public float get_WordIQ()
        {
            float val_9;
            if((System.String.IsNullOrEmpty(value:  this._wordIQ)) != false)
            {
                    float val_3 = WordIQManager.BaseIQ;
                string val_4 = 0.ToString();
                this._wordIQ = ;
                float val_5 = WordIQManager.BaseIQ;
                val_9 = 0;
                return val_9;
            }
            
            float val_6 = WordIQManager.BaseIQ;
            bool val_8 = System.Single.TryParse(s:  this._wordIQ, result: out  float val_7 = 3.965249E-10f);
            val_9 = 0f;
            return val_9;
        }
        public void set_WordIQ(float value)
        {
            string val_1 = ???.ToString();
            this._wordIQ = ???;
        }
        public int get_GuildMemberId()
        {
            return (int)this.ServerId;
        }
        public void set_GuildMemberId(int value)
        {
            this.ServerId = value;
        }
        public System.DateTime get_GetContributedAt()
        {
            System.DateTime val_1 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, millisecond:  0);
            System.DateTime val_2 = this.AddSeconds(value:  null);
            return new System.DateTime() {dateData = val_2.dateData};
        }
        public decimal get_GetLeagueCoins()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  803395680, provider:  R1 + 84);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public override void Merge(EncodableModel model)
        {
            var val_16;
            object val_17;
            var val_18;
            var val_19;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_21;
            var val_22;
            var val_23;
            float val_24;
            var val_25;
            var val_26;
            var val_27;
            val_16 = this;
            val_17 = model;
            System.Type val_1 = val_16.GetType();
            System.Type val_2 = val_17.GetType();
            if(val_16 == 0)
            {
                goto label_39;
            }
            
            System.Type val_3 = val_17.GetType();
            System.Type val_4 = val_16.GetType();
            if(val_17 == 0)
            {
                goto label_39;
            }
            
            System.Type val_5 = val_16.GetType();
            val_18 = 1152921505047261184;
            val_19 = null;
            val_19 = null;
            val_21 = Profile.<>c.<>9__38_0;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  Profile.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(803487776));
                Profile.<>c.<>9__38_0 = val_21;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<System.Object>(source:  803512800, predicate:  7720960);
            val_18 = 0;
            val_18 = val_18 + 1;
            val_22 = val_16;
            val_23 = val_16;
            val_24 = 1152921504683417600;
            label_33:
            val_18 = 0;
            val_18 = val_18 + 1;
            val_25 = val_23;
            if(val_23 == 0)
            {
                goto label_23;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_26 = val_23;
            System.Type val_11 = val_17.GetType();
            System.Reflection.FieldInfo val_12 = val_17.GetField(name:  803512800);
            this.SetValue(obj:  803512800, value:  val_17);
            goto label_33;
            label_23:
            val_16 = 0;
            if(val_23 != 0)
            {
                    val_18 = 0;
                val_18 = val_18 + 1;
                val_27 = val_23;
            }
            
            label_39:
            var val_14 = FP - 28;
        }
        public override string ToString()
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  803628992, formatting:  1);
            return System.String.Format(format:  803604896, arg0:  803628992);
        }
        public Profile()
        {
            this.Name = "Player";
            this.Level = 1;
            this.LastSeasonRankInClub = 0;
            this.GuildServerId = 0;
            this.FacebookId = "";
            this._wordIQ = "";
        }
    
    }

}
