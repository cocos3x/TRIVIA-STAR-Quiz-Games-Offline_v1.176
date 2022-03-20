using UnityEngine;

namespace WordForest
{
    public class WFOShieldStatView : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UI.Image> shieldList;
        private System.Collections.Generic.List<UnityEngine.UI.Image> frameBgList;
        private UnityEngine.UI.Button button;
        private int visualShieldCount;
        private DG.Tweening.Sequence[] shieldAnimSeq;
        protected int artificalTargetBalance;
        
        // Properties
        public bool Interactable { get; set; }
        public UnityEngine.UI.Button Button { get; }
        
        // Methods
        public bool get_Interactable()
        {
            if(this.button != 0)
            {
                    return (bool)this;
            }
            
            return (bool)this;
        }
        public void set_Interactable(bool value)
        {
            this.button.interactable = value;
        }
        public UnityEngine.UI.Button get_Button()
        {
        
        }
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  342140928, name:  -812849888);
            this.shieldAnimSeq = null;
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  342266240, method:  new IntPtr(342241216));
            this.button.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            int val_3;
            var val_4;
            val_3 = this.artificalTargetBalance;
            if(val_3 <= 1)
            {
                    WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
                val_3 = mem[this.artificalTargetBalance + 308];
                val_3 = this.artificalTargetBalance + 308;
            }
            
            this.visualShieldCount = val_3;
            val_4 = 4;
            goto label_3;
            label_12:
            if(val_3 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_2 = 2621443.gameObject;
            if(R7 < this.visualShieldCount)
            {
                    0 = 1;
            }
            
            2621443.SetActive(value:  true);
            if(2621443 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(R7 >= this.visualShieldCount)
            {
                    0 = 1;
            }
            
            2621443.enabled = true;
            val_4 = 5;
            label_3:
            if((val_4 - 4) < 2621443)
            {
                goto label_12;
            }
            
            this.artificalTargetBalance = 0;
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  342523008, name:  -812849888);
        }
        public void SetTargetBalance(int targetBalance)
        {
            this.artificalTargetBalance = targetBalance;
        }
        private void OnShieldBalanceUpdated()
        {
            this.UpdateUI(instantly:  false);
        }
        public void UpdateUI(bool instantly = False)
        {
            bool val_39;
            bool val_40;
            float val_41;
            int val_42;
            int val_43;
            int val_44;
            DG.Tweening.Sequence[] val_45;
            val_39 = instantly;
            val_40 = static_value_021FA615;
            if(val_40 != true)
            {
                    val_40 = true;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            val_41 = 1152921504762277888;
            val_42 = -2080374784;
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  -2080374784);
            if(this.artificalTargetBalance >= 0)
            {
                    val_42 = 0;
                val_43 = this.artificalTargetBalance;
                this.artificalTargetBalance = val_42;
            }
            
            val_44 = this.visualShieldCount;
            if(val_43 == val_44)
            {
                    return;
            }
            
            if(val_43 <= val_44)
            {
                goto label_5;
            }
            
            goto label_6;
            label_58:
            if(this.shieldAnimSeq[val_44] != 0)
            {
                    DG.Tweening.Sequence val_39 = this.shieldAnimSeq[val_44];
                DG.Tweening.TweenExtensions.Kill(t:  val_39, complete:  false);
            }
            
            if(val_39 != false)
            {
                    if(val_39 <= val_44)
            {
                    var val_40 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_40 = val_40 + (val_44 << 2);
                UnityEngine.Transform val_3 = (0 + (this.visualShieldCount) << 2) + 16.transform;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
                (0 + (this.visualShieldCount) << 2) + 16.localScale = new UnityEngine.Vector3();
                if(((0 + (this.visualShieldCount) << 2) + 16) <= val_44)
            {
                    var val_41 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_41 = val_41 + (val_44 << 2);
                UnityEngine.Color val_5 = UnityEngine.Color.white;
                val_43 = val_43;
                if(((0 + (this.visualShieldCount) << 2) + 16) <= val_44)
            {
                    var val_42 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_42 = val_42 + (val_44 << 2);
                UnityEngine.GameObject val_6 = (0 + (this.visualShieldCount) << 2) + 16.gameObject;
                (0 + (this.visualShieldCount) << 2) + 16.SetActive(value:  true);
                if(((0 + (this.visualShieldCount) << 2) + 16) <= val_44)
            {
                    var val_43 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_43 = val_43 + (val_44 << 2);
                (0 + (this.visualShieldCount) << 2) + 16.enabled = false;
            }
            else
            {
                    typeof(WFOShieldStatView.<>c__DisplayClass17_0).__il2cppRuntimeField_C = this;
                if(new System.Object() <= val_44)
            {
                    var val_44 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_44 = val_44 + (val_44 << 2);
                UnityEngine.Transform val_8 = (0 + (this.visualShieldCount) << 2) + 16.transform;
                UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                (0 + (this.visualShieldCount) << 2) + 16.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                if(((0 + (this.visualShieldCount) << 2) + 16) <= val_44)
            {
                    var val_45 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_45 = val_45 + (val_44 << 2);
                UnityEngine.Color val_10 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
                if(((0 + (this.visualShieldCount) << 2) + 16) <= val_44)
            {
                    var val_46 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_43 = val_43;
                val_46 = val_46 + (val_44 << 2);
                UnityEngine.GameObject val_11 = (0 + (this.visualShieldCount) << 2) + 16.gameObject;
                (0 + (this.visualShieldCount) << 2) + 16.SetActive(value:  true);
                typeof(WFOShieldStatView.<>c__DisplayClass17_0).__il2cppRuntimeField_8 = val_44;
                DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
                if(0 <= val_44)
            {
                    var val_47 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_47 = val_47 + (val_44 << 2);
                UnityEngine.Transform val_13 = (0 + (this.visualShieldCount) << 2) + 16.transform;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
                DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + (this.visualShieldCount) << 2) + 16, endValue:  new UnityEngine.Vector3(), duration:  val_14.x);
                object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + (this.visualShieldCount) << 2) + 16, ease:  27);
                DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  (0 + (this.visualShieldCount) << 2) + 16);
                if(0 <= val_44)
            {
                    var val_48 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_48 = val_48 + (val_44 << 2);
                DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (0 + (this.visualShieldCount) << 2) + 16, endValue:  val_14.x, duration:  val_14.y);
                object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + (this.visualShieldCount) << 2) + 16, ease:  1);
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  (0 + (this.visualShieldCount) << 2) + 16);
                DG.Tweening.TweenCallback val_21 = new DG.Tweening.TweenCallback(object:  409796608, method:  new IntPtr(342953792));
                object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
                val_41 = 1152921504762277888;
                this.shieldAnimSeq[val_44] = 0;
                val_39 = val_39;
            }
            
            val_44 = val_44 + 1;
            label_6:
            val_42 = this.shieldList;
            if(val_44 < (UnityEngine.Mathf.Min(a:  val_43, b:  190734336)))
            {
                goto label_58;
            }
            
            goto label_62;
            label_5:
            if(val_44 <= val_43)
            {
                goto label_62;
            }
            
            val_41 = val_44 + 3;
            label_88:
            object val_24 = null;
            val_45 = val_24;
            val_24 = new System.Object();
            val_44 = val_41 - 3;
            typeof(WFOShieldStatView.<>c__DisplayClass17_1).__il2cppRuntimeField_C = this;
            if(val_44 < 1)
            {
                goto label_62;
            }
            
            int val_25 = val_41 - 4;
            typeof(WFOShieldStatView.<>c__DisplayClass17_1).__il2cppRuntimeField_8 = val_25;
            if(null != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shieldAnimSeq[typeof(WFOShieldStatView.<>c__DisplayClass17_1).__il2cppRuntimeField_8], complete:  false);
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16.enabled = true;
            if(val_39 != false)
            {
                    val_42 = this.shieldList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.GameObject val_26 = (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16.gameObject;
                val_45 = (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16;
                val_45.SetActive(value:  false);
            }
            else
            {
                    DG.Tweening.Sequence val_27 = DG.Tweening.DOTween.Sequence();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Transform val_28 = (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16.transform;
                UnityEngine.Vector3 val_29 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  null);
                object val_31 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16, ease:  27);
                DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16);
                val_42 = this.shieldList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16, endValue:  null, duration:  null);
                object val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16, ease:  1);
                DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  (0 + (((this.visualShieldCount + 3) - 4)) << 2) + 16);
                DG.Tweening.TweenCallback val_36 = new DG.Tweening.TweenCallback(object:  409849856, method:  new IntPtr(343089984));
                object val_37 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
                val_45 = this.shieldAnimSeq;
                val_45[typeof(WFOShieldStatView.<>c__DisplayClass17_1).__il2cppRuntimeField_8] = 0;
                val_39 = val_39;
            }
            
            val_41 = val_41 - 1;
            val_43 = val_43;
            if(val_25 > val_43)
            {
                goto label_88;
            }
            
            label_62:
            this.artificalTargetBalance = 0;
            this.visualShieldCount = val_43;
        }
        private void OnClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public WFOShieldStatView()
        {
            this.artificalTargetBalance = 0;
        }
    
    }

}
