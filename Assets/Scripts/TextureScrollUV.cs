using UnityEngine;
public class TextureScrollUV : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector2 scrollSpeed;
    private UnityEngine.Vector2 currentUV;
    public bool resetOnEnable;
    private bool firstEnable;
    private UnityEngine.Vector2 originalUV;
    public bool useSharedMaterial;
    private UnityEngine.Material mMat;
    
    // Methods
    private void OnEnable()
    {
        if(this.firstEnable != false)
        {
                object val_1 = this.GetComponent<System.Object>();
            if(this.useSharedMaterial != false)
        {
                UnityEngine.Material val_2 = this.sharedMaterial;
        }
        else
        {
                UnityEngine.Material val_3 = this.material;
        }
        
            this.mMat = this;
            UnityEngine.Vector2 val_4 = mainTextureOffset;
            this.currentUV = new UnityEngine.Vector2();
            mem[1152921511185743832] = ???;
            this.firstEnable = false;
            this.originalUV = this.currentUV;
            mem[1152921511185743844] = ???;
        }
        
        if(this.resetOnEnable == true)
        {
                this.resetOnEnable = this.originalUV;
            this.currentUV = this.resetOnEnable;
            mem[1152921511185743832] = ???;
        }
    
    }
    public void SynchronizeUVs()
    {
        this.currentUV = this.originalUV;
        mem[1152921511185855832] = ???;
    }
    public void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        this.currentUV = this.currentUV;
        float val_2 = UnityEngine.Time.deltaTime;
        mem[1152921511185971928] = ;
        if()
        {
                if()
        {
                mem2[0] = 0;
        }
        
        }
        else
        {
                mem2[0] = 0;
        }
        
        if()
        {
                if()
        {
            goto label_3;
        }
        
        }
        
        mem[1152921511185971928] = 0;
        label_3:
        this.mMat.mainTextureOffset = new UnityEngine.Vector2() {x = mem[this.currentUV + (0)], y = mem[this.currentUV + (4)]};
    }
    public TextureScrollUV()
    {
        this.firstEnable = true;
    }

}
