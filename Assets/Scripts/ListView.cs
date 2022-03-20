using UnityEngine;
public class ListView
{
    // Fields
    public ListView.Type listType;
    private UnityEngine.RectTransform root;
    private System.Collections.Generic.List<UnityEngine.RectTransform> items;
    private float itemSize;
    private UnityEngine.MonoBehaviour behaviour;
    private bool isSnapScroll;
    
    // Methods
    public ListView(UnityEngine.MonoBehaviour behaviour)
    {
        this.behaviour = behaviour;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.items = null;
    }
    public ListView SetType(ListView.Type listType)
    {
        this.listType = listType;
    }
    public ListView SetSnapScroll(bool isSnap)
    {
        this.isSnapScroll = true;
    }
    public ListView SetRoot(UnityEngine.RectTransform root)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        UnityEngine.RectTransform val_9;
        var val_10;
        this.root = root;
        System.Collections.IEnumerator val_1 = root.GetEnumerator();
        label_17:
        val_5 = 0;
        val_6 = 0;
        val_5 = val_5 + 1;
        val_6 = (uint)val_5 & 65535;
        val_7 = root;
        if(root == 0)
        {
            goto label_7;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_8 = root;
        val_9 = 0;
        if(root != 0)
        {
                if(null != null)
        {
            
        }
        else
        {
                val_9 = root;
        }
        
        }
        
        this.items.Add(item:  val_9);
        goto label_17;
        label_7:
        if(root != 0)
        {
                val_5 = 0;
            val_5 = val_5 + 1;
            val_10 = root;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public ListView SetItemSize(float itemSize)
    {
        this.itemSize = ;
    }
    public void Build()
    {
        this.UpdateList();
    }
    private void UpdateList()
    {
        float val_3;
        float val_6;
        UnityEngine.RectTransform val_10;
        UnityEngine.RectTransform val_11;
        var val_12;
        System.Collections.Generic.List<UnityEngine.RectTransform> val_1 = this.GetActiveItems();
        val_10 = this.root;
        if(this.isSnapScroll == false)
        {
                this.itemSize = 0f;
        }
        
        if(this.listType == 1)
        {
                val_11 = val_10;
            if(this == 0)
        {
                val_11 = this.root;
        }
        
            UnityEngine.Vector2 val_2 = sizeDelta;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (float)this.root, y:  val_2.y);
            val_12 = 0;
            val_10.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            if(this.root < 1)
        {
                return;
        }
        
            this.itemSize = this.itemSize * 0.5f;
            do
        {
            if(this.root <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Vector2 val_5 = sizeDelta;
            float val_10 = val_6;
            val_10 = val_10 * 0.5f;
            val_10 = this.itemSize + val_10;
            PluginExtension.SetLocalX(transform:  ListView.Type.__il2cppRuntimeField_byval_arg, x:  val_10);
            val_12 = val_12 + 1;
        }
        while(val_12 < this.root);
        
            return;
        }
        
        UnityEngine.Vector2 val_7 = sizeDelta;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  (float)this.root, y:  val_7.y);
        val_12 = 0;
        val_10.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        if(this.root < 1)
        {
                return;
        }
        
        this.itemSize = this.itemSize * 0.5f;
        do
        {
            if(this.root <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Vector2 val_9 = sizeDelta;
            float val_11 = val_3;
            val_11 = val_11 * (-0.5f);
            val_11 = val_11 - this.itemSize;
            PluginExtension.SetLocalY(transform:  ListView.Type.__il2cppRuntimeField_byval_arg, y:  val_11);
            val_12 = val_12 + 1;
        }
        while(val_12 < this.root);
    
    }
    public void DisappearItems(int[] indexes)
    {
        var val_2;
        val_2 = 0;
        goto label_1;
        label_8:
        if(true <= null)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 1913211840;
        UnityEngine.GameObject val_1 = (0 + 1913211840) + 16.gameObject;
        (0 + 1913211840) + 16.SetActive(value:  false);
        val_2 = 1;
        label_1:
        if(val_2 < ((0 + 1913211840) + 16))
        {
            goto label_8;
        }
        
        this.UpdateList();
    }
    public void DisappearItemsAfterTime(float delay, int[] indexes)
    {
        System.Collections.IEnumerator val_1 = this.IEDisappearItems(indexes:  R2, delay:  delay);
        UnityEngine.Coroutine val_2 = this.behaviour.StartCoroutine(routine:  -2132071104);
    }
    private System.Collections.IEnumerator IEDisappearItems(int[] indexes, float delay)
    {
        typeof(ListView.<IEDisappearItems>d__16).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(ListView.<IEDisappearItems>d__16).__il2cppRuntimeField_14 = this;
            typeof(ListView.<IEDisappearItems>d__16).__il2cppRuntimeField_18 = indexes;
        }
        else
        {
                mem[20] = this;
            mem[24] = indexes;
        }
        
        typeof(ListView.<IEDisappearItems>d__16).__il2cppRuntimeField_10 = R2;
    }
    private System.Collections.Generic.List<UnityEngine.RectTransform> GetActiveItems()
    {
        var val_2;
        System.Predicate<UnityEngine.RectTransform> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = ListView.<>c.<>9__17_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  ListView.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2163214976));
            ListView.<>c.<>9__17_0 = val_4;
        }
        
        if(this.items != 0)
        {
                return this.items.FindAll(match:  8040448);
        }
        
        return this.items.FindAll(match:  8040448);
    }
    public int GetActiveItemsCount()
    {
        System.Collections.Generic.List<UnityEngine.RectTransform> val_1 = this.GetActiveItems();
        if(this != 0)
        {
                return (int)this.root;
        }
        
        return (int)this.root;
    }

}
