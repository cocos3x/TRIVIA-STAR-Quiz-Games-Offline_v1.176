using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class KeyboardShortcutListenerService : SRServiceBase<SRDebugger.Services.Implementation.KeyboardShortcutListenerService>
    {
        // Fields
        private System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut> _shortcuts;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            UnityEngine.Transform val_2 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(p:  466780208);
            SRDebugger.Settings val_3 = SRDebugger.Settings.Instance;
            System.Collections.Generic.List<ZooTile> val_4 = new System.Collections.Generic.List<ZooTile>(collection:  83886592);
            this._shortcuts = null;
        }
        private void ToggleTab(SRDebugger.DefaultTabs t)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            SRDebugger.Services.IDebugPanelService val_1 = SRDebugger.Internal.Service.Panel;
            var val_11 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_10 = 0;
            label_4:
            val_8 = mem[mem[1179403735] + 0];
            val_8 = mem[1179403735] + 0;
            if(val_8 == null)
            {
                goto label_3;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_9 = 0;
            goto label_5;
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
            val_9 = val_11 + 212;
            label_5:
            SRDebugger.Services.IDebugPanelService val_3 = SRDebugger.Internal.Service.Panel;
            var val_12 = 0;
            if(0 == 0)
            {
                goto label_7;
            }
            
            val_8 = 0;
            label_9:
            if(1179403647 == null)
            {
                goto label_8;
            }
            
            val_8 = val_8 + 1;
            if(((uint)val_8 & 65535) < 0)
            {
                goto label_9;
            }
            
            label_7:
            val_10 = ;
            goto label_10;
            label_8:
            var val_4 = 0 + 0;
            val_12 = val_12 + (((0 + 0) + 4) << 3);
            val_10 = val_12 + 196;
            label_10:
            if( != 0)
            {
                     = 0;
                goto label_11;
            }
            
            label_17:
            SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_13;
            }
            
            val_8 = 0;
            label_15:
            if((mem[1179403735] + 0) == null)
            {
                goto label_14;
            }
            
            val_8 = val_8 + 1;
            if(((uint)val_8 & 65535) < mem[1179403825])
            {
                goto label_15;
            }
            
            label_13:
            val_11 = ;
            return;
            label_14:
            var val_6 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_11 = val_13 + 260;
            return;
            label_11:
            System.Int32Enum val_7 = 0.Value;
            if( != t)
            {
                goto label_17;
            }
            
            SRDebugger.Services.IDebugService val_8 = SRDebug.Instance;
            var val_15 = 0;
            if(0 == 0)
            {
                goto label_19;
            }
            
            var val_14 = 0;
            label_21:
            if(1179403647 == null)
            {
                goto label_20;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < 0)
            {
                goto label_21;
            }
            
            label_19:
            val_12 = ;
            return;
            label_20:
            var val_9 = 0 + 0;
            val_15 = val_15 + (((0 + 0) + 4) << 3);
            val_12 = val_15 + 268;
        }
        private void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut)
        {
            var val_18;
            var val_19;
            var val_21;
            string val_22;
            var val_23;
            var val_25;
            var val_26;
            var val_27;
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
            string val_39;
            var val_40;
            var val_41;
            var val_42;
            string val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            Settings.ShortcutActions val_1 = shortcut.Action - 1;
            if(val_1 <= 10)
            {
                    var val_2 = 11404636 + (11404636 + ((shortcut.Action - 1)) << 2);
                if(val_1 == 10)
            {
                    11404636 + ((shortcut.Action - 1)) << 2 = (11404636 + ((shortcut.Action - 1)) << 2) & ((IP) >> 32);
                11404636 + ((shortcut.Action - 1)) << 2 = (11404636 + ((shortcut.Action - 1)) << 2) & (shortcut >> 1);
                11404636 + ((shortcut.Action - 1)) << 2 = (11404636 + ((shortcut.Action - 1)) << 2) & ((IP) >> 1);
                mem2[0] = (((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut;
                mem2[0] = (((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP;
                ((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1) = (((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1)) & ((R8) >> 2);
                ((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1) = (((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1)) & (shortcut << 3);
                ((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1) = (((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1)) & (((IP) << (32-3)) | ((IP) << 3));
                ((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1) = (((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP) & (((int)IP) >> 1)) & (shortcut >> R2);
                mem2[0] = ((((((((11404636 + ((shortcut.Action - 1)) << 2 & (IP) >> 32) & (shortcut) >> 1) & (IP) >> 1) + shortcut + IP & ((int)IP) >> 1) & (R8) >> 2) & (shortcut) << 3) & ((IP) << (32-3)) | ((IP) << 3)) & ((in + IP;
            }
            
            }
            else
            {
                    string val_3 = 474068208 + 415387648;
                UnityEngine.Debug.LogWarning(message:  474068208);
                return;
            }
            
            var val_4 = FP - 24;
            val_21 = "[SRDebugger] Unhandled keyboard shortcut: ";
            val_22 = "[SRDebugger] Unhandled keyboard shortcut: ";
            if(0 == 0)
            {
                goto label_41;
            }
            
            val_18 = 0;
            label_12:
            val_19 = 0;
            if((R3 + 0) == null)
            {
                goto label_42;
            }
            
            val_18 = val_18 + 1;
            val_19 = (uint)val_18 & 65535;
            if(val_19 < 0)
            {
                goto label_12;
            }
            
            goto label_41;
            label_22:
            val_29 = 0;
            val_30 = mem[mem[null + 88] + 0];
            val_30 = mem[null + 88] + 0;
            if(val_30 == null)
            {
                goto label_21;
            }
            
             =  + 1;
            val_29 = (uint) & 65535;
            if(val_29 < (mem[null + 178]))
            {
                goto label_22;
            }
            
            val_31 = 1152921504622235648;
            goto label_23;
            label_27:
            if((mem[null + 88] + 0) == null)
            {
                goto label_26;
            }
            
            val_32 =  + 1;
            if(((uint)val_32 & 65535) < (mem[null + 178]))
            {
                goto label_27;
            }
            
            val_33 = val_31;
            goto label_28;
            label_32:
            val_27 = 0;
            val_26 = mem[mem[null + 88] + 0];
            val_26 = mem[null + 88] + 0;
            if(val_26 == null)
            {
                goto label_31;
            }
            
             =  + 1;
            val_27 = (uint) & 65535;
            if(val_27 < (mem[null + 178]))
            {
                goto label_32;
            }
            
            val_34 = val_33;
            goto label_33;
            label_37:
            val_26 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_36;
            }
            
            val_27 =  + 1;
            val_26 = (uint)val_27 & 65535;
            if(val_26 < (mem[null + 178]))
            {
                goto label_37;
            }
            
            val_37 = val_34;
            goto label_38;
            label_21:
            var val_5 =  + 0;
             =  + (((mem[null + 88] + 0) + 4) << 3);
            label_23:
            val_38 = 1152921504622235648;
            val_39 = null;
            if(1152921504622235648 == null)
            {
                goto label_40;
            }
            
            if((mem[val_39 + 178]) == 0)
            {
                goto label_41;
            }
            
            val_23 = mem[val_39 + 88];
            val_18 = 0;
            label_43:
            val_19 = 0;
            if((mem[val_39 + 88] + 0) == null)
            {
                goto label_42;
            }
            
            val_18 = val_18 + 1;
            val_19 = (uint)val_18 & 65535;
            if(val_19 < (mem[val_39 + 178]))
            {
                goto label_43;
            }
            
            label_41:
            val_40 = val_38;
            goto label_44;
            label_40:
            if((mem[val_39 + 178]) == 0)
            {
                goto label_45;
            }
            
            val_23 = mem[val_39 + 88];
            val_26 = 0;
            label_47:
            val_27 = 0;
            if((mem[val_39 + 88] + 0) == null)
            {
                goto label_46;
            }
            
            val_26 = val_26 + 1;
            val_27 = (uint)val_26 & 65535;
            if(val_27 < (mem[val_39 + 178]))
            {
                goto label_47;
            }
            
            label_45:
            val_41 = val_38;
            goto label_48;
            label_42:
            var val_6 = R3 + 0;
            val_22 = val_22 + (((R3 + 0) + 4) << 3);
            val_40 = val_22 + 268;
            label_44:
            val_25 = val_21;
            var val_7 = (mem[(FP - 24) + (24)]) - 24;
            label_46:
            var val_8 = R3 + ((mem[(mem[(FP - 24) + (24)] - 24) + (12)]) << 3);
            val_25 = val_25 + (((R3 + (mem[(mem[(FP - 24) + (24)] - 24) + (12)]) << 3) + 4) << 3);
            val_41 = val_25 + 252;
            label_48:
            val_42 = mem[((val_25 + ((R3 + (mem[(mem[(FP - 24) + (24)] - 24) + (12)]) << 3) + 4) << 3) + 252)];
            val_42 = val_41;
            val_43 = mem[(mem[(FP - 24) + (24)] - 24) + (0)];
            goto label_49;
            label_26:
            var val_9 = (mem[null + 88]) + 0;
             =  + (((mem[null + 88] + 0) + 4) << 3);
            label_28:
            mem2[0] = mem[(null + ((mem[null + 88] + 0) + 4) << 3) + 4];
            var val_10 = (mem[(FP - 24) + (24)]) - 24;
            return;
            label_31:
            var val_11 = (mem[null + 88]) + 0;
             =  + (((mem[null + 88] + 0) + 4) << 3);
            label_33:
            val_35 = val_33;
            string val_24 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_51;
            }
            
            val_26 = 0;
            label_53:
            val_27 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_52;
            }
            
            val_26 = val_26 + 1;
            val_27 = (uint)val_26 & 65535;
            if(val_27 < (mem[null + 178]))
            {
                goto label_53;
            }
            
            label_51:
            val_44 = val_33;
            goto label_54;
            label_36:
            var val_12 = (mem[null + 88]) + 0;
             =  + (((mem[null + 88] + 0) + 4) << 3);
            label_38:
            string val_25 = null;
            val_45 = val_34 ^ 1;
            if((mem[null + 178]) == 0)
            {
                goto label_56;
            }
            
            val_27 = 0;
            label_58:
            val_26 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_57;
            }
            
            val_27 = val_27 + 1;
            val_26 = (uint)val_27 & 65535;
            if(val_26 < (mem[null + 178]))
            {
                goto label_58;
            }
            
            label_56:
            val_46 = ;
            goto label_59;
            label_52:
            var val_13 = (mem[null + 88]) + 0;
            val_24 = val_24 + (((mem[null + 88] + 0) + 4) << 3);
            label_54:
            string val_26 = null;
            val_36 = 1152921505026228224;
            if((mem[null + 178]) == 0)
            {
                goto label_61;
            }
            
            val_26 = 0;
            label_63:
            val_27 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_62;
            }
            
            val_26 = val_26 + 1;
            val_27 = (uint)val_26 & 65535;
            if(val_27 < (mem[null + 178]))
            {
                goto label_63;
            }
            
            label_61:
            val_47 = val_33;
            goto label_64;
            label_57:
            var val_14 = (mem[null + 88]) + 0;
            val_25 = val_25 + (((mem[null + 88] + 0) + 4) << 3);
            goto label_70;
            label_62:
            var val_15 = (mem[null + 88]) + 0;
            val_26 = val_26 + (((mem[null + 88] + 0) + 4) << 3);
            label_64:
            val_43 = null;
            val_45 = val_33 ^ 1;
            if((mem[val_43 + 178]) == 0)
            {
                goto label_67;
            }
            
            val_42 = mem[val_43 + 88];
            label_69:
            val_48 = 0;
            if((mem[val_43 + 88] + 0) == null)
            {
                goto label_68;
            }
            
            val_27 = 0 + 1;
            val_26 = (uint)val_27 & 65535;
            if(val_26 < (mem[val_43 + 178]))
            {
                goto label_69;
            }
            
            label_67:
            val_46 = val_35;
            label_59:
            label_70:
            val_43 = val_35;
            label_49:
            var val_16 = (mem[(FP - 24) + (24)]) - 24;
            goto r3;
            label_68:
            string val_17 = val_46 + ((mem[(mem[(FP - 24) + (24)] - 24) + (8)]) << 3);
            val_43 = val_43 + ((mem[(val_46 + (mem[(mem[(FP - 24) + (24)] - 24) + (8)]) << 3) + 4]) << 3);
            goto label_70;
        }
        protected override void Update()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            this.Update();
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(0 == 0)
            {
                goto label_9;
            }
            
            bool val_2 = UnityEngine.Input.GetKeyDown(key:  27);
            if(val_2 == false)
            {
                goto label_9;
            }
            
            SRDebugger.Services.IDebugPanelService val_3 = SRDebugger.Internal.Service.Panel;
            if((val_2 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_14 = 0;
            label_7:
            if((val_2 + 88 + 0) == null)
            {
                goto label_6;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (val_2 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_14 = val_2;
            goto label_8;
            label_6:
            var val_4 = (val_2 + 88) + 0;
            var val_15 = (val_2 + 88 + 0) + 4;
            val_15 = val_2 + (val_15 << 3);
            val_14 = val_15 + 196;
            label_8:
            if(val_2 == false)
            {
                goto label_9;
            }
            
            SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
            if((val_2 + 178) == 0)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            label_13:
            if((val_2 + 88 + 0) == null)
            {
                goto label_12;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < (val_2 + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_15 = val_2;
            goto label_14;
            label_12:
            var val_6 = (val_2 + 88) + 0;
            var val_17 = (val_2 + 88 + 0) + 4;
            val_17 = val_2 + (val_17 << 3);
            val_15 = val_17 + 268;
            label_14:
            label_9:
            val_16 = 1;
            val_17 = 1;
            if((UnityEngine.Input.GetKey(key:  306)) != true)
            {
                    val_17 = UnityEngine.Input.GetKey(key:  305);
            }
            
            if((UnityEngine.Input.GetKey(key:  308)) != true)
            {
                    val_16 = UnityEngine.Input.GetKey(key:  307);
            }
            
            val_18 = 0;
            val_19 = 1;
            if((UnityEngine.Input.GetKey(key:  304)) == true)
            {
                goto label_18;
            }
            
            bool val_12 = UnityEngine.Input.GetKey(key:  303);
            goto label_18;
            label_27:
            if(val_12 <= val_18)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + 0;
            if(((0 + 0) + 16 + 13) != 0)
            {
                    (0 + 0) + 16 + 13 = 1;
            }
            
            if((~val_17) != 1)
            {
                goto label_24;
            }
            
            if(((0 + 0) + 16 + 20) != 0)
            {
                    (0 + 0) + 16 + 20 = 1;
            }
            
            if((~val_12) != 1)
            {
                goto label_24;
            }
            
            if(((0 + 0) + 16 + 12) != 0)
            {
                    (0 + 0) + 16 + 12 = 1;
            }
            
            if((~val_16) != 1)
            {
                goto label_24;
            }
            
            bool val_13 = UnityEngine.Input.GetKeyDown(key:  (0 + 0) + 16 + 16);
            if(val_13 == true)
            {
                goto label_25;
            }
            
            label_24:
            val_18 = 1;
            label_18:
            if(val_18 < val_13)
            {
                goto label_27;
            }
            
            return;
            label_25:
            val_13.ExecuteShortcut(shortcut:  (0 + 0) + 16);
        }
        public KeyboardShortcutListenerService()
        {
        
        }
    
    }

}
