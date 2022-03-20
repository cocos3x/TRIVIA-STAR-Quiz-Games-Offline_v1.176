using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLFtuxDemoWindow : FTUXDemoWindow
    {
        // Fields
        private UnityEngine.UI.Image handCursor;
        private UnityEngine.UI.Text tutorialMessage;
        private UnityEngine.RectTransform maskTutorialMessage;
        private UnityEngine.RectTransform[] maskActionStep1;
        private UnityEngine.RectTransform[] maskActionStep2;
        private System.Collections.Generic.List<UnityEngine.Transform> allowedPoints;
        private UnityEngine.Transform initial;
        private DG.Tweening.Sequence cursorSeq;
        private bool checkTouch;
        
        // Properties
        protected bool checkTouchedMe { get; }
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  701342496, name:  701318400);
        }
        public void Setup(SLC.Wordlicious.FTUX_TYPE type)
        {
            this.ShowFtux(type:  type);
        }
        public void Update()
        {
            if(this.checkTouchedMe == false)
            {
                    return;
            }
            
            R4.CloseWindow();
        }
        private void ShowFtux(SLC.Wordlicious.FTUX_TYPE type)
        {
            float val_9;
            float val_10;
            float val_48;
            float val_49;
            float val_54;
            float val_55;
            var val_67;
            SLC.Wordlicious.WOLFtuxDemoWindow val_79;
            var val_80;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_81;
            System.Action<twelvegigs.storage.JsonDictionary> val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_87;
            var val_88;
            val_79 = this;
            val_80 = type;
            val_81 = null;
            val_81 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_82 = null;
            val_82 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  701695904, method:  new IntPtr(701666784));
            System.Delegate val_4 = System.Delegate.Combine(a:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48, b:  7401472);
            val_83 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48;
            if(val_83 != 0)
            {
                    if(val_83 == null)
            {
                goto label_6;
            }
            
            }
            
            val_83 = 0;
            label_6:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48 = val_83;
            if(val_80 > 4)
            {
                    return;
            }
            
            var val_5 = 11269396 + (11269396 + (type) << 2);
            if(val_80 == 4)
            {
                    11269396 = 11269396 & 36167220;
                11269396 = 11269396 & (((type) << (32-26)) | ((type) << 26));
                mem2[0] = ((11269396 & 36167220) & ((type) << (32-26)) | ((type) << 26)) + 1152921504614248448;
            }
            
            UnityEngine.RectTransform val_6 = this.GetMaskPan(type:  0);
            UnityEngine.RectTransform val_7 = this.GetMaskWordRegion(type:  0);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_12 = GetComponentsInChildren<System.Object>();
            val_84 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            val_85 = 0;
            System.Collections.Generic.List<TSource> val_22 = System.Linq.Enumerable.ToList<System.Object>(source:  -2028557104);
            mem[1152921513898477504] = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            mem[1152921513898477508] = UnityEngine.Transform[].__il2cppRuntimeField_name + 16;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_24 = transform;
            UnityEngine.Vector3 val_25 = position;
            UnityEngine.Vector3 val_27 = ScreenCast.GetObjectPosition(mode:  701683784, objectPosition:  new UnityEngine.Vector3() {x = 1.401298E-45f, y = val_9, z = val_10});
            this.position = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
            twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_33 = GetComponentsInChildren<System.Object>();
            val_87 = public static SLC.Wordlicious.WOLWordRegion MonoSingleton<SLC.Wordlicious.WOLWordRegion>::get_Instance();
            val_88 = 0;
            twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_79 = val_79;
            UnityEngine.Transform val_40 = transform;
            object val_41 = GetComponentInChildren<System.Object>();
            UnityEngine.Transform val_42 = transform;
            UnityEngine.Transform val_43 = GetChild(index:  1);
            UnityEngine.Vector3 val_44 = position;
            UnityEngine.Transform val_45 = transform;
            UnityEngine.Transform val_46 = GetChild(index:  2);
            UnityEngine.Vector3 val_47 = position;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 9.363411E-14f}, b:  new UnityEngine.Vector3() {y = val_49, z = val_48});
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 9.363403E-14f}, d:  val_51.x);
            UnityEngine.Vector3 val_56 = ScreenCast.GetObjectPosition(mode:  701683804, objectPosition:  new UnityEngine.Vector3() {x = 1.401298E-45f, y = val_54, z = val_55});
            this.position = new UnityEngine.Vector3();
            string val_57 = Localization.Localize(key:  701670992, defaultValue:  701670880, useSingularKey:  false);
            UnityEngine.GameObject val_58 = mem[1152921513898477492].gameObject;
            mem[1152921513898477492].SetActive(value:  true);
            UnityEngine.GameObject val_59 = mem[1152921513898477484].gameObject;
            mem[1152921513898477484].SetActive(value:  true);
            UnityEngine.Transform val_60 = mem[1152921513898477484].transform;
            if(val_81 != 0)
            {
                    Add(item:  mem[1152921513898477484]);
                Add(item:  701695904);
            }
            else
            {
                    Add(item:  mem[1152921513898477484]);
                Add(item:  701695904);
            }
            
            Add(item:  701695904);
            Add(item:  mem[1152921513898477492]);
            UnityEngine.GameObject val_71 = this.gameObject;
            this.SetActive(value:  true);
            UnityEngine.GameObject val_72 = this.gameObject;
            this.SetActive(value:  true);
            mem[1152921513898477516] = 0;
            val_80 = 1152921511559723536;
            twelvegigs.Autopilot.AutopilotManager val_73 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_81 = 0;
            BlockRaycasts = false;
            twelvegigs.Autopilot.AutopilotManager val_74 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_75 = new UnityEngine.Color(r:  val_56.x, g:  val_56.y, b:  val_56.z, a:  null);
            val_9 = val_81;
            System.Nullable<UnityEngine.Color> val_76 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_75.r, g = val_75.g, b = val_75.b, a = val_75.r});
            val_83 = 1056964608;
            val_82 = val_67;
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_76.HasValue}, fadeInDuration:  val_56.x, fadeOutDuration:  val_56.y);
            twelvegigs.Autopilot.AutopilotManager val_77 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_78 = ToArray();
            ShowOverlay(contentToOverlay:  80883712);
            this.AnimateCursor();
        }
        private void AnimateCursor()
        {
            UnityEngine.GameObject val_1 = this.handCursor.gameObject;
            this.handCursor.SetActive(value:  true);
            UnityEngine.Transform val_2 = this.handCursor.transform;
            int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.handCursor, complete:  false);
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            this.handCursor.color = new UnityEngine.Color() {a = ???};
            UnityEngine.RectTransform val_5 = this.handCursor.rectTransform;
            UnityEngine.RectTransform val_6 = this.handCursor.rectTransform;
            UnityEngine.Rect val_7 = rect;
            float val_8 = height;
            float val_36 = -0.5f;
            val_36 = 701825544 * val_36;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_36, y:  val_7.m_YMin, z:  701825544);
            UnityEngine.Vector3 val_10 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.handCursor, y = val_9.x, z = val_9.y});
            UnityEngine.RectTransform val_11 = this.handCursor.rectTransform;
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 9.459385E-14f, y = R4, z = R6}, b:  new UnityEngine.Vector3() {x = R7});
            UnityEngine.GameObject val_14 = this.handCursor.gameObject;
            UnityEngine.Transform val_15 = this.handCursor.transform;
            UnityEngine.Vector3 val_16 = position;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 9.459369E-14f}, b:  new UnityEngine.Vector3());
            this.handCursor.position = new UnityEngine.Vector3();
            System.Collections.Generic.List<UnityEngine.Vector3> val_18 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            List.Enumerator<T> val_19 = GetEnumerator();
            label_23:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            UnityEngine.Vector3 val_22 = position;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 9.45942E-14f}, b:  new UnityEngine.Vector3());
            Add(item:  new UnityEngine.Vector3());
            goto label_23;
            label_18:
            Dispose();
            T[] val_24 = ToArray();
            DG.Tweening.Sequence val_25 = DG.Tweening.DOTween.Sequence();
            mem[1152921513898619208] = 0;
            object val_26 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  true);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  val_17.x);
            UnityEngine.Transform val_28 = this.handCursor.transform;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_29 = DG.Tweening.ShortcutExtensions.DOPath(target:  this.handCursor, path:  80883712, duration:  1.094062E+09f, pathType:  1.094062E+09f, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  1);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.handCursor);
            DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.handCursor, endValue:  1.094062E+09f, duration:  val_17.y);
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.handCursor);
            DG.Tweening.TweenCallback val_34 = new DG.Tweening.TweenCallback(object:  701837600, method:  new IntPtr(701812576));
            object val_35 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        private UnityEngine.RectTransform GetMaskWordRegion(SLC.Wordlicious.FTUX_TYPE type)
        {
            if(type == 0)
            {
                    this.maskActionStep2 = this.maskActionStep1;
            }
            
            UnityEngine.RectTransform val_1 = this.maskActionStep2[0];
        }
        private UnityEngine.RectTransform GetMaskPan(SLC.Wordlicious.FTUX_TYPE type)
        {
            if(type == 0)
            {
                    this.maskActionStep2 = this.maskActionStep1;
            }
            
            UnityEngine.RectTransform val_1 = this.maskActionStep2[1];
        }
        private void OnCompleteCycle()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeSelf == false)
            {
                    return;
            }
            
            R4.AnimateCursor();
        }
        private void OnWolDragBegin()
        {
            this.CloseWindow();
        }
        protected bool get_checkTouchedMe()
        {
            if(this.checkTouch == false)
            {
                    return false;
            }
            
            if(UnityEngine.Input.touchCount > 0)
            {
                    return true;
            }
            
            return UnityEngine.Input.GetMouseButtonDown(button:  0);
        }
        public void OnWordSubmitted(string word)
        {
            this.CloseWindow();
        }
        public void CloseWindow()
        {
            var val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  702994336, method:  new IntPtr(701666784));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48, value:  7401472);
            val_9 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48;
            if(val_9 != 0)
            {
                    if(val_9 == null)
            {
                goto label_6;
            }
            
            }
            
            val_9 = 0;
            label_6:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48 = val_9;
            UnityEngine.Transform val_4 = this.handCursor.transform;
            int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.handCursor, complete:  false);
            UnityEngine.GameObject val_6 = this.handCursor.gameObject;
            this.handCursor.SetActive(value:  false);
            this.allowedPoints.Clear();
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseOverlay(forceImmediate:  true, onClosed:  0);
            UnityEngine.GameObject val_8 = this.gameObject;
            SLCWindow.CloseWindow(window:  702994336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WOLFtuxDemoWindow()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.allowedPoints = null;
        }
    
    }

}
