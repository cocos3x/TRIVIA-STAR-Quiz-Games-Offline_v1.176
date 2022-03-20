using UnityEngine;
public class PEButtonScript : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
    // Fields
    private UnityEngine.UI.Button myButton;
    public ButtonTypes ButtonType;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.myButton = this;
    }
    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(UICanvasManager.GlobalAccess == 0)
        {
                null = 1152921504903118940;
        }
        
        UICanvasManager.GlobalAccess.MouseOverButton = true;
        UICanvasManager.GlobalAccess.UpdateToolTip(toolTipType:  this.ButtonType);
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(UICanvasManager.GlobalAccess == 0)
        {
                null = 1152921504903118940;
        }
        
        UICanvasManager.GlobalAccess.MouseOverButton = false;
        UICanvasManager.GlobalAccess.ClearToolTip();
    }
    public void OnButtonClicked()
    {
        UICanvasManager.GlobalAccess.UIButtonClick(buttonTypeClicked:  this.ButtonType);
    }
    public PEButtonScript()
    {
    
    }

}
