using UnityEngine;

namespace RestaurantRivals
{
    public class CommonEventEconDataHelper
    {
        // Methods
        private static void Log(string str)
        {
        
        }
        public static int GetPlayerTier()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(33453552 < 10000)
            {
                    return 1;
            }
            
            if(33453552 > 24999)
            {
                    2 = 3;
            }
            
            return 3;
        }
        public static void ParseRewardTierList(string rawLineStr, int pointsReqColIndex, int rewQtyColIndex, int rewTypeColIndex, int currRowIndex, ref System.Collections.Generic.List<RESEventRewardData> tierList)
        {
            int val_20;
            var val_21;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_22;
            var val_23;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
            System.String[] val_1 = rawLineStr.Split(separator:  478563824);
            string val_3 = rawLineStr + (pointsReqColIndex << 2);
            System.Globalization.CultureInfo val_4 = System.Globalization.CultureInfo.InvariantCulture;
            if((System.Int32.TryParse(s:  478563824, style:  111, provider:  0, result: out  int val_5 = 347656204)) != true)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = "Error parsing Points Req for cell [";
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                typeof(System.Object[]).__il2cppRuntimeField_18 = ", ";
                typeof(System.Object[]).__il2cppRuntimeField_1C = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = "] (Defaulting value to ";
                typeof(System.Object[]).__il2cppRuntimeField_24 = null;
                typeof(System.Object[]).__il2cppRuntimeField_28 = ")";
                string val_7 = +472754880;
            }
            
            string val_8 = rawLineStr + (rewQtyColIndex << 2);
            System.Globalization.CultureInfo val_9 = System.Globalization.CultureInfo.InvariantCulture;
            val_20 = rewTypeColIndex;
            if((System.Decimal.TryParse(s:  13152256, style:  111, provider:  0, result: out  new System.Decimal() {flags = 347656208, lo = rewTypeColIndex, mid = rewQtyColIndex})) != true)
            {
                    val_21 = null;
                val_21 = null;
                if(new System.Object() != 0)
            {
                
            }
            
                val_22 = null;
                val_22 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                typeof(RESEventRewardData).__il2cppRuntimeField_20 = val_22;
                EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  515975088, newValue:  (rawLineStr + (rewQtyColIndex) << 2) + 16);
            }
            
            string val_12 = rawLineStr + (val_20 << 2);
            string val_13 = rewQtyColIndex.Trim();
            string val_14 = rewQtyColIndex.ToLowerInvariant();
            val_23 = 2;
            if((System.String.op_Equality(a:  rewQtyColIndex, b:  -1987367328)) != true)
            {
                    val_23 = 1;
                if((System.String.op_Equality(a:  rewQtyColIndex, b:  -1987496016)) != true)
            {
                    val_23 = 3;
                if((System.String.op_Equality(a:  rewQtyColIndex, b:  -702174016)) != true)
            {
                    val_23 = 4;
                if((System.String.op_Equality(a:  rewQtyColIndex, b:  -960166544)) != true)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = "Error parsing Reward Type for cell [";
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                typeof(System.Object[]).__il2cppRuntimeField_18 = ", ";
                typeof(System.Object[]).__il2cppRuntimeField_1C = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = "] (Defaulting value to ";
                val_20 = null;
                typeof(System.Object[]).__il2cppRuntimeField_24 = val_20;
                typeof(System.Object[]).__il2cppRuntimeField_28 = ")";
                string val_19 = +472754880;
                val_23 = 2;
            }
            
            }
            
            }
            
            }
            
            typeof(RESEventRewardData).__il2cppRuntimeField_8 = val_23;
            tierList.Add(item:  347656192);
        }
        public static void ParseCoinValueTierList(string rawLineStr, int tierStartColumn, int tierLastColumn, int currRowIndex, ref System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>> tierList)
        {
            var val_15;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
            System.String[] val_1 = rawLineStr.Split(separator:  478563824);
            val_15 = 0;
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            bool val_4 = System.Int32.TryParse(s:  rawLineStr, style:  111, provider:  0, result: out  int val_3 = 516116596);
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            bool val_7 = System.Int32.TryParse(s:  rawLineStr, style:  111, provider:  0, result: out  int val_6 = 516116592);
            if(tierStartColumn > tierLastColumn)
            {
                    return;
            }
            
            string val_9 = (rawLineStr + (tierStartColumn << 2)) + 16;
            var val_16 = 0;
            do
            {
                int val_10 = tierStartColumn + val_16;
                System.Globalization.CultureInfo val_11 = System.Globalization.CultureInfo.InvariantCulture;
                bool val_12 = System.Decimal.TryParse(s:  15388672, style:  111, provider:  0, result: out  new System.Decimal() {flags = 516116576});
                if(new System.Object() != 0)
            {
                    typeof(RESEventCoinValue).__il2cppRuntimeField_8 = 0;
                typeof(RESEventCoinValue).__il2cppRuntimeField_C = val_15;
            }
            else
            {
                    mem[8] = 0;
                typeof(RESEventCoinValue).__il2cppRuntimeField_C = val_15;
            }
            
                if((mem[tierList + 12]) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_15 = mem[tierList + 8];
                val_15 = val_15 + 0;
                val_15 = mem[(mem[tierList + 8] + 0) + 16];
                val_15 = (mem[tierList + 8] + 0) + 16;
                val_15.Add(item:  347496448);
                val_16 = val_16 + 1;
            }
            while((tierStartColumn + val_16) <= tierLastColumn);
        
        }
        public static RESEventRewardData GetDynamicEventReward(System.Collections.Generic.List<RESEventRewardData> tierList, System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>> coinList, int rewardProgressLevel)
        {
            var val_23;
            var val_25;
            var val_26;
            var val_27;
            RESEventRewardData val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            val_25 = tierList;
            val_26 = rewardProgressLevel;
            val_27 = 0;
            if(516249752 <= val_26)
            {
                    return;
            }
            
            if(516249752 <= val_26)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_26 << 2);
            val_28 = mem[(0 + (rewardProgressLevel) << 2) + 16];
            val_28 = (0 + (rewardProgressLevel) << 2) + 16;
            if(val_28 == 0)
            {
                    return;
            }
            
            if(val_25 <= val_26)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = val_26 + (val_26 << 2);
                val_28 = mem[(0 + (rewardProgressLevel) << 2) + 16];
                val_28 = (0 + (rewardProgressLevel) << 2) + 16;
            }
            
            RESEventRewardData val_1 = null;
            val_27 = val_1;
            val_1 = new RESEventRewardData(rData:  val_28);
            val_29 = val_27;
            val_30 = null;
            val_30 = null;
            val_31 = 0;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = RESEventRewardData.__il2cppRuntimeField_byval_arg, hi = typeof(RESEventRewardData).__il2cppRuntimeField_14, lo = RESEventRewardData.__il2cppRuntimeField_this_arg, mid = typeof(RESEventRewardData).__il2cppRuntimeField_1C}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) == false)
            {
                    return;
            }
            
            val_31 = 0;
            object val_3 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  RESEventRewardData.__il2cppRuntimeField_element_class, key:  515975088, defaultValue:  0);
            if(0 != null)
            {
                    RESEventRewardData.__il2cppRuntimeField_element_class = 0;
            }
            
            val_31 = RESEventRewardData.__il2cppRuntimeField_element_class;
            if((System.String.IsNullOrEmpty(value:  null)) == true)
            {
                    return;
            }
            
            uint val_5 = _PrivateImplementationDetails_.ComputeStringHash(s:  null);
            if(val_5 > 2329555634)
            {
                goto label_15;
            }
            
            if(val_5 > 2279222777)
            {
                goto label_16;
            }
            
            if(val_5 == 2228889920)
            {
                goto label_17;
            }
            
            if(val_5 == 2245667539)
            {
                goto label_18;
            }
            
            if(val_5 != 2279222777)
            {
                    return;
            }
            
            val_32 = "C1";
            goto label_20;
            label_15:
            if(val_5 > 2413443729)
            {
                goto label_26;
            }
            
            if(val_5 == 2346333253)
            {
                goto label_27;
            }
            
            if(val_5 == 2396666110)
            {
                goto label_28;
            }
            
            if(val_5 != 2413443729)
            {
                    return;
            }
            
            val_33 = "C9";
            if((System.String.op_Equality(a:  null, b:  516233136)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 48;
            goto label_96;
            label_20:
            if((System.String.op_Equality(a:  null, b:  516233216)) == false)
            {
                    return;
            }
            
            if((coinList + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 16;
            goto label_96;
            label_16:
            if(val_5 == 2296000396)
            {
                goto label_41;
            }
            
            if(val_5 == 2312778015)
            {
                goto label_42;
            }
            
            if(val_5 != 2329555634)
            {
                    return;
            }
            
            val_35 = "C4";
            goto label_44;
            label_26:
            if(val_5 == 2759201240)
            {
                goto label_45;
            }
            
            if(val_5 == 2775978859)
            {
                goto label_46;
            }
            
            if(val_5 != 2809534097)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  null, b:  516233376)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 60;
            goto label_96;
            label_18:
            val_40 = "C3";
            goto label_62;
            label_28:
            val_38 = "C8";
            if((System.String.op_Equality(a:  null, b:  516233856)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 44;
            goto label_96;
            label_42:
            val_39 = "C7";
            if((System.String.op_Equality(a:  null, b:  516233936)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 40;
            goto label_96;
            label_46:
            val_37 = "C10";
            if((System.String.op_Equality(a:  null, b:  516234016)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 52;
            goto label_96;
            label_62:
            if((System.String.op_Equality(a:  null, b:  516234176)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 24;
            goto label_96;
            label_17:
            val_42 = "C2";
            goto label_80;
            label_27:
            val_41 = "C5";
            if((System.String.op_Equality(a:  null, b:  516234336)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 32;
            goto label_96;
            label_41:
            val_36 = "C6";
            if((System.String.op_Equality(a:  null, b:  516234416)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 36;
            goto label_96;
            label_45:
            if((System.String.op_Equality(a:  null, b:  516234496)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 56;
            goto label_96;
            label_44:
            if((System.String.op_Equality(a:  null, b:  516234576)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 28;
            goto label_96;
            label_80:
            if((System.String.op_Equality(a:  null, b:  516234656)) == false)
            {
                    return;
            }
            
            if((coinList + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_34 = (coinList + 8) + 20;
            label_96:
            if(val_34 == 0)
            {
                    return;
            }
            
            Player val_19 = App.Player;
            val_26 = 0;
            val_43 = null;
            val_43 = null;
            if(App.game == 18)
            {
                    WordForest.WFOPlayer val_20 = WordForest.WFOPlayer.Instance;
                val_26 = 19;
            }
            
            List.Enumerator<T> val_21 = GetEnumerator();
            label_112:
            if(MoveNext() == false)
            {
                goto label_109;
            }
            
            if(val_26 > (val_23 + 12))
            {
                    0 = 1;
            }
            
            if((val_23 + 12) != 0)
            {
                    val_23 + 12 = 1;
            }
            
            if((val_26 < (val_23 + 8)) || (val_26 != (val_23 + 8)))
            {
                goto label_112;
            }
            
            var val_24 = val_23 + 16;
            label_109:
            Dispose();
        }
        public static System.Collections.Generic.List<RESEventRewardData> GetDynamicEventRewardList(System.Collections.Generic.List<RESEventRewardData> tierList, System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>> coinList)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3;
            if(tierList != 0)
            {
                    val_3 = null;
                val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                if(val_3 < 1)
            {
                    return;
            }
            
                var val_3 = 0;
                do
            {
                RESEventRewardData val_2 = RestaurantRivals.CommonEventEconDataHelper.GetDynamicEventReward(tierList:  tierList, coinList:  coinList, rewardProgressLevel:  0);
                Add(item:  tierList);
                val_3 = val_3 + 1;
            }
            while(val_3 < val_3);
            
                return;
            }
            
            val_3 = 0;
        }
        public CommonEventEconDataHelper()
        {
        
        }
    
    }

}
