using UnityEngine;

namespace WordForest
{
    public class WFOTree : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image treeImage;
        private UnityEngine.UI.Image shadowImage;
        private UnityEngine.Transform growScaler;
        private UnityEngine.Color shadowColor;
        private UnityEngine.Sprite spriteChoppedTree;
        private int growthState;
        private UnityEngine.Sprite spriteFullGrownTree;
        private UnityEngine.Vector3 posFullGrownTree;
        private UnityEngine.ParticleSystem choppedTreeSmokeEfx;
        private static WordForest.WFODigAnimation _digAnimationPrefab;
        private static UnityEngine.ParticleSystem _choppedTreeSmokeEfxPrefab;
        
        // Properties
        public int GrowthState { get; }
        public UnityEngine.Transform originTransform { get; }
        private static WordForest.WFODigAnimation DigAnimationPrefab { get; }
        private static UnityEngine.ParticleSystem ChoppedTreeSmokeEfxPrefab { get; }
        
        // Methods
        public int get_GrowthState()
        {
            return (int)this.growthState;
        }
        public UnityEngine.Transform get_originTransform()
        {
        
        }
        private static WordForest.WFODigAnimation get_DigAnimationPrefab()
        {
            var val_3;
            var val_4;
            if(WordForest.WFOTree._digAnimationPrefab != 0)
            {
                    return;
            }
            
            var val_3 = 28105983;
            val_3 = 7519804 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            if(App.game == 18)
            {
                    val_4 = 1152921511771698688;
            }
            else
            {
                    val_4 = 1152921511797278048;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOTree._digAnimationPrefab = null;
        }
        private static UnityEngine.ParticleSystem get_ChoppedTreeSmokeEfxPrefab()
        {
            var val_3;
            var val_4;
            var val_5;
            if(WordForest.WFOTree._choppedTreeSmokeEfxPrefab != 0)
            {
                goto label_3;
            }
            
            var val_3 = 28105511;
            val_3 = 7520276 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            if(App.game != 18)
            {
                goto label_9;
            }
            
            val_4 = 1152921511771698688;
            goto label_12;
            label_3:
            val_5 = 1152921505016750172;
            return;
            label_9:
            val_4 = 1152921511797278048;
            label_12:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = null;
            WordForest.WFOTree._choppedTreeSmokeEfxPrefab = null;
        }
        private void Awake()
        {
            UnityEngine.UI.Image val_3;
            if(this.treeImage != 0)
            {
                    this.spriteFullGrownTree = this.treeImage.m_Sprite;
                val_3 = this.treeImage;
            }
            else
            {
                    val_3 = this.treeImage;
                this.spriteFullGrownTree = this.treeImage.m_Sprite;
                if(val_3 == 0)
            {
                    val_3 = 0;
            }
            
            }
            
            UnityEngine.Transform val_1 = val_3.transform;
            UnityEngine.Vector3 val_2 = localPosition;
        }
        private void Start()
        {
            this.shadowImage.color = new UnityEngine.Color() {r = this.shadowColor, g = SB, b = R7, a = ???};
        }
        public DG.Tweening.Sequence SetGrowthState(int state, bool instant = True, bool delayGrowth = False, UnityEngine.Transform shadowParent)
        {
            float val_6;
            float val_24;
            float val_25;
            bool val_47;
            int val_48;
            UnityEngine.ParticleSystem val_49;
            float val_50;
            float val_51;
            var val_52;
            val_47 = instant;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_48 = val_1;
                typeof(WFOTree.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = state;
                WFOTree.<>c__DisplayClass21_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = shadowParent;
            }
            else
            {
                    val_48 = 8;
                mem[8] = state;
                mem[12] = shadowParent;
            }
            
            typeof(WFOTree.<>c__DisplayClass21_0).__il2cppRuntimeField_10 = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.growthState = val_48;
            if(mem[8] != 2)
            {
                goto label_5;
            }
            
            this.treeImage.sprite = this.spriteChoppedTree;
            UnityEngine.Transform val_3 = this.treeImage.transform;
            UnityEngine.Transform val_4 = this.treeImage.transform;
            UnityEngine.Vector3 val_5 = localPosition;
            UnityEngine.Transform val_7 = this.treeImage.transform;
            UnityEngine.Vector3 val_8 = localPosition;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_8.x, y:  val_8.y, z:  val_8.z);
            this.treeImage.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            bool val_10 = UnityEngine.Object.op_Equality(x:  this.choppedTreeSmokeEfx, y:  0);
            if(val_10 == false)
            {
                goto label_15;
            }
            
            UnityEngine.ParticleSystem val_11 = WordForest.WFOTree.ChoppedTreeSmokeEfxPrefab;
            UnityEngine.GameObject val_12 = this.gameObject;
            UnityEngine.Transform val_13 = this.transform;
            object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  val_10, parent:  345065600);
            val_49 = val_10;
            val_47 = val_47;
            this.choppedTreeSmokeEfx = val_10;
            goto label_19;
            label_5:
            this.treeImage.sprite = this.spriteFullGrownTree;
            UnityEngine.Transform val_15 = this.treeImage.transform;
            this.treeImage.localPosition = new UnityEngine.Vector3() {x = this.posFullGrownTree, y = 3.094657E-24f, z = this.spriteFullGrownTree};
            val_47 = val_47;
            if(this.choppedTreeSmokeEfx == 0)
            {
                goto label_29;
            }
            
            UnityEngine.GameObject val_17 = this.choppedTreeSmokeEfx.gameObject;
            UnityEngine.Object.Destroy(obj:  this.choppedTreeSmokeEfx);
            goto label_29;
            label_15:
            val_49 = this.choppedTreeSmokeEfx;
            label_19:
            UnityEngine.Transform val_18 = val_49.transform;
            UnityEngine.Transform val_19 = this.shadowImage.transform;
            UnityEngine.Vector3 val_20 = position;
            val_49.position = new UnityEngine.Vector3();
            this.choppedTreeSmokeEfx.Play();
            label_29:
            if(mem[8] != 0)
            {
                    UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            }
            else
            {
                    UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
            }
            
            val_50 = val_24;
            val_51 = val_6;
            if(val_47 != false)
            {
                    this.growScaler.localScale = new UnityEngine.Vector3() {x = val_50, y = val_51, z = val_25};
                if(mem[8] == 0)
            {
                    return;
            }
            
                if(mem[12] == 0)
            {
                    return;
            }
            
                UnityEngine.Transform val_27 = this.shadowImage.transform;
                this.shadowImage.SetParent(parent:  mem[12], worldPositionStays:  true);
                return;
            }
            
            object val_28 = new System.Object();
            WordForest.WFODigAnimation val_29 = WordForest.WFOTree.DigAnimationPrefab;
            UnityEngine.Transform val_30 = this.transform;
            object val_31 = UnityEngine.Object.Instantiate<System.Object>(original:  val_28 = new System.Object(), parent:  345065600);
            if(val_28 != 0)
            {
                    val_52 = val_28;
                typeof(WFOTree.<>c__DisplayClass21_1).__il2cppRuntimeField_8 = val_28;
            }
            else
            {
                    val_52 = 8;
                mem[8] = val_28;
            }
            
            UnityEngine.Transform val_32 = val_52.transform;
            val_52.SetAsFirstSibling();
            UnityEngine.Transform val_33 = mem[8].transform;
            UnityEngine.Vector3 val_34 = localPosition;
            mem[8].localPosition = new UnityEngine.Vector3();
            mem[8].StartDigAnimation();
            if(delayGrowth != false)
            {
                    DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_34.x);
            }
            
            val_50 = 0;
            DG.Tweening.TweenCallback val_36 = new DG.Tweening.TweenCallback(object:  410009600, method:  new IntPtr(345031360));
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            val_47 = val_51;
            val_48 = val_25;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 1.465127E-26f, y = val_50, z = val_47}, d:  val_34.x);
            DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.growScaler, endValue:  new UnityEngine.Vector3(), duration:  val_38.x);
            object val_40 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growScaler, ease:  6);
            val_51 = 0;
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growScaler);
            DG.Tweening.Tweener val_42 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.growScaler, endValue:  new UnityEngine.Vector3() {x = val_50, y = val_47, z = val_48}, duration:  val_38.x);
            object val_43 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growScaler, ease:  30);
            DG.Tweening.TweenCallback val_44 = new DG.Tweening.TweenCallback(object:  409956352, method:  new IntPtr(345040576));
            object val_45 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.growScaler, action:  190734336);
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growScaler);
        }
        public WFOTree()
        {
        
        }
    
    }

}
