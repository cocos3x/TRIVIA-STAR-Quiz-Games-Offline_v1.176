using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackScreenTransition : MonoSingleton<RestaurantRivals.RESRaidAttackScreenTransition>
    {
        // Fields
        private UnityEngine.GameObject attackSceneIcon;
        private UnityEngine.GameObject raidSceneIcon;
        private UnityEngine.GameObject[] attackLightnings;
        private UnityEngine.CanvasGroup bgLightIcon;
        private UnityEngine.UI.Image blackBGIcon;
        private UnityEngine.CanvasGroup OpponentAvatarBg;
        private UnityEngine.RectTransform OpponentAvatarPos;
        private UnityEngine.UI.Image OpponentAvatarImage;
        private UnityEngine.Transform OpponentAvatarMask;
        private UnityEngine.Sprite spriteIconAttack_mask;
        private UnityEngine.Sprite spriteIconRaid_mask;
        private UnityEngine.GameObject reveal_inside;
        private UnityEngine.GameObject reveal_outside;
        private UnityEngine.UI.Image reveal_inside_image;
        private UnityEngine.UI.Image reveal_outside_image;
        public static RestaurantRivals.RaidAttackActionType currentAttackRaidSceneType;
        private UnityEngine.GameObject sceneIcon;
        
        // Methods
        private void Start()
        {
            var val_2;
            this.reveal_inside.SetActive(value:  false);
            UnityEngine.GameObject val_1 = this.OpponentAvatarPos.gameObject;
            val_2 = 0;
            this.OpponentAvatarPos.SetActive(value:  false);
            this.OpponentAvatarBg.alpha = null;
            goto label_4;
            label_8:
            1152921507209181152.SetActive(value:  false);
            val_2 = 1;
            label_4:
            if(val_2 < 1152921507209181152)
            {
                goto label_8;
            }
        
        }
        public void ExtendCurtains(RestaurantRivals.RaidAttackActionType sceneType, System.Action onComplete, System.Action onMiddle)
        {
            var val_38;
            float val_39;
            if(new System.Object() != 0)
            {
                    typeof(RESRaidAttackScreenTransition.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = onMiddle;
            }
            else
            {
                    mem[8] = onMiddle;
            }
            
            typeof(RESRaidAttackScreenTransition.<>c__DisplayClass18_0).__il2cppRuntimeField_C = onComplete;
            RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType = sceneType;
            this.SetIcon(sceneType:  RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType);
            if(RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType == 1)
            {
                goto label_3;
            }
            
            if(RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType != 2)
            {
                goto label_14;
            }
            
            mem[1152921513798036608].sprite = mem[1152921513798036592];
            val_38 = 0;
            mem[1152921513798036612].sprite = mem[1152921513798036592];
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            var val_3 = mem[1152921513798036564] + 16;
            goto label_9;
            label_13:
            object val_4 = new System.Object();
            typeof(RESRaidAttackScreenTransition.<>c__DisplayClass18_1).__il2cppRuntimeField_8 = (mem[1152921513798036564] + 16) + 0;
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  427368448, method:  new IntPtr(601211520));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  UnityEngine.Random.Range(min:  null, max:  null));
            val_38 = 1;
            label_9:
            if(val_38 < (mem[1152921513798036564] + 12))
            {
                goto label_13;
            }
            
            goto label_14;
            label_3:
            this.reveal_inside_image.sprite = this.spriteIconRaid_mask;
            this.reveal_outside_image.sprite = this.spriteIconRaid_mask;
            label_14:
            UnityEngine.Color val_9 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_39 = 0;
            if(mem[1152921513798036616] != 0)
            {
                    UnityEngine.Transform val_11 = mem[1152921513798036616].transform;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
                mem[1152921513798036616].localScale = new UnityEngine.Vector3() {x = val_9.r, y = val_39, z = val_9.b};
            }
            
            UnityEngine.Transform val_13 = mem[1152921513798036568].transform;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            mem[1152921513798036568].localScale = new UnityEngine.Vector3() {x = val_9.r, y = val_9.g, z = val_9.b};
            DG.Tweening.Sequence val_15 = DG.Tweening.DOTween.Sequence();
            if(RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType != 0)
            {
                    DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  val_14.x);
                if(mem[1152921513798036616] != 0)
            {
                    UnityEngine.Transform val_18 = mem[1152921513798036616].transform;
                DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[1152921513798036616], endValue:  val_14.x, duration:  val_14.y);
                object val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921513798036616], ease:  27);
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921513798036616]);
            }
            
                UnityEngine.Transform val_22 = mem[1152921513798036568].transform;
                DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[1152921513798036568], endValue:  val_14.x, duration:  val_14.y);
                DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921513798036568]);
                DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921513798036568], endValue:  val_14.x, duration:  val_14.y);
                DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921513798036568]);
                DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921513798036572], endValue:  val_14.x, duration:  val_14.y);
                DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921513798036572]);
            }
            else
            {
                    DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921513798036572], endValue:  val_14.x, duration:  val_14.y);
                DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921513798036572]);
                DG.Tweening.TweenCallback val_31 = new DG.Tweening.TweenCallback(object:  427315200, method:  new IntPtr(601228928));
                DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
                DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921513798036572], endValue:  val_14.x, duration:  val_14.y);
                DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921513798036572]);
                DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  val_14.x);
            }
            
            DG.Tweening.TweenCallback val_36 = new DG.Tweening.TweenCallback(object:  427315200, method:  new IntPtr(601229952));
            object val_37 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        public void WithdrawCurtains(float delay = 0, bool showReveal = True, System.Action onComplete)
        {
            float val_6;
            RestaurantRivals.RESRaidAttackScreenTransition val_35;
            var val_36;
            val_35 = this;
            if(new System.Object() != 0)
            {
                    typeof(RESRaidAttackScreenTransition.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = val_35;
            }
            else
            {
                    mem[8] = val_35;
            }
            
            typeof(RESRaidAttackScreenTransition.<>c__DisplayClass19_0).__il2cppRuntimeField_C = R3;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  delay);
            UnityEngine.Transform val_4 = this.sceneIcon.transform;
            UnityEngine.Vector3 val_5 = localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            if((val_6.Equals(other:  new UnityEngine.Vector3())) != true)
            {
                    if(RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType == 1)
            {
                    UnityEngine.Transform val_10 = this.sceneIcon.transform;
                DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sceneIcon, endValue:  val_8.x, duration:  val_8.y);
                object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.sceneIcon, ease:  27);
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.sceneIcon);
                object val_14 = this.sceneIcon.GetComponent<System.Object>();
                DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.sceneIcon, endValue:  val_8.x, duration:  val_8.y);
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.sceneIcon);
            }
            
                UnityEngine.Transform val_17 = this.bgLightIcon.transform;
                DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.bgLightIcon, endValue:  val_8.x, duration:  val_8.y);
                DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.bgLightIcon);
                DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgLightIcon, endValue:  val_8.x, duration:  val_8.y);
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.bgLightIcon);
                if(RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType == 2)
            {
                    val_36 = 0;
                DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.blackBGIcon, endValue:  val_8.x, duration:  val_8.y);
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.blackBGIcon);
                DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_8.x);
                val_35 = this.sceneIcon;
                UnityEngine.Transform val_25 = val_35.transform;
                if(val_35 != 0)
            {
                    if(null != null)
            {
                    val_35 = 0;
            }
            
                val_36 = val_35;
            }
            
                DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  val_8.x, duration:  val_8.y, snapping:  false);
                DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  0);
                DG.Tweening.TweenCallback val_28 = new DG.Tweening.TweenCallback(object:  427421696, method:  new IntPtr(601404416));
                DG.Tweening.Tween val_29 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_8.x, callback:  1056964608, ignoreTimeScale:  false);
                DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  1056964608);
            }
            
                if((onComplete != 0) && (RestaurantRivals.RESRaidAttackScreenTransition.currentAttackRaidSceneType == 1))
            {
                    DG.Tweening.TweenCallback val_31 = new DG.Tweening.TweenCallback(object:  427421696, method:  new IntPtr(601405440));
                DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            }
            
            }
            
            DG.Tweening.TweenCallback val_33 = new DG.Tweening.TweenCallback(object:  427421696, method:  new IntPtr(601406464));
            object val_34 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        public void ShowReavelAnimation(System.Action onMiddle)
        {
            if(new System.Object() != 0)
            {
                    typeof(RESRaidAttackScreenTransition.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = onMiddle;
            }
            else
            {
                    mem[8] = onMiddle;
            }
            
            typeof(RESRaidAttackScreenTransition.<>c__DisplayClass20_0).__il2cppRuntimeField_C = this;
            this.reveal_inside.SetActive(value:  true);
            UnityEngine.Transform val_2 = this.reveal_inside.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.reveal_inside.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_4 = this.reveal_outside.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.reveal_outside.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_6 = this.reveal_inside.transform;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.reveal_inside, endValue:  val_5.x, duration:  val_5.y);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.reveal_inside, ease:  mem[8]);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  427474944, method:  new IntPtr(601572736));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.reveal_inside, action:  190734336);
        }
        public void MoveOpponentAvatarPosTo(UnityEngine.Transform targetPos)
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.OpponentAvatarPos, endValue:  null, duration:  null);
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Vector3 val_6 = position;
            UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y, z:  val_6.z);
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.OpponentAvatarPos, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_6.x, snapping:  true);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.OpponentAvatarPos, ease:  10);
            DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  601747648, method:  new IntPtr(601722624));
            object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.OpponentAvatarPos, action:  190734336);
        }
        public void HideOpponentAvatarBg()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.OpponentAvatarBg, endValue:  null, duration:  null);
        }
        private void SetIcon(RestaurantRivals.RaidAttackActionType sceneType)
        {
            sceneType = (sceneType - 2) >> 5;
            this.attackSceneIcon.SetActive(value:  sceneType);
            this.raidSceneIcon.SetActive(value:  (sceneType - 1) >> 5);
            this.sceneIcon = this.attackSceneIcon;
        }
        public RESRaidAttackScreenTransition()
        {
        
        }
        private void <MoveOpponentAvatarPosTo>b__21_0()
        {
            UnityEngine.GameObject val_1 = this.OpponentAvatarPos.gameObject;
            this.OpponentAvatarPos.SetActive(value:  false);
        }
    
    }

}
