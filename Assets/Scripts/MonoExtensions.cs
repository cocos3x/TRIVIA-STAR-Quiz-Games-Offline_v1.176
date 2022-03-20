using UnityEngine;
public static class MonoExtensions
{
    // Methods
    public static void ResetLocal(UnityEngine.Transform trans)
    {
        float val_4;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        trans.localPosition = new UnityEngine.Vector3();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        trans.localScale = new UnityEngine.Vector3();
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        trans.localRotation = new UnityEngine.Quaternion() {w = val_4};
    }
    public static void DelayedCallEndOfFrame(UnityEngine.MonoBehaviour monoBehaviour, System.Action callback)
    {
        System.Collections.IEnumerator val_1 = MonoExtensions.DelayedCallEndOfFrameCoroutine(callback:  callback);
        UnityEngine.Coroutine val_2 = monoBehaviour.StartCoroutine(routine:  callback);
    }
    private static System.Collections.IEnumerator DelayedCallEndOfFrameCoroutine(System.Action callback)
    {
        object val_1 = new System.Object();
        typeof(MonoExtensions.<DelayedCallEndOfFrameCoroutine>d__2).__il2cppRuntimeField_8 = 0;
        typeof(MonoExtensions.<DelayedCallEndOfFrameCoroutine>d__2).__il2cppRuntimeField_10 = callback;
    }
    public static void ScrollToTop(UnityEngine.UI.ScrollRect scrollRect)
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public static void ScrollToBottom(UnityEngine.UI.ScrollRect scrollRect)
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public static void SetUIAnchor_WRONGLY(UnityEngine.RectTransform rect, Anchor anchor)
    {
        float val_4;
        float val_5;
        float val_7;
        float val_8;
        Anchor val_1 = anchor - 1;
        if(val_1 > 8)
        {
                return;
        }
        
        var val_2 = 7976308 + (7976308 + ((anchor - 1)) << 2);
        if(val_1 == 8)
        {
                7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & (rect >> 32);
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & (rect >> 1);
            7976308 + ((anchor - 1)) << 2 = IP * 7976308;
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & ((7976308 + ((anchor - 1)) << 2) >> 2);
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & ((IP) << R2);
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & (rect >> 1);
            7976308 + ((anchor - 1)) << 2 = R8 * R2;
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & ((7976308 + ((anchor - 1)) << 2) >> 2);
            7976308 + ((anchor - 1)) << 2 = (7976308 + ((anchor - 1)) << 2) & (rect >> 32);
        }
        
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.up;
        rect.anchorMin = new UnityEngine.Vector2() {x = val_4, y = val_5};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.up;
        if(rect != 0)
        {
                rect.anchorMax = new UnityEngine.Vector2() {x = val_7, y = val_8};
        }
        else
        {
                0.anchorMax = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        }
        
        UnityEngine.Vector2 val_19 = pivot;
        ???.Set(newX:  val_24.x, newY:  val_24.y);
    }
    public static void SetUIAnchor(UnityEngine.RectTransform rect, Anchor anchor)
    {
        Anchor val_1 = anchor - 1;
        if(val_1 > 8)
        {
                return;
        }
        
        var val_2 = 7977632 + (7977632 + ((anchor - 1)) << 2);
        if(val_1 == 8)
        {
                mem2[0] = 7977632 + ((anchor - 1)) << 2 + R8;
            (7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) = ((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) & (((rect) << (32-3)) | ((rect) << 3));
            (7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) = ((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) & (rect >> 32);
            (7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) = ((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) & (((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) << 5);
            (7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) = ((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) & (rect << R3);
            (7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) = ((7977632 + ((anchor - 1)) << 2 + R8) & (((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632)) & (rect >> 32);
            mem2[0] = ((((((7977632 + ((anchor - 1)) << 2 + R8 & ((int)7977632 + ((anchor - 1)) << 2 + R8) >> 7977632) & ((rect) << (32-3)) | ((rect) << 3)) & (rect) >> 32) & ((((7977632 + ((anchor - 1)) << 2 + R8 & ((int) + R8;
        }
        
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
        rect.anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
        rect.anchorMax = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
         = new UnityEngine.Vector2(x:  val_10.x, y:  val_10.y);
        rect.pivot = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    public static int SetUnsetBit(int value, int bit, bool isOn)
    {
        int val_1 = bit & 31;
        bit = value & (~(1 << val_1));
        if(isOn == true)
        {
                bit = value | (1 << val_1);
        }
        
        return bit;
    }
    public static int SetBit(int value, int bit)
    {
        bit = bit & 31;
        value = value | (1 << bit);
        return (int)value;
    }
    public static int UnsetBit(int value, int bit)
    {
        bit = bit & 31;
        value = value & (~(1 << bit));
        return (int)value;
    }
    public static bool IsBitSet(int value, int bit)
    {
        bit = bit & 31;
        value = value & (1 << bit);
        if(value != 0)
        {
                value = 1;
        }
        
        return true;
    }

}
