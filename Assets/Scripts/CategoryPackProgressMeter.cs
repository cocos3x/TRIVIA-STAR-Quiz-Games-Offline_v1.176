using UnityEngine;
public class CategoryPackProgressMeter : MonoBehaviour
{
    // Fields
    private const int TOTAL_METER_SUBDIVISIONS = 5;
    private UnityEngine.CanvasGroup meterCanvasGroup;
    private UnityEngine.UI.Slider progressMeter;
    private UnityEngine.UI.Text meterName;
    private UnityEngine.UI.Image goalImage;
    private UnityEngine.RectTransform nodeContainerCoinIcons;
    private UnityEngine.RectTransform nodeContainerMeterDivider;
    private UnityEngine.Sprite spriteCoin;
    private UnityEngine.Sprite spriteTick;
    private UnityEngine.Sprite spriteMeterDivider;
    private float packCompletionRateNormalized;
    private int meterSegmentsCompleted;
    private System.Collections.Generic.List<UnityEngine.UI.Image> meterCoinsList;
    private System.Collections.Generic.List<UnityEngine.UI.Image> meterTicksList;
    
    // Methods
    public void Initialize()
    {
        var val_16;
        var val_17;
        var val_18;
        UnityEngine.Transform val_19;
        UnityEngine.Transform val_20;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                val_17 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28;
        }
        else
        {
                val_17 = 2097204;
            val_16 = 2097204;
        }
        
        if(val_16 != 0)
        {
                CategoryPackWordBank val_2 = GetWordBank(packId:  34776348);
            val_18 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        }
        else
        {
                val_18 = 0;
        }
        
        float val_6 = ((float)GetPackProgress(packId:  34776348)) / (float)val_18.Size;
        this.packCompletionRateNormalized = val_6;
        float val_16 = 0.2f;
        var val_17 = 0;
        val_16 = val_6 / val_16;
        this.meterSegmentsCompleted = UnityEngine.Mathf.FloorToInt(f:  val_16);
        string val_8 = val_17.FullTitle;
        string val_9 = System.String.Format(format:  -1503392448, arg0:  2097204, arg1:  13152256, arg2:  13152256);
        do
        {
            UnityEngine.RectTransform val_10 = this.meterName.CreateMeterNode(parent:  this.nodeContainerCoinIcons);
            val_19 = this.meterName;
            UnityEngine.RectTransform val_11 = this.meterName.CreateMeterNode(parent:  this.nodeContainerMeterDivider);
            val_20 = this.meterName;
            if(val_17 != 4)
        {
                UnityEngine.UI.Image val_12 = this.CreateImageCoin(parent:  val_19);
            val_19 = this;
            this.meterCoinsList.Add(item:  -1503350944);
            if(val_17 < (GetCurrentChapterForPack(packId:  34776348)))
        {
                UnityEngine.GameObject val_13 = this.gameObject;
            this.SetActive(value:  false);
        }
        
            UnityEngine.UI.Image val_14 = this.CreateImageDivider(parent:  val_20);
        }
        
            if(val_17 < this.meterSegmentsCompleted)
        {
                val_19 = this.meterTicksList;
            UnityEngine.UI.Image val_15 = this.CreateImageTick(parent:  val_20);
            val_20 = this;
            val_19.Add(item:  -1503350944);
        }
        
            val_17 = val_17 + 1;
        }
        while(val_17 != 5);
    
    }
    public void ShowLevelCompleteAnimation(float startDelay = 0, bool isChapterComplete = False, System.Action onComplete)
    {
        var val_4;
        var val_5;
        var val_6;
        CategoryPackProgressMeter val_49;
        var val_50;
        float val_51;
        float val_52;
        var val_53;
        val_49 = this;
        object val_1 = new System.Object();
        typeof(CategoryPackProgressMeter.<>c__DisplayClass15_0).__il2cppRuntimeField_C = val_49;
        this.Initialize();
        UnityEngine.GameObject val_2 = this.meterName.gameObject;
        this.meterName.SetActive(value:  onComplete ^ 1);
        this.meterCanvasGroup.alpha = startDelay;
        val_50 = 4;
        goto label_6;
        label_18:
        if(this.progressMeter <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_51 = val_5;
        if((-1503201848) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_49 = val_49;
        if((3.673424E-39f) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_7 = 2621443.transform;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  startDelay, y:  null, z:  null);
        2621443.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_50 = 5;
        label_6:
        if((val_50 - 4) < 2621443)
        {
            goto label_18;
        }
        
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        typeof(CategoryPackProgressMeter.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = 0;
        if(mem[1152921511693591828] >= 1)
        {
                float val_52 = 0.8f;
            val_52 = mem[1152921511693591824] / val_52;
            var val_60 = 0;
            val_51 = 1152921509932985248;
            val_52 = 1f / val_52;
            float val_11 = val_52 / 5f;
            do
        {
            if(val_60 < mem[1152921511693591828])
        {
                if(mem[1152921511693591828] <= val_60)
        {
                var val_53 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_53 = val_53 + 0;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (0 + 0) + 16, endValue:  val_52, duration:  null);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + 0) + 16, ease:  1);
            val_52 = val_11 * ((float)val_60 + 1);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_52, t:  val_52);
            var val_54 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_54 = val_54 + 0;
            UnityEngine.Transform val_16 = (0 + 0) + 16.transform;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + 0) + 16, endValue:  val_52, duration:  null);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + 0) + 16, ease:  27);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_52, t:  val_52);
        }
        
            if((onComplete != 0) && (val_60 < (mem[1152921511693591832] + 12)))
        {
                var val_20 = val_60 + 1;
            if(val_20 == mem[1152921511693591828])
        {
                if((mem[1152921511693591832] + 12) <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_55 = mem[1152921511693591832] + 8;
            val_55 = val_55 + 0;
            UnityEngine.GameObject val_21 = (mem[1152921511693591832] + 8 + 0) + 16.gameObject;
            (mem[1152921511693591832] + 8 + 0) + 16.SetActive(value:  true);
            if((mem[1152921511693591832] + 12) <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_56 = mem[1152921511693591832] + 8;
            val_56 = val_56 + 0;
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (mem[1152921511693591832] + 8 + 0) + 16, endValue:  val_52, duration:  null);
            object val_23 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  (mem[1152921511693591832] + 8 + 0) + 16, delay:  val_52);
            object val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (mem[1152921511693591832] + 8 + 0) + 16, ease:  20);
            float val_57 = (float)val_20;
            val_57 = val_11 * val_57;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_57, t:  val_57);
            if((mem[1152921511693591832] + 12) <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_58 = mem[1152921511693591832] + 8;
            val_58 = val_58 + 0;
            UnityEngine.RectTransform val_26 = (mem[1152921511693591832] + 8 + 0) + 16.rectTransform;
            if((mem[1152921511693591832] + 12) <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_59 = mem[1152921511693591832] + 8;
            val_59 = val_59 + 0;
            UnityEngine.RectTransform val_27 = (mem[1152921511693591832] + 8 + 0) + 16.rectTransform;
            UnityEngine.Vector2 val_28 = anchoredPosition;
            val_52 = val_5 + 30f;
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  (mem[1152921511693591832] + 8 + 0) + 16, endValue:  val_52, duration:  val_28.y, snapping:  val_52);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (mem[1152921511693591832] + 8 + 0) + 16, ease:  6);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_52, t:  val_57);
            val_49 = val_49;
        }
        
        }
        
            val_60 = val_60 + 1;
        }
        while(val_60 < mem[1152921511693591828]);
        
        }
        
        object val_32 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
        val_53 = 0;
        DG.Tweening.Sequence val_33 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_52);
        DG.Tweening.Tweener val_35 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.meterCanvasGroup, endValue:  val_52, duration:  val_28.y);
        DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.meterCanvasGroup);
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_52);
        DG.Tweening.TweenCallback val_38 = new DG.Tweening.TweenCallback(object:  311500800, method:  new IntPtr(2791749408));
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Tweener val_40 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.progressMeter, endValue:  val_52, duration:  val_28.y, snapping:  mem[1152921511693591824]);
        object val_41 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<System.Object>(t:  this.progressMeter, isSpeedBased:  true);
        object val_42 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.progressMeter, ease:  1);
        DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.progressMeter);
        if(mem[1152921511693591828] >= 5)
        {
                val_53 = 0;
            DG.Tweening.TweenCallback val_44 = new DG.Tweening.TweenCallback(object:  311500800, method:  new IntPtr(2791751456));
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_46 = mem[1152921511693591800].transform;
            val_5 = val_53;
            val_4 = val_53;
            val_51 = 1065353216;
            val_6 = val_53;
            UnityEngine.Vector3 val_47 = new UnityEngine.Vector3(x:  val_52, y:  val_28.y, z:  5f);
            DG.Tweening.Tweener val_48 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  mem[1152921511693591800], punch:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, duration:  val_52, vibrato:  1050253722, elasticity:  val_28.y);
            DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511693591800]);
        }
        
        if((???) == 0)
        {
                return;
        }
        
        DG.Tweening.TweenCallback val_50 = new DG.Tweening.TweenCallback(object:  ???, method:  new IntPtr(2791752480));
        object val_51 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public void Hide(float fadeOutDuration = 0)
    {
        if()
        {
                DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.meterCanvasGroup, endValue:  R1, duration:  null);
            return;
        }
        
        this.meterCanvasGroup.alpha = R1;
    }
    private UnityEngine.RectTransform CreateMeterNode(UnityEngine.Transform parent)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  -1502952928);
        UnityEngine.Transform val_2 = transform;
        SetParent(p:  parent);
        UnityEngine.Transform val_3 = transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        object val_7 = AddComponent<System.Object>();
    }
    private UnityEngine.UI.Image CreateImage(string objName, UnityEngine.Transform parent, UnityEngine.Sprite sprite)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  objName);
        UnityEngine.Transform val_2 = transform;
        SetParent(p:  parent);
        UnityEngine.Transform val_3 = transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        object val_7 = AddComponent<System.Object>();
        if(val_1 != 0)
        {
                sprite = sprite;
        }
        else
        {
                sprite = sprite;
        }
        
        if(val_1 != 0)
        {
                return;
        }
    
    }
    private UnityEngine.UI.Image CreateImageCoin(UnityEngine.Transform parent)
    {
        var val_8;
        var val_9;
        val_8 = 0;
        UnityEngine.UI.Image val_1 = CreateImage(objName:  -1502694016, parent:  parent, sprite:  this.spriteCoin);
        if("CoinIcon" != 0)
        {
                UnityEngine.RectTransform val_2 = rectTransform;
            val_9 = "CoinIcon";
            val_8 = "CoinIcon";
        }
        else
        {
                UnityEngine.RectTransform val_3 = 0.rectTransform;
            val_9 = 0;
        }
        
        UnityEngine.RectTransform val_4 = val_8.rectTransform;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  null);
        val_8.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        val_9.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.RectTransform val_6 = val_8.rectTransform;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  null, y:  null);
        val_8.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
    }
    private UnityEngine.UI.Image CreateImageTick(UnityEngine.Transform parent)
    {
        float val_8;
        float val_9;
        var val_10;
        var val_11;
        val_10 = 0;
        UnityEngine.UI.Image val_1 = CreateImage(objName:  -1502565536, parent:  parent, sprite:  this.spriteTick);
        if("TickIcon" != 0)
        {
                UnityEngine.RectTransform val_2 = rectTransform;
            val_11 = "TickIcon";
            val_10 = "TickIcon";
        }
        else
        {
                UnityEngine.RectTransform val_3 = 0.rectTransform;
            val_11 = 0;
        }
        
        UnityEngine.RectTransform val_4 = val_10.rectTransform;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  null);
        val_10.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        val_11.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.RectTransform val_6 = val_10.rectTransform;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        val_10.anchoredPosition = new UnityEngine.Vector2() {x = val_8, y = val_9};
    }
    private UnityEngine.UI.Image CreateImageDivider(UnityEngine.Transform parent)
    {
        float val_6;
        float val_7;
        var val_12;
        var val_17;
        var val_19;
        UnityEngine.UI.Image val_1 = CreateImage(objName:  -1502437056, parent:  parent, sprite:  this.spriteMeterDivider);
        UnityEngine.RectTransform val_2 = rectTransform;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
        anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.RectTransform val_4 = rectTransform;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        anchorMax = new UnityEngine.Vector2() {x = val_6, y = val_7};
        if("Divider" != 0)
        {
                UnityEngine.RectTransform val_8 = rectTransform;
            val_19 = "Divider";
        }
        else
        {
                UnityEngine.RectTransform val_9 = rectTransform;
            val_19 = "Divider";
        }
        
        UnityEngine.Rect val_10 = rect;
        UnityEngine.Vector2 val_11 = size;
        float val_19 = -0.5f;
        val_19 = val_12 * val_19;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_19, y:  val_11.y);
        offsetMin = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        UnityEngine.RectTransform val_14 = rectTransform;
        UnityEngine.Rect val_15 = rect;
        UnityEngine.Vector2 val_16 = size;
        float val_20 = 0.5f;
        val_20 = val_17 * val_20;
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_20, y:  val_16.y);
        offsetMax = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
    }
    public CategoryPackProgressMeter()
    {
        this.meterCoinsList = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.meterTicksList = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
