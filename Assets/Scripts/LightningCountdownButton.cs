using UnityEngine;
public class LightningCountdownButton : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite lightningWords;
    private UnityEngine.Sprite lightningLevels;
    private UnityEngine.UI.Text countdown;
    private UnityEngine.UI.Button eventButton;
    private int defaultFontSize;
    
    // Methods
    private void Awake()
    {
        var val_11;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.eventButton = this;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1168447088, method:  new IntPtr(3126478800));
        this.AddListener(call:  162246656);
        this.defaultFontSize = this.countdown.resizeTextMaxSize;
        T[] val_5 = this.GetComponentsInChildren<System.Object>(includeInactive:  true);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -1168447088, method:  new IntPtr(3126484944));
        System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<System.Object>(source:  -1168447088, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<System.Object>(source:  -1168447088);
        List.Enumerator<T> val_9 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
                12 = 16;
        }
        
        val_11.sprite = this.lightningLevels;
        goto label_9;
        label_6:
        Dispose();
    }
    public void SetupCountdownText(string text, int size = 0)
    {
        if(size == 0)
        {
                size = this.defaultFontSize;
        }
        
        this.countdown.resizeTextMaxSize = size;
        if(this.countdown == 0)
        {
            
        }
    
    }
    private void ShowEventListPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public LightningCountdownButton()
    {
    
    }
    private bool <Awake>b__5_0(UnityEngine.UI.Image x)
    {
        UnityEngine.GameObject val_1 = x.gameObject;
        UnityEngine.GameObject val_2 = this.gameObject;
        return UnityEngine.Object.op_Inequality(x:  x, y:  -1167962224);
    }

}
