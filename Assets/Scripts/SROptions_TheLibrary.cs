using UnityEngine;
public class SROptions_TheLibrary : SuperLuckySROptionsParent<SROptions_TheLibrary>, INotifyPropertyChanged
{
    // Fields
    private int collectionIndex;
    private int bookIndex;
    
    // Properties
    private System.Collections.Generic.List<string> BookListKeys { get; }
    private System.Collections.Generic.List<BookInfo> CurrentBooks { get; }
    public string CurrentCollection { get; }
    public string CurrentBook { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    public void RefreshBooksStore()
    {
        ulong val_5;
        System.DateTime val_1 = TheLibraryLogic.LastPurchasableRefreshDate;
        int val_7 = TheLibraryLogic.PurchasableBookRefreshTimeHours;
        val_7 = 0 - val_7;
        System.DateTime val_4 = AddHours(value:  null);
        TheLibraryLogic.LastPurchasableRefreshDate = new System.DateTime() {dateData = val_5};
    }
    private System.Collections.Generic.List<string> get_BookListKeys()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_1 = BookList.BooksByCollection;
        Dictionary.KeyCollection<TKey, TValue> val_2 = 0.Keys;
        return System.Linq.Enumerable.ToList<System.Object>(source:  0);
    }
    private System.Collections.Generic.List<BookInfo> get_CurrentBooks()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_1 = BookList.BooksByCollection;
        System.Collections.Generic.List<System.String> val_2 = this.BookListKeys;
        if(0 <= this.collectionIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = 0;
        val_3 = val_3 + (this.collectionIndex << 2);
        if(0 != 0)
        {
                return 0.Item[(0 + (this.collectionIndex) << 2) + 16];
        }
        
        return 0.Item[(0 + (this.collectionIndex) << 2) + 16];
    }
    public string get_CurrentCollection()
    {
        bool val_2 = static_value_021FD5DE;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.BookListKeys;
        if(50331648 <= this.collectionIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = 0;
        val_2 = val_2 + (this.collectionIndex << 2);
    }
    public void CycleCollectionForward()
    {
        int val_1 = this.collectionIndex + 1;
        this.collectionIndex = val_1;
        System.Collections.Generic.List<System.String> val_2 = this.collectionIndex.BookListKeys;
        float val_3 = UnityEngine.Mathf.Repeat(t:  (float)val_1, length:  null);
        this.bookIndex = 0;
        this.collectionIndex = (float)val_1;
        SROptions_TheLibrary.NotifyPropertyChanged(propertyName:  -824411072);
    }
    public void CycleCollectionBackward()
    {
        int val_1 = this.collectionIndex - 1;
        this.collectionIndex = val_1;
        System.Collections.Generic.List<System.String> val_2 = this.collectionIndex.BookListKeys;
        float val_3 = UnityEngine.Mathf.Repeat(t:  (float)val_1, length:  null);
        this.bookIndex = 0;
        this.collectionIndex = (float)val_1;
        SROptions_TheLibrary.NotifyPropertyChanged(propertyName:  -824411072);
    }
    public string get_CurrentBook()
    {
        System.Collections.Generic.List<BookInfo> val_1 = this.CurrentBooks;
        if(this <= this.bookIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (this.bookIndex << 2);
        if(((0 + (this.bookIndex) << 2) + 16) != 0)
        {
                return;
        }
    
    }
    public void CycleBookForward()
    {
        int val_1 = this.bookIndex + 1;
        this.bookIndex = val_1;
        System.Collections.Generic.List<BookInfo> val_2 = this.CurrentBooks;
        float val_3 = UnityEngine.Mathf.Repeat(t:  (float)val_1, length:  null);
        this.bookIndex = (float)val_1;
        SROptions_TheLibrary.NotifyPropertyChanged(propertyName:  -824074976);
    }
    public void CycleBookBackward()
    {
        int val_1 = this.bookIndex - 1;
        this.bookIndex = val_1;
        System.Collections.Generic.List<BookInfo> val_2 = this.CurrentBooks;
        float val_3 = UnityEngine.Mathf.Repeat(t:  (float)val_1, length:  null);
        this.bookIndex = (float)val_1;
        SROptions_TheLibrary.NotifyPropertyChanged(propertyName:  -824074976);
    }
    public void GrantBook()
    {
        System.Collections.Generic.List<BookInfo> val_1 = this.CurrentBooks;
        if(this <= this.bookIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = R1 + (this.bookIndex << 2);
        TheLibraryLogic.Hack_GrantBook(bookToGive:  (R1 + (this.bookIndex) << 2) + 16);
    }
    public void BackFillBooks()
    {
        TheLibraryLogic.Hack_BackFillBooksEarned();
    }
    public SROptions_TheLibrary()
    {
    
    }

}
