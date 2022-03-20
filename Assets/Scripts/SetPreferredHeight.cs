using UnityEngine;
public class SetPreferredHeight : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.LayoutElement layoutElement;
    private UnityEngine.Canvas canvas;
    private UnityEngine.RectTransform canvasRectTransform;
    private bool matchCanvasHeight;
    private float heightOffset;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.layoutElement = this;
        object val_2 = this.GetComponentInParent<System.Object>();
        this.canvas = this;
        UnityEngine.Transform val_3 = this.transform;
        object val_4 = this.GetComponent<System.Object>();
        this.canvasRectTransform = this;
    }
    private void Start()
    {
        this.UpdateUI();
    }
    private void OnRectTransformDimensionsChange()
    {
        this.UpdateUI();
    }
    private void UpdateUI()
    {
        UnityEngine.UI.LayoutElement val_5 = this.layoutElement;
        if(val_5 == 0)
        {
                return;
        }
        
        if(this.matchCanvasHeight == false)
        {
                return;
        }
        
        val_5 = this.layoutElement;
        UnityEngine.Rect val_2 = rect;
        float val_3 = height;
        float val_4 = 4130659264 + this.heightOffset;
    }
    public SetPreferredHeight()
    {
    
    }

}
