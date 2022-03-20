using UnityEngine;

namespace WordForest
{
    public class RaidAttackScreenTransition : MonoSingleton<WordForest.RaidAttackScreenTransition>
    {
        // Fields
        private UnityEngine.GameObject rootContainer;
        private UnityEngine.CanvasGroup leftCurtain;
        private UnityEngine.CanvasGroup rightCurtain;
        private UnityEngine.UI.RawImage sceneIcon;
        private UnityEngine.UI.Text sceneText;
        private UnityEngine.Texture textureAttack;
        private UnityEngine.Texture textureRaid;
        
        // Methods
        public void ExtendCurtains(WordForest.RaidAttackActionType sceneType, System.Action onComplete)
        {
            UnityEngine.UI.Text val_31;
            var val_33;
            var val_34;
            UnityEngine.RectTransform val_35;
            var val_36;
            object val_1 = new System.Object();
            typeof(RaidAttackScreenTransition.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = onComplete;
            if(sceneType == 1)
            {
                goto label_2;
            }
            
            if(sceneType != 2)
            {
                goto label_3;
            }
            
            this.sceneIcon.texture = this.textureAttack;
            val_31 = this.sceneText;
            val_33 = "ATTACK";
            goto label_6;
            label_2:
            this.sceneIcon.texture = this.textureRaid;
            val_31 = this.sceneText;
            val_33 = "RAID";
            label_6:
            label_3:
            UnityEngine.Transform val_2 = this.leftCurtain.transform;
            if(this.leftCurtain == 0)
            {
                goto label_10;
            }
            
            val_34 = this.leftCurtain;
            if(null == null)
            {
                goto label_11;
            }
            
            label_10:
            val_34 = 0;
            label_11:
            UnityEngine.Transform val_3 = this.rightCurtain.transform;
            val_35 = 0;
            if(this.rightCurtain != 0)
            {
                    if(null != null)
            {
                    val_35 = 0;
            }
            else
            {
                    val_35 = this.rightCurtain;
            }
            
            }
            
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            val_34.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  null);
            val_35.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            this.rightCurtain.alpha = null;
            this.leftCurtain.alpha = null;
            UnityEngine.Transform val_6 = this.sceneIcon.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.sceneIcon.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_8 = this.sceneText.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.sceneText.localScale = new UnityEngine.Vector3();
            val_36 = 0;
            this.rootContainer.SetActive(value:  true);
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  val_9.x, duration:  val_9.y, snapping:  false);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  val_35, endValue:  val_9.x, duration:  val_9.y, snapping:  false);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_35);
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.leftCurtain, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.leftCurtain);
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.rightCurtain, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.rightCurtain);
            if(sceneType != 0)
            {
                    UnityEngine.Transform val_19 = this.sceneIcon.transform;
                DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sceneIcon, endValue:  val_9.x, duration:  val_9.y);
                val_36 = 1152921510714553472;
                object val_21 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.sceneIcon, delay:  val_9.x);
                val_34 = 1152921509932985248;
                object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.sceneIcon, ease:  27);
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.sceneIcon);
                UnityEngine.Transform val_24 = this.sceneText.transform;
                DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sceneText, endValue:  val_9.x, duration:  val_9.y);
                object val_26 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.sceneText, delay:  val_9.x);
                object val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.sceneText, ease:  27);
                DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.sceneText);
            }
            
            DG.Tweening.TweenCallback val_29 = new DG.Tweening.TweenCallback(object:  404897792, method:  new IntPtr(259804512));
            object val_30 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        public void WithdrawCurtains(float delay = 0, System.Action onComplete)
        {
            float val_16;
            var val_30;
            var val_31;
            var val_32;
            if(new System.Object() != 0)
            {
                    typeof(RaidAttackScreenTransition.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(RaidAttackScreenTransition.<>c__DisplayClass8_0).__il2cppRuntimeField_C = R2;
            UnityEngine.Transform val_2 = this.leftCurtain.transform;
            if(this.leftCurtain == 0)
            {
                goto label_4;
            }
            
            val_30 = this.leftCurtain;
            if(null == null)
            {
                goto label_5;
            }
            
            label_4:
            val_30 = 0;
            label_5:
            UnityEngine.Transform val_3 = this.rightCurtain.transform;
            if(this.rightCurtain == 0)
            {
                goto label_7;
            }
            
            val_31 = this.rightCurtain;
            if(null == null)
            {
                goto label_8;
            }
            
            label_7:
            val_31 = 0;
            label_8:
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  delay);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  delay, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  delay, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  0);
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.leftCurtain, endValue:  delay, duration:  null);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.leftCurtain);
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.rightCurtain, endValue:  delay, duration:  null);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.rightCurtain);
            UnityEngine.Transform val_14 = this.sceneIcon.transform;
            val_32 = 0;
            UnityEngine.Vector3 val_15 = localScale;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            if((val_16.Equals(other:  new UnityEngine.Vector3())) != true)
            {
                    UnityEngine.Transform val_20 = this.sceneIcon.transform;
                DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sceneIcon, endValue:  val_18.x, duration:  val_18.y);
                val_32 = 1152921509932985248;
                object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.sceneIcon, ease:  26);
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.sceneIcon);
                UnityEngine.Transform val_24 = this.sceneText.transform;
                DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sceneText, endValue:  val_18.x, duration:  val_18.y);
                object val_26 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.sceneText, ease:  26);
                DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.sceneText);
            }
            
            DG.Tweening.TweenCallback val_28 = new DG.Tweening.TweenCallback(object:  404951040, method:  new IntPtr(260028128));
            object val_29 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        public RaidAttackScreenTransition()
        {
        
        }
    
    }

}
