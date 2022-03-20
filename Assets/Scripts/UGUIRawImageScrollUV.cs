using UnityEngine;
public class UGUIRawImageScrollUV : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 scrollSpeed;
    private UnityEngine.Vector2 currentUV;
    private UnityEngine.UI.RawImage _myImage;
    
    // Properties
    private UnityEngine.UI.RawImage myImage { get; }
    
    // Methods
    private UnityEngine.UI.RawImage get_myImage()
    {
        if(this._myImage != 0)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this._myImage = this;
    }
    private void Update()
    {
        float val_6;
        float val_7;
        float val_1 = UnityEngine.Time.deltaTime;
        this.currentUV = this.currentUV;
        float val_2 = UnityEngine.Time.deltaTime;
        mem[1152921511198932312] = ;
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
        
        mem[1152921511198932312] = 0;
        label_3:
        UnityEngine.UI.RawImage val_3 = this.myImage;
        UnityEngine.UI.RawImage val_4 = this.myImage;
        UnityEngine.Vector2 val_5 = size;
        UnityEngine.Rect val_8 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = this.currentUV.x, y = this.currentUV.y}, size:  new UnityEngine.Vector2() {x = val_6, y = val_7});
        this.uvRect = new UnityEngine.Rect() {m_XMin = val_8.m_XMin, m_YMin = val_8.m_YMin, m_Width = val_8.m_Width, m_Height = val_8.m_Height};
    }
    public UGUIRawImageScrollUV()
    {
    
    }

}
