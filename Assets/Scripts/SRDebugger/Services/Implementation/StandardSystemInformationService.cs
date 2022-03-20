using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class StandardSystemInformationService : ISystemInformationService
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.IList<SRDebugger.InfoEntry>> _info;
        
        // Methods
        public StandardSystemInformationService()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._info = null;
            this.CreateDefaultSet();
        }
        public System.Collections.Generic.IEnumerable<string> GetCategories()
        {
            if(this._info != 0)
            {
                    return this._info.Keys;
            }
            
            return this._info.Keys;
        }
        public System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(string category)
        {
            if((this._info.TryGetValue(key:  category, value: out  System.Collections.Generic.IList<SRDebugger.InfoEntry> val_1 = 485592820)) != false)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = category;
            string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  485576576, args:  472754880);
            UnityEngine.Debug.LogError(message:  485576576);
        }
        public void Add(SRDebugger.InfoEntry info, string category = "Default")
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IList<SRDebugger.InfoEntry>> val_9;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_10;
            var val_11;
            object val_1 = new System.Object();
            typeof(StandardSystemInformationService.<>c__DisplayClass4_0).__il2cppRuntimeField_8 = info;
            val_9 = this._info;
            if((val_9.TryGetValue(key:  category, value: out  System.Collections.Generic.IList<SRDebugger.InfoEntry> val_2 = 485735836)) != true)
            {
                    val_9 = null;
                val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this._info.Add(key:  category, value:  80883712);
            }
            
            val_10 = null;
            val_10 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  420605952, method:  new IntPtr(485719472));
            if((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  80883712, predicate:  7720960)) == true)
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<T> val_9 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_7;
            }
            
            val_9 = 0;
            label_9:
            val_10 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_8;
            }
            
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            if(val_10 < (mem[null + 178]))
            {
                goto label_9;
            }
            
            label_7:
            val_11 = val_9;
            return;
            label_8:
            var val_7 = (mem[null + 88]) + 0;
            val_9 = val_9 + (((mem[null + 88] + 0) + 4) << 3);
            return;
            label_5:
            System.ArgumentException val_8 = new System.ArgumentException(message:  485722544, paramName:  485722768);
        }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> CreateReport(bool includePrivate = False)
        {
            WordPets.WPTPetTile val_5;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_33:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if((val_5 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_12 = 0;
            label_6:
            if((val_5 + 88 + 0) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (val_5 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_12 = val_5;
            goto label_7;
            label_5:
            var val_7 = (val_5 + 88) + 0;
            var val_13 = (val_5 + 88 + 0) + 4;
            val_13 = val_5 + (val_13 << 3);
            val_12 = val_13 + 188;
            label_7:
            label_23:
            var val_15 = val_5;
            if((val_5 + 178) == 0)
            {
                goto label_9;
            }
            
            var val_14 = 0;
            label_11:
            if((val_5 + 88 + 0) == null)
            {
                goto label_10;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (val_5 + 178))
            {
                goto label_11;
            }
            
            label_9:
            val_13 = val_5;
            goto label_12;
            label_10:
            var val_8 = (val_5 + 88) + 0;
            val_15 = val_15 + (((val_5 + 88 + 0) + 4) << 3);
            val_13 = val_15 + 188;
            label_12:
            if(val_5 == 0)
            {
                goto label_13;
            }
            
            var val_17 = val_5;
            if((val_5 + 178) == 0)
            {
                goto label_15;
            }
            
            var val_16 = 0;
            label_17:
            if((val_5 + 88 + 0) == null)
            {
                goto label_16;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < (val_5 + 178))
            {
                goto label_17;
            }
            
            label_15:
            val_14 = val_5;
            goto label_18;
            label_16:
            var val_9 = (val_5 + 88) + 0;
            val_17 = val_17 + (((val_5 + 88 + 0) + 4) << 3);
            val_14 = val_17 + 188;
            label_18:
            if((val_5 + 12) != 0)
            {
                    if(includePrivate == false)
            {
                goto label_23;
            }
            
            }
            
            object val_10 = val_5.Value;
            Add(key:  val_5 + 8, value:  val_5);
            goto label_23;
            label_13:
            var val_18 = 0;
            val_18 = val_18 + 1;
            mem2[0] = 114;
            if(val_5 == 0)
            {
                goto label_24;
            }
            
            var val_20 = val_5;
            if((val_5 + 178) == 0)
            {
                goto label_25;
            }
            
            var val_19 = 0;
            label_27:
            if((val_5 + 88 + 0) == null)
            {
                goto label_26;
            }
            
            val_19 = val_19 + 1;
            if(((uint)val_19 & 65535) < (val_5 + 178))
            {
                goto label_27;
            }
            
            label_25:
            val_15 = val_5;
            goto label_28;
            label_26:
            var val_11 = (val_5 + 88) + 0;
            val_20 = val_20 + (((val_5 + 88 + 0) + 4) << 3);
            val_15 = val_20 + 188;
            label_28:
            label_24:
            var val_22 = val_18;
            if(val_22 != 1)
            {
                    if(val_22 > 1)
            {
                    0 = 1;
            }
            
                var val_21 = 485871304 + ((0 + 1)) << 2;
                val_21 = val_21 - 114;
                val_21 = val_21 >> 5;
                val_21 = 1 & val_21;
                val_22 = val_22 - val_21;
            }
            
            Add(key:  0, value:  78753792);
            goto label_33;
            label_2:
            0.Dispose();
        }
        private void CreateDefaultSet()
        {
            if(mem[35632387] != true)
            {
                
            }
        
        }
        private static string GetCloudManifestPrettyName(string name)
        {
            var val_8;
            if((System.String.op_Equality(a:  name, b:  486091616)) != false)
            {
                    val_8 = "Commit";
                return;
            }
            
            if((System.String.op_Equality(a:  name, b:  486091792)) != false)
            {
                    val_8 = "Branch";
                return;
            }
            
            if((System.String.op_Equality(a:  name, b:  486091888)) != false)
            {
                    val_8 = "Build Target";
                return;
            }
            
            if((System.String.op_Equality(a:  name, b:  486092096)) != false)
            {
                    val_8 = "Build Date";
                return;
            }
            
            string val_5 = name.Substring(startIndex:  0, length:  1);
            string val_6 = name.ToUpper();
            string val_7 = name.Substring(startIndex:  1);
            return name + name;
        }
    
    }

}
