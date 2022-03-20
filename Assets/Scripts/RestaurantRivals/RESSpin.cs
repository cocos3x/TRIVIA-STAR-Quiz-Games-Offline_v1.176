using UnityEngine;

namespace RestaurantRivals
{
    public class RESSpin
    {
        // Fields
        public int spinBet;
        public System.Collections.Generic.List<RestaurantRivals.RESSpin> spinSeries;
        public int spinNumber;
        public bool spinToEmpty;
        public int spinBalance;
        public decimal coinBalance;
        public int shieldBalance;
        public RestaurantRivals.RESLevelDef levelDef;
        protected int reelsPacked;
        public RestaurantRivals.RESPayout payout;
        public bool anticipateReel3;
        public decimal coinGain;
        public decimal attackOrRaidPotentialCoins;
        public int shieldGain;
        public int spinGain;
        public int eventSymbolGain;
        protected static int COIN;
        protected static int BAG;
        protected static int ATTACK;
        protected static int RAID;
        protected static int SHIELD;
        protected static int SPIN;
        protected static int EVENTSYMBOL;
        protected static int SHIFTREEL2;
        protected static int SHIFTREEL3;
        protected static int REEL1;
        protected static int REEL2;
        protected static int REEL3;
        public static RestaurantRivals.RESSpin.PackedResultsId currentPackedResultsId;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults_Default;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults_AttackMadness;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults_RaidMadness;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults_WithEventSymbol_Default;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults_WithEventSymbol_Alt;
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> _packedResults;
        protected static int[] alias;
        protected static double[] probability;
        private static RestaurantRivals.RESManager manager;
        private static RestaurantRivals.RESPlayer player;
        private static RestaurantRivals.RESGameEcon gameEcon;
        
        // Properties
        public string reel1Result { get; }
        public string reel2Result { get; }
        public string reel3Result { get; }
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> packedResults { get; set; }
        public decimal totalCoinGain { get; }
        
        // Methods
        public string get_reel1Result()
        {
            var val_2;
            var val_3;
            var val_2 = 29713118;
            val_2 = 5912424 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_2 = null;
            val_2 = null;
            int val_3 = this.reelsPacked;
            val_3 = null;
            val_3 = null;
            val_3 = (RestaurantRivals.RESSpin.REEL1 & val_3) - 1;
            if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = RestaurantRivals.RESSymbol.currentOrdered + 8;
            val_4 = val_4 + (val_3 << 2);
        }
        public string get_reel2Result()
        {
            var val_3;
            var val_4;
            var val_3 = 29712794;
            val_3 = 5912748 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            int val_4 = this.reelsPacked;
            val_4 = null;
            val_4 = null;
            val_4 = 0 + ((RestaurantRivals.RESSpin.REEL2 & val_4) >> (RestaurantRivals.RESSpin.SHIFTREEL2 & 31));
            if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = RestaurantRivals.RESSymbol.currentOrdered + 8;
            val_5 = val_5 + (val_4 << 2);
        }
        public string get_reel3Result()
        {
            var val_3;
            var val_4;
            var val_3 = 29712458;
            val_3 = 5913084 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            int val_4 = this.reelsPacked;
            val_4 = null;
            val_4 = null;
            val_4 = 0 + ((RestaurantRivals.RESSpin.REEL3 & val_4) >> (RestaurantRivals.RESSpin.SHIFTREEL3 & 31));
            if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = RestaurantRivals.RESSymbol.currentOrdered + 8;
            val_5 = val_5 + (val_4 << 2);
        }
        protected static System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> get_packedResults()
        {
            var val_1 = null;
            if(RestaurantRivals.RESSpin._packedResults == 0)
            {
                    UnityEngine.Debug.Log(message:  651984352);
                val_1 = null;
            }
            
            val_1 = null;
        }
        protected static void set_packedResults(System.Collections.Generic.List<RestaurantRivals.RESSpin.Result> value)
        {
            null = null;
            RestaurantRivals.RESSpin._packedResults = value;
        }
        public static void SwapSlotOutcomeResults(RestaurantRivals.RESSpin.PackedResultsId resultsId)
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<Result> val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            RestaurantRivals.RESSpin.alias = 0;
            RestaurantRivals.RESSpin.probability = 0;
            RestaurantRivals.RESSpin.currentPackedResultsId = resultsId;
            PackedResultsId val_1 = resultsId - 1;
            if(val_1 <= 3)
            {
                    var val_2 = 5913828 + (5913828 + ((resultsId - 1)) << 2);
                if(val_1 == 3)
            {
                    val_3 = 429817856;
                val_3 = val_3 & (((R8) << (32-val_3)) | ((R8) << val_3));
                val_3 = val_3 & ((R8) >> 2);
                val_3 = val_3 & (((int)IP) >> 5913828 + ((resultsId - 1)) << 2);
            }
            
                if(((((((val_3 & ((R8) << (32-val_3)) | ((R8) << val_3)) & (R8) >> 2) & ((int)IP) >> 5913828 + ((resultsId - 1)) << 2) + 187) & 2) == 0) && (((((val_3 & ((R8) << (32-val_3)) | ((R8) << val_3)) & (R8) >> 2) & ((int)IP) >> 5913828 + ((resultsId - 1)) << 2) + 116) == 0))
            {
                    val_3 = null;
            }
            
                val_4 = 5913892 + 29711651;
                val_5 = RestaurantRivals.RESSpin.packedResults_AttackMadness;
            }
            else
            {
                    val_3 = null;
                val_4 = 5913944 + 29711599;
                val_5 = RestaurantRivals.RESSpin.packedResults_Default;
            }
            
            if( == 0)
            {
                    val_3 = null;
                mem2[0] = 1;
            }
            
            val_3 = null;
            RestaurantRivals.RESSpin._packedResults = ;
            val_6 = 0;
            RestaurantRivals.RESSymbol.IncludeEventSymbols(includeSymbols:  true);
            RestaurantRivals.RESSpin.initAliasMethod();
        }
        public static void initAliasMethod()
        {
            var val_7;
            float val_32;
            var val_33;
            var val_35;
            var val_36;
            int val_37;
            var val_40;
            val_32 = 1152921505036664832;
            val_33 = null;
            val_33 = null;
            if(RestaurantRivals.RESSpin.alias != null)
            {
                    val_33 = null;
                if(RestaurantRivals.RESSpin.probability != null)
            {
                    return;
            }
            
            }
            
            System.Collections.Generic.List<Result> val_1 = RestaurantRivals.RESSpin.packedResults;
            RestaurantRivals.RESSpin.probability = null;
            System.Collections.Generic.List<Result> val_2 = RestaurantRivals.RESSpin.packedResults;
            RestaurantRivals.RESSpin.alias = null;
            System.Collections.Generic.List<Result> val_3 = RestaurantRivals.RESSpin.packedResults;
            System.Collections.Generic.List<Result> val_4 = RestaurantRivals.RESSpin.packedResults;
            List.Enumerator<T> val_6 = GetEnumerator();
            val_35 = 1152921513849119472;
            goto label_13;
            label_15:
            label_13:
            if(MoveNext() == true)
            {
                goto label_15;
            }
            
            Dispose();
            System.Collections.Generic.List<Result> val_10 = RestaurantRivals.RESSpin.packedResults;
            List.Enumerator<T> val_11 = GetEnumerator();
            goto label_19;
            label_22:
            if(val_7 != 0)
            {
                    val_36 = mem[val_7 + 12];
                val_36 = val_7 + 12;
            }
            else
            {
                    val_36 = 0;
            }
            
            mem2[0] = D16 / (D10 + D16);
            label_19:
            if(MoveNext() == true)
            {
                goto label_22;
            }
            
            Dispose();
            val_37 = 0;
            System.Collections.Generic.List<Result> val_17 = RestaurantRivals.RESSpin.packedResults;
            val_35 = 0;
            val_40 = null;
            val_37 = Pop();
            System.Double[] val_29 = RestaurantRivals.RESSpin.probability + (val_37 << 3);
            mem2[0] = val_35;
            mem2[0] = 1072693248;
        }
        public static int rollResultIndex()
        {
            var val_6;
            var val_7;
            System.Collections.Generic.List<Result> val_1 = RestaurantRivals.RESSpin.packedResults;
            val_6 = UnityEngine.Random.Range(min:  0, max:  -600180352);
            float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
            System.Double[] val_4 = RestaurantRivals.RESSpin.probability + (val_6 << 3);
            if((RestaurantRivals.RESSpin.probability + 12) > val_6)
            {
                    return (int)val_6;
            }
            
            val_7 = null;
            val_7 = null;
            System.Int32[] val_5 = RestaurantRivals.RESSpin.alias + (val_6 << 2);
            val_6 = mem[(RestaurantRivals.RESSpin.alias + (val_2) << 2) + 16];
            val_6 = (RestaurantRivals.RESSpin.alias + (val_2) << 2) + 16;
            return (int)val_6;
        }
        public decimal get_totalCoinGain()
        {
            int val_3;
            RestaurantRivals.RESSpin val_5;
            int val_8;
            var val_9;
            RestaurantRivals.RESSpin val_10;
            var val_11;
            var val_12;
            int val_13;
            RestaurantRivals.RESSpin val_14;
            val_8 = mem[R1 + 12];
            val_8 = R1 + 12;
            if(val_8 == 0)
            {
                    return new System.Decimal() {flags = R1 + 64, hi = val_8};
            }
            
            val_9 = public List.Enumerator<T> System.Collections.Generic.List<RestaurantRivals.RESSpin>::GetEnumerator();
            List.Enumerator<T> val_1 = GetEnumerator();
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_6:
            decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 652575880, mid = val_3}, d2:  new System.Decimal() {flags = val_13, hi = val_2 + 64, lo = val_2 + 68, mid = val_2 + 72});
            val_10 = val_5;
            label_2:
            val_3 = ???;
            if(MoveNext() == true)
            {
                goto label_6;
            }
            
            val_8 = public System.Void List.Enumerator<RestaurantRivals.RESSpin>::Dispose();
            Dispose();
            val_14 = this;
            this = val_10;
            return new System.Decimal() {flags = R1 + 64, hi = val_8};
        }
        public static RestaurantRivals.RESSpin RunSpinSeries(int startSpinBet, int startSpinBalance, decimal startCoinBalance, int startShieldBalance, RestaurantRivals.RESLevelDef levelDef)
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = null;
            val_6 = null;
            RestaurantRivals.RESSpin.manager = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance();
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESSpin.player = 0;
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            RestaurantRivals.RESSpin.gameEcon = 0;
            RestaurantRivals.RESSpin val_4 = new RestaurantRivals.RESSpin(rSpinBet:  startSpinBet, rSpinBalance:  startSpinBalance, rCoinBalance:  new System.Decimal() {flags = startCoinBalance.flags, hi = startCoinBalance.hi, lo = startCoinBalance.lo, mid = startCoinBalance.mid}, rShieldBalance:  startShieldBalance, rLevelDef:  levelDef, rSpinToEmpty:  true, rSpinSeries:  0, rSpinNumber:  0);
            do
            {
                RestaurantRivals.RESSpin val_5 = Spin();
            }
            while(null != 0);
        
        }
        public RESSpin(int rSpinBet, int rSpinBalance, decimal rCoinBalance, int rShieldBalance, RestaurantRivals.RESLevelDef rLevelDef, bool rSpinToEmpty = False, System.Collections.Generic.List<RestaurantRivals.RESSpin> rSpinSeries, int rSpinNumber = 0)
        {
            System.Collections.Generic.List<RestaurantRivals.RESSpin> val_2;
            var val_3;
            val_2 = rSpinSeries;
            this.spinBet = 1;
            val_3 = null;
            val_3 = null;
            int val_2 = RestaurantRivals.RESSpin.SHIFTREEL2;
            int val_3 = RestaurantRivals.RESSpin.ATTACK;
            val_2 = val_2 & 31;
            int val_4 = RestaurantRivals.RESSpin.SHIFTREEL3;
            val_3 = RestaurantRivals.RESSpin.SPIN | (val_3 << val_2);
            val_4 = val_4 & 31;
            val_4 = val_3 | (RestaurantRivals.RESSpin.SHIELD << val_4);
            this.reelsPacked = val_4;
            this.spinBalance = rSpinBalance;
            this.coinBalance = rCoinBalance;
            mem[1152921513849609936] = rCoinBalance.hi;
            mem[1152921513849609940] = rCoinBalance.lo;
            mem[1152921513849609944] = rCoinBalance.mid;
            this.shieldBalance = rShieldBalance;
            this.levelDef = rLevelDef;
            this.spinToEmpty = rSpinToEmpty;
            this.spinBet = rSpinBet;
            this.spinSeries = val_2;
            this.spinNumber = rSpinNumber;
            if((val_2 == 0) && (rSpinToEmpty != false))
            {
                    val_2 = null;
                val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.spinSeries = val_2;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            Add(item:  652828336);
        }
        public RestaurantRivals.RESSpin Spin()
        {
            int val_3;
            RestaurantRivals.RESSpin val_6;
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            this.DeductBet();
            this.RollSpin();
            this.GivePayout();
            val_6 = 0;
            if(this.spinToEmpty == false)
            {
                    return;
            }
            
            if(this.spinBalance < 1)
            {
                    return;
            }
            
            val_9 = mem[this.coinBalance + (8)];
            val_10 = IP;
            val_8 = mem[this.coinBalance + (4)];
            val_7 = mem[this.coinBalance + (0)];
            decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 652944668, hi = val_7, lo = val_8, mid = val_9}, d2:  new System.Decimal() {flags = mem[this.coinBalance + (12)], hi = this.coinGain, lo = ???, mid = val_10});
            int val_6 = this.shieldBalance;
            val_6 = null;
            val_6 = this.shieldGain + val_6;
            val_6 = new RestaurantRivals.RESSpin(rSpinBet:  this.spinBet, rSpinBalance:  this.spinGain + this.spinBalance, rCoinBalance:  new System.Decimal() {flags = val_3}, rShieldBalance:  val_6, rLevelDef:  this.levelDef, rSpinToEmpty:  this.spinToEmpty, rSpinSeries:  this.spinSeries, rSpinNumber:  this.spinNumber + 1);
        }
        protected void DeductBet()
        {
            int val_1;
            int val_2;
            var val_3;
            int val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_1 = this.spinBet;
            val_2 = this.spinBalance;
            if(val_1 > val_2)
            {
                    var val_1 = 0;
                val_3 = null;
                val_4 = this.levelDef.levelNumber;
                val_3 = null;
                val_1 = val_1 + 1;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = null;
                val_4 = this.spinBalance;
                val_5 = null;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_6 = null;
                val_6 = null;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = null;
                val_7 = null;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_8 = null;
                val_8 = null;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_2 = this.spinBalance;
                this.spinBet = List<T>.__il2cppRuntimeField_10;
            }
            
            this.spinBalance = (this.spinBalance - List<T>.__il2cppRuntimeField_10);
        }
        protected void RollSpin()
        {
            System.Collections.Generic.List<Result> val_1 = RestaurantRivals.RESSpin.packedResults;
            int val_2 = RestaurantRivals.RESSpin.rollResultIndex();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.reelsPacked = (RestaurantRivals.RESSpin.__il2cppRuntimeField_name + (val_2) << 2) + 16 + 8;
            this.payout = (RestaurantRivals.RESSpin.__il2cppRuntimeField_name + (val_2) << 2) + 16 + 16;
            this.anticipateReel3 = (RestaurantRivals.RESSpin.__il2cppRuntimeField_name + (val_2) << 2) + 16 + 20;
        }
        protected void GivePayout()
        {
            int val_17;
            int val_18;
            RestaurantRivals.RESPayout val_25;
            int val_26;
            int val_27;
            var val_28;
            this.shieldGain = 0;
            this.spinGain = 0;
            this.eventSymbolGain = 0;
            val_25 = this.payout;
            if(val_25 == 7)
            {
                    val_27 = this.levelDef.attackHitPayout;
                int val_1 = this.spinBet * val_27;
                decimal val_2 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 4)
            {
                    val_27 = this.levelDef.bag1Payout;
                int val_3 = this.spinBet * val_27;
                decimal val_4 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 5)
            {
                    val_27 = this.levelDef.bag2Payout;
                int val_5 = this.spinBet * val_27;
                decimal val_6 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 6)
            {
                    val_27 = this.levelDef.bag3Payout;
                int val_7 = this.spinBet * val_27;
                decimal val_8 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 1)
            {
                    val_27 = this.levelDef.coin1Payout;
                int val_9 = this.spinBet * val_27;
                decimal val_10 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 2)
            {
                    val_27 = this.levelDef.coin2Payout;
                int val_11 = this.spinBet * val_27;
                decimal val_12 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 3)
            {
                    val_27 = this.levelDef.coin3Payout;
                int val_13 = this.spinBet * val_27;
                decimal val_14 = System.Decimal.op_Implicit(value:  653374880);
                val_25 = this.payout;
            }
            
            if(val_25 == 8)
            {
                    decimal val_15 = getRaidPayout;
                decimal val_16 = System.Decimal.op_Implicit(value:  653374864);
                val_27 = val_18;
                decimal val_19 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 653374848}, d2:  new System.Decimal() {flags = val_17, hi = val_27});
                val_25 = this.payout;
            }
            
            if(val_25 == 9)
            {
                    val_28 = null;
                val_28 = null;
                val_26 = RestaurantRivals.RESSpin.manager.MaxShieldCount;
                val_27 = this.shieldBalance;
                int val_22 = UnityEngine.Mathf.Min(a:  this.spinBet, b:  val_26 - val_27);
                val_25 = this.payout;
                int val_25 = this.spinBet;
                this.shieldGain = val_22;
                val_25 = val_25 - val_22;
                this.spinGain = val_25;
            }
            
            if(val_25 == 10)
            {
                    val_26 = this.spinBet;
                RestaurantRivals.RESGameEcon val_23 = RestaurantRivals.RESGameEcon.Instance;
                int val_26 = 1261;
                val_25 = this.payout;
                val_26 = val_26 * val_26;
                this.spinGain = val_26;
            }
            
            if(val_25 != 11)
            {
                    return;
            }
            
            if(HotNSpicyEventHandler.IsEventActive == false)
            {
                    return;
            }
            
            this.eventSymbolGain = HotNSpicyEcon.__il2cppRuntimeField_element_class;
        }
        public void SetRaidAttackResults(decimal winnings)
        {
            int val_2;
            int val_3;
            int val_4;
            RestaurantRivals.RESSpin val_10;
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            int val_15;
            int val_16;
            val_10 = this;
            val_11 = winnings.hi;
            val_12 = winnings.flags;
            val_13 = winnings.mid;
            val_13 = winnings.mid;
            val_16 = val_13;
            decimal val_1 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 653573904, hi = val_12, lo = val_11, mid = winnings.lo}, d2:  new System.Decimal() {flags = val_13, hi = this.coinGain, mid = ???});
            this.coinGain = winnings;
            mem[1152921513850367604] = val_11;
            mem[1152921513850367608] = winnings.lo;
            mem[1152921513850367612] = val_16;
            if(this.spinSeries == 0)
            {
                    return;
            }
            
            int val_6 = this.spinSeries.IndexOf(item:  653585968);
            val_11 = val_6 + 5;
            goto label_4;
            label_11:
            if(val_6 <= winnings.lo)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = mem[0 + ((val_6 + 5)) << 2 + 28 + 4];
            val_14 = 0 + ((val_6 + 5)) << 2 + 28 + 4;
            val_15 = mem[0 + ((val_6 + 5)) << 2 + 28 + 12];
            val_15 = 0 + ((val_6 + 5)) << 2 + 28 + 12;
            decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 653573904, hi = 0 + ((val_6 + 5)) << 2 + 28, lo = val_14, mid = 0 + ((val_6 + 5)) << 2 + 28 + 8}, d2:  new System.Decimal() {flags = val_15, hi = val_2, lo = val_3, mid = val_4});
            val_11 = val_11 + 1;
            val_10 = val_10;
            label_4:
            val_16 = this.spinSeries;
            if((val_11 - 4) < val_7.flags)
            {
                goto label_11;
            }
        
        }
        public override string ToString()
        {
            var val_8;
            typeof(System.Object[]).__il2cppRuntimeField_10 = "[#";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "  bet:";
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "  spins:";
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = "  coins:";
            typeof(System.Object[]).__il2cppRuntimeField_2C = null;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "  shields:";
            typeof(System.Object[]).__il2cppRuntimeField_34 = null;
            typeof(System.Object[]).__il2cppRuntimeField_38 = "  reels:<";
            val_8 = null;
            val_8 = null;
            string val_1 = this.reel1Result;
            string val_2 = RestaurantRivals.RESSymbol.debugTxt.Item[653707072];
            typeof(System.Object[]).__il2cppRuntimeField_3C = RestaurantRivals.RESSymbol.debugTxt;
            string val_3 = this.reel2Result;
            string val_4 = RestaurantRivals.RESSymbol.debugTxt.Item[653707072];
            typeof(System.Object[]).__il2cppRuntimeField_40 = RestaurantRivals.RESSymbol.debugTxt;
            string val_5 = this.reel3Result;
            string val_6 = RestaurantRivals.RESSymbol.debugTxt.Item[653707072];
            typeof(System.Object[]).__il2cppRuntimeField_44 = RestaurantRivals.RESSymbol.debugTxt;
            typeof(System.Object[]).__il2cppRuntimeField_48 = ">--";
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            typeof(System.Object[]).__il2cppRuntimeField_4C = null;
            typeof(System.Object[]).__il2cppRuntimeField_50 = "  coins +";
            typeof(System.Object[]).__il2cppRuntimeField_54 = null;
            typeof(System.Object[]).__il2cppRuntimeField_58 = "  shields +";
            typeof(System.Object[]).__il2cppRuntimeField_5C = null;
            typeof(System.Object[]).__il2cppRuntimeField_60 = "  spins +";
            typeof(System.Object[]).__il2cppRuntimeField_64 = null;
            typeof(System.Object[]).__il2cppRuntimeField_68 = "]";
            string val_7 = +472754880;
        }
        public string PrintSeries()
        {
            string val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_4 = 1098586544 + val_3 + 1269544832;
            goto label_4;
            label_2:
            Dispose();
            decimal val_5 = totalCoinGain;
            string val_6 = 1098586544 + 10170368 + 653799168;
        }
        public void SetSpin(System.Nullable<RestaurantRivals.RESPayout> hackSpinType)
        {
            var val_10;
            var val_11;
            int val_12;
            RESSpin.Result val_13;
            var val_14;
            val_10 = hackSpinType.HasValue;
            if((R2 & 255) != 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = RestaurantRivals.RESSpin.ATTACK;
            val_13 = null;
            val_13 = new RESSpin.Result(reel1:  val_12, reel2:  RestaurantRivals.RESSpin.RAID, reel3:  RestaurantRivals.RESSpin.SPIN, _weight:  180, _payout:  0, _anticipate:  false);
            if(val_10 <= true)
            {
                    var val_2 = 5889488 + (5889488 + (hackSpinType.HasValue) << 2);
                if(val_10 == true)
            {
                    5889488 = 5889488;
                5889488 = 5889488 & (((this) << (32-5889488 + (hackSpinType.HasValue) << 2)) | ((this) << 5889488 + (hackSpinType.HasValue) << 2));
                5889488 = 5889488 & (((int)IP) >> 3);
                5889488 = 5889488 & ((IP) << RestaurantRivals.RESSpin.RAID);
                5889488 = 5889488 & 40871466;
                5889488 = 5889488 & 10217866;
                5889488 = this * RestaurantRivals.RESSpin.SPIN;
                5889488 = 5889488 & 1078850757;
                5889488 = 5889488 & 2554466;
                5889488 = this * RestaurantRivals.RESSpin.RAID;
                5889488 = 5889488 & 1343454513;
            }
            
                System.Collections.Generic.List<Result> val_3 = RestaurantRivals.RESSpin.packedResults;
                val_14 = null;
                val_14 = null;
                val_12 = RESSpin.<>c.<>9__65_0;
                if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  RESSpin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(653915360));
                RESSpin.<>c.<>9__65_0 = val_12;
            }
            
                System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<System.Object>(source:  429817856, predicate:  7720960);
                System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  429817856);
                int val_7 = UnityEngine.Random.Range(min:  0, max:  -600180352);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_13 = mem[(RestaurantRivals.RESSpin.__il2cppRuntimeField_name + (val_7) << 2) + 16];
                val_13 = (RestaurantRivals.RESSpin.__il2cppRuntimeField_name + (val_7) << 2) + 16;
            }
            
            if( != 0)
            {
                    mem2[0] = RESSpin.Result.__il2cppRuntimeField_name;
                mem2[0] = RESSpin.Result.__il2cppRuntimeField_byval_arg;
            }
            else
            {
                    mem2[0] = 0;
                mem2[0] = 2621443;
            }
            
            mem2[0] = typeof(RESSpin.Result).__il2cppRuntimeField_14;
            var val_9 = FP - 28;
        }
        private static RESSpin()
        {
        
        }
    
    }

}
