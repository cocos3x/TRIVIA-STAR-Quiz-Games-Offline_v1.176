using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    public class InfoTabController : SRMonoBehaviourEx
    {
        // Fields
        public const char Tick = '\x2713';
        public const char Cross = '\xd7';
        public const string NameColor = "#BCBCBC";
        private System.Collections.Generic.Dictionary<string, SRDebugger.UI.Controls.InfoBlock> _infoBlocks;
        public SRDebugger.UI.Controls.InfoBlock InfoBlockPrefab;
        public UnityEngine.RectTransform LayoutContainer;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.Refresh();
        }
        public void Refresh()
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            var val_12 = 0;
            val_18 = 0;
            val_12 = val_12 + 1;
            val_18 = (uint)val_12 & 65535;
            val_19 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            var val_13 = 0;
            val_18 = 0;
            val_13 = val_13 + 1;
            val_18 = (uint)val_13 & 65535;
            val_20 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            label_27:
            val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            if((public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>()) == 0)
            {
                goto label_18;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_22 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            if((this._infoBlocks.ContainsKey(key:  426966608)) == true)
            {
                goto label_27;
            }
            
            SRDebugger.UI.Controls.InfoBlock val_7 = this.CreateBlock(title:  426966608);
            this._infoBlocks.Add(key:  426966608, value:  427009040);
            goto label_27;
            label_18:
            val_23 = 0;
            if((public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>()) != 0)
            {
                    val_18 = 0;
                val_18 = val_18 + 1;
                val_24 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
                val_23 = val_23;
            }
            
            if(0 != 1)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
                var val_15 = 0;
                val_15 = 0 - val_15;
                val_25 = val_15 + 1;
            }
            else
            {
                    val_25 = 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_9 = 0.GetEnumerator();
            label_43:
            if(0.MoveNext() == false)
            {
                goto label_37;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_26 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            FillInfoBlock(block:  0, info:  426966608);
            goto label_43;
            label_37:
            0.Dispose();
        }
        private void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info)
        {
            var val_24;
            System.Collections.Generic.IList<SRDebugger.InfoEntry> val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            System.Collections.Generic.IList<SRDebugger.InfoEntry> val_31;
            var val_32;
            var val_33;
            System.Collections.Generic.IList<SRDebugger.InfoEntry> val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = info;
            val_26 = val_25;
            val_27 = 0;
            goto label_14;
            label_21:
            var val_25 = ;
            if((info + 178) == 0)
            {
                goto label_8;
            }
            
            var val_24 = 0;
            label_10:
            val_24 = mem[info + 88 + 0];
            val_24 = info + 88 + 0;
            if(val_24 == null)
            {
                goto label_9;
            }
            
            val_24 = val_24 + 1;
            if(((uint)val_24 & 65535) < (info + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_28 = ;
            goto label_11;
            label_9:
            var val_3 = (info + 88) + 0;
            val_25 = val_25 + (((info + 88 + 0) + 4) << 3);
            val_28 = val_25 + 188;
            label_11:
            if((info + 8 + 8) > val_27)
            {
                    val_27 = mem[info + 8 + 8];
                val_27 = info + 8 + 8;
            }
            
            label_14:
            var val_27 = ;
            if((info + 178) == 0)
            {
                goto label_17;
            }
            
            var val_26 = 0;
            label_19:
            val_24 = mem[info + 88 + 0];
            val_24 = info + 88 + 0;
            if(val_24 == null)
            {
                goto label_18;
            }
            
            val_26 = val_26 + 1;
            val_24 = (uint)val_26 & 65535;
            if(val_24 < (info + 178))
            {
                goto label_19;
            }
            
            label_17:
            val_29 = ;
            goto label_20;
            label_18:
            var val_4 = (info + 88) + 0;
            val_27 = val_27 + (((info + 88 + 0) + 4) << 3);
            val_29 = val_27 + 188;
            label_20:
            if( != 0)
            {
                goto label_21;
            }
            
            val_30 = 0;
            val_31 = info;
            if( == 0)
            {
                goto label_22;
            }
            
            var val_29 = ;
            if((info + 178) == 0)
            {
                goto label_23;
            }
            
            var val_28 = 0;
            label_25:
            val_24 = mem[info + 88 + 0];
            val_24 = info + 88 + 0;
            if(val_24 == null)
            {
                goto label_24;
            }
            
            val_28 = val_28 + 1;
            if(((uint)val_28 & 65535) < (info + 178))
            {
                goto label_25;
            }
            
            label_23:
            val_32 = ;
            goto label_26;
            label_24:
            var val_5 = (info + 88) + 0;
            val_29 = val_29 + (((info + 88 + 0) + 4) << 3);
            val_32 = val_29 + 188;
            label_26:
            val_31 = info;
            val_30 = val_30;
            label_22:
            if(0 != 1)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
                var val_30 = 0;
                val_30 = 0 - val_30;
                val_33 = val_30 + 1;
            }
            else
            {
                    val_33 = 0;
            }
            
            var val_31 = val_31;
            if((info + 178) == 0)
            {
                goto label_31;
            }
            
            val_24 = 0;
            label_33:
            val_30 = 0;
            if((info + 88 + 0) == null)
            {
                goto label_32;
            }
            
            val_24 = val_24 + 1;
            val_30 = (uint)val_24 & 65535;
            if(val_30 < (info + 178))
            {
                goto label_33;
            }
            
            label_31:
            val_34 = info;
            val_35 = val_34;
            goto label_34;
            label_32:
            var val_6 = (info + 88) + 0;
            val_34 = info;
            val_31 = val_31 + (((info + 88 + 0) + 4) << 3);
            val_35 = val_31 + 188;
            label_34:
            label_70:
            var val_32 = val_34;
            if((info + 178) == 0)
            {
                goto label_36;
            }
            
            val_24 = 0;
            label_38:
            val_30 = mem[info + 88 + 0];
            val_30 = info + 88 + 0;
            if(val_30 == null)
            {
                goto label_37;
            }
            
            val_24 = val_24 + 1;
            val_30 = (uint)val_24 & 65535;
            if(val_30 < (info + 178))
            {
                goto label_38;
            }
            
            label_36:
            val_36 = val_34;
            goto label_39;
            label_37:
            var val_8 = (info + 88) + 0;
            val_32 = val_32 + (((info + 88 + 0) + 4) << 3);
            val_36 = val_32 + 188;
            label_39:
            if(val_34 == 0)
            {
                goto label_40;
            }
            
            var val_34 = val_34;
            if((info + 178) == 0)
            {
                goto label_42;
            }
            
            var val_33 = 0;
            label_44:
            if((info + 88 + 0) == null)
            {
                goto label_43;
            }
            
            val_33 = val_33 + 1;
            if(((uint)val_33 & 65535) < (info + 178))
            {
                goto label_44;
            }
            
            label_42:
            val_37 = val_34;
            goto label_45;
            label_43:
            var val_9 = (info + 88) + 0;
            val_34 = val_34 + (((info + 88 + 0) + 4) << 3);
            val_37 = val_34 + 188;
            label_45:
            if(1 == 1)
            {
                    System.Text.StringBuilder val_10 = AppendLine();
            }
            
            System.Text.StringBuilder val_11 = Append(value:  427117520);
            System.Text.StringBuilder val_12 = Append(value:  427117616);
            System.Text.StringBuilder val_13 = Append(value:  -1847126608);
            System.Text.StringBuilder val_14 = Append(value:  info + 8);
            System.Text.StringBuilder val_15 = Append(value:  2089622272);
            System.Text.StringBuilder val_16 = Append(value:  1113431872);
            val_38 = mem[info + 8 + 8];
            val_38 = info + 8 + 8;
            goto label_56;
            label_58:
            System.Text.StringBuilder val_17 = Append(value:  ' ');
            val_38 = val_38 + 1;
            label_56:
            if(val_38 <= (val_27 + 2))
            {
                goto label_58;
            }
            
            object val_18 = val_34.Value;
            if(val_34 != 0)
            {
                    if(val_34 == null)
            {
                goto label_61;
            }
            
            }
            
            object val_19 = val_34.Value;
            System.Text.StringBuilder val_20 = Append(value:  val_34);
            goto label_70;
            label_61:
            object val_21 = val_34.Value;
            val_39 = 0;
            System.Text.StringBuilder val_22 = Append(value:  '×');
            goto label_70;
            label_40:
            if(val_34 == 0)
            {
                goto label_71;
            }
            
            var val_35 = val_34;
            if((info + 178) == 0)
            {
                goto label_72;
            }
            
            val_24 = 0;
            label_74:
            val_30 = 0;
            if((info + 88 + 0) == null)
            {
                goto label_73;
            }
            
            val_24 = val_24 + 1;
            val_30 = (uint)val_24 & 65535;
            if(val_30 < (info + 178))
            {
                goto label_74;
            }
            
            label_72:
            val_40 = val_34;
            goto label_75;
            label_73:
            var val_23 = (info + 88) + 0;
            val_35 = val_35 + (((info + 88 + 0) + 4) << 3);
            val_40 = val_35 + 188;
            label_75:
            label_71:
            if((block + 36) == 0)
            {
                
            }
        
        }
        private SRDebugger.UI.Controls.InfoBlock CreateBlock(string title)
        {
            UnityEngine.RectTransform val_1 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.InfoBlockPrefab);
            UnityEngine.Transform val_2 = this.InfoBlockPrefab.CachedTransform;
            this.InfoBlockPrefab.SetParent(parent:  this.LayoutContainer, worldPositionStays:  false);
        }
        public InfoTabController()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._infoBlocks = null;
        }
    
    }

}
