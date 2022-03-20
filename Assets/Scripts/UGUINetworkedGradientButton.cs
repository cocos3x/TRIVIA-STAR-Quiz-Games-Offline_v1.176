using UnityEngine;
public class UGUINetworkedGradientButton : UGUINetworkedButton
{
    // Fields
    public GradientInfo gradient_default;
    public GradientInfo gradient_pressed;
    public GradientInfo gradient_hover;
    public GradientInfo gradient_disabled;
    public float duration;
    private GradientInfo nextGradient;
    private System.Collections.IEnumerator routine;
    public UIGradient targetGradient;
    
    // Methods
    protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
    {
        GradientInfo val_4;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        if(state > 4)
        {
            goto label_2;
        }
        
        var val_3 = 7412320 + (7412320 + (state) << 2);
        if(state == 4)
        {
                7412320 = 7412320 & (instant << 7412320);
            7412320 = 7412320 & (7412320 >> 32);
            7412320 = 7412320 & ((R8) >> 32);
            7412320 = 7412320 & (7412320 >> 7412320);
            7412320 = 7412320 & ((R8) >> ((((7412320 & (instant) << 7412320) & ((7412320 & (instant) << 7412320)) >> 32) & (R8) >> 32) & ((((7412320 & (instant) << 7412320) & ((7412320 & (instant) << 7412320)) >> 32) & (R8) >> 32)) >> (((741);
        }
        
        val_4 = this.gradient_default;
        goto label_5;
        label_2:
        val_4 = this.nextGradient;
        goto label_6;
        label_5:
        this.nextGradient = ;
        label_6:
        this.CrossfadeGradient(gradient:  this.targetGradient, newGradientInfo:  null);
        this.DoStateTransition(state:  state, instant:  instant);
    }
    private void CrossfadeGradient(UIGradient gradient, GradientInfo newGradientInfo)
    {
        if(gradient == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                if(this.routine != 0)
        {
                this.StopCoroutine(routine:  this.routine);
        }
        
            System.Collections.IEnumerator val_3 = this.DoCrossfadeGradient(gradient:  gradient, newGradientInfo:  newGradientInfo);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1908334192);
            return;
        }
        
        gradient.m_angle = newGradientInfo.m_angle;
    }
    private System.Collections.IEnumerator DoCrossfadeGradient(UIGradient gradient, GradientInfo newGradientInfo)
    {
        typeof(UGUINetworkedGradientButton.<DoCrossfadeGradient>d__10).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(UGUINetworkedGradientButton.<DoCrossfadeGradient>d__10).__il2cppRuntimeField_10 = this;
            typeof(UGUINetworkedGradientButton.<DoCrossfadeGradient>d__10).__il2cppRuntimeField_14 = gradient;
        }
        else
        {
                mem[16] = this;
            mem[20] = gradient;
        }
        
        typeof(UGUINetworkedGradientButton.<DoCrossfadeGradient>d__10).__il2cppRuntimeField_18 = newGradientInfo;
    }
    public UGUINetworkedGradientButton()
    {
        this.duration = 0.1f;
    }

}
