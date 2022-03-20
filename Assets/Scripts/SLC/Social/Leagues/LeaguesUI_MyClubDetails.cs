using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_MyClubDetails : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text leaguePointsText;
        private UnityEngine.UI.Text leaguePointsBonusText;
        private UnityEngine.UI.Text leaguePointsTotalText;
        private UnityEngine.UI.Text leaguePointsMultiplierText;
        private UnityEngine.UI.Text myRankText;
        private UnityEngine.UI.Text clubRankText;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay tierDisplay;
        private UnityEngine.UI.Button increaseMultiplierButton;
        private UnityEngine.UI.Text mySeasonPoints;
        private UnityEngine.UI.Text seasonComparisonText;
        private UnityEngine.UI.Slider seasonComparisonSlider;
        private UnityEngine.GameObject clubRacer;
        private UnityEngine.RectTransform raceTrack;
        private UnityEngine.GameObject seasonRolloverInfo;
        private UnityEngine.RectTransform trackImage;
        private UnityEngine.RectTransform redZone;
        private UnityEngine.RectTransform greenZone;
        private float greenZoneFudge;
        private float redZoneFudge;
        private System.Collections.Generic.List<UnityEngine.GameObject> clubRacerList;
        private const int MAX_CLUBS = 15;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  863908768, name:  442544128);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  863908768, name:  442544128);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  863908768, name:  442544128);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  863908768, method:  new IntPtr(863883744));
            this.increaseMultiplierButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            this.UpdateUI();
            this.CheckRaceTrackUpdate();
        }
        private void OnDestroy()
        {
            this.StopAllCoroutines();
        }
        public void OnMyGuildUpdate()
        {
            this.UpdateUI();
            this.CheckRaceTrackUpdate();
        }
        public void OnMyProfileUpdate()
        {
            this.UpdateUI();
            this.CheckRaceTrackUpdate();
        }
        public void OnGuildListUpdate()
        {
            this.CheckRaceTrackUpdate();
        }
        private void CheckRaceTrackUpdate()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.seasonRolloverInfo.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.raceTrack.gameObject;
            this.raceTrack.SetActive(value:  false);
        }
        private System.Collections.IEnumerator UpdateRaceTrack()
        {
            object val_1 = new System.Object();
            typeof(LeaguesUI_MyClubDetails.<UpdateRaceTrack>d__28).__il2cppRuntimeField_8 = 0;
            typeof(LeaguesUI_MyClubDetails.<UpdateRaceTrack>d__28).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator CreateClubRacerItems()
        {
            object val_1 = new System.Object();
            typeof(LeaguesUI_MyClubDetails.<CreateClubRacerItems>d__29).__il2cppRuntimeField_8 = 0;
            typeof(LeaguesUI_MyClubDetails.<CreateClubRacerItems>d__29).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator SetupClubRacerItems()
        {
            object val_1 = new System.Object();
            typeof(LeaguesUI_MyClubDetails.<SetupClubRacerItems>d__30).__il2cppRuntimeField_8 = 0;
            typeof(LeaguesUI_MyClubDetails.<SetupClubRacerItems>d__30).__il2cppRuntimeField_10 = this;
        }
        private bool RacersOverlapping(float xPosA, float xPosB)
        {
            float val_2 = System.Math.Abs(R1 - R2);
            if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private UnityEngine.Vector2 GetPosInTrack(decimal points)
        {
            int val_3;
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            float val_4 = val_3.CalculateRaceTrackBounds(points:  new System.Decimal() {flags = points.hi, hi = points.lo, lo = points.mid, mid = val_3});
            uint val_6 = 865161480;
            this = 0;
            val_6 = val_6 * val_3;
            mem[1152921514061955108] = 0;
            this = new UnityEngine.Vector2(x:  val_6, y:  val_1.m_YMin);
            return new UnityEngine.Vector2() {x = val_6, y = val_1.m_YMin};
        }
        private float CalculateRaceTrackBounds(decimal points)
        {
            int val_4;
            var val_15;
            var val_16;
            int val_17;
            float val_18;
            val_15 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_2 = 0.GuildsInMyTier;
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            decimal val_3 = LeaguePointsFinal;
            val_16 = null;
            val_17 = val_4;
            val_16 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = R7, hi = SB, lo = SL, mid = val_17}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_18 = 0f;
                return (float)val_18;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_7 = 0.GuildsInMyTier;
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_9 = 0.GuildsInMyTier;
            var val_15 = 0;
            val_15 = val_15 - 1;
            if(0 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = 0;
            val_16 = val_16 + (val_15 << 2);
            val_15 = 0;
            decimal val_10 = LeaguePointsFinal;
            float val_11 = System.Decimal.op_Explicit(value:  new System.Decimal());
            float val_12 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = R7, hi = SB, lo = SL, mid = val_17});
            val_17 = points.flags;
            float val_14 = UnityEngine.Mathf.InverseLerp(a:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = points.flags, hi = points.hi, lo = points.lo, mid = points.mid}), b:  null, value:  null);
            val_18 = R0;
            return (float)val_18;
        }
        private void OnIncreaseMultiplierButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private void UpdateUI()
        {
            int val_8;
            int val_9;
            int val_10;
            int val_12;
            int val_14;
            int val_15;
            int val_16;
            SLC.Social.Leagues.LeaguesUI_MyClubDetails val_89;
            var val_90;
            var val_91;
            int val_92;
            object val_93;
            var val_94;
            var val_95;
            SLC.Social.Leagues.LeaguesUI_MyClubDetails val_96;
            var val_97;
            System.Func<SLC.Social.Leagues.Guild, System.Int32> val_99;
            var val_100;
            var val_101;
            var val_103;
            var val_104;
            val_89 = this;
            val_91 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            if(0 == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
            var val_7 = 0 + 68;
            val_92 = ???;
            decimal val_11 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 865501568, hi = val_92, lo = R6, mid = R7}, d2:  new System.Decimal() {hi = val_8, lo = val_9, mid = val_10});
            decimal val_13 = System.Decimal.Floor(d:  new System.Decimal() {flags = 865501552});
            decimal val_18 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 865501536}, d2:  new System.Decimal() {hi = val_14, lo = val_15, mid = val_16});
            GameEcon val_19 = App.getGameEcon;
            string val_20 = ToString(format:  null);
            GameEcon val_21 = App.getGameEcon;
            string val_22 = ToString(format:  null);
            string val_23 = System.String.Format(format:  2128510224, arg0:  865501592);
            GameEcon val_24 = App.getGameEcon;
            string val_25 = 0.ToString(format:  null);
            string val_26 = ToString();
            string val_27 = System.String.Format(format:  865486560, arg0:  865501600);
            SLC.Social.Leagues.LeaguesDataController val_28 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_29 = 0.MyGuild;
            mem[1152921514062295300].UpdateTierUI(guildTier:  1);
            SLC.Social.Leagues.LeaguesDataController val_30 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_31 = 0.MyGuild;
            GameEcon val_32 = App.getGameEcon;
            string val_33 = 52.ToString(format:  null);
            string val_34 = Ordinal.AddOrdinal(num:  52);
            string val_35 = Localization.Localize(key:  865486640, defaultValue:  865486752, useSingularKey:  false);
            string val_36 = System.String.Format(format:  865486848, arg0:  865486640, arg1:  865501588, arg2:  52);
            SLC.Social.Leagues.LeaguesDataController val_37 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_38 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_39 = SLC.Social.Leagues.LeaguesManager.DAO;
            int val_40 = 0.GetRankInGuildById(id:  0);
            GameEcon val_41 = App.getGameEcon;
            string val_42 = val_40.ToString(format:  null);
            string val_43 = Ordinal.AddOrdinal(num:  val_40);
            val_89 = val_40;
            string val_44 = Localization.Localize(key:  865486976, defaultValue:  865487088, useSingularKey:  false);
            string val_45 = System.String.Format(format:  865487184, arg0:  865501584, arg1:  val_89, arg2:  865486976);
            string val_46 = Localization.Localize(key:  865487312, defaultValue:  -1183154368, useSingularKey:  false);
            SLC.Social.Leagues.LeaguesDataController val_47 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_48 = 0.MyProfile;
            object val_91 = 0;
            val_91 = val_91 + 60;
            GameEcon val_49 = App.getGameEcon;
            string val_50 = val_91.ToString(format:  null);
            val_93 = val_91;
            val_94 = null;
            val_94 = null;
            if(App.game != 17)
            {
                goto label_55;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_51 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_52 = 0.MyProfile;
            var val_53 = 0 + 64;
            val_95 = null;
            val_95 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_55;
            }
            
            val_89 = 1152921511299501312;
            twelvegigs.Autopilot.AutopilotManager val_55 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((hasSubscription(subPackage:  0)) == true)
            {
                goto label_51;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((hasSubscription(subPackage:  1)) == false)
            {
                goto label_55;
            }
            
            label_51:
            twelvegigs.Autopilot.AutopilotManager val_59 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_60 = pointMultiplier;
            string val_61 = System.String.Format(format:  865487440, arg0:  val_93, arg1:  -1897280256);
            val_93 = "{0} x{1}";
            label_55:
            string val_62 = System.String.Format(format:  865487312, arg0:  865487536, arg1:  865487440, arg2:  1113431872);
            SLC.Social.Leagues.LeaguesDataController val_63 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_96 = val_89;
            System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_64 = 0.GuildsInMyTier;
            string val_65 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
            object val_66 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  null);
            val_90 = 0;
            val_91 = 1152921505051041792;
            val_97 = null;
            val_97 = null;
            val_99 = LeaguesUI_MyClubDetails.<>c.<>9__35_0;
            if(val_99 == 0)
            {
                    val_99 = null;
                val_99 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  LeaguesUI_MyClubDetails.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(865487648));
                LeaguesUI_MyClubDetails.<>c.<>9__35_0 = val_99;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_68 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  0, keySelector:  7720960);
            SLC.Social.Leagues.LeaguesDataController val_69 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_70 = 0.MyGuild;
            if(0 >= 3)
            {
                goto label_75;
            }
            
            label_83:
            UnityEngine.GameObject val_71 = mem[1152921514062295340].gameObject;
            val_100 = 0;
            goto label_78;
            label_75:
            val_93 = 0;
            decimal val_72 = LeaguePointsFinal;
            val_101 = null;
            val_101 = null;
            val_96 = val_89;
            if((1 == 1) || ((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true))
            {
                goto label_83;
            }
            
            if(0 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            decimal val_74 = LeaguePointsFinal;
            float val_75 = val_12.CalculateRaceTrackBounds(points:  new System.Decimal() {mid = val_12});
            val_89 = mem[1152921514062295340];
            val_91 = 0;
            UnityEngine.Vector2 val_76 = sizeDelta;
            UnityEngine.Vector2 val_78 = sizeDelta;
            float val_92 = 1f;
            val_92 = val_92 - val_12;
            UnityEngine.Vector2 val_80 = new UnityEngine.Vector2(x:  val_92, y:  val_78.y);
            val_89.sizeDelta = new UnityEngine.Vector2() {x = val_80.x, y = val_80.y};
            UnityEngine.GameObject val_81 = mem[1152921514062295340].gameObject;
            val_100 = 1;
            label_78:
            mem[1152921514062295340].SetActive(value:  true);
            if(0 >= 12)
            {
                goto label_91;
            }
            
            label_99:
            UnityEngine.GameObject val_82 = mem[1152921514062295336].gameObject;
            val_103 = 0;
            goto label_94;
            label_91:
            val_93 = 0;
            decimal val_83 = LeaguePointsFinal;
            val_104 = null;
            val_104 = null;
            if((1 == 15) || ((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) == true))
            {
                goto label_99;
            }
            
            if(0 <= 11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            decimal val_85 = LeaguePointsFinal;
            float val_86 = val_12.CalculateRaceTrackBounds(points:  new System.Decimal() {mid = val_12});
            val_91 = mem[1152921514062295336];
            val_89 = 0;
            UnityEngine.Vector2 val_87 = sizeDelta;
            UnityEngine.Vector2 val_88 = sizeDelta;
            UnityEngine.Vector2 val_89 = new UnityEngine.Vector2(x:  val_88.x, y:  val_88.y);
            val_91.sizeDelta = new UnityEngine.Vector2() {x = val_89.x, y = val_89.y};
            UnityEngine.GameObject val_90 = mem[1152921514062295336].gameObject;
            val_103 = 1;
            label_94:
            mem[1152921514062295336].SetActive(value:  true);
        }
        public LeaguesUI_MyClubDetails()
        {
            this.greenZoneFudge = 5f;
            this.redZoneFudge = -5f;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.clubRacerList = null;
        }
    
    }

}
