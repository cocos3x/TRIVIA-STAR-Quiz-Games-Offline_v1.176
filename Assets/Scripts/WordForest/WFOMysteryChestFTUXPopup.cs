using UnityEngine;

namespace WordForest
{
    public class WFOMysteryChestFTUXPopup : WGHintButtonDemoPopup
    {
        // Fields
        private UnityEngine.RectTransform tip_window;
        private UnityEngine.RectTransform tip_left;
        private UnityEngine.RectTransform tip_right;
        private UnityEngine.UI.Button gotBtn;
        private UnityEngine.GameObject ftux_window;
        private UnityEngine.UI.Button letsGoBtn;
        
        // Methods
        protected override void Start()
        {
            var val_8;
            this.ftux_window.SetActive(value:  true);
            UnityEngine.GameObject val_1 = this.tip_window.gameObject;
            this.tip_window.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  275220448, method:  new IntPtr(4170710432));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
            val_8 = null;
            val_8 = null;
            System.Type val_4 = this.GetType();
            EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  275220448, newValue:  true);
            UnityEngine.GameObject val_5 = this.tip_window.gameObject;
            mem[1152921513472002044] = this.tip_window;
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  275220448, method:  new IntPtr(275186208));
            this.letsGoBtn.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  275220448, method:  new IntPtr(275195424));
            this.gotBtn.m_OnClick.AddListener(call:  162246656);
        }
        private void ShowTip()
        {
            float val_11;
            float val_12;
            float val_14;
            float val_15;
            float val_24;
            float val_26;
            float val_27;
            float val_28;
            float val_31;
            float val_32;
            float val_39;
            float val_40;
            float val_50;
            float val_51;
            var val_58;
            var val_80;
            float val_89;
            float val_90;
            float val_91;
            var val_92;
            var val_93;
            UnityEngine.GameObject val_1 = this.tip_window.gameObject;
            this.tip_window.SetActive(value:  true);
            WordRegion val_2 = WordRegion.instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_4 = GetChestsWordIndexes();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_5 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_6 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            UnityEngine.Vector3 val_7 = localPosition;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_7.x, y:  val_7.y, z:  val_7.z);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.620854E-29f}, b:  new UnityEngine.Vector3() {y = val_8.x, z = val_8.y});
            UnityEngine.Vector3 val_13 = TransformPoint(position:  new UnityEngine.Vector3() {x = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16, y = val_11, z = val_12});
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_17 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_18 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            UnityEngine.Vector3 val_19 = localPosition;
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_19.x, y:  val_19.y, z:  val_19.z);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.620839E-29f}, b:  new UnityEngine.Vector3() {y = val_20.x, z = val_20.y});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.right;
            UnityEngine.Vector2 val_23 = sizeDelta;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 4.62083E-29f}, d:  val_24);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.620831E-29f}, b:  new UnityEngine.Vector3() {y = val_27, z = val_26});
            UnityEngine.Vector3 val_30 = TransformPoint(position:  new UnityEngine.Vector3() {x = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16, y = val_26, z = val_28});
            UnityEngine.Transform val_33 = this.transform;
            UnityEngine.Camera val_34 = this.GetCameraByTransform(obTranform:  275414368);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_35 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            UnityEngine.Camera val_36 = this.GetCameraByTransform(obTranform:  (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16);
            UnityEngine.Vector3 val_37 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 4.624495E-29f, y = val_14, z = val_15});
            UnityEngine.Vector3 val_41 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 4.624495E-29f, y = val_39, z = val_40});
            UnityEngine.Transform val_44 = this.transform;
            UnityEngine.Camera val_45 = this.GetCameraByTransform(obTranform:  275414368);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_46 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16.transform;
            UnityEngine.Camera val_47 = this.GetCameraByTransform(obTranform:  (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16 + 20 + 8 + 16);
            UnityEngine.Vector3 val_48 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 4.624495E-29f, y = val_31, z = val_32});
            UnityEngine.Vector3 val_52 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 4.624495E-29f, y = val_50, z = val_51});
            UnityEngine.Vector3 val_55 = position;
            if(this.tip_left < 0)
            {
                    UnityEngine.Vector3 val_57 = position;
                UnityEngine.Transform val_59 = this.tip_window.transform;
                UnityEngine.Vector3 val_60 = val_8.x.position;
                UnityEngine.Vector3 val_61 = new UnityEngine.Vector3(x:  val_60.x, y:  val_60.y, z:  val_60.z);
                UnityEngine.Transform val_62 = this.tip_window.transform;
                val_89 = val_61.x;
                val_90 = val_61.y;
                val_91 = val_61.z;
            }
            else
            {
                    UnityEngine.Vector3 val_63 = position;
                if(this.tip_right > 0)
            {
                    UnityEngine.Vector3 val_64 = position;
                UnityEngine.Transform val_65 = this.tip_window.transform;
                UnityEngine.Vector3 val_66 = val_8.x.position;
                UnityEngine.Vector3 val_67 = new UnityEngine.Vector3(x:  val_66.x, y:  val_66.y, z:  val_66.z);
                UnityEngine.Vector2 val_68 = UnityEngine.Vector2.one;
                this.tip_window.pivot = new UnityEngine.Vector2() {x = val_11, y = val_12};
                UnityEngine.Transform val_69 = this.tip_window.transform;
                val_89 = val_67.x;
                val_90 = val_67.y;
                val_91 = val_67.z;
            }
            else
            {
                    UnityEngine.Transform val_70 = this.tip_window.transform;
                UnityEngine.Transform val_71 = this.tip_window.transform;
                UnityEngine.Vector3 val_72 = position;
                UnityEngine.Vector3 val_74 = new UnityEngine.Vector3(x:  val_72.x, y:  val_72.y, z:  val_72.z);
            }
            
            }
            
            this.tip_window.position = new UnityEngine.Vector3() {x = val_89, y = val_90, z = val_91};
            twelvegigs.Autopilot.AutopilotManager val_75 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_76 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            Interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_77 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_78 = new UnityEngine.Color(r:  val_72.x, g:  val_72.y, b:  val_72.z, a:  null);
            val_58 = 0;
            System.Nullable<UnityEngine.Color> val_79 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_78.r, g = val_78.g, b = val_78.b, a = val_78.r});
            val_92 = val_80;
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_79.HasValue}, fadeInDuration:  val_72.x, fadeOutDuration:  val_72.y);
            if((-1637058032) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_83 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_93 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
            val_92 = null;
            UnityEngine.Transform val_84 = val_78.r.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = val_78.r;
            UnityEngine.Transform val_85 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = (0 + (public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_8 + 16) << 2) + 16;
            ShowOverlay(contentToOverlay:  -2028557104);
        }
        public WFOMysteryChestFTUXPopup()
        {
        
        }
        private void <Start>b__6_0()
        {
            this.ftux_window.SetActive(value:  false);
            this.ShowTip();
        }
        private void <Start>b__6_1()
        {
            this.OnClick_UseHint();
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  275811808);
        }
    
    }

}
