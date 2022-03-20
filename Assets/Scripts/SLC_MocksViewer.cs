using UnityEngine;
public class SLC_MocksViewer : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.RawImage currentMock;
    
    // Methods
    public void OnOpacitySliderChanged(float value)
    {
        UnityEngine.CanvasRenderer val_1 = this.currentMock.canvasRenderer;
        this.currentMock.SetAlpha(alpha:  value);
    }
    public void SetImage(UnityEngine.Texture image)
    {
        this.currentMock.texture = image;
    }
    public UnityEngine.Texture GetImage()
    {
        if(this.currentMock == 0)
        {
                return;
        }
        
        0 = this.currentMock.m_Texture;
    }
    public SLC_MocksViewer()
    {
    
    }

}
