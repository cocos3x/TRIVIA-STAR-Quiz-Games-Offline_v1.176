using UnityEngine;
public class BookList
{
    // Fields
    public static System.Collections.Generic.List<System.Collections.Generic.List<string>> BookOptionsSkus;
    private static bool hasLoaded;
    private static System.Collections.Generic.Dictionary<string, BookInfo> bookInfos;
    private static System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> booksByRarity;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> booksByCollection;
    private static BookInfo tempBook;
    
    // Properties
    public static System.Collections.Generic.Dictionary<string, BookInfo> BookInfos { get; }
    public static System.Collections.Generic.List<BookInfo> BookInfosList { get; }
    public static System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> BooksByRarity { get; }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> BooksByCollection { get; }
    
    // Methods
    public static System.Collections.Generic.Dictionary<string, BookInfo> get_BookInfos()
    {
        var val_1 = null;
        if(BookList.hasLoaded == false)
        {
            goto label_3;
        }
        
        val_1 = null;
        if(BookList.bookInfos != 0)
        {
            goto label_6;
        }
        
        label_3:
        BookList.Load();
        val_1 = null;
        label_6:
        val_1 = null;
    }
    public static System.Collections.Generic.List<BookInfo> get_BookInfosList()
    {
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_1 = BookList.BookInfos;
        Dictionary.ValueCollection<TKey, TValue> val_2 = Values;
        return System.Linq.Enumerable.ToList<System.Object>(source:  299413504);
    }
    public static System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> get_BooksByRarity()
    {
        System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> val_9;
        var val_10;
        System.Func<BookInfo, BookRarity> val_12;
        var val_13;
        System.Func<System.Linq.IGrouping<BookRarity, BookInfo>, System.Linq.IGrouping<BookRarity, BookInfo>> val_15;
        var val_16;
        System.Func<System.Linq.IGrouping<BookRarity, BookInfo>, BookRarity> val_18;
        System.Func<System.Linq.IGrouping<BookRarity, BookInfo>, System.Collections.Generic.List<BookInfo>> val_20;
        val_9 = null;
        val_9 = null;
        if(BookList.booksByRarity == 0)
        {
                System.Collections.Generic.List<BookInfo> val_1 = BookList.BookInfosList;
            val_10 = null;
            val_10 = null;
            val_12 = BookList.<>c.<>9__9_0;
            if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<System.Object, System.Int32Enum>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2578786368));
            BookList.<>c.<>9__9_0 = val_12;
        }
        
            System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_3 = System.Linq.Enumerable.GroupBy<System.Object, System.Int32Enum>(source:  299413504, keySelector:  7720960);
            val_13 = null;
            val_13 = null;
            val_15 = BookList.<>c.<>9__9_1;
            if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2578789440));
            BookList.<>c.<>9__9_1 = val_15;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_5 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  299413504, selector:  7720960);
            val_16 = null;
            val_16 = null;
            val_18 = BookList.<>c.<>9__9_2;
            if(val_18 == 0)
        {
                val_18 = null;
            val_18 = new System.Func<System.Object, System.Int32Enum>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2578792512));
            val_16 = null;
            BookList.<>c.<>9__9_2 = val_18;
        }
        
            val_16 = null;
            val_20 = BookList.<>c.<>9__9_3;
            if(val_20 == 0)
        {
                val_20 = null;
            val_20 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2578794560));
            BookList.<>c.<>9__9_3 = val_20;
        }
        
            System.Collections.Generic.Dictionary<TKey, TElement> val_8 = System.Linq.Enumerable.ToDictionary<System.Object, System.Int32Enum, System.Object>(source:  299413504, keySelector:  7720960, elementSelector:  7720960);
            val_9 = null;
            val_9 = null;
            BookList.booksByRarity = val_9;
        }
        
        val_9 = null;
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> get_BooksByCollection()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_3 = null;
        if(BookList.booksByCollection == 0)
        {
                System.Collections.Generic.List<BookInfo> val_1 = BookList.BookInfosList;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_2 = BookList.GroupBookInfosByCollection(booksToGroup:  299413504);
            val_3 = null;
            BookList.booksByCollection = val_3;
        }
        
        val_3 = null;
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> GroupBookInfosByCollection(System.Collections.Generic.List<BookInfo> booksToGroup)
    {
        var val_7;
        System.Func<BookInfo, System.String> val_9;
        var val_10;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Linq.IGrouping<System.String, BookInfo>> val_12;
        var val_13;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.String> val_15;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Collections.Generic.List<BookInfo>> val_17;
        val_7 = null;
        val_7 = null;
        val_9 = BookList.<>c.<>9__13_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2579025728));
            BookList.<>c.<>9__13_0 = val_9;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_2 = System.Linq.Enumerable.GroupBy<System.Object, System.Object>(source:  booksToGroup, keySelector:  7720960);
        val_10 = null;
        val_10 = null;
        val_12 = BookList.<>c.<>9__13_1;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2579028800));
            BookList.<>c.<>9__13_1 = val_12;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_4 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  booksToGroup, selector:  7720960);
        val_13 = null;
        val_13 = null;
        val_15 = BookList.<>c.<>9__13_2;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2579031872));
            val_13 = null;
            BookList.<>c.<>9__13_2 = val_15;
        }
        
        val_13 = null;
        val_17 = BookList.<>c.<>9__13_3;
        if(val_17 != 0)
        {
                return System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Object>(source:  booksToGroup, keySelector:  7720960, elementSelector:  7720960);
        }
        
        val_17 = null;
        val_17 = new System.Func<ZooTile, System.String>(object:  BookList.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2579033920));
        BookList.<>c.<>9__13_3 = val_17;
        return System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Object>(source:  booksToGroup, keySelector:  7720960, elementSelector:  7720960);
    }
    private static void Load()
    {
        var val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_10 = null;
        val_10 = null;
        BookList.bookInfos = null;
        object val_2 = UnityEngine.Resources.Load<System.Object>(path:  -1715813184);
        string val_3 = text;
        string val_4 = Replace(oldValue:  1975550000, newValue:  1098586544);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_5 = Split(separator:  478563824);
        val_11 = "LibraryBooks/Library Economy - Book List";
        val_12 = 5;
        var val_10 =  - 4;
        if( != 0)
        {
                return;
        }
    
    }
    public BookList()
    {
    
    }
    private static BookList()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  -1715586976);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                Add(item:  -1715585808);
        }
        else
        {
                Add(item:  -1715585808);
        }
        
        Add(item:  -1715585664);
        Add(item:  -1715585520);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                Add(item:  -1715585376);
        }
        else
        {
                Add(item:  -1715585376);
        }
        
        Add(item:  -1715585232);
        Add(item:  -1715585088);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                Add(item:  -1715584944);
        }
        else
        {
                Add(item:  -1715584944);
        }
        
        Add(item:  -1715584800);
        Add(item:  -1715584656);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                Add(item:  -1715584512);
        }
        else
        {
                Add(item:  -1715584512);
        }
        
        Add(item:  -1715584368);
        Add(item:  -1715584224);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                Add(item:  -1715584080);
        }
        else
        {
                Add(item:  -1715584080);
        }
        
        Add(item:  -1715583936);
        Add(item:  -1715583792);
        Add(item:  80883712);
        BookList.BookOptionsSkus = null;
        BookList.hasLoaded = false;
    }

}
