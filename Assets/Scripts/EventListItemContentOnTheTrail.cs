using UnityEngine;
public class EventListItemContentOnTheTrail : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Slider slider;
    private UnityEngine.Transform wagon;
    private UnityEngine.UI.Image completionStatus;
    private UnityEngine.Sprite checkMark;
    private UnityEngine.Sprite crossMark;
    private UnityEngine.UI.Text levels;
    
    // Methods
    public void Setup(float progress, string progressText, bool isWagonBroken)
    {
        object val_1 = this.slider.GetComponent<System.Object>();
        UnityEngine.Rect val_2 = rect;
        float val_3 = width;
        object val_4 = this.wagon.GetComponent<System.Object>();
        UnityEngine.Rect val_5 = rect;
        float val_6 = width;
        float val_7 = 2883044216 * (-0.5f);
        val_7 = val_7 + 12f;
        float val_8 = UnityEngine.Mathf.Max(a:  val_7, b:  val_5.m_YMin);
        UnityEngine.Vector3 val_9 = localPosition;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  val_9.z);
        this.wagon.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
        if((???) != 0)
        {
                0f = -10f;
        }
        
        this.wagon.Rotate(axis:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8}, angle:  -10f);
        if((???) != 0)
        {
                24 = 28;
        }
        
        this.completionStatus.sprite = this.crossMark;
        if(this.levels != 0)
        {
                return;
        }
    
    }
    public EventListItemContentOnTheTrail()
    {
    
    }

}
