using UnityEngine;
public class WGExtraChapterEventProgressPopup : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
    // Fields
    private UnityEngine.UI.Text timeRemainingText;
    private UnityEngine.UI.Text currentMultiplierText;
    private bool canClick;
    private int frameSkips;
    
    // Methods
    public void Init(float currentMultiplier)
    {
        string val_1 = ExtraChapterEventHandler._Instance.TimeRemainingFormatted;
        this.canClick = false;
    }
    public System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(WGExtraChapterEventProgressPopup.<Start>d__5).__il2cppRuntimeField_8 = 0;
        typeof(WGExtraChapterEventProgressPopup.<Start>d__5).__il2cppRuntimeField_10 = this;
    }
    private void Update()
    {
        int val_5;
        if(UnityEngine.Input.touchCount <= 0)
        {
                if((UnityEngine.Input.GetMouseButton(button:  0)) != true)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_3;
        }
        
        }
        
        }
        
        if(this.canClick == false)
        {
            goto label_3;
        }
        
        if(this.frameSkips < 2)
        {
            goto label_4;
        }
        
        this.StopAllCoroutines();
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_3:
        val_5 = 0;
        goto label_6;
        label_4:
        val_5 = this.frameSkips + 1;
        label_6:
        this.frameSkips = val_5;
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
    {
        this.frameSkips = 0;
        this.canClick = 0;
    }
    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.frameSkips = 0;
        this.canClick = 0;
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.canClick = true;
    }
    public WGExtraChapterEventProgressPopup()
    {
    
    }

}
