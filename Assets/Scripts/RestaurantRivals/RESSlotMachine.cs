using UnityEngine;

namespace RestaurantRivals
{
    public class RESSlotMachine : MonoSingleton<RestaurantRivals.RESSlotMachine>
    {
        // Fields
        private static System.Nullable<RestaurantRivals.RESPayout> _hackType;
        protected System.Collections.Generic.List<RestaurantRivals.RESSpin> spinSeries;
        protected int nextSpinIndex;
        
        // Properties
        public static System.Nullable<RestaurantRivals.RESPayout> HackType { get; set; }
        public int getSpinsRemaining { get; }
        public RestaurantRivals.RESSpin getNextSpin { get; }
        
        // Methods
        public static System.Nullable<RestaurantRivals.RESPayout> get_HackType()
        {
            null = null;
            mem2[0] = RestaurantRivals.RESSlotMachine._hackType;
            mem[4] = RestaurantRivals.RESSlotMachine._hackType.__il2cppRuntimeField_4;
            return (System.Nullable<RestaurantRivals.RESPayout>)RestaurantRivals.RESSlotMachine._hackType.__il2cppRuntimeField_4;
        }
        public static void set_HackType(System.Nullable<RestaurantRivals.RESPayout> value)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            RestaurantRivals.RESSlotMachine._hackType = value.HasValue;
            RestaurantRivals.RESSlotMachine._hackType.__il2cppRuntimeField_4 = R1;
            val_3 = null;
            val_3 = 1152921505036505180;
            string val_1 = RestaurantRivals.RESSlotMachine._hackType.ToString();
            val_4 = val_3;
            UnityEngine.Debug.LogError(message:  650033072);
        }
        public int get_getSpinsRemaining()
        {
            if(this.spinSeries == 0)
            {
                    this.spinSeries = 0;
            }
            
            return (int)this.spinSeries;
        }
        public RestaurantRivals.RESSpin get_getNextSpin()
        {
            System.Collections.Generic.List<RestaurantRivals.RESSpin> val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = this.spinSeries;
            val_4 = 0;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(this.nextSpinIndex >= true)
            {
                    return;
            }
            
            int val_1 = this.nextSpinIndex + 1;
            this.nextSpinIndex = val_1;
            if(val_1 <= this.nextSpinIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = R1 + (this.nextSpinIndex << 2);
            val_4 = mem[(R1 + (this.nextSpinIndex) << 2) + 16];
            val_4 = (R1 + (this.nextSpinIndex) << 2) + 16;
            val_3 = 5889016 + 29736524;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_6 = null;
            val_6 = null;
            val_4.SetSpin(hackSpinType:  new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = RestaurantRivals.RESSlotMachine._hackType});
        }
        public RestaurantRivals.RESSpin getNextSpinByType(RestaurantRivals.RESPayout payoutType)
        {
            var val_3 = 0;
            if(this.spinSeries == 0)
            {
                    return;
            }
            
            if(this.nextSpinIndex >= true)
            {
                    return;
            }
            
            int val_1 = this.nextSpinIndex + 1;
            this.nextSpinIndex = val_1;
            if(val_1 <= this.nextSpinIndex)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (this.nextSpinIndex << 2);
            val_3 = mem[(0 + (this.nextSpinIndex) << 2) + 16];
            val_3 = (0 + (this.nextSpinIndex) << 2) + 16;
            System.Nullable<com.adjust.sdk.AdjustLogLevel> val_2 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  payoutType);
            val_3.SetSpin(hackSpinType:  new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_2.HasValue});
        }
        public override void InitMonoSingleton()
        {
            this.Init();
        }
        public void Init()
        {
            RestaurantRivals.RESSpin.initAliasMethod();
        }
        public void CalculateSessionOutcome(int spinBet, int spinBalance, decimal coinBalance, int shieldBalance, RestaurantRivals.RESLevelDef currentLevel, decimal levelProgress)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_8;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            RestaurantRivals.RESLevelDef val_31;
            int val_33;
            var val_35;
            int val_36;
            float val_37;
            var val_38;
            var val_43;
            val_31 = currentLevel;
            var val_31 = 0;
            do
            {
                var val_30 = 0;
                do
            {
                if(val_31 == 0)
            {
                    val_31 = currentLevel;
            }
            
                decimal val_1 = getBuildCost(category:  val_31, tier:  0);
                decimal val_2 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 650759064}, d2:  new System.Decimal());
                val_30 = val_30 + 1;
                val_33 = val_6;
            }
            while(val_30 != 5);
            
                val_31 = val_31 + 1;
            }
            while(val_31 != 5);
            
            decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 650759080, hi = val_3, lo = val_4, mid = val_5}, d2:  new System.Decimal() {flags = val_33, hi = levelProgress.flags, lo = levelProgress.hi, mid = levelProgress.lo});
            decimal val_9 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 650759064}, d2:  new System.Decimal() {flags = val_8, hi = coinBalance.flags, lo = coinBalance.hi, mid = coinBalance.lo});
            RestaurantRivals.RESSpin.initAliasMethod();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_35 = 0;
            decimal val_12 = new System.Decimal(lo:  1, mid:  0, hi:  0, isNegative:  false, scale:  1);
            decimal val_13 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 650759064, hi = val_12.flags, lo = val_12.hi, mid = val_12.lo}, d2:  new System.Decimal() {flags = val_12.mid, hi = val_3, lo = val_4, mid = val_5});
            val_36 = val_3;
            val_37 = val_4;
            decimal val_14 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 650759048, hi = val_36, lo = val_37, mid = val_5}, d2:  new System.Decimal() {flags = val_6});
            List.Enumerator<T> val_19 = GetEnumerator();
            val_38 = 0;
            goto label_29;
            label_30:
            decimal val_20 = val_12.flags.totalCoinGain;
            decimal val_21 = totalCoinGain;
            val_35 = 0;
            bool val_22 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal());
            val_36 = val_3;
            val_37 = val_4;
            label_29:
            if(MoveNext() == false)
            {
                goto label_21;
            }
            
            decimal val_25 = val_12.flags.totalCoinGain;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal() {flags = val_15, hi = val_16, lo = val_17, mid = val_18})) == false)
            {
                goto label_29;
            }
            
            decimal val_27 = val_12.flags.totalCoinGain;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal() {flags = val_36, hi = val_37, lo = val_5, mid = val_6})) == false)
            {
                goto label_29;
            }
            
            if(val_38 != 0)
            {
                goto label_30;
            }
            
            goto label_29;
            label_21:
            Dispose();
            label_52:
            val_43 = val_38;
            if(val_43 == 0)
            {
                    int val_29 = RandomSet.singleInRange(lowest:  0, highest:  1094062063);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_43 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_29) << 2) + 16];
                val_43 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_29) << 2) + 16;
                if(val_43 == 0)
            {
                goto label_49;
            }
            
            }
            
            mem[1152921513847552732] = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_29) << 2) + 16 + 12;
            mem[1152921513847552736] = 0;
            return;
            label_49:
            if(val_43 != 1)
            {
                goto label_50;
            }
            
            Dispose();
            goto label_52;
            label_50:
        }
        public RESSlotMachine()
        {
        
        }
        private static RESSlotMachine()
        {
        
        }
    
    }

}
