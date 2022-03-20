using UnityEngine;
public class LibraryBookDisplay_AcquireBooks : LibraryBookDisplay
{
    // Fields
    private UnityEngine.GameObject object_new_tag;
    private UnityEngine.GameObject object_purchaseable_group;
    private UnityEngine.UI.Button button_purchase;
    private UnityEngine.UI.Text text_apples_cost;
    private UnityEngine.UI.Button button_purchased_display;
    private UnityEngine.UI.Text text_collection_progress;
    private BookInfo myBookInfo;
    private System.Action<BookInfo, LibraryBookDisplay_AcquireBooks> bookClickedAction;
    private System.Action<BookInfo, LibraryBookDisplay_AcquireBooks> bookAlreadyPurchasedClickedAction;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1694937104, method:  new IntPtr(2599995952));
        this.button_purchase.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1694937104, method:  new IntPtr(2600005168));
        this.button_purchased_display.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(BookInfo info, bool isNew, bool isPurchased, System.Action<BookInfo, LibraryBookDisplay_AcquireBooks> onBookClicked, System.Action<BookInfo, LibraryBookDisplay_AcquireBooks> onBookAlreadyPurchasedClicked)
    {
        var val_38;
        BookInfo val_39;
        var val_40;
        var val_41;
        System.Func<BookInfo, System.String> val_43;
        var val_44;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Linq.IGrouping<System.String, BookInfo>> val_46;
        var val_47;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.String> val_49;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Int32> val_51;
        var val_52;
        System.Func<BookInfo, System.String> val_54;
        System.Func<System.String, System.Collections.Generic.IEnumerable<BookInfo>, BookInfo> val_56;
        var val_57;
        System.Func<BookInfo, System.Int32> val_59;
        var val_60;
        System.Func<BookInfo, System.String> val_62;
        var val_63;
        var val_64;
        this.Setup(info:  info);
        this.myBookInfo = info;
        this.object_new_tag.SetActive(value:  isNew);
        this.object_purchaseable_group.SetActive(value:  isPurchased ^ 1);
        UnityEngine.GameObject val_2 = this.button_purchased_display.gameObject;
        this.button_purchased_display.SetActive(value:  isPurchased);
        val_38 = null;
        val_38 = null;
        BookEconInfo val_3 = TheLibraryLogic.BookEcon.Item[this.myBookInfo.Rarity];
        string val_4 = TheLibraryLogic.BookEcon.ToString();
        this.bookClickedAction = onBookClicked;
        this.bookAlreadyPurchasedClickedAction = onBookAlreadyPurchasedClicked;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_5 = BookList.BooksByCollection;
        val_39 = info;
        string val_6 = 0.Item[info + 24];
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_7 = TheLibraryLogic.PlayerBooksByCollection;
        if((0.ContainsKey(key:  info + 24)) != false)
        {
                object val_9 = new System.Object();
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_10 = TheLibraryLogic.PlayerBooksByCollection;
            string val_11 = 0.Item[info + 24];
            val_40 = 1152921504907325440;
            val_41 = null;
            val_41 = null;
            val_43 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_0;
            if(val_43 == 0)
        {
                val_43 = null;
            val_43 = new System.Func<ZooTile, System.String>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600171440));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_0 = val_43;
        }
        
            System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_13 = System.Linq.Enumerable.GroupBy<System.Object, System.Object>(source:  0, keySelector:  7720960);
            val_44 = null;
            val_44 = null;
            val_46 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_1;
            if(val_46 == 0)
        {
                val_46 = null;
            val_40 = 1152921504907325440;
            val_46 = new System.Func<ZooTile, System.String>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600172464));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_1 = val_46;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_15 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  0, selector:  7720960);
            val_47 = null;
            val_49 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_2;
            if(val_49 == 0)
        {
                val_49 = null;
            val_40 = 1152921504907325440;
            val_49 = new System.Func<ZooTile, System.String>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600173488));
            val_47 = null;
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_2 = val_49;
        }
        
            val_51 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_3;
            if(val_51 == 0)
        {
                val_51 = null;
            val_40 = 1152921504907325440;
            val_51 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600174512));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_3 = val_51;
        }
        
            System.Collections.Generic.Dictionary<TKey, TElement> val_18 = System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Int32>(source:  0, keySelector:  7720960, elementSelector:  7720960);
            val_52 = null;
            val_54 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_4;
            if(val_54 == 0)
        {
                val_54 = null;
            val_40 = 1152921504907325440;
            val_54 = new System.Func<ZooTile, System.String>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600175536));
            val_52 = null;
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_4 = val_54;
        }
        
            val_56 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_5;
            if(val_56 == 0)
        {
                val_56 = null;
            val_40 = 1152921504907325440;
            val_56 = new System.Func<System.String, System.Collections.Generic.IEnumerable<BookInfo>, BookInfo>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600176560));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_5 = val_56;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_21 = System.Linq.Enumerable.GroupBy<System.Object, System.Object, System.Object>(source:  0, keySelector:  7720960, resultSelector:  7774208);
            val_57 = null;
            val_59 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_6;
            if(val_59 == 0)
        {
                val_59 = null;
            val_40 = 1152921504907325440;
            val_59 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600177584));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_6 = val_59;
        }
        
            System.Linq.IOrderedEnumerable<TSource> val_23 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  0, keySelector:  7720960);
            val_60 = null;
            val_62 = LibraryBookDisplay_AcquireBooks.<>c.<>9__10_7;
            if(val_62 == 0)
        {
                val_62 = null;
            val_62 = new System.Func<ZooTile, System.String>(object:  LibraryBookDisplay_AcquireBooks.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2600178608));
            LibraryBookDisplay_AcquireBooks.<>c.<>9__10_7 = val_62;
        }
        
            System.Linq.IOrderedEnumerable<TSource> val_25 = System.Linq.Enumerable.ThenBy<System.Object, System.Object>(source:  0, keySelector:  7720960);
            System.Collections.Generic.List<TSource> val_26 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_27 = BookList.BooksByCollection;
            string val_28 = 0.Item[info + 24];
            typeof(LibraryBookDisplay_AcquireBooks.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = 0;
            val_63 = 0;
            if(0.Count >= 0)
        {
                Dictionary.ValueCollection<TKey, TValue> val_30 = 0.Values;
        }
        
            typeof(LibraryBookDisplay_AcquireBooks.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = System.Linq.Enumerable.Min(source:  0);
            Dictionary.ValueCollection<TKey, TValue> val_32 = 0.Values;
            System.Func<System.Int32, System.Boolean> val_33 = new System.Func<System.Int32, System.Boolean>(object:  300425216, method:  new IntPtr(2600179632));
            int val_34 = System.Linq.Enumerable.Count<System.Int32>(source:  0, predicate:  7720960);
            if(val_34 == 0)
        {
                val_39 = info;
            if((typeof(LibraryBookDisplay_AcquireBooks.<>c__DisplayClass10_0).__il2cppRuntimeField_8) >= 1)
        {
                val_64 = 0;
        }
        
        }
        else
        {
                val_39 = info;
        }
        
        }
        
        string val_35 = val_34.ToString();
        string val_36 = 0.ToString();
        string val_37 = System.String.Format(format:  -1694782544, arg0:  info + 24, arg1:  -1694770488, arg2:  -1694770492);
        if(this.text_collection_progress != 0)
        {
                return;
        }
    
    }
    private void OnPurchaseClicked()
    {
        if(this.bookClickedAction == 0)
        {
                return;
        }
        
        this.bookClickedAction.Invoke(arg1:  this.myBookInfo, arg2:  -1694596272);
    }
    private void OnAlreadyPurchasedClicked()
    {
        if(this.bookAlreadyPurchasedClickedAction == 0)
        {
                return;
        }
        
        this.bookAlreadyPurchasedClickedAction.Invoke(arg1:  this.myBookInfo, arg2:  -1694467888);
    }
    public LibraryBookDisplay_AcquireBooks()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
