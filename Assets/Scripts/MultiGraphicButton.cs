using UnityEngine;
public class MultiGraphicButton : Button
{
    // Fields
    public UnityEngine.UI.Graphic[] additionalGraphics;
    protected float disabledAlpha;
    public UnityEngine.UI.Graphic[] tintGraphics;
    protected UnityEngine.Color pressedTint;
    protected UnityEngine.Color disabledTint;
    protected float tintFadeDuration;
    protected bool autoGetTintGraphics;
    public bool useOverlay;
    protected UnityEngine.UI.Image[] overlays;
    public bool useOverlayWhenPressed;
    public UnityEngine.UI.Image[] pressedOverlays;
    protected UnityEngine.RectTransform[] offsetTransforms;
    protected MultiGraphicButton.TransformType pressedOffsetType;
    protected UnityEngine.Vector2 pressedOffset;
    protected UnityEngine.RectTransform[] scalingTransforms;
    protected MultiGraphicButton.TransformType pressedScalingType;
    protected UnityEngine.Vector2 pressedScale;
    protected System.Collections.Generic.List<UnityEngine.Vector2> initialOffsetTransformsPos;
    protected System.Collections.Generic.List<UnityEngine.Vector3> initialScalingTransformsValue;
    protected UnityEngine.UI.Graphic[] tintGraphicsRuntime;
    
    // Methods
    protected override void Awake()
    {
        this.GetInitialOffsetPosition();
        this.GetInitialScales();
    }
    protected override void Start()
    {
        this.TryGetTintGraphic();
    }
    protected void GetInitialOffsetPosition()
    {
        var val_4;
        bool val_1 = UnityEngine.Application.isPlaying;
        if(val_1 == false)
        {
                return;
        }
        
        if(val_1 == false)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.initialOffsetTransformsPos = null;
        val_4 = 0;
        goto label_4;
        label_10:
        UnityEngine.RectTransform val_4 = this.offsetTransforms[val_4];
        UnityEngine.Vector2 val_3 = anchoredPosition;
        this.initialOffsetTransformsPos.Add(item:  new UnityEngine.Vector2());
        val_4 = 1;
        label_4:
        if(val_4 < this.initialOffsetTransformsPos)
        {
            goto label_10;
        }
    
    }
    protected void GetInitialScales()
    {
        var val_4;
        bool val_1 = UnityEngine.Application.isPlaying;
        if(val_1 == false)
        {
                return;
        }
        
        if(val_1 == false)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.initialScalingTransformsValue = null;
        val_4 = 0;
        goto label_4;
        label_10:
        UnityEngine.RectTransform val_4 = this.scalingTransforms[val_4];
        UnityEngine.Vector3 val_3 = localScale;
        this.initialScalingTransformsValue.Add(item:  new UnityEngine.Vector3());
        val_4 = 1;
        label_4:
        if(val_4 < this.initialScalingTransformsValue)
        {
            goto label_10;
        }
    
    }
    protected void TryGetTintGraphic()
    {
        if(this.autoGetTintGraphics == false)
        {
                return;
        }
        
        T[] val_1 = this.GetComponentsInChildren<System.Object>(includeInactive:  true);
        this.tintGraphicsRuntime = this;
    }
    protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
    {
        float val_2;
        float val_3;
        var val_4;
        var val_14;
        var val_15;
        bool val_20;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        UnityEngine.Color val_27;
        float val_28;
        var val_29;
        var val_30;
        UnityEngine.RectTransform val_31;
        float val_32;
        float val_33;
        val_20 = instant;
        val_21 = state;
        if(this.initialOffsetTransformsPos == 0)
        {
                this.initialOffsetTransformsPos = this;
            this.GetInitialOffsetPosition();
        }
        
        if(this.initialScalingTransformsValue == 0)
        {
                this.initialScalingTransformsValue = this;
            this.GetInitialScales();
        }
        
        val_22 = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if(val_21 == 2)
        {
            goto label_1;
        }
        
        if(val_21 != 4)
        {
            goto label_2;
        }
        
        if(this.useOverlay == false)
        {
            goto label_3;
        }
        
        val_23 = 1f;
        goto label_4;
        label_1:
        val_23 = 1f;
        val_24 = 1152921513030913944;
        val_25 = 1152921513030913940;
        val_26 = 1152921513030913936;
        val_27 = this.pressedTint;
        if(this.useOverlayWhenPressed == true)
        {
                val_28 = 1;
        }
        
        val_22 = 1;
        goto label_5;
        label_2:
        val_23 = 1f;
        val_28 = 0;
        goto label_6;
        label_3:
        val_23 = this.disabledAlpha;
        label_4:
        val_24 = 1152921513030913960;
        val_25 = 1152921513030913956;
        val_26 = 1152921513030913952;
        val_27 = this.disabledTint;
        val_22 = 0;
        val_28 = 0;
        label_5:
        label_6:
        UnityEngine.GameObject val_6 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.useOverlay == false)
        {
            goto label_9;
        }
        
        val_29 = 0;
        val_28 = 1152921504765685760;
        goto label_10;
        label_17:
        if((-964883952) != 0)
        {
                1152921507936930320.enabled = false;
        }
        
        val_29 = 1;
        label_10:
        if(val_29 < 1152921507936930320)
        {
            goto label_17;
        }
        
        goto label_18;
        label_9:
        this.SetAlpha(targetAlpha:  val_1.r, instant:  val_23);
        label_18:
        this.SetTint(color:  new UnityEngine.Color() {r = this.disabledTint.r, g = 3.049421E-25f, b = 3.049421E-25f, a = 3.049421E-25f}, instant:  val_20);
        val_21 = val_28;
        if(this.useOverlayWhenPressed == false)
        {
            goto label_19;
        }
        
        val_28 = 0;
        val_20 = 1152921504765685760;
        goto label_20;
        label_27:
        if((-964879856) != 0)
        {
                1152921507936934416.enabled = false;
        }
        
        val_28 = 1;
        label_20:
        if(val_28 < 1152921507936934416)
        {
            goto label_27;
        }
        
        label_19:
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_66;
        }
        
        if(val_22 == 0)
        {
            goto label_29;
        }
        
        val_28 = 16;
        val_30 = 4;
        goto label_30;
        label_49:
        if(this.pressedOffsetType == 1)
        {
            goto label_31;
        }
        
        if(this.pressedOffsetType != 0)
        {
            goto label_32;
        }
        
        UnityEngine.Vector2 val_11 = GetButtonDimension();
        UnityEngine.Vector2 val_23 = this.pressedOffset;
        val_31 = this.offsetTransforms[0];
        float val_12 = val_3 * S18;
        val_23 = val_2 * val_23;
        if((-165879880) <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -7.954443E+32f, y = 3.673424E-39f}, b:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = val_23});
        val_32 = val_14;
        val_33 = val_15;
        goto label_40;
        label_31:
        val_31 = this.offsetTransforms[0];
        if(this.pressedOffsetType <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -7.954452E+32f, y = 3.673424E-39f}, b:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = this.pressedOffset});
        val_32 = val_2;
        val_33 = val_3;
        label_40:
        val_31.anchoredPosition = new UnityEngine.Vector2() {x = val_32, y = val_33};
        label_32:
        val_30 = 5;
        val_28 = val_28 + 8;
        label_30:
        var val_17 = val_30 - 4;
        if(val_17 < val_31)
        {
            goto label_49;
        }
        
        val_22 = 0;
        val_21 = 4;
        val_20 = 0;
        goto label_50;
        label_65:
        if(this.pressedScalingType == 1)
        {
            goto label_51;
        }
        
        if(this.pressedScalingType != 0)
        {
            goto label_60;
        }
        
        UnityEngine.RectTransform val_24 = this.scalingTransforms[0];
        if(val_24 <= val_17)
        {
                var val_25 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_25 = val_25 + val_20;
        val_28 = mem[(0 + val_20) + 16];
        val_28 = (0 + val_20) + 16;
        val_3 = 0;
        val_2 = 0;
        val_4 = 0;
        UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_16.x, y:  val_16.y, z:  val_1.b);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = -7.954443E+32f, y = val_28, z = (0 + val_20) + 20}, b:  new UnityEngine.Vector3() {x = (0 + val_20) + 24, y = val_18.x, z = val_18.y});
        val_24.localScale = new UnityEngine.Vector3();
        val_22 = 0;
        goto label_60;
        label_51:
        UnityEngine.RectTransform val_26 = this.scalingTransforms[0];
        val_3 = val_22;
        val_2 = val_22;
        val_4 = val_22;
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_16.x, y:  val_16.y, z:  val_1.b);
        val_26.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        label_60:
        val_21 = 5;
        val_20 = 12;
        label_50:
        if((val_21 - 4) < val_26)
        {
            goto label_65;
        }
        
        goto label_66;
        label_29:
        val_28 = 0;
        goto label_67;
        label_74:
        UnityEngine.RectTransform val_27 = this.offsetTransforms[val_28];
        if(this.offsetTransforms[val_28] <= val_28)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = 1;
        val_27.anchoredPosition = new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f};
        val_28 = 1;
        label_67:
        if(val_28 < val_27)
        {
            goto label_74;
        }
        
        val_21 = 4;
        val_20 = 0;
        goto label_75;
        label_82:
        UnityEngine.RectTransform val_28 = this.scalingTransforms[0];
        if(val_27 <= 2621443)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + val_20;
        val_28 = mem[(0 + val_20) + 20];
        val_28 = (0 + val_20) + 20;
        val_22 = mem[(0 + val_20) + 24];
        val_22 = (0 + val_20) + 24;
        val_28.localScale = new UnityEngine.Vector3() {x = (0 + val_20) + 16, y = val_28, z = val_22};
        val_21 = 5;
        val_20 = 12;
        label_75:
        if((val_21 - 4) < val_28)
        {
            goto label_82;
        }
        
        label_66:
        this.DoStateTransition(state:  val_21, instant:  val_20);
    }
    protected void SetAlpha(float targetAlpha, bool instant)
    {
        var val_1 = mem[1152921513031533824] + 16;
        goto label_1;
        label_8:
        if(((mem[1152921513031533824] + 16) + 0) != 0)
        {
                if((???) == 0)
        {
                ??? = this;
            0 = mem[1152921513031533772];
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < (mem[1152921513031533824] + 12))
        {
            goto label_8;
        }
    
    }
    protected void SetTint(UnityEngine.Color color, bool instant)
    {
        float val_3;
        float val_4;
        var val_7;
        if(this.autoGetTintGraphics == false)
        {
            goto label_1;
        }
        
        val_3 = 0;
        val_4 = 1152921504765685760;
        goto label_2;
        label_9:
        if((-964871664) != 0)
        {
                if(instant == false)
        {
                instant = this;
            0 = mem[1152921513031719596];
        }
        
        }
        
        val_3 = 1;
        label_2:
        if(val_3 < 1152921507936942608)
        {
            goto label_9;
        }
        
        return;
        label_1:
        val_4 = this.tintGraphics;
        val_7 = 0;
        val_3 = 1152921504765685760;
        goto label_11;
        label_18:
        if((-964888048) != 0)
        {
                if(instant == false)
        {
                instant = this;
            0 = mem[1152921513031719596];
        }
        
        }
        
        val_7 = 1;
        label_11:
        if(val_7 < 1152921507936926224)
        {
            goto label_18;
        }
    
    }
    protected UnityEngine.Vector2 GetButtonDimension()
    {
        var val_3;
        var val_6;
        var val_8;
        float val_11;
        var val_14;
        var val_15;
        val_14 = 0;
        UnityEngine.Transform val_1 = R1.transform;
        if(R1 != 0)
        {
                if(R1 == null)
        {
            goto label_2;
        }
        
        }
        
        val_15 = 1;
        goto label_3;
        label_2:
        val_15 = 0;
        val_14 = R1;
        label_3:
        UnityEngine.Vector2 val_2 = sizeDelta;
        UnityEngine.Transform val_4 = R1.transform;
        UnityEngine.Vector3 val_5 = localScale;
        UnityEngine.Vector2 val_7 = sizeDelta;
        UnityEngine.Transform val_9 = R1.transform;
        UnityEngine.Vector3 val_10 = localScale;
        float val_14 = val_11;
        float val_12 = val_3 * val_6;
        val_14 = val_8 * val_14;
        this = 0;
        mem[1152921513031905108] = 0;
        this = new UnityEngine.Vector2(x:  val_14, y:  val_10.y);
        return new UnityEngine.Vector2() {x = val_14, y = val_10.y};
    }
    public MultiGraphicButton()
    {
        UnityEngine.Vector2 val_4;
        var val_5;
        UnityEngine.Vector2 val_7;
        var val_8;
        this.additionalGraphics = null;
        this.disabledAlpha = 0.4f;
        this.tintGraphics = null;
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        this.tintFadeDuration = 0.07f;
        this.offsetTransforms = null;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.pressedOffset = val_4;
        mem[1152921513032025548] = val_5;
        this.scalingTransforms = null;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.one;
        this.pressedScale = val_7;
        mem[1152921513032025564] = val_8;
        this.tintGraphicsRuntime = null;
    }

}
