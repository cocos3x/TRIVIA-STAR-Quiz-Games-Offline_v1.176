using UnityEngine;
public class FtuxTooltip : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform parentRectTransform;
    private UnityEngine.RectTransform tooltipRectTransform;
    private UnityEngine.RectOffset paddingForSpeechBubble;
    private UnityEngine.UI.Image bubbleTipImage;
    private UnityEngine.UI.Text tooltipText;
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.Canvas parentCanvas;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponentInChildren<System.Object>();
        UnityEngine.Canvas val_2 = this.canvas;
        UnityEngine.Canvas val_3 = this.rootCanvas;
        this.parentCanvas = this;
    }
    public void SetText(string description)
    {
        if(this.tooltipText == 0)
        {
            
        }
    
    }
    public void SetupButton(string text, UnityEngine.Events.UnityAction action)
    {
        UnityEngine.GameObject val_1 = this.button.gameObject;
        this.button.SetActive(value:  true);
        if(action == 0)
        {
                return;
        }
        
        this.button.m_OnClick.RemoveAllListeners();
        this.button.m_OnClick.AddListener(call:  action);
    }
    public void Reposition(UnityEngine.Vector3 worldPos)
    {
        float val_2;
        float val_3;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.Reposition(worldPos:  new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z}, anchoredOffset:  new UnityEngine.Vector2() {x = val_3, y = val_2});
    }
    public void Reposition(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 anchoredOffset)
    {
        float val_9;
        float val_10;
        var val_13;
        var val_14;
        float val_17;
        float val_18;
        float val_21;
        float val_22;
        var val_24;
        var val_25;
        float val_28;
        float val_29;
        var val_31;
        var val_32;
        var val_34;
        var val_35;
        float val_46;
        float val_47;
        var val_49;
        var val_51;
        UnityEngine.Canvas val_58;
        var val_59;
        var val_60;
        float val_61;
        float val_62;
        float val_63;
        if(this.parentCanvas == 0)
        {
                object val_2 = this.parentCanvas.GetComponentInChildren<System.Object>();
            UnityEngine.Canvas val_3 = this.canvas;
            UnityEngine.Canvas val_4 = this.parentCanvas.rootCanvas;
            val_58 = this;
            this.parentCanvas = this;
        }
        else
        {
                val_58 = this.parentCanvas;
        }
        
        UnityEngine.GameObject val_5 = val_58.gameObject;
        UnityEngine.Transform val_6 = val_58.transform;
        val_59 = val_58;
        val_60 = 0;
        UnityEngine.Camera val_7 = this.parentCanvas.worldCamera;
        if(val_59 == 0)
        {
            goto label_10;
        }
        
        val_60 = null;
        if(null == val_60)
        {
            goto label_11;
        }
        
        label_10:
        val_59 = 0;
        label_11:
        UnityEngine.Vector2 val_8 = WorldToCanvasPosition(canvasRect:  160436224, canvasCamera:  0, position:  new UnityEngine.Vector3() {x = this.parentCanvas, y = worldPos.x, z = worldPos.y});
        UnityEngine.Rect val_11 = rect;
        UnityEngine.Vector2 val_12 = min;
        UnityEngine.Rect val_15 = rect;
        UnityEngine.Vector2 val_16 = max;
        UnityEngine.Rect val_19 = rect;
        UnityEngine.Vector2 val_20 = min;
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.862409E+26f, y = val_21}, b:  new UnityEngine.Vector2() {x = val_22, y = val_9});
        UnityEngine.Rect val_26 = rect;
        UnityEngine.Vector2 val_27 = max;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.862385E+26f, y = val_28}, b:  new UnityEngine.Vector2() {x = val_29, y = val_9});
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.zero;
        val_62 = val_34;
        val_63 = val_35;
        float val_58 = (float)this.paddingForSpeechBubble.left;
        val_58 = val_13 + val_58;
        if(this.paddingForSpeechBubble > 0)
        {
                val_61 = val_62;
            float val_59 = (float)this.paddingForSpeechBubble.left;
            val_59 = val_13 + val_59;
            val_59 = val_59 - val_24;
            val_59 = val_59 + val_61;
            val_62 = val_59;
        }
        
        float val_60 = (float)this.paddingForSpeechBubble.right;
        val_60 = val_17 - val_60;
        if(this.paddingForSpeechBubble < 0)
        {
                val_61 = val_62;
            float val_61 = (float)this.paddingForSpeechBubble.right;
            val_61 = val_17 - val_61;
            val_61 = val_32 - val_61;
            val_61 = val_61 - val_61;
            val_62 = val_61;
        }
        
        float val_62 = (float)this.paddingForSpeechBubble.bottom;
        val_62 = val_14 + val_62;
        if(this.paddingForSpeechBubble > 0)
        {
                val_61 = val_63;
            float val_63 = (float)this.paddingForSpeechBubble.bottom;
            val_63 = val_14 + val_63;
            val_63 = val_63 - val_25;
            val_63 = val_63 + val_61;
            val_63 = val_63;
        }
        
        float val_64 = (float)this.paddingForSpeechBubble.top;
        val_64 = val_18 - val_64;
        if(this.paddingForSpeechBubble < 0)
        {
                val_61 = val_63;
            float val_65 = (float)this.paddingForSpeechBubble.top;
            val_65 = val_18 - val_65;
            val_65 = val_31 - val_65;
            val_65 = val_61 - val_65;
            val_63 = val_65;
        }
        
        UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.862432E+26f, y = val_9}, b:  new UnityEngine.Vector2() {x = val_10, y = val_62});
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.862438E+26f, y = val_17}, b:  new UnityEngine.Vector2() {x = val_18, y = anchoredOffset.x});
        if(this.tooltipRectTransform != 0)
        {
                this.tooltipRectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_46, y = val_47};
        }
        else
        {
                0.anchoredPosition = new UnityEngine.Vector2() {x = val_46, y = val_47};
        }
        
        UnityEngine.Vector2 val_48 = sizeDelta;
        var val_66 = val_49;
        val_66 = val_66 * 0.8f;
        float val_67 = 0.5f;
        var val_68 = val_9;
        UnityEngine.Vector2 val_50 = anchoredPosition;
        val_67 = val_66 * val_67;
        val_68 = val_68 - val_51;
        UnityEngine.RectTransform val_52 = this.bubbleTipImage.rectTransform;
        float val_53 = val_67 ^ 2147483648;
        float val_54 = UnityEngine.Mathf.Clamp(value:  val_50.x, min:  val_50.y, max:  val_61);
        UnityEngine.RectTransform val_55 = this.bubbleTipImage.rectTransform;
        UnityEngine.Vector2 val_56 = anchoredPosition;
        val_14 = 0;
        val_13 = 0;
        UnityEngine.Vector2 val_57 = new UnityEngine.Vector2(x:  val_56.x, y:  val_56.y);
        this.bubbleTipImage.anchoredPosition = new UnityEngine.Vector2() {x = val_57.x, y = val_57.y};
    }
    private UnityEngine.Vector2 WorldToCanvasPosition(UnityEngine.RectTransform canvasRect, UnityEngine.Camera canvasCamera, UnityEngine.Vector3 position)
    {
        FtuxTooltip val_4;
        float val_5;
        var val_7;
        var val_9;
        float val_17;
        UnityEngine.Vector3 val_2 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = -9.999517E+26f});
        FtuxTooltip val_18 = val_4;
        float val_19 = val_5;
        UnityEngine.Vector2 val_6 = sizeDelta;
        UnityEngine.Vector2 val_8 = sizeDelta;
        UnityEngine.Vector2 val_10 = sizeDelta;
        val_18 = val_18 * val_7;
        UnityEngine.Vector2 val_12 = pivot;
        val_19 = val_19 * val_9;
        UnityEngine.Vector2 val_14 = sizeDelta;
        UnityEngine.Vector2 val_16 = pivot;
        this = val_18;
        mem[1152921512866412580] = val_19;
        return new UnityEngine.Vector2() {x = val_17, y = val_16.y};
    }
    public FtuxTooltip()
    {
    
    }

}
