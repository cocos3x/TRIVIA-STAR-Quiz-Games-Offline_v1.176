using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIGridTile : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image image;
        private UnityEngine.GameObject outline;
        private UnityEngine.UI.Image timerImage;
        private UnityEngine.UI.Image specialIcon;
        private DG.Tweening.DOTweenAnimation hintAnimation;
        private UnityEngine.Sprite bombSprite;
        private UnityEngine.Sprite chestSprite;
        private UnityEngine.Sprite collectionSprite;
        private SLC.MatchyPics.MPITileData <tileData>k__BackingField;
        private UnityEngine.GameObject ftuxIndicator;
        private UnityEngine.GameObject timerParent;
        private int timeRemaing;
        private int specialTileTime;
        private bool isAHint;
        
        // Properties
        public SLC.MatchyPics.MPITileData tileData { get; set; }
        public bool IsActive { get; }
        public UnityEngine.Vector2Int Location { get; set; }
        
        // Methods
        public SLC.MatchyPics.MPITileData get_tileData()
        {
        
        }
        private void set_tileData(SLC.MatchyPics.MPITileData value)
        {
            this.<tileData>k__BackingField = value;
        }
        public bool get_IsActive()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this != 0)
            {
                    return this.activeSelf;
            }
            
            return this.activeSelf;
        }
        public UnityEngine.Vector2Int get_Location()
        {
            if((R1 + 44) != 0)
            {
                    return new UnityEngine.Vector2Int() {m_X = R1 + 44 + 24, m_Y = R1 + 44 + 28};
            }
            
            return new UnityEngine.Vector2Int() {m_X = R1 + 44 + 24, m_Y = R1 + 44 + 28};
        }
        public void set_Location(UnityEngine.Vector2Int value)
        {
            this.<tileData>k__BackingField.location = value;
            mem2[0] = value.m_Y;
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.timerImage.transform;
            UnityEngine.Transform val_2 = this.timerImage.parent;
            UnityEngine.GameObject val_3 = this.timerImage.gameObject;
            this.timerParent = this.timerImage;
            this.outline.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.timerParent.gameObject;
            this.timerParent.SetActive(value:  false);
            UnityEngine.GameObject val_5 = this.specialIcon.gameObject;
            this.specialIcon.SetActive(value:  false);
        }
        public void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SelectTile(tile:  772335776);
        }
        public void Setup(SLC.MatchyPics.MPITileData data)
        {
            int val_3;
            this.<tileData>k__BackingField = data;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(data != 0)
            {
                    val_3 = data.ImageSetIndex;
            }
            else
            {
                    val_3 = 0;
            }
            
            UnityEngine.Sprite val_2 = GetSprite(imageSetIndex:  0, spriteIndex:  data.SpriteIndex);
            this.image.sprite = -851265360;
        }
        public bool IsAMatch(SLC.MatchyPics.MPIGridTile tile)
        {
            int val_1 = tile.<tileData>k__BackingField.SpriteIndex;
            val_1 = (this.<tileData>k__BackingField.SpriteIndex) - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void HighLight()
        {
            this.outline.SetActive(value:  true);
        }
        public void Reset()
        {
            this.outline.SetActive(value:  false);
        }
        public void OnTileRemoved()
        {
            this.ResetHint();
            if((this.<tileData>k__BackingField.type) == 3)
            {
                goto label_1;
            }
            
            if((this.<tileData>k__BackingField.type) == 2)
            {
                goto label_2;
            }
            
            if((this.<tileData>k__BackingField.type) != 1)
            {
                goto label_5;
            }
            
            this.DisableBomb();
            goto label_5;
            label_1:
            this.CollectCollectionItem();
            goto label_5;
            label_2:
            this.CollectChestReward();
            label_5:
            this.<tileData>k__BackingField.type = 0;
        }
        public void HighLightHint(bool isFtux = False)
        {
            var val_6 = 35638207;
            this.isAHint = true;
            this.InvokeRepeating(methodName:  773065696, time:  null, repeatRate:  null);
            if(isFtux == false)
            {
                    return;
            }
            
            val_6 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_34) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_4 = this.transform;
            val_6 = this;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_34, parent:  773089808);
            this.ftuxIndicator = public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_34;
        }
        public void ResetHint()
        {
            if(this.isAHint == false)
            {
                    return;
            }
            
            this.isAHint = false;
            this.CancelInvoke(methodName:  773065696);
            if(this.ftuxIndicator == 0)
            {
                    return;
            }
            
            R4 + 48.SetActive(value:  false);
        }
        public void UpdateImageSet()
        {
            SLC.MatchyPics.MPITileData val_5;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeSelf == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = this.<tileData>k__BackingField;
            if((this.<tileData>k__BackingField) != 0)
            {
                goto label_5;
            }
            
            val_5 = this.<tileData>k__BackingField;
            if(val_5 == 0)
            {
                goto label_6;
            }
            
            label_5:
            UnityEngine.Sprite val_4 = GetSprite(imageSetIndex:  this.<tileData>k__BackingField.ImageSetIndex, spriteIndex:  this.<tileData>k__BackingField.SpriteIndex);
            this.image.sprite = -851265360;
            return;
            label_6:
        }
        public void Hide()
        {
            if(this.ftuxIndicator != 0)
            {
                    this.ftuxIndicator.SetActive(value:  false);
            }
            
            UnityEngine.Transform val_2 = this.transform;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  773467792, endValue:  null, duration:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  773467792, ease:  26);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  773467792, method:  new IntPtr(773442768));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  773467792, action:  190734336);
        }
        public void ShuffleAnimation()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = R4.transform;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  R4, endValue:  null, duration:  null);
            UnityEngine.Transform val_5 = R4.transform;
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  R4, endValue:  null, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  R4, delay:  null);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  R4, ease:  30);
        }
        public void ShakeAndReset()
        {
            this.outline.SetActive(value:  false);
            UnityEngine.Transform val_1 = this.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  773704080, duration:  null, strength:  null, vibrato:  1053609165, randomness:  null, snapping:  false, fadeOut:  true);
        }
        public void DisableBomb()
        {
            if((this.<tileData>k__BackingField.type) != 1)
            {
                    return;
            }
            
            mem2[0] = 0;
            UnityEngine.GameObject val_1 = R4 + 24.gameObject;
            R4 + 24.SetActive(value:  false);
            UnityEngine.GameObject val_2 = R4 + 52.gameObject;
            R4 + 52.SetActive(value:  false);
            UnityEngine.Transform val_3 = R4 + 24.transform;
            int val_4 = DG.Tweening.ShortcutExtensions.DOKill(target:  R4 + 24, complete:  true);
        }
        public void InitTimeTiles(int timeElapsed)
        {
            UnityEngine.UI.Image val_8;
            var val_9;
            UnityEngine.UI.Image val_10;
            UnityEngine.Sprite val_11;
            if((this.<tileData>k__BackingField.type) == 0)
            {
                    return;
            }
            
            if((this.<tileData>k__BackingField.type) == 1)
            {
                goto label_4;
            }
            
            if((this.<tileData>k__BackingField.type) == 2)
            {
                goto label_5;
            }
            
            if((this.<tileData>k__BackingField.type) != 3)
            {
                goto label_6;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = this;
            val_9 = mem[public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 92];
            val_9 = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 92;
            val_10 = this.specialIcon;
            val_11 = this.collectionSprite;
            goto label_12;
            label_4:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = this;
            val_11 = this.bombSprite;
            mem[1152921513970779340] = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 32;
            this.specialIcon.sprite = val_11;
            this.BombIconAnimation();
            goto label_26;
            label_5:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = this;
            val_9 = mem[public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 60];
            val_9 = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 60;
            val_10 = this.specialIcon;
            val_11 = this.chestSprite;
            label_12:
            mem[1152921513970779340] = val_9;
            val_10.sprite = val_11;
            goto label_26;
            label_6:
            val_8 = this.specialIcon;
            label_26:
            UnityEngine.GameObject val_4 = mem[this.specialIcon].gameObject;
            mem[this.specialIcon].SetActive(value:  true);
            UnityEngine.GameObject val_5 = this.timerParent.gameObject;
            this.timerParent.SetActive(value:  true);
            int val_6 = this.specialTileTime - timeElapsed;
            this.timeRemaing = val_6;
            float val_7 = UnityEngine.Mathf.Max(a:  (float)val_6, b:  null);
            float val_8 = (float)this.specialTileTime;
            val_8 = 0 / val_8;
            this.timerImage.fillAmount = val_8;
        }
        public void UpdateTimer(int timeElapsed)
        {
            int val_8 = timeElapsed;
            if((this.<tileData>k__BackingField.type) == 0)
            {
                    return;
            }
            
            val_8 = this.specialTileTime - val_8;
            this.timeRemaing = val_8;
            float val_1 = UnityEngine.Mathf.Max(a:  (float)val_8, b:  null);
            val_8 = this.specialTileTime;
            float val_8 = (float)val_8;
            val_8 = 0 / val_8;
            this.timerImage.fillAmount = val_8;
            if(this.timeRemaing > 0)
            {
                    return;
            }
            
            if((this.<tileData>k__BackingField.type) == 1)
            {
                    NotificationCenter val_2 = NotificationCenter.DefaultCenter;
                0.PostNotification(aSender:  774199904, aName:  767102512);
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  774155344, clipIndex:  0);
            }
            
            this.<tileData>k__BackingField.type = 0;
            UnityEngine.GameObject val_4 = this.specialIcon.gameObject;
            this.specialIcon.SetActive(value:  false);
            UnityEngine.GameObject val_5 = this.timerParent.gameObject;
            this.timerParent.SetActive(value:  false);
            this.timerImage.fillAmount = val_8;
            UnityEngine.Transform val_6 = this.specialIcon.transform;
            int val_7 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.specialIcon, complete:  true);
        }
        private void BombIconAnimation()
        {
            var val_7;
            UnityEngine.Transform val_1 = this.specialIcon.transform;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  this.specialIcon, duration:  null, strength:  new UnityEngine.Vector3() {x = 0.5f, y = val_2.x, z = val_2.y}, vibrato:  val_2.z, randomness:  null, fadeOut:  true);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.specialIcon, delay:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  774357984, method:  new IntPtr(774332960));
            System.Delegate val_6 = System.Delegate.Combine(a:  0, b:  190734336);
            val_7 = 0;
            if(val_7 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_5;
            }
            
            }
            
            val_7 = 0;
            label_5:
            mem2[0] = val_7;
        }
        private void PlayHintAnimation()
        {
            if(this.hintAnimation == 0)
            {
                
            }
        
        }
        private void CollectChestReward()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 48];
            val_6 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 48;
            mem[48] = 1835038;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(750732288 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowRewardCollected(tile:  774602464);
        }
        private void CollectCollectionItem()
        {
            SLC.MatchyPics.MPITileData val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-851040240) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = this.<tileData>k__BackingField;
            if((this.<tileData>k__BackingField) != 0)
            {
                goto label_8;
            }
            
            val_6 = this.<tileData>k__BackingField;
            if(val_6 == 0)
            {
                goto label_9;
            }
            
            label_8:
            CollectItem(setIndex:  this.<tileData>k__BackingField.ImageSetIndex, spriteIndex:  this.<tileData>k__BackingField.SpriteIndex);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CollectItem(tile:  774722656);
            return;
            label_9:
        }
        public MPIGridTile()
        {
        
        }
        private void <Hide>b__32_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
    
    }

}
