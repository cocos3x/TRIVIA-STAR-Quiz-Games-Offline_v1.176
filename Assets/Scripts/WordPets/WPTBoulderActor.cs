using UnityEngine;

namespace WordPets
{
    public class WPTBoulderActor : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform boulderRoot;
        private UnityEngine.UI.Image boulderImage;
        private UnityEngine.ParticleSystem boulderEfx;
        private float animationDuration;
        
        // Properties
        public UnityEngine.RectTransform BoulderRoot { get; }
        public UnityEngine.UI.Image BoulderImage { get; }
        public UnityEngine.ParticleSystem BoulderEfx { get; }
        
        // Methods
        public UnityEngine.RectTransform get_BoulderRoot()
        {
        
        }
        public UnityEngine.UI.Image get_BoulderImage()
        {
        
        }
        public UnityEngine.ParticleSystem get_BoulderEfx()
        {
        
        }
        public void ExecuteAction(System.Collections.Generic.List<WordPets.WPTGameColumn> columnList, UnityEngine.Transform columnParent, System.Action<WordPets.WPTGameTile> onTileCollide, System.Action onComplete)
        {
            float val_9;
            float val_10;
            float val_12;
            float val_16;
            float val_17;
            float val_19;
            float val_26;
            float val_28;
            float val_32;
            float val_33;
            float val_75;
            float val_76;
            float val_84;
            var val_85;
            var val_86;
            float val_87;
            var val_88;
            DG.Tweening.TweenCallback val_89;
            val_84 = columnParent;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    typeof(WPTBoulderActor.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = onTileCollide;
            }
            else
            {
                    mem[8] = onTileCollide;
            }
            
            typeof(WPTBoulderActor.<>c__DisplayClass10_0).__il2cppRuntimeField_C = onComplete;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_85 = 0;
            goto label_3;
            label_10:
            if(val_2 <= val_85)
            {
                    var val_84 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_84 = val_84 + 0;
            if(((0 + 0) + 16 + 16 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Add(item:  (0 + 0) + 16 + 16 + 8 + 16);
            val_85 = 1;
            label_3:
            if(val_85 < val_2)
            {
                goto label_10;
            }
            
            if(val_84 != 0)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_84 = 0;
            val_86 = 1;
            goto label_13;
            label_12:
            val_86 = 0;
            label_13:
            UnityEngine.Rect val_3 = rect;
            UnityEngine.Vector2 val_4 = min;
            UnityEngine.RectTransform val_5 = this.boulderImage.rectTransform;
            UnityEngine.Rect val_6 = rect;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  width, y:  val_6.m_YMin);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 2.700516E-33f, y = val_9}, b:  new UnityEngine.Vector2() {x = val_10, y = val_8.x});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.700514E-33f, y = val_12});
            UnityEngine.Vector3 val_18 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_84, y = val_16, z = val_17});
            UnityEngine.Rect val_20 = rect;
            UnityEngine.Vector2 val_21 = max;
            UnityEngine.RectTransform val_22 = this.boulderImage.rectTransform;
            UnityEngine.Rect val_23 = rect;
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  width, y:  val_23.m_YMin);
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.700506E-33f, y = val_19}, b:  new UnityEngine.Vector2() {x = val_26, y = val_25.x});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.700504E-33f, y = val_28});
            UnityEngine.Vector3 val_34 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_84, y = val_32, z = val_33});
            val_87 = this;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.GameObject val_36 = List<T>.__il2cppRuntimeField_10.gameObject;
            UnityEngine.Transform val_37 = List<T>.__il2cppRuntimeField_10.transform;
            UnityEngine.Vector3 val_38 = position;
            UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  val_38.x, y:  val_38.y);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.GameObject val_41 = List<T>.__il2cppRuntimeField_10.gameObject;
            UnityEngine.Transform val_42 = List<T>.__il2cppRuntimeField_10.transform;
            UnityEngine.Vector3 val_43 = position;
            UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_43.x, y:  val_43.y);
            float val_46 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
            UnityEngine.Transform val_47 = this.boulderRoot.transform;
            UnityEngine.GameObject val_48 = this.boulderRoot.gameObject;
            UnityEngine.Transform val_49 = this.transform;
            UnityEngine.Vector3 val_50 = position;
            UnityEngine.Vector3 val_52 = new UnityEngine.Vector3(x:  val_50.x, y:  val_50.y, z:  val_50.z);
            this.boulderRoot.position = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
            DG.Tweening.Sequence val_53 = DG.Tweening.DOTween.Sequence();
            val_88 = 0;
            UnityEngine.Transform val_54 = this.boulderRoot.transform;
            UnityEngine.GameObject val_55 = this.boulderRoot.gameObject;
            val_89 = 0;
            UnityEngine.Transform val_56 = this.transform;
            UnityEngine.Vector3 val_57 = position;
            UnityEngine.Vector3 val_59 = new UnityEngine.Vector3(x:  val_57.x, y:  val_57.y, z:  val_57.z);
            DG.Tweening.Tweener val_60 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.boulderRoot, endValue:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, duration:  this.animationDuration, snapping:  this.animationDuration);
            object val_61 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.boulderRoot, ease:  1);
            DG.Tweening.Sequence val_62 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.boulderRoot);
            UnityEngine.RectTransform val_63 = this.boulderImage.rectTransform;
            DG.Tweening.Tweener val_64 = DG.Tweening.ShortcutExtensions46.DOShakeAnchorPos(target:  this.boulderImage, duration:  this.animationDuration, strength:  val_57.y, vibrato:  this.animationDuration, randomness:  val_57.z, snapping:  false, fadeOut:  true);
            DG.Tweening.Sequence val_65 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.boulderImage);
            object val_66 = new System.Object();
            typeof(WPTBoulderActor.<>c__DisplayClass10_1).__il2cppRuntimeField_C = val_1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            typeof(WPTBoulderActor.<>c__DisplayClass10_1).__il2cppRuntimeField_8 = List<T>.__il2cppRuntimeField_10;
            UnityEngine.RectTransform val_67 = this.boulderImage.rectTransform;
            UnityEngine.Rect val_68 = rect;
            float val_69 = width;
            float val_70 = 157309400 * (-0.5f);
            UnityEngine.Transform val_71 = typeof(WPTBoulderActor.<>c__DisplayClass10_1).__il2cppRuntimeField_8.transform;
            val_87 = typeof(WPTBoulderActor.<>c__DisplayClass10_1).__il2cppRuntimeField_8;
            UnityEngine.Vector2 val_72 = new UnityEngine.Vector2(x:  157309400, y:  val_68.m_YMin);
            UnityEngine.Vector3 val_73 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.700519E-33f, y = val_72.x});
            UnityEngine.Vector3 val_77 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_87, y = val_75, z = val_76});
            UnityEngine.Vector2 val_78 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 2.700514E-33f});
            float val_79 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_16, y = val_17}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
            val_89 = null;
            val_89 = new DG.Tweening.TweenCallback(object:  398348288, method:  new IntPtr(157295456));
            float val_85 = val_16;
            val_85 = val_85 / val_45.x;
            val_85 = val_85 * this.animationDuration;
            DG.Tweening.Sequence val_81 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  val_85, callback:  val_85);
            val_88 = 0 + 1;
            DG.Tweening.TweenCallback val_82 = new DG.Tweening.TweenCallback(object:  398295040, method:  new IntPtr(157296480));
            object val_83 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        public WPTBoulderActor()
        {
            this.animationDuration = 1.5f;
        }
    
    }

}
