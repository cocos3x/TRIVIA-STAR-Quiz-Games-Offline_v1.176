using UnityEngine;
public class UIGradientSpinner : MonoBehaviour
{
    // Fields
    private float angleIncrement;
    private UIGradient _gradient;
    private UnityEngine.UI.Image _image;
    
    // Properties
    private UIGradient gradient { get; }
    private UnityEngine.UI.Image image { get; }
    
    // Methods
    private UIGradient get_gradient()
    {
        if(0 != this._gradient)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this._gradient = this;
    }
    private UnityEngine.UI.Image get_image()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._image)) != false)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this._image = this;
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  1822384288);
    }
    private void FixedUpdate()
    {
    
    }
    private void doTHing()
    {
        float val_8;
        var val_9;
        float val_10;
        UIGradient val_1 = this.gradient;
        if(this != 0)
        {
                val_8 = this.angleIncrement;
            val_9 = 1152921510724446704;
        }
        else
        {
                val_9 = 48;
            val_8 = this.angleIncrement;
            val_10 = 2.571435E-39f;
        }
        
        mem[48] = val_8 + val_10;
        UIGradient val_3 = this.gradient;
        if(this >= 0)
        {
                UIGradient val_4 = this.gradient;
            UIGradient val_5 = this.gradient;
            float val_8 = -180f;
            val_8 = (val_8 + val_8) + val_8;
            mem[1152921510724446704] = val_8;
        }
        
        UnityEngine.UI.Image val_7 = this.image;
        if(this == 0)
        {
            
        }
    
    }
    private System.Collections.IEnumerator fakeUpdate()
    {
        object val_1 = new System.Object();
        typeof(UIGradientSpinner.<fakeUpdate>d__10).__il2cppRuntimeField_8 = 0;
        typeof(UIGradientSpinner.<fakeUpdate>d__10).__il2cppRuntimeField_10 = this;
    }
    public UIGradientSpinner()
    {
        this.angleIncrement = 10f;
    }

}
