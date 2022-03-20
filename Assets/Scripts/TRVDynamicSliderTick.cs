using UnityEngine;
public class TRVDynamicSliderTick : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text myText;
    private UnityEngine.GameObject completeImage;
    private bool completeImageReplacesText;
    
    // Methods
    public void Init(int myValue, int maxValue, int myDisplayAmount, int lastTickOffset, bool isComplete = False)
    {
        var val_14;
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = this.parent;
        object val_4 = this.GetComponent<System.Object>();
        UnityEngine.Rect val_5 = rect;
        float val_6 = width;
        float val_14 = (float)maxValue;
        val_14 = (float)myValue / val_14;
        uint val_15 = 3762287656;
        val_14 = val_14 * val_15;
        val_15 = val_14 + (float)lastTickOffset;
        val_14 = val_14;
        object val_7 = this.GetComponent<System.Object>();
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_14 = val_15, y:  val_5.m_YMin);
        this.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        if(this.myText != 0)
        {
                val_14 = this;
        }
        
        if(this.completeImage == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_11 = this.completeImage.gameObject;
        val_14 = this.completeImage;
        val_14.SetActive(value:  isComplete);
        if(isComplete != true)
        {
                return;
        }
        
        if(this.myText == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_13 = this.myText.gameObject;
        this.myText.SetActive(value:  false);
    }
    public virtual string FormatMyText(int myDisplayAmount)
    {
        string val_1 = myDisplayAmount.ToString();
        string val_2 = System.String.Format(format:  -588332288, arg0:  -532543028);
    }
    public TRVDynamicSliderTick()
    {
    
    }

}
