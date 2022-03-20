using UnityEngine;

namespace WordPets
{
    public class WPTLetterTile : WPTGameTile
    {
        // Fields
        private UnityEngine.GameObject containerNormal;
        private UnityEngine.UI.Text myText;
        private UnityEngine.UI.Image backgroundImage;
        private UnityEngine.UI.Image overlayImage;
        private UnityEngine.UI.Image crate;
        private UnityEngine.Sprite normalSpriteRegular;
        private UnityEngine.Font normalFontRegular;
        private UnityEngine.Sprite normalSpritePressed;
        private UnityEngine.Font normalFontPressed;
        private UnityEngine.GameObject containerBalloon;
        private UnityEngine.CanvasGroup balloonCanvasGroup;
        private UnityEngine.UI.Text balloonText;
        private UnityEngine.UI.Image balloon;
        private UnityEngine.UI.Image balloonImageSelected;
        private UnityEngine.GameObject GraphicsObject;
        private UnityEngine.ParticleSystem particle;
        private UnityEngine.UI.Image spiderWeb;
        private UnityEngine.Canvas overrideCanvas;
        private UnityEngine.UI.GraphicRaycaster rayCaster;
        private WordPets.WPTButterfly attachedButterfly;
        private DG.Tweening.Sequence letterSwapSeq;
        private DG.Tweening.Tweener overlaySeq;
        private bool <Selected>k__BackingField;
        private System.Nullable<float> heightToFontSizeFactor;
        
        // Properties
        public bool Selected { get; set; }
        public bool HasButterfly { get; set; }
        public bool HasCrate { get; set; }
        public bool HasSpiderWeb { get; set; }
        public bool HasBalloon { get; set; }
        
        // Methods
        public bool get_Selected()
        {
            return (bool)this.<Selected>k__BackingField;
        }
        public void set_Selected(bool value)
        {
            this.<Selected>k__BackingField = value;
        }
        public bool get_HasButterfly()
        {
            if((R4 + 20) != 0)
            {
                    return R4 + 20.IsTileButterfly(rowIndex:  this.RowIndex);
            }
            
            return R4 + 20.IsTileButterfly(rowIndex:  this.RowIndex);
        }
        public void set_HasButterfly(bool value)
        {
            R5 + 20.SetTileButterfly(rowIndex:  this.RowIndex, isOn:  value);
        }
        public bool get_HasCrate()
        {
            if((R4 + 20) != 0)
            {
                    return R4 + 20.IsTileCrate(rowIndex:  this.RowIndex);
            }
            
            return R4 + 20.IsTileCrate(rowIndex:  this.RowIndex);
        }
        public void set_HasCrate(bool value)
        {
            R6 + 20.SetTileCrate(rowIndex:  this.RowIndex, isOn:  value);
            this.ToggleCrate(state:  value);
        }
        public bool get_HasSpiderWeb()
        {
            if((R4 + 20) != 0)
            {
                    return R4 + 20.IsTileSpiderweb(rowIndex:  this.RowIndex);
            }
            
            return R4 + 20.IsTileSpiderweb(rowIndex:  this.RowIndex);
        }
        public void set_HasSpiderWeb(bool value)
        {
            R6 + 20.SetTileSpiderweb(rowIndex:  this.RowIndex, isOn:  value);
            this.ToggleSpiderWeb(state:  value);
        }
        public bool get_HasBalloon()
        {
            if((R4 + 20) != 0)
            {
                    return R4 + 20.IsTileBalloon(rowIndex:  this.RowIndex);
            }
            
            return R4 + 20.IsTileBalloon(rowIndex:  this.RowIndex);
        }
        public void set_HasBalloon(bool value)
        {
            R6 + 20.SetTileBalloon(rowIndex:  this.RowIndex, isOn:  value);
            this.ToggleBalloon(state:  value);
        }
        public override void SetLetter(char letter)
        {
            this.myCharacter = letter;
            string val_1 = letter.ToString();
            string val_2 = letter.ToUpper();
            if(this.myText != 0)
            {
                    return;
            }
        
        }
        public bool IsSpecialTile()
        {
            if(this.HasButterfly == true)
            {
                    return true;
            }
            
            if(this.HasCrate == true)
            {
                    return true;
            }
            
            if(this.HasSpiderWeb == false)
            {
                    return this.HasBalloon;
            }
            
            return true;
        }
        public bool IsSelectable()
        {
            if(this.HasCrate == true)
            {
                    return (bool)0;
            }
            
            0 = this.HasSpiderWeb ^ 1;
            return (bool)0;
        }
        public bool HasButterflyUnselected()
        {
            bool val_1 = this.HasButterfly;
            if(val_1 == true)
            {
                    false = this.<Selected>k__BackingField;
            }
            
            if(val_1 == true)
            {
                    false = false >> 5;
            }
            
            return (bool)false;
        }
        public void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClickTile(tile:  192620912);
        }
        public override void SetDimension(UnityEngine.Vector2 size)
        {
            float val_9;
            var val_10;
            var val_11;
            val_9 = size.x;
            val_10 = 35638844;
            if(192729048 != 0)
            {
                goto label_1;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            val_11 = 0;
            UnityEngine.Transform val_3 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            if(this != 0)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            label_6:
            if(null != null)
            {
                    val_11 = 0;
            }
            else
            {
                    val_11 = this;
            }
            
            label_9:
            val_10 = 0;
            UnityEngine.Rect val_4 = rect;
            float val_5 = height;
            float val_9 = (float)this.myText.fontSize;
            val_9 = val_9 / 192729048;
            System.Nullable<System.Single> val_6 = new System.Nullable<System.Single>(value:  val_9);
            val_9 = val_9;
            this.heightToFontSizeFactor = val_6.HasValue;
            mem[1152921513389522816] = val_10;
            label_1:
            this.SetDimension(size:  new UnityEngine.Vector2() {x = val_9, y = size.y});
            float val_7 = this.heightToFontSizeFactor.Value;
            this.myText.fontSize = this.heightToFontSizeFactor * size.y;
        }
        public void SwapChar(char newChar)
        {
            if(new System.Object() != 0)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_C = newChar;
            bool val_2 = this.HasBalloon;
            if(val_2 == true)
            {
                    newChar = this.balloonText;
            }
            
            if(val_2 == false)
            {
                    newChar = this.myText;
            }
            
            UnityEngine.Transform val_3 = newChar.transform;
            typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_10 = newChar;
            this.myCharacter = typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_C;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_10, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  400105472, method:  new IntPtr(192845488));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  typeof(WPTLetterTile.<>c__DisplayClass45_0).__il2cppRuntimeField_10, action:  190734336);
        }
        public void ToggleSelection(bool isSelected)
        {
            var val_26;
            object val_1 = null;
            val_26 = val_1;
            val_1 = new System.Object();
            if(val_26 != 0)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass46_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass46_0).__il2cppRuntimeField_C = isSelected;
            if(this.HasBalloon != false)
            {
                    object val_3 = new System.Object();
                typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_10 = val_26;
                if(this.letterSwapSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.letterSwapSeq);
                val_26 = typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_10;
            }
            
                if((typeof(WPTLetterTile.<>c__DisplayClass46_0).__il2cppRuntimeField_C) == false)
            {
                    this.balloon = this.balloonImageSelected;
            }
            
                typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_C = mem[this.balloonImageSelected];
                if((typeof(WPTLetterTile.<>c__DisplayClass46_0).__il2cppRuntimeField_C) == false)
            {
                    this.balloonImageSelected = this.balloon;
            }
            
                UnityEngine.GameObject val_4 = mem[this.balloon].gameObject;
                UnityEngine.Transform val_5 = mem[this.balloon].transform;
                mem[this.balloon].SetAsFirstSibling();
                mem[this.balloon].enabled = true;
                typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_C.enabled = true;
                typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_8 = 1039516303;
                DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
                this.letterSwapSeq = 0;
                DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_C, endValue:  null, duration:  null);
                object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_C, ease:  1);
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_C);
                UnityEngine.Color val_16 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
                float val_26 = typeof(WPTLetterTile.<>c__DisplayClass46_1).__il2cppRuntimeField_8;
                val_26 = val_26 * 0.5f;
                DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOColor(target:  mem[1152921513389786700], endValue:  new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.r}, duration:  val_26);
                DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  400211968, method:  new IntPtr(192970800));
                object val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  mem[1152921513389786700], action:  190734336);
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921513389786700]);
                DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[this.balloon], endValue:  val_26, duration:  null);
                object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[this.balloon], ease:  1);
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[this.balloon]);
                DG.Tweening.TweenCallback val_24 = new DG.Tweening.TweenCallback(object:  400211968, method:  new IntPtr(192971824));
                object val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
                return;
            }
            
            if((typeof(WPTLetterTile.<>c__DisplayClass46_0).__il2cppRuntimeField_C) == false)
            {
                    80 = 72;
                76 = 68;
            }
            
            this.SwapSprite(newSprite:  this.normalSpriteRegular, newFont:  this.normalFontRegular, dontAnimate:  false);
        }
        public void SwapSprite(UnityEngine.Sprite newSprite, UnityEngine.Font newFont, bool dontAnimate = False)
        {
            UnityEngine.Sprite val_17;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_17 = val_1;
                typeof(WPTLetterTile.<>c__DisplayClass47_0).__il2cppRuntimeField_C = newSprite;
                WPTLetterTile.<>c__DisplayClass47_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
            }
            else
            {
                    mem[8] = this;
                val_17 = 12;
                mem[12] = newSprite;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass47_0).__il2cppRuntimeField_10 = newFont;
            if(this.letterSwapSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.letterSwapSeq);
            }
            
            if(dontAnimate != false)
            {
                    this.backgroundImage.sprite = val_17;
                this.myText.font = typeof(WPTLetterTile.<>c__DisplayClass47_0).__il2cppRuntimeField_10;
                return;
            }
            
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.letterSwapSeq = 0;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  null, duration:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.backgroundImage, ease:  1);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.backgroundImage);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.myText, endValue:  null, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.myText, ease:  1);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.letterSwapSeq, t:  this.myText);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  400265216, method:  new IntPtr(193142192));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.letterSwapSeq, callback:  190734336);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  null, duration:  null);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.backgroundImage, ease:  1);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.letterSwapSeq, t:  this.backgroundImage);
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.myText, endValue:  null, duration:  null);
            object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.myText, ease:  1);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.letterSwapSeq, t:  this.myText);
        }
        public void OverrideSort(bool overrideSort)
        {
            if(overrideSort != false)
            {
                    UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.GraphicsObject);
                this.overrideCanvas = this.GraphicsObject;
                UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.GraphicsObject);
                this.rayCaster = this.GraphicsObject;
                this.overrideCanvas.overrideSorting = true;
                this.overrideCanvas.sortingOrder = 10;
                return;
            }
            
            if(this.overrideCanvas == 0)
            {
                    return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  this.rayCaster);
            UnityEngine.Object.DestroyImmediate(obj:  this.overrideCanvas);
        }
        public void ToggleOverlay(bool isVisible, float animDuration = 0, float overlayAlpha = 0.5)
        {
            DG.Tweening.TweenCallback val_10;
            object val_11;
            bool val_12;
            val_10 = R3;
            if(new System.Object() != 0)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_C = isVisible;
            UnityEngine.GameObject val_2 = this.overlayImage.gameObject;
            val_11 = this.overlayImage;
            bool val_3 = val_11.activeSelf;
            val_12 = typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_C;
            if(val_12 == true)
            {
                    val_12 = 1;
            }
            
            val_3 = val_3 ^ 1;
            if(val_3 != true)
            {
                    return;
            }
            
            if(this.overlaySeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.overlaySeq, complete:  false);
                val_12 = typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_C;
            }
            
            if(val_12 == false)
            {
                    val_10 = 0;
            }
            
            UnityEngine.Color val_4 = color;
            UnityEngine.GameObject val_5 = this.overlayImage.gameObject;
            val_11 = this.overlayImage;
            if(this.overlayImage > 0)
            {
                    val_11.SetActive(value:  true);
                DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.overlayImage, endValue:  val_4.r, duration:  val_4.g);
                object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.overlayImage, ease:  1);
                val_11 = this.overlayImage;
                val_10 = null;
                val_10 = new DG.Tweening.TweenCallback(object:  400318464, method:  new IntPtr(193514672));
                object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_11, action:  190734336);
                this.overlaySeq = val_11;
                return;
            }
            
            if((typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_C) == true)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass49_0).__il2cppRuntimeField_C = 1;
            }
            
            val_11.SetActive(value:  true);
        }
        public override void HideTile()
        {
            static_value_021FCE42.RemoveTile(removeTile:  193677296);
            this.particle.Play();
            UnityEngine.GameObject val_1 = this.particle.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  193677296);
            this.interactable = false;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  193677296, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  193677296, method:  new IntPtr(193652272));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  193677296, action:  190734336);
            UnityEngine.Transform val_6 = this.transform;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  193677296, endValue:  null, duration:  null);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  193677296, ease:  9);
        }
        public void SpawnBalloon(UnityEngine.Transform petTile)
        {
            if(this.HasBalloon == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.balloon.gameObject;
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.balloon, parent:  petTile, worldPositionStays:  true);
        }
        public void Shake()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  193921776, duration:  null, strength:  new UnityEngine.Vector3() {x = 0.5f, y = val_2.x, z = val_2.y}, vibrato:  val_2.z, randomness:  null, snapping:  true, fadeOut:  false);
        }
        private void ToggleCrate(bool state)
        {
            if(new System.Object() != 0)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass53_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass53_0).__il2cppRuntimeField_C = state;
            if((typeof(WPTLetterTile.<>c__DisplayClass53_0).__il2cppRuntimeField_C) == true)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass53_0).__il2cppRuntimeField_C = 1;
            }
            
            this.crate.enabled = this.crate.enabled | 1;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.crate, endValue:  1f = 0, duration:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  400371712, method:  new IntPtr(194017968));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.crate, action:  190734336);
        }
        private void ToggleSpiderWeb(bool state)
        {
            if(new System.Object() != 0)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass54_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLetterTile.<>c__DisplayClass54_0).__il2cppRuntimeField_C = state;
            if((typeof(WPTLetterTile.<>c__DisplayClass54_0).__il2cppRuntimeField_C) == true)
            {
                    typeof(WPTLetterTile.<>c__DisplayClass54_0).__il2cppRuntimeField_C = 1;
            }
            
            this.spiderWeb.enabled = this.spiderWeb.enabled | 1;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.spiderWeb, endValue:  0.5f = 0, duration:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  400424960, method:  new IntPtr(194147376));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.spiderWeb, action:  190734336);
        }
        private void ToggleBalloon(bool state)
        {
            bool val_6;
            var val_7;
            UnityEngine.GameObject val_8;
            val_6 = state;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_7 = val_1;
                typeof(WPTLetterTile.<>c__DisplayClass55_0).__il2cppRuntimeField_C = val_6;
                WPTLetterTile.<>c__DisplayClass55_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
                val_8 = this.containerBalloon;
            }
            else
            {
                    mem[8] = this;
                val_7 = 12;
                mem[12] = val_6;
                val_8 = this.containerBalloon;
                val_6 = mem[12];
            }
            
            if(val_6 == true)
            {
                    val_6 = 1;
            }
            
            val_8.SetActive(value:  true);
            this.containerNormal.SetActive(value:  val_8 >> 5);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.balloonCanvasGroup, endValue:  1f = 0, duration:  null);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  400478208, method:  new IntPtr(194284976));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.balloonCanvasGroup, action:  190734336);
        }
        public WPTLetterTile()
        {
            mem[1152921513391219964] = 1157234688;
            mem[1152921513391219968] = 1056964608;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <HideTile>b__50_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
    
    }

}
