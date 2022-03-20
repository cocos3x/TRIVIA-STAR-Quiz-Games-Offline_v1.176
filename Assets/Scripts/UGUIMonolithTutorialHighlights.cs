using UnityEngine;
public class UGUIMonolithTutorialHighlights : MonoBehaviour
{
    // Fields
    protected System.Collections.Generic.List<UnityEngine.Transform> Highlights;
    protected int currentHighlightIndex;
    protected UnityEngine.Transform currentParent;
    protected UnityEngine.Vector3 currentPos;
    protected int currentLayer;
    protected int currentSiblingIndex;
    
    // Methods
    public UnityEngine.Transform HighlightByIndex(int index, UnityEngine.Transform stage, bool disableButton = False)
    {
        float val_13;
        float val_14;
        float val_16;
        float val_17;
        float val_22;
        float val_23;
        float val_24;
        this.currentHighlightIndex = index;
        if(true <= index)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + (index << 2);
        UnityEngine.Transform val_1 = (0 + (index) << 2) + 16.parent;
        this.currentParent = (0 + (index) << 2) + 16;
        if(((0 + (index) << 2) + 16) <= index)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + (index << 2);
        UnityEngine.Vector3 val_2 = position;
        if(R0 <= index)
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = val_30 + (index << 2);
        UnityEngine.GameObject val_3 = (0 + (index) << 2) + 16.gameObject;
        int val_4 = (0 + (index) << 2) + 16.layer;
        this.currentLayer = val_4;
        if(val_4 <= index)
        {
                var val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_31 = val_31 + (index << 2);
        this.currentSiblingIndex = (0 + (index) << 2) + 16.GetSiblingIndex();
        object val_6 = this.currentParent.GetComponent<System.Object>();
        if(this.currentParent != 0)
        {
                object val_8 = this.currentParent.GetComponent<System.Object>();
            this.currentParent.enabled = false;
        }
        
        if(this.currentParent <= index)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + (index << 2);
        UnityEngine.Transform val_9 = (0 + (index) << 2) + 16.root;
        object val_10 = (0 + (index) << 2) + 16.GetComponentInChildren<System.Object>();
        if(((0 + (index) << 2) + 16) <= index)
        {
                var val_33 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_33 = val_33 + (index << 2);
        UnityEngine.Vector3 val_11 = position;
        UnityEngine.Vector3 val_15 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = (0 + (index) << 2) + 16, y = val_13, z = val_14});
        UnityEngine.Transform val_19 = stage.root;
        object val_20 = stage.GetComponentInChildren<System.Object>();
        UnityEngine.Vector3 val_21 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = stage, y = val_16, z = val_17});
        if(val_24 <= index)
        {
                var val_34 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_34 = val_34 + (index << 2);
        (0 + (index) << 2) + 16.SetParent(p:  stage);
        if(((0 + (index) << 2) + 16) <= index)
        {
                var val_35 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = val_35 + (index << 2);
        (0 + (index) << 2) + 16.position = new UnityEngine.Vector3() {x = val_22, y = val_24, z = val_23};
        if(((0 + (index) << 2) + 16) <= index)
        {
                var val_36 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_36 = val_36 + (index << 2);
        UnityEngine.GameObject val_25 = (0 + (index) << 2) + 16.gameObject;
        UnityEngine.GameObject val_26 = stage.gameObject;
        (0 + (index) << 2) + 16.layer = stage.layer;
        if(((0 + (index) << 2) + 16) <= index)
        {
                var val_37 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_37 = val_37 + (index << 2);
    }
    public void UnhighlightCurrent()
    {
        int val_5 = this.currentHighlightIndex;
        if(val_5 == 1)
        {
                return;
        }
        
        if(true <= val_5)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (val_5 << 2);
        (0 + (this.currentHighlightIndex) << 2) + 16.SetParent(p:  this.currentParent);
        if(((0 + (this.currentHighlightIndex) << 2) + 16) <= this.currentHighlightIndex)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (this.currentHighlightIndex << 2);
        (0 + (this.currentHighlightIndex) << 2) + 16.position = new UnityEngine.Vector3() {x = this.currentPos, y = this.Highlights, z = R7};
        if(((0 + (this.currentHighlightIndex) << 2) + 16) <= this.currentHighlightIndex)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (this.currentHighlightIndex << 2);
        UnityEngine.GameObject val_1 = (0 + (this.currentHighlightIndex) << 2) + 16.gameObject;
        (0 + (this.currentHighlightIndex) << 2) + 16.layer = this.currentLayer;
        if(((0 + (this.currentHighlightIndex) << 2) + 16) <= this.currentHighlightIndex)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (this.currentHighlightIndex << 2);
        (0 + (this.currentHighlightIndex) << 2) + 16.SetSiblingIndex(index:  this.currentSiblingIndex);
        val_5 = 1152921512512943088;
        object val_2 = this.currentParent.GetComponent<System.Object>();
        if(this.currentParent == 0)
        {
                return;
        }
        
        object val_4 = this.currentParent.GetComponent<System.Object>();
        this.currentParent.enabled = true;
    }
    public UGUIMonolithTutorialHighlights()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.Highlights = null;
        this.currentHighlightIndex = 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.currentSiblingIndex = 0;
    }

}
