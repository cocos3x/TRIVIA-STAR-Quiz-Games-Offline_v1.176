using UnityEngine;
public class TheLibraryCollectionScreen : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_back;
    private UnityEngine.UI.Button button_info;
    private UnityEngine.UI.Text text_total_score;
    private UnityEngine.UI.Text text_title;
    private ExtraProgress extra_progress_bar;
    private UnityEngine.UI.Text text_progress;
    private UnityEngine.UI.Text text_progress_complete_amount;
    private UnityEngine.GameObject obj_complete_display;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.Transform xfm_content_group;
    private LibraryBookDisplay_Collection prefab_book_display;
    private UnityEngine.Transform xfm_shelf_group;
    private UnityEngine.GameObject prefab_shelf;
    private System.Collections.Generic.List<LibraryBookDisplay_Collection> libraryBookInstances;
    private System.Collections.Generic.List<UnityEngine.GameObject> shelfInstances;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1685991408, method:  new IntPtr(2608941648));
        this.button_back.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1685991408, method:  new IntPtr(2608950864));
        this.button_info.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(string collectionName)
    {
        var val_45;
        var val_46;
        System.Func<BookInfo, System.String> val_48;
        var val_49;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Linq.IGrouping<System.String, BookInfo>> val_51;
        var val_52;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.String> val_54;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Int32> val_56;
        var val_57;
        System.Func<BookInfo, System.String> val_59;
        System.Func<System.String, System.Collections.Generic.IEnumerable<BookInfo>, BookInfo> val_61;
        var val_62;
        System.Func<BookInfo, System.Int32> val_64;
        var val_65;
        System.Func<BookInfo, System.String> val_67;
        var val_68;
        var val_70;
        var val_71;
        var val_72;
        var val_74;
        var val_75;
        var val_76;
        var val_78;
        object val_1 = new System.Object();
        UnityEngine.GameObject val_2 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  false);
        GameBehavior val_3 = App.getBehavior;
        string val_4 = collectionName.ToUpper();
        string val_5 = System.String.Format(format:  null, arg0:  collectionName);
        val_45 = null;
        val_45 = null;
        string val_6 = ToString();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_7 = TheLibraryLogic.PlayerBooksByCollection;
        string val_8 = this.text_progress_complete_amount.Item[collectionName];
        val_46 = null;
        val_46 = null;
        val_48 = TheLibraryCollectionScreen.<>c.<>9__16_0;
        if(val_48 == 0)
        {
                val_48 = null;
            val_48 = new System.Func<ZooTile, System.String>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609096656));
            TheLibraryCollectionScreen.<>c.<>9__16_0 = val_48;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_10 = System.Linq.Enumerable.GroupBy<System.Object, System.Object>(source:  this.text_progress_complete_amount, keySelector:  7720960);
        val_49 = null;
        val_49 = null;
        val_51 = TheLibraryCollectionScreen.<>c.<>9__16_1;
        if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Func<ZooTile, System.String>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609097680));
            TheLibraryCollectionScreen.<>c.<>9__16_1 = val_51;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_12 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  this.text_progress_complete_amount, selector:  7720960);
        val_52 = null;
        val_52 = null;
        val_54 = TheLibraryCollectionScreen.<>c.<>9__16_2;
        if(val_54 == 0)
        {
                val_54 = null;
            val_54 = new System.Func<ZooTile, System.String>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609098704));
            val_52 = null;
            TheLibraryCollectionScreen.<>c.<>9__16_2 = val_54;
        }
        
        val_52 = null;
        val_56 = TheLibraryCollectionScreen.<>c.<>9__16_3;
        if(val_56 == 0)
        {
                val_56 = null;
            val_56 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609099728));
            TheLibraryCollectionScreen.<>c.<>9__16_3 = val_56;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_15 = System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Int32>(source:  this.text_progress_complete_amount, keySelector:  7720960, elementSelector:  7720960);
        val_57 = null;
        val_57 = null;
        val_59 = TheLibraryCollectionScreen.<>c.<>9__16_4;
        if(val_59 == 0)
        {
                val_59 = null;
            val_59 = new System.Func<ZooTile, System.String>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609100752));
            val_57 = null;
            TheLibraryCollectionScreen.<>c.<>9__16_4 = val_59;
        }
        
        val_57 = null;
        val_61 = TheLibraryCollectionScreen.<>c.<>9__16_5;
        if(val_61 == 0)
        {
                val_61 = null;
            val_61 = new System.Func<System.String, System.Collections.Generic.IEnumerable<BookInfo>, BookInfo>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609101776));
            TheLibraryCollectionScreen.<>c.<>9__16_5 = val_61;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_18 = System.Linq.Enumerable.GroupBy<System.Object, System.Object, System.Object>(source:  this.text_progress_complete_amount, keySelector:  7720960, resultSelector:  7774208);
        val_62 = null;
        val_62 = null;
        val_64 = TheLibraryCollectionScreen.<>c.<>9__16_6;
        if(val_64 == 0)
        {
                val_64 = null;
            val_64 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609102800));
            TheLibraryCollectionScreen.<>c.<>9__16_6 = val_64;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_20 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.text_progress_complete_amount, keySelector:  7720960);
        val_65 = null;
        val_65 = null;
        val_67 = TheLibraryCollectionScreen.<>c.<>9__16_7;
        if(val_67 == 0)
        {
                val_67 = null;
            val_67 = new System.Func<ZooTile, System.String>(object:  TheLibraryCollectionScreen.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2609103824));
            TheLibraryCollectionScreen.<>c.<>9__16_7 = val_67;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_22 = System.Linq.Enumerable.ThenBy<System.Object, System.Object>(source:  this.text_progress_complete_amount, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_23 = System.Linq.Enumerable.ToList<System.Object>(source:  this.text_progress_complete_amount);
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_24 = BookList.BooksByCollection;
        string val_25 = 0.Item[collectionName];
        typeof(TheLibraryCollectionScreen.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = 0;
        val_68 = 0;
        if(this.text_progress_complete_amount.Count >= 0)
        {
                Dictionary.ValueCollection<TKey, TValue> val_27 = this.text_progress_complete_amount.Values;
        }
        
        typeof(TheLibraryCollectionScreen.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = System.Linq.Enumerable.Min(source:  this.text_progress_complete_amount);
        Dictionary.ValueCollection<TKey, TValue> val_29 = this.text_progress_complete_amount.Values;
        System.Func<System.Int32, System.Boolean> val_30 = new System.Func<System.Int32, System.Boolean>(object:  301064192, method:  new IntPtr(2609104848));
        int val_31 = System.Linq.Enumerable.Count<System.Int32>(source:  this.text_progress_complete_amount, predicate:  7720960);
        val_31 = val_31 >> 5;
        if((typeof(TheLibraryCollectionScreen.<>c__DisplayClass16_0).__il2cppRuntimeField_8) > 0)
        {
                0 = 1;
        }
        
        if((val_31 & 1) == 1)
        {
            
        }
        
        string val_33 = val_31.ToString();
        string val_34 = 0.ToString();
        string val_35 = System.String.Format(format:  1629069648, arg0:  -1685831032, arg1:  -1685831040);
        if((typeof(TheLibraryCollectionScreen.<>c__DisplayClass16_0).__il2cppRuntimeField_8) > 0)
        {
                0 = 1;
        }
        
        this.obj_complete_display.SetActive(value:  true);
        this.extra_progress_bar.target = 0f;
        this.extra_progress_bar.current = 0f;
        val_70 = null;
        val_70 = null;
        val_71 = 4;
        goto label_70;
        label_81:
        if(((TheLibraryLogic.CategoryCompleteLibraryBonus * val_28)) <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_36 = this.text_progress_complete_amount.Item[static_value_0028000F];
        val_72 = null;
        val_72 = null;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        BookEconInfo val_37 = TheLibraryLogic.BookEcon.Item[5890];
        val_71 = 5;
        label_70:
        if(1 < (TheLibraryLogic.BookEcon + 12))
        {
            goto label_81;
        }
        
        string val_38 = TheLibraryLogic.BookEcon + 12.ToString();
        if((mem[1152921511510962640] + 12) < )
        {
                var val_46 = mem[1152921511510962640] + 12;
            if(val_46 < )
        {
                do
        {
            object val_39 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921511510962628], parent:  this.xfm_content_group);
            mem[1152921511510962640].Add(item:  mem[1152921511510962628]);
            val_46 = val_46 + 1;
        }
        while(val_46 < mem[1152921511510962628]);
        
        }
        
        }
        
        float val_47 = 3f;
        val_47 = (float)mem[1152921511510962628] / val_47;
        val_74 = UnityEngine.Mathf.CeilToInt(f:  val_47);
        if(((mem[1152921511510962644] + 12) < val_74) && ((mem[1152921511510962644] + 12) < val_74))
        {
                int val_41 = val_74 - (mem[1152921511510962644] + 12);
            do
        {
            object val_42 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921511510962636], parent:  mem[1152921511510962632]);
            mem[1152921511510962644].Add(item:  mem[1152921511510962636]);
            val_41 = val_41 - 1;
        }
        while(mem[1152921511510962644] != 0);
        
        }
        
        val_75 = 0;
        goto label_101;
        label_106:
        if((mem[1152921511510962644] + 12) <= val_75)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = mem[1152921511510962644] + 8;
        val_48 = val_48 + 0;
        if(val_75 < val_74)
        {
                0 = 1;
        }
        
        (mem[1152921511510962644] + 8 + 0) + 16.SetActive(value:  true);
        val_75 = 1;
        label_101:
        if(val_75 < (mem[1152921511510962644] + 12))
        {
            goto label_106;
        }
        
        val_76 = 4;
        goto label_107;
        label_122:
        if((mem[1152921511510962640] + 12) <= val_41)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_43 = mem[1152921511510962640] + 8 + 16.gameObject;
        if(val_41 < (mem[1152921511510962640] + 8 + 16))
        {
                0 = 1;
        }
        
        mem[1152921511510962640] + 8 + 16.SetActive(value:  true);
        if(val_41 < (mem[1152921511510962640] + 8 + 16))
        {
                if((mem[1152921511510962640] + 12) <= val_41)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_74 = mem[mem[1152921511510962640] + 8 + 16];
            val_74 = mem[1152921511510962640] + 8 + 16;
            if(0 <= val_41)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_78 = mem[1152921511510962640] + 8 + 16;
            if(0 <= val_41)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_78 = 2621443;
        }
        
            val_74.Setup(info:  mem[1152921511510962640] + 8 + 16, bookCount:  this.text_progress_complete_amount.Item[static_value_0028000F]);
        }
        
        val_76 = 5;
        label_107:
        if((val_76 - 4) < (mem[1152921511510962640] + 12))
        {
            goto label_122;
        }
        
        this.Invoke(methodName:  -1688057264, time:  val_47);
    }
    private void ShowScroll()
    {
        UnityEngine.GameObject val_1 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  true);
        MonoExtensions.ScrollToTop(scrollRect:  this.scrollRect);
    }
    private void OnBackClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BackButtonPressed();
    }
    private void OnInfoClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public TheLibraryCollectionScreen()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.libraryBookInstances = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.shelfInstances = null;
    }

}
