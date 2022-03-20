using UnityEngine;
public class TheLibraryLogic
{
    // Fields
    private const string prefs_player_books = "player_library_books";
    private const string prefs_books_buyable_refreshed_time = "lib_buy_time";
    private const string prefs_books_buyable = "lib_buy_books";
    private const string prefs_books_purchased = "lib_pur_books";
    private const string prefs_saved_econ_version = "lib_econ_ver";
    private const string prefs_skus_from_chapters = "lib_skus_per_ch";
    private const string prefs_current_unlock_target_sku = "lib_tgt_sku";
    private const string prefs_book_packs_purchased = "lib_lft_bpks";
    private const string prefs_books_from_packs_purchased = "lib_bfp";
    public const string On_Book_Granted_Notification = "OnBookGranted";
    private const int EconVersion = 1;
    public static int LibraryAccessed;
    private static System.Collections.Generic.Dictionary<BookRarity, int> debug_rolledRarities;
    private static System.Collections.Generic.Dictionary<string, int> debug_rolledBooks;
    private static BookRarity[] PurchasableRarityDispersion;
    public static int PurchasableBookRefreshTimeHours;
    public static int CategoryCompleteLibraryBonus;
    public static System.Collections.Generic.Dictionary<BookRarity, BookEconInfo> BookEcon;
    public static int BookPackGemCost;
    public static int BookPackBookCount;
    private static int _MyEconVersion;
    private static System.Collections.Generic.List<BookInfo> playerBooks;
    private static System.Collections.Generic.List<string> _SkusGrantedForCompletedBooks;
    private static string _CurrentBookUnlockTarget;
    private static BookInfo _LastGrantedBook;
    private static System.DateTime _LastPurchasableRefreshDate;
    private static int TL_Version;
    private static int _LifetimeBookPacksPurchased;
    private static int _LifetimeBooksPurchasedInPacks;
    private static System.Collections.Generic.List<BookInfo> _PurchasableBooks;
    private static System.Collections.Generic.List<BookInfo> _PurchasedBooksInPeriod;
    private static int lastBookCount;
    private static int completedCollectionCount;
    private static RandomSet randomSet;
    private static System.Collections.Generic.List<BookInfo> booksOfRarity;
    private static BookInfo rolledBook;
    private const string prefs_server_queue = "lib_svr_q";
    private static bool IsPosting;
    private static System.Collections.Generic.Queue<TheLibraryServerQueuedItem> _QueuedItems;
    
    // Properties
    private static int MyEconVersion { get; set; }
    public static System.Collections.Generic.List<BookInfo> PlayerBooks { get; }
    public static System.Collections.Generic.List<string> SkusGrantedForCompletedBooks { get; }
    public static string CurrentBookUnlockTarget { get; set; }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> PlayerBooksByCollection { get; }
    public static int LibraryScore { get; }
    public static BookInfo LastGrantedBook { get; }
    public static System.DateTime LastPurchasableRefreshDate { get; set; }
    public static int LifetimeBooksEarned { get; }
    public static int LifetimeBooksPurchased { get; }
    public static int LifetimeBookPacksPurchased { get; set; }
    public static int LifetimeBooksPurchasedInPacks { get; set; }
    public static System.Collections.Generic.List<BookInfo> PurchasableBooks { get; }
    public static System.Collections.Generic.List<BookInfo> PurchasedBooksInPeriod { get; set; }
    private static System.Collections.Generic.Queue<TheLibraryServerQueuedItem> QueuedItems { get; }
    
    // Methods
    private static int get_MyEconVersion()
    {
        var val_2 = null;
        if(TheLibraryLogic._MyEconVersion == 1)
        {
                val_2 = null;
            val_2 = null;
            TheLibraryLogic._MyEconVersion = UnityEngine.PlayerPrefs.GetInt(key:  -1706561696, defaultValue:  0);
        }
        
        val_2 = null;
        return (int)TheLibraryLogic._MyEconVersion;
    }
    private static void set_MyEconVersion(int value)
    {
        null = null;
        TheLibraryLogic._MyEconVersion = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -1706561696, value:  TheLibraryLogic._MyEconVersion);
    }
    public static System.Collections.Generic.List<BookInfo> get_PlayerBooks()
    {
        var val_3 = null;
        if(TheLibraryLogic.playerBooks == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1706337600, defaultValue:  -2040381152);
            System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.DeserializeBooksFromSkuCount(skuJson:  -1706337600);
            TheLibraryLogic.playerBooks = "player_library_books";
            TheLibraryLogic.RequestPlayerBooksFromServer();
            val_3 = null;
        }
        
        val_3 = null;
    }
    public static System.Collections.Generic.List<string> get_SkusGrantedForCompletedBooks()
    {
        var val_3 = null;
        if(TheLibraryLogic._SkusGrantedForCompletedBooks == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1706225488, defaultValue:  -2141227328);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1706225488);
            val_3 = null;
            val_3 = null;
            TheLibraryLogic._SkusGrantedForCompletedBooks = "lib_skus_per_ch";
        }
        
        val_3 = null;
    }
    public static string get_CurrentBookUnlockTarget()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        if((System.String.IsNullOrEmpty(value:  TheLibraryLogic._CurrentBookUnlockTarget)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1706113376, defaultValue:  1098586544);
            val_8 = null;
            val_8 = null;
            TheLibraryLogic._CurrentBookUnlockTarget = "lib_tgt_sku";
        }
        else
        {
                val_8 = null;
        }
        
        val_8 = null;
        if((System.String.IsNullOrEmpty(value:  -1706113376)) != false)
        {
                System.Collections.Generic.List<BookInfo> val_4 = TheLibraryLogic.GetBookChoices(currentBookIndex:  0);
            if(0 != 0)
        {
                val_9 = 0;
            val_10 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_9 = 12;
            val_10 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_9 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_7 = 0;
            val_7 = val_7 + (val_10 << 2);
            TheLibraryLogic._CurrentBookUnlockTarget = (0 + (val_6) << 2) + 16 + 8;
            UnityEngine.PlayerPrefs.SetString(key:  -1706113376, value:  TheLibraryLogic._CurrentBookUnlockTarget);
        }
        
        val_11 = null;
        val_11 = null;
    }
    public static void set_CurrentBookUnlockTarget(string value)
    {
        null = null;
        TheLibraryLogic._CurrentBookUnlockTarget = value;
        UnityEngine.PlayerPrefs.SetString(key:  -1706113376, value:  TheLibraryLogic._CurrentBookUnlockTarget);
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BookInfo>> get_PlayerBooksByCollection()
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PlayerBooks;
        return BookList.GroupBookInfosByCollection(booksToGroup:  299999232);
    }
    public static int get_LibraryScore()
    {
        var val_6;
        var val_7;
        val_6 = 0;
        val_7 = 0;
        System.Collections.Generic.List<BookInfo> val_3 = TheLibraryLogic.PlayerBooks;
        return (int)TheLibraryLogic.CountCompletedCollections();
    }
    public static BookInfo get_LastGrantedBook()
    {
        null = null;
    }
    public static System.DateTime get_LastPurchasableRefreshDate()
    {
        System.DateTime val_6;
        System.DateTime val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = null;
        val_13 = null;
        val_14 = null;
        val_14 = null;
        if(((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = TheLibraryLogic._LastPurchasableRefreshDate}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false) && ((UnityEngine.PlayerPrefs.HasKey(key:  -1705544064)) != false))
        {
                val_15 = null;
            val_15 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  -1705543968, defaultValue:  1)) < TheLibraryLogic.TL_Version)
        {
                System.DateTime val_4 = System.DateTime.UtcNow;
            val_16 = null;
            val_16 = null;
            TheLibraryLogic._LastPurchasableRefreshDate = val_6;
            UnityEngine.PlayerPrefs.SetInt(key:  -1705543968, value:  TheLibraryLogic.TL_Version);
            bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
        }
        else
        {
                string val_8 = UnityEngine.PlayerPrefs.GetString(key:  -1705544064);
            System.DateTime val_9 = System.DateTime.UtcNow;
            System.DateTime val_10 = SLCDateTime.Parse(dateTime:  -1705531920, defaultValue:  new System.DateTime() {dateData = 1152921511491237504});
            val_17 = null;
            val_17 = null;
            TheLibraryLogic._LastPurchasableRefreshDate = val_12;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        mem2[0] = TheLibraryLogic._LastPurchasableRefreshDate;
        return new System.DateTime() {dateData = TheLibraryLogic._LastPurchasableRefreshDate};
    }
    public static void set_LastPurchasableRefreshDate(System.DateTime value)
    {
        null = null;
        TheLibraryLogic._LastPurchasableRefreshDate = value.dateData;
        string val_1 = TheLibraryLogic._LastPurchasableRefreshDate.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1705544064, value:  300003384);
    }
    public static int get_LifetimeBooksEarned()
    {
        Player val_1 = App.Player;
        int val_2 = ChapterBookLogic.GetCurrentBook(playerLevel:  0);
        val_2 = val_2 - 1;
        return (int)val_2;
    }
    public static int get_LifetimeBooksPurchased()
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PlayerBooks;
        int val_2 = TheLibraryLogic.LifetimeBooksEarned;
        int val_3 = TheLibraryLogic.LifetimeBooksPurchasedInPacks;
        return (int)((TheLibraryLogic.__il2cppRuntimeField_namespaze - val_2) - val_3);
    }
    public static int get_LifetimeBookPacksPurchased()
    {
        var val_2 = null;
        if(TheLibraryLogic._LifetimeBookPacksPurchased <= 1)
        {
                val_2 = null;
            val_2 = null;
            TheLibraryLogic._LifetimeBookPacksPurchased = UnityEngine.PlayerPrefs.GetInt(key:  -1705095872, defaultValue:  0);
        }
        
        val_2 = null;
        return (int)TheLibraryLogic._LifetimeBookPacksPurchased;
    }
    public static void set_LifetimeBookPacksPurchased(int value)
    {
        null = null;
        TheLibraryLogic._LifetimeBookPacksPurchased = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -1705095872, value:  TheLibraryLogic._LifetimeBookPacksPurchased);
    }
    public static int get_LifetimeBooksPurchasedInPacks()
    {
        var val_2 = null;
        if(TheLibraryLogic._LifetimeBooksPurchasedInPacks <= 1)
        {
                val_2 = null;
            val_2 = null;
            TheLibraryLogic._LifetimeBooksPurchasedInPacks = UnityEngine.PlayerPrefs.GetInt(key:  -1704871776, defaultValue:  0);
        }
        
        val_2 = null;
        return (int)TheLibraryLogic._LifetimeBooksPurchasedInPacks;
    }
    public static void set_LifetimeBooksPurchasedInPacks(int value)
    {
        null = null;
        TheLibraryLogic._LifetimeBooksPurchasedInPacks = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -1704871776, value:  TheLibraryLogic._LifetimeBooksPurchasedInPacks);
    }
    public static System.Collections.Generic.List<BookInfo> get_PurchasableBooks()
    {
        var val_6;
        ulong val_33;
        var val_35;
        System.Collections.Generic.List<BookInfo> val_36;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        System.Predicate<BookInfo> val_45;
        System.Int32Enum val_46;
        var val_47;
        var val_48;
        BookInfo val_49;
        var val_52;
        var val_53;
        var val_54;
        System.Collections.Generic.List<BookInfo> val_55;
        val_35 = null;
        val_35 = null;
        if(TheLibraryLogic._PurchasableBooks == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1704647680, defaultValue:  -2040381152);
            System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.DeserializeBooksFromSkuCount(skuJson:  -1704647680);
            val_35 = null;
            TheLibraryLogic._PurchasableBooks = "lib_buy_books";
        }
        
        val_35 = null;
        val_36 = TheLibraryLogic._PurchasableBooks;
        if(val_36 == 0)
        {
            goto label_12;
        }
        
        val_36 = TheLibraryLogic._PurchasableBooks;
        if(val_36 == 0)
        {
            goto label_11;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.DateTime val_4 = TheLibraryLogic.LastPurchasableRefreshDate;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511492152056}, d2:  new System.DateTime());
        double val_8 = val_6.TotalSeconds;
        val_39 = null;
        val_40 = 3600;
        int val_36 = TheLibraryLogic.PurchasableBookRefreshTimeHours;
        val_36 = val_36 * val_40;
        label_12:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_41 = null;
        val_41 = null;
        val_40 = 0;
        TheLibraryLogic._PurchasableBooks = null;
        goto label_22;
        label_86:
        System.Collections.Generic.List<BookInfo> val_10 = TheLibraryLogic.PlayerBooks;
        System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> val_11 = BookList.BooksByRarity;
        val_42 = null;
        val_42 = null;
        object val_12 = 0.Item[TheLibraryLogic.PurchasableRarityDispersion + 12 + 16];
        val_43 = null;
        val_43 = null;
        val_45 = TheLibraryLogic.<>c.<>9__60_0;
        if(val_45 == 0)
        {
                val_45 = null;
            val_45 = new System.Predicate<ZooTile>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2590320736));
            TheLibraryLogic.<>c.<>9__60_0 = val_45;
        }
        
        System.Collections.Generic.List<T> val_14 = 0.FindAll(match:  8040448);
        val_47 = 0;
        if(0 < 1)
        {
            goto label_41;
        }
        
        val_48 = UnityEngine.Random.Range(min:  0, max:  0);
        goto label_74;
        label_41:
        val_49 = 0;
        goto label_62;
        label_79:
        System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> val_22 = BookList.BooksByRarity;
        val_52 = null;
        val_52 = null;
        object val_23 = 0.Item[TheLibraryLogic.PurchasableRarityDispersion + 12 + 16];
        val_47 = 0;
        System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> val_24 = BookList.BooksByRarity;
        val_46 = mem[TheLibraryLogic.PurchasableRarityDispersion + 12 + 16];
        val_46 = TheLibraryLogic.PurchasableRarityDispersion + 12 + 16;
        object val_25 = 0.Item[val_46];
        val_48 = UnityEngine.Random.Range(min:  0, max:  0);
        label_74:
        if(0 <= val_48)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_38 = val_47 + 8;
        val_38 = val_38 + (val_48 << 2);
        val_49 = mem[((val_47 + 8) + (val_26) << 2) + 16];
        val_49 = ((val_47 + 8) + (val_26) << 2) + 16;
        label_62:
        if(val_49 == 0)
        {
            goto label_79;
        }
        
        val_53 = null;
        val_53 = null;
        if((TheLibraryLogic.ListContainsBook(bookInfos:  80883712, bookToCheck:  val_49)) == true)
        {
            goto label_79;
        }
        
        val_54 = null;
        val_54 = null;
        Add(item:  val_49);
        val_41 = null;
        val_40 = 1;
        label_22:
        val_41 = null;
        if(TheLibraryLogic.PurchasableRarityDispersion == null)
        {
                val_41 = null;
        }
        
        if(val_40 < (TheLibraryLogic.PurchasableRarityDispersion + 12))
        {
            goto label_86;
        }
        
        val_41 = null;
        val_55 = TheLibraryLogic._PurchasedBooksInPeriod;
        if(val_55 != 0)
        {
                val_55 = TheLibraryLogic._PurchasedBooksInPeriod;
            if(val_55 == 0)
        {
                val_55 = 0;
        }
        
            val_55.Clear();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_30 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            TheLibraryLogic.PurchasedBooksInPeriod = 80883712;
            val_41 = null;
        }
        
        val_41 = null;
        string val_31 = TheLibraryLogic.SerializeBooksToSkuCount(booksToSerialize:  80883712);
        UnityEngine.PlayerPrefs.SetString(key:  -1704647680, value:  80883712);
        System.DateTime val_32 = DateTimeCheat.UtcNow;
        TheLibraryLogic.LastPurchasableRefreshDate = new System.DateTime() {dateData = val_33};
        bool val_35 = PrefsSerializationManager.SavePlayerPrefs();
        val_39 = null;
        val_39 = null;
        return;
        label_11:
    }
    public static System.Collections.Generic.List<BookInfo> get_PurchasedBooksInPeriod()
    {
        var val_3 = null;
        if(TheLibraryLogic._PurchasedBooksInPeriod == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1704529440, defaultValue:  -2040381152);
            System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.DeserializeBooksFromSkuCount(skuJson:  -1704529440);
            val_3 = null;
            TheLibraryLogic._PurchasedBooksInPeriod = "lib_pur_books";
        }
        
        val_3 = null;
    }
    public static void set_PurchasedBooksInPeriod(System.Collections.Generic.List<BookInfo> value)
    {
        null = null;
        TheLibraryLogic._PurchasedBooksInPeriod = value;
        string val_1 = TheLibraryLogic.SerializeBooksToSkuCount(booksToSerialize:  TheLibraryLogic._PurchasedBooksInPeriod);
        UnityEngine.PlayerPrefs.SetString(key:  -1704529440, value:  TheLibraryLogic._PurchasedBooksInPeriod);
    }
    public static void GrantTargetBook()
    {
        BookInfo val_10;
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_1 = BookList.BookInfos;
        string val_2 = TheLibraryLogic.CurrentBookUnlockTarget;
        string val_3 = 0.Item[299999232];
        TheLibraryLogic._LastGrantedBook = 0;
        System.Collections.Generic.List<System.String> val_4 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        0.Add(item:  0);
        System.Collections.Generic.List<System.String> val_5 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
        UnityEngine.PlayerPrefs.SetString(key:  -1706225488, value:  null);
        TheLibraryLogic.CurrentBookUnlockTarget = 1098586544;
        TheLibraryLogic.AddBookToPlayer(bookInfo:  0, purchased:  false);
        Player val_7 = App.Player;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_10 = TheLibraryLogic._LastGrantedBook;
        if(TheLibraryLogic._LastGrantedBook != 0)
        {
            goto label_12;
        }
        
        val_10 = TheLibraryLogic._LastGrantedBook;
        if(val_10 == 0)
        {
            goto label_13;
        }
        
        label_12:
        string val_9 = System.String.Format(format:  -1704297152, arg0:  0, arg1:  2621443);
        Add(key:  -1704297056, value:  -1704297152);
        0.TrackNonCoinReward(source:  2124997712, subSource:  -1704296960, rewardType:  null, rewardAmount:  0, additionalParams:  null);
        return;
        label_13:
    }
    public static BookInfo GrantRandomBook()
    {
        BookInfo val_1 = TheLibraryLogic.GetRandomBook();
        TheLibraryLogic._LastGrantedBook = null;
        System.Collections.Generic.List<System.String> val_2 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        Add(item:  -1673565760);
        System.Collections.Generic.List<System.String> val_3 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        string val_4 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  299999232);
        UnityEngine.PlayerPrefs.SetString(key:  -1706225488, value:  299999232);
        TheLibraryLogic.AddBookToPlayer(bookInfo:  299999232, purchased:  false);
    }
    public static bool BuyBook(BookInfo bookToBuy)
    {
        string val_10;
        var val_15;
        var val_16;
        val_15 = null;
        val_15 = null;
        BookEconInfo val_1 = TheLibraryLogic.BookEcon.Item[bookToBuy.Rarity];
        val_16 = 0;
        Player val_2 = App.Player;
        if(4 < (TheLibraryLogic.BookEcon + 16))
        {
                return (bool)val_16;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_4 = System.String.Format(format:  -1704297152, arg0:  bookToBuy.Title, arg1:  bookToBuy.Author);
        Add(key:  -1704056480, value:  -1704297152);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        string val_6 = System.String.Format(format:  -1704056384, arg0:  299200512);
        DebitBalance(debitAmount:  TheLibraryLogic.BookEcon + 16, source:  -1704056384, additionalParams:  78753792);
        TheLibraryLogic.AddBookToPlayer(bookInfo:  bookToBuy, purchased:  true);
        TheLibraryLogic.AddPurchasedBookForPeriod(bookInfo:  bookToBuy);
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  20);
        System.DateTime val_7 = TheLibraryLogic.LastPurchasableRefreshDate;
        System.DateTime val_8 = AddHours(value:  null);
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  20, when:  new System.DateTime() {dateData = 1152921511492737360}, optMessage:  val_10, extraData:  "New books are available!");
        NotificationCenter val_11 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_16 = 1;
        if(0 == 0)
        {
                return (bool)val_16;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_16 = 1;
        0.UpdateMyProfileInfo(force:  true);
        return (bool)val_16;
    }
    public static System.Collections.Generic.List<BookInfo> BuyBookPack(int packSize)
    {
        var val_10;
        int val_17;
        var val_18;
        var val_19;
        var val_20;
        BookInfo val_21;
        var val_22;
        val_17 = packSize;
        val_18 = null;
        val_18 = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Player val_2 = App.Player;
        val_19 = 0;
        if(0 < TheLibraryLogic.BookPackGemCost)
        {
                return;
        }
        
        Player val_3 = App.Player;
        string val_4 = System.String.Format(format:  -1703927776, arg0:  13152256);
        0.AddGems(amount:  0 - TheLibraryLogic.BookPackGemCost, source:  -1703927776, subsource:  null);
        RandomSet val_6 = null;
        val_19 = val_6;
        val_6 = new RandomSet();
        val_20 = null;
        val_20 = null;
        Dictionary.ValueCollection<TKey, TValue> val_7 = TheLibraryLogic.BookEcon.Values;
        val_21 = TheLibraryLogic.BookEcon;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_8 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        if(val_10 != 0)
        {
                val_22 = mem[val_10 + 8];
            val_22 = val_10 + 8;
        }
        else
        {
                val_22 = 0;
        }
        
        add(item:  0, weight:  (float)val_10 + 20);
        goto label_18;
        label_14:
        Dispose();
        if(val_19 != 0)
        {
                typeof(RandomSet).__il2cppRuntimeField_8 = 1;
        }
        else
        {
                mem[8] = 1;
        }
        
        printBuckets();
        if(val_17 >= 1)
        {
                do
        {
            int val_11 = roll(unweighted:  false);
            if(val_11 == 0)
        {
                0 = 0 + 1;
        }
        
            if(0 == 3)
        {
                use(item:  0);
        }
        
            if((val_11 & (~1)) == 2)
        {
                0 = 0 + 1;
        }
        
            if(0 == 0)
        {
                if(val_19 != 0)
        {
                use(item:  0);
        }
        else
        {
                use(item:  0);
        }
        
            use(item:  1);
        }
        
            printBuckets();
            BookInfo val_13 = TheLibraryLogic.GetRandomBookByRarity(rarity:  val_11);
            val_21 = val_11;
            TheLibraryLogic.AddBookToPlayer(bookInfo:  val_11, purchased:  true);
            TheLibraryLogic.AddPurchasedBookForPeriod(bookInfo:  val_21);
            Add(item:  val_21);
            val_17 = val_17 - 1;
        }
        while(null != 0);
        
        }
        
        int val_14 = TheLibraryLogic.LifetimeBookPacksPurchased;
        val_14 = val_14 + 1;
        TheLibraryLogic.LifetimeBookPacksPurchased = val_14;
        int val_15 = TheLibraryLogic.LifetimeBooksPurchasedInPacks;
        TheLibraryLogic.LifetimeBooksPurchasedInPacks = (System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze + val_15);
        WGBonusRewardsHandler val_16 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public static void Hack_GrantBook(BookInfo bookToGive)
    {
        TheLibraryLogic.AddBookToPlayer(bookInfo:  bookToGive, purchased:  true);
    }
    public static void Hack_BackFillBooksEarned()
    {
        var val_11;
        var val_12;
        int val_2 = (ChapterBookLogic.GetCurrentBook(playerLevel:  0)) - 1;
        System.Collections.Generic.List<System.String> val_3 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        if(val_2 >= 1)
        {
                var val_12 = 0;
            do
        {
            System.Collections.Generic.List<BookInfo> val_4 = TheLibraryLogic.GetBookChoices(currentBookIndex:  0);
            if(val_12 != 0)
        {
                val_11 = val_12;
            val_12 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_11 = 12;
            val_12 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_11 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = 0;
            val_11 = val_11 + (val_12 << 2);
            System.Collections.Generic.List<System.String> val_7 = TheLibraryLogic.SkusGrantedForCompletedBooks;
            val_11.Add(item:  (0 + (val_6) << 2) + 16 + 8);
            TheLibraryLogic.playerBooks.Add(item:  (0 + (val_6) << 2) + 16);
            val_12 = val_12 + 1;
        }
        while(val_2 != val_12);
        
        }
        
        System.Collections.Generic.List<System.String> val_8 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        string val_9 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  299999232);
        UnityEngine.PlayerPrefs.SetString(key:  -1706225488, value:  299999232);
        bool val_10 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static string LogDebug()
    {
        null = null;
        TheLibraryLogic.randomSet.printBuckets();
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  TheLibraryLogic.debug_rolledRarities, formatting:  1);
        string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  TheLibraryLogic.debug_rolledBooks, formatting:  1);
        return System.String.Format(format:  -1703579392, arg0:  TheLibraryLogic.debug_rolledRarities, arg1:  TheLibraryLogic.debug_rolledBooks);
    }
    public static int CountTimesCollectionCompleted(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.List<BookInfo>> playerCollection)
    {
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.String> val_12;
        var val_13;
        System.Func<BookInfo, System.String> val_15;
        var val_16;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Linq.IGrouping<System.String, BookInfo>> val_18;
        var val_19;
        System.Func<System.Linq.IGrouping<System.String, BookInfo>, System.Int32> val_22;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_1 = BookList.BooksByCollection;
        string val_2 = 0.Item[playerCollection.Value];
        val_12 = mem[R1 + 12];
        val_12 = R1 + 12;
        if(val_12 < 0)
        {
                return 0;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = TheLibraryLogic.<>c.<>9__72_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2591501072));
            TheLibraryLogic.<>c.<>9__72_0 = val_15;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_4 = System.Linq.Enumerable.GroupBy<System.Object, System.Object>(source:  R1, keySelector:  7720960);
        val_16 = null;
        val_16 = null;
        val_18 = TheLibraryLogic.<>c.<>9__72_1;
        if(val_18 == 0)
        {
                val_18 = null;
            val_18 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2591502096));
            TheLibraryLogic.<>c.<>9__72_1 = val_18;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  R1, selector:  7720960);
        val_19 = null;
        val_19 = null;
        val_12 = TheLibraryLogic.<>c.<>9__72_2;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2591503120));
            val_19 = null;
            TheLibraryLogic.<>c.<>9__72_2 = val_12;
        }
        
        val_19 = null;
        val_22 = TheLibraryLogic.<>c.<>9__72_3;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2591504144));
            TheLibraryLogic.<>c.<>9__72_3 = val_22;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_9 = System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Int32>(source:  R1, keySelector:  7720960, elementSelector:  7720960);
        if(R1.Count < 0)
        {
                return 0;
        }
        
        Dictionary.ValueCollection<TKey, TValue> val_11 = R1.Values;
        return System.Linq.Enumerable.Min(source:  R1);
    }
    public static bool ListContainsBook(System.Collections.Generic.List<BookInfo> bookInfos, BookInfo bookToCheck)
    {
        object val_1 = new System.Object();
        typeof(TheLibraryLogic.<>c__DisplayClass73_0).__il2cppRuntimeField_8 = bookToCheck;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  300105728, method:  new IntPtr(2591629456));
        return System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  bookInfos, predicate:  7720960);
    }
    public static void AddPurchasedBookForPeriod(BookInfo bookInfo)
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PurchasedBooksInPeriod;
        Add(item:  bookInfo);
        string val_2 = TheLibraryLogic.SerializeBooksToSkuCount(booksToSerialize:  TheLibraryLogic._PurchasedBooksInPeriod);
        UnityEngine.PlayerPrefs.SetString(key:  -1704529440, value:  TheLibraryLogic._PurchasedBooksInPeriod);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static bool BookAlreadyPurchased(BookInfo bookInfo)
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PurchasedBooksInPeriod;
        return TheLibraryLogic.ListContainsBook(bookInfos:  299999232, bookToCheck:  bookInfo);
    }
    public static void TrackSessionEnd(ref System.Collections.Generic.Dictionary<string, object> eventProperties)
    {
        null = null;
        eventProperties.Add(key:  -1702970176, value:  13152256);
        TheLibraryLogic.prefs_server_queue = 0;
    }
    public static int CountCompletedCollections()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = null;
        val_9 = null;
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PlayerBooks;
        val_10 = null;
        if(TheLibraryLogic.lastBookCount == TheLibraryLogic.PurchasableRarityDispersion)
        {
                val_11 = null;
            val_12 = 1152921504906846300;
            return (int)TheLibraryLogic.completedCollectionCount;
        }
        
        val_13 = null;
        TheLibraryLogic.completedCollectionCount = 0;
        System.Collections.Generic.List<BookInfo> val_3 = TheLibraryLogic.PlayerBooks;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_4 = BookList.GroupBookInfosByCollection(booksToGroup:  300003328);
        Dictionary.Enumerator<TKey, TValue> val_5 = 0.GetEnumerator();
        goto label_13;
        label_16:
        val_14 = null;
        val_14 = null;
        int val_6 = TheLibraryLogic.CountTimesCollectionCompleted(playerCollection:  new System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<BookInfo>>() {Value = R5});
        val_6 = val_6 + TheLibraryLogic.completedCollectionCount;
        TheLibraryLogic.completedCollectionCount = val_6;
        label_13:
        if(0.MoveNext() == true)
        {
            goto label_16;
        }
        
        0.Dispose();
        System.Collections.Generic.List<BookInfo> val_8 = TheLibraryLogic.PlayerBooks;
        val_12 = null;
        TheLibraryLogic.lastBookCount = TheLibraryLogic.__il2cppRuntimeField_namespaze;
        return (int)TheLibraryLogic.completedCollectionCount;
    }
    public static string GetProgressForCollection(string collectionName, bool showCompletedState = True)
    {
        bool val_36;
        var val_37;
        var val_38;
        var val_39;
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
        var val_66;
        var val_67;
        val_36 = showCompletedState;
        object val_1 = new System.Object();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_2 = BookList.BooksByCollection;
        string val_3 = 0.Item[collectionName];
        val_37 = 0;
        val_38 = 1152921504906846208;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_4 = TheLibraryLogic.PlayerBooksByCollection;
        if(Count < 1)
        {
            goto label_11;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_6 = TheLibraryLogic.PlayerBooksByCollection;
        if((ContainsKey(key:  collectionName)) == false)
        {
            goto label_11;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_8 = TheLibraryLogic.PlayerBooksByCollection;
        string val_9 = Item[collectionName];
        val_39 = null;
        val_40 = 1152921504906899456;
        val_41 = null;
        val_41 = null;
        val_43 = TheLibraryLogic.<>c.<>9__80_0;
        if(val_43 == 0)
        {
                val_43 = null;
            val_43 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592234464));
            val_39 = val_39;
            TheLibraryLogic.<>c.<>9__80_0 = val_43;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_11 = System.Linq.Enumerable.GroupBy<System.Object, System.Object>(source:  299999232, keySelector:  7720960);
        val_44 = null;
        val_44 = null;
        val_46 = TheLibraryLogic.<>c.<>9__80_1;
        if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592235488));
            TheLibraryLogic.<>c.<>9__80_1 = val_46;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_13 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  299999232, selector:  7720960);
        val_47 = null;
        val_47 = null;
        val_49 = TheLibraryLogic.<>c.<>9__80_2;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592236512));
            val_47 = null;
            TheLibraryLogic.<>c.<>9__80_2 = val_49;
        }
        
        val_47 = null;
        val_51 = TheLibraryLogic.<>c.<>9__80_3;
        if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592237536));
            val_37 = val_37;
            val_40 = 1152921504906899456;
            TheLibraryLogic.<>c.<>9__80_3 = val_51;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_16 = System.Linq.Enumerable.ToDictionary<System.Object, System.Object, System.Int32>(source:  299999232, keySelector:  7720960, elementSelector:  7720960);
        val_36 = val_39;
        val_52 = null;
        val_54 = TheLibraryLogic.<>c.<>9__80_4;
        if(val_54 == 0)
        {
                val_54 = null;
            val_54 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592238560));
            val_52 = null;
            TheLibraryLogic.<>c.<>9__80_4 = val_54;
        }
        
        val_52 = null;
        val_56 = TheLibraryLogic.<>c.<>9__80_5;
        if(val_56 == 0)
        {
                val_56 = null;
            val_40 = val_40;
            val_56 = new System.Func<System.String, System.Collections.Generic.IEnumerable<BookInfo>, BookInfo>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592239584));
            val_37 = val_37;
            TheLibraryLogic.<>c.<>9__80_5 = val_56;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_19 = System.Linq.Enumerable.GroupBy<System.Object, System.Object, System.Object>(source:  299999232, keySelector:  7720960, resultSelector:  7774208);
        val_57 = null;
        val_59 = TheLibraryLogic.<>c.<>9__80_6;
        if(val_59 == 0)
        {
                val_59 = null;
            val_40 = val_40;
            val_59 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592242656));
            TheLibraryLogic.<>c.<>9__80_6 = val_59;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_21 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  299999232, keySelector:  7720960);
        val_38 = val_39;
        val_60 = null;
        val_62 = TheLibraryLogic.<>c.<>9__80_7;
        if(val_62 == 0)
        {
                val_62 = null;
            val_62 = new System.Func<ZooTile, System.String>(object:  TheLibraryLogic.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2592245728));
            TheLibraryLogic.<>c.<>9__80_7 = val_62;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_23 = System.Linq.Enumerable.ThenBy<System.Object, System.Object>(source:  299999232, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_24 = System.Linq.Enumerable.ToList<System.Object>(source:  299999232);
        typeof(TheLibraryLogic.<>c__DisplayClass80_0).__il2cppRuntimeField_8 = 0;
        val_63 = 0;
        if(Count >= 0)
        {
                Dictionary.ValueCollection<TKey, TValue> val_26 = Values;
        }
        
        typeof(TheLibraryLogic.<>c__DisplayClass80_0).__il2cppRuntimeField_8 = System.Linq.Enumerable.Min(source:  299999232);
        Dictionary.ValueCollection<TKey, TValue> val_28 = Values;
        System.Func<System.Int32, System.Boolean> val_29 = new System.Func<System.Int32, System.Boolean>(object:  300158976, method:  new IntPtr(2592247776));
        int val_30 = System.Linq.Enumerable.Count<System.Int32>(source:  299999232, predicate:  7720960);
        if(val_36 == false)
        {
            goto label_62;
        }
        
        val_64 = "{0}/{1}";
        if(val_30 != 0)
        {
            goto label_63;
        }
        
        goto label_64;
        label_11:
        string val_31 = 0.ToString();
        val_66;
        string val_32 = 0.ToString();
        val_67;
        val_64 = "{0}/{1}";
        goto label_66;
        label_62:
        val_64 = "{0}/{1}";
        label_63:
        label_64:
        string val_33 = val_30.ToString();
        val_66;
        string val_34 = 0.ToString();
        val_67;
        label_66:
        string val_35 = System.String.Format(format:  1629069648, arg0:  -1702704488, arg1:  -1702704492);
    }
    public static string GetCurrentBookUnlockTarget()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((System.String.IsNullOrEmpty(value:  TheLibraryLogic._CurrentBookUnlockTarget)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1706113376, defaultValue:  1098586544);
            val_4 = null;
            val_4 = null;
            TheLibraryLogic._CurrentBookUnlockTarget = "lib_tgt_sku";
        }
        else
        {
                val_4 = null;
        }
        
        val_4 = null;
    }
    public static System.Collections.Generic.List<BookInfo> GetBookChoices(int currentBookIndex = -1)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        string val_12;
        val_7 = currentBookIndex;
        if(val_7 <= 1)
        {
                val_7 = (ChapterBookLogic.GetCurrentBook(playerLevel:  0)) - 1;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_8 = null;
        val_8 = null;
        if(val_7 >= (BookList.BookOptionsSkus + 12))
        {
            goto label_7;
        }
        
        val_9 = null;
        val_9 = null;
        if((BookList.BookOptionsSkus + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = BookList.BookOptionsSkus + 8;
        val_10 = 0;
        val_6 = val_6 + (val_7 << 2);
        val_11 = mem[(BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16];
        val_11 = (BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16;
        goto label_12;
        label_19:
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_3 = BookList.BookInfos;
        if(((BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16 + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = (BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16 + 8;
        val_7 = val_7 + 0;
        val_12 = mem[((BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16 + 8 + 0) + 16];
        val_12 = ((BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16 + 8 + 0) + 16;
        string val_4 = 0.Item[val_12];
        Add(item:  0);
        val_10 = 1;
        label_12:
        if(val_10 < ((BookList.BookOptionsSkus + 8 + ((val_1 - 1)) << 2) + 16 + 12))
        {
            goto label_19;
        }
        
        return;
        label_7:
        var val_8 = 3;
        val_12 = 1152921504906846208;
        val_11 = 1152921511492138080;
        do
        {
            BookInfo val_5 = TheLibraryLogic.GetRandomBook();
            Add(item:  299999232);
            val_8 = val_8 - 1;
        }
        while(null != 0);
    
    }
    public static void InitializePlayerData()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        if(TheLibraryLogic.playerBooks == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1706337600, defaultValue:  -2040381152);
            System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.DeserializeBooksFromSkuCount(skuJson:  -1706337600);
            TheLibraryLogic.playerBooks = "player_library_books";
            TheLibraryLogic.RequestPlayerBooksFromServer();
            val_9 = null;
        }
        
        val_9 = null;
        if((System.String.IsNullOrEmpty(value:  TheLibraryLogic._CurrentBookUnlockTarget)) != false)
        {
                string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1706113376, defaultValue:  1098586544);
            val_10 = null;
            val_10 = null;
            TheLibraryLogic._CurrentBookUnlockTarget = "lib_tgt_sku";
        }
        else
        {
                val_10 = null;
        }
        
        val_10 = null;
        if((System.String.IsNullOrEmpty(value:  -1706113376)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<BookInfo> val_6 = TheLibraryLogic.GetBookChoices(currentBookIndex:  0);
        if(0 != 0)
        {
                val_11 = 0;
            val_12 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_11 = 12;
            val_12 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_11 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = 0;
        val_9 = val_9 + (val_12 << 2);
        TheLibraryLogic._CurrentBookUnlockTarget = (0 + (val_8) << 2) + 16 + 8;
        UnityEngine.PlayerPrefs.SetString(key:  -1706113376, value:  TheLibraryLogic._CurrentBookUnlockTarget);
    }
    public static BookInfo GetRandomBook()
    {
        var val_5;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if(TheLibraryLogic.randomSet != 0)
        {
            goto label_3;
        }
        
        val_10 = null;
        val_10 = null;
        TheLibraryLogic.randomSet = new RandomSet();
        Dictionary.ValueCollection<TKey, TValue> val_2 = TheLibraryLogic.BookEcon.Values;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_11 = null;
        val_11 = null;
        if(val_5 != 0)
        {
                val_12 = mem[val_5 + 8];
            val_12 = val_5 + 8;
        }
        else
        {
                val_12 = 0;
        }
        
        add(item:  0, weight:  (float)val_5 + 20);
        goto label_14;
        label_8:
        Dispose();
        val_13 = null;
        val_13 = null;
        if(TheLibraryLogic.randomSet == 0)
        {
                val_13 = 1152921504906846300;
        }
        
        typeof(RandomSet).__il2cppRuntimeField_8 = 1;
        printBuckets();
        val_9 = null;
        label_3:
        val_9 = null;
        BookInfo val_7 = TheLibraryLogic.GetRandomBookByRarity(rarity:  roll(unweighted:  false));
    }
    private static BookInfo GetRandomBookByRarity(BookRarity rarity)
    {
        var val_5;
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<BookRarity, System.Collections.Generic.List<BookInfo>> val_1 = BookList.BooksByRarity;
        object val_2 = 0.Item[rarity];
        val_5 = null;
        val_5 = null;
        TheLibraryLogic.booksOfRarity = 0;
        if(TheLibraryLogic.booksOfRarity != 0)
        {
                val_6 = TheLibraryLogic.booksOfRarity;
            val_7 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_6 = 12;
            val_7 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_6 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (val_7 << 2);
        TheLibraryLogic.rolledBook = (0 + (val_4) << 2) + 16;
        TheLibraryLogic.DebugRoll(rolledRarityToTrack:  rarity, rolledBookToTrack:  TheLibraryLogic.rolledBook);
    }
    private static void AddBookToPlayer(BookInfo bookInfo, bool purchased)
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PlayerBooks;
        Add(item:  bookInfo);
        System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.PlayerBooks;
        string val_3 = TheLibraryLogic.SerializeBooksToSkuCount(booksToSerialize:  299999232);
        UnityEngine.PlayerPrefs.SetString(key:  -1706337600, value:  299999232);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1702028064);
        TheLibraryLogic.PostAddedBookToServer(sku:  bookInfo.SKU, purchased:  purchased);
    }
    private static void DebugRoll(BookRarity rolledRarityToTrack, BookInfo rolledBookToTrack)
    {
        var val_12;
        System.Collections.Generic.Dictionary<BookRarity, System.Int32> val_13;
        var val_14;
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_19;
        var val_20;
        var val_21;
        val_12 = null;
        val_12 = null;
        val_13 = TheLibraryLogic.debug_rolledRarities;
        if(val_13 != 0)
        {
                val_14 = val_13.Item[rolledRarityToTrack];
        }
        else
        {
                val_13 = 0;
            val_14 = 0.Item[rolledRarityToTrack];
        }
        
        val_13.set_Item(key:  rolledRarityToTrack, value:  val_14 + 1);
        if(rolledBookToTrack != 0)
        {
                val_15 = rolledBookToTrack;
            val_16 = rolledBookToTrack.Author;
        }
        else
        {
                val_15 = 16;
            val_16 = 2621443;
        }
        
        string val_4 = 2621443 + -1835139360(-1835139360) + rolledBookToTrack.Title;
        val_17 = null;
        if((TheLibraryLogic.debug_rolledBooks.ContainsKey(key:  2621443)) == false)
        {
            goto label_8;
        }
        
        val_18 = null;
        val_19 = TheLibraryLogic.debug_rolledBooks;
        string val_7 = 2621443 + -1835139360(-1835139360) + rolledBookToTrack.Title;
        if(val_19 == 0)
        {
            goto label_11;
        }
        
        val_20 = val_19.Item[2621443];
        goto label_12;
        label_8:
        val_21 = null;
        string val_9 = 2621443 + -1835139360(-1835139360) + rolledBookToTrack.Title;
        TheLibraryLogic.debug_rolledBooks.Add(key:  2621443, value:  1);
        return;
        label_11:
        val_20 = 0.Item[2621443];
        val_19 = 0;
        label_12:
        val_19.set_Item(key:  2621443, value:  val_20 + 1);
    }
    private static string SerializeBooksToSkuCount(System.Collections.Generic.List<BookInfo> booksToSerialize)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = 4;
        goto label_1;
        label_21:
        if((new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>()) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_2 = System.String.IsNullOrEmpty(value:  406886400);
        if(val_2 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = 2621443;
        if(val_2 == false)
        {
            goto label_6;
        }
        
        string val_3 = System.String.Format(format:  -1701736384, arg0:  2621443);
        val_10 = "TheLibraryLogic.SerializeBooksToSkuCount: SKU null for book:`{0}`. This book will be lost, like... tears... in rain.";
        UnityEngine.Debug.LogError(message:  -1701736384);
        goto label_19;
        label_6:
        bool val_4 = ContainsKey(key:  406886400);
        val_9 = val_4;
        if(val_4 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = 406886400;
        if(val_9 == false)
        {
            goto label_13;
        }
        
        if(0 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(null == 0)
        {
            goto label_16;
        }
        
        val_9 = Item[406886400];
        goto label_17;
        label_13:
        Add(key:  406886400, value:  1);
        goto label_19;
        label_16:
        val_9 = Item[406886400];
        label_17:
        set_Item(key:  406886400, value:  val_9 + 1);
        label_19:
        val_8 = 5;
        label_1:
        if((val_8 - 4) < null)
        {
            goto label_21;
        }
        
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792, formatting:  0);
    }
    private static System.Collections.Generic.List<BookInfo> DeserializeBooksFromSkuCount(string skuJson)
    {
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  skuJson);
        Dictionary.KeyCollection<TKey, TValue> val_3 = skuJson.Keys;
        TSource[] val_4 = System.Linq.Enumerable.ToArray<System.Object>(source:  skuJson);
        val_11 = 0;
        goto label_4;
        label_24:
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_5 = BookList.BookInfos;
        val_12 = 0;
        if((val_12.ContainsKey(key:  System.String.__il2cppRuntimeField_byval_arg)) == false)
        {
            goto label_9;
        }
        
        val_13 = 0;
        goto label_10;
        label_18:
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_7 = BookList.BookInfos;
        string val_8 = 0.Item[System.String.__il2cppRuntimeField_byval_arg];
        val_12 = 0;
        Add(item:  0);
        val_13 = 1;
        label_10:
        if(val_13 < skuJson.Item[System.String.__il2cppRuntimeField_byval_arg])
        {
            goto label_18;
        }
        
        goto label_19;
        label_9:
        string val_10 = System.String.Format(format:  -1701613840, arg0:  System.String.__il2cppRuntimeField_byval_arg);
        val_12 = "TheLibraryLogic.DeserializeBooksFromSkuCount: No known SKU matches SKU:`{0}`. This book will be lost, like... tears... in rain.";
        UnityEngine.Debug.LogError(message:  -1701613840);
        label_19:
        val_11 = 1;
        label_4:
        if(val_11 < skuJson.m_firstChar)
        {
            goto label_24;
        }
    
    }
    private static string SerializeBooksToSkuList(System.Collections.Generic.List<BookInfo> booksToSerialize)
    {
        var val_4;
        var val_5;
        val_4 = 4;
        goto label_1;
        label_12:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_2 = System.String.IsNullOrEmpty(value:  406886400);
        if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_2 != false)
        {
                string val_3 = System.String.Format(format:  -1701493312, arg0:  2621443);
            val_5 = "TheLibraryLogic.SerializeBooksToSkuList: SKU null for book:`{0}`. This book will be lost, like... tears... in rain.";
            UnityEngine.Debug.LogError(message:  -1701493312);
        }
        else
        {
                val_5 = 406886400;
            Add(item:  406886400);
        }
        
        val_4 = 5;
        label_1:
        if((val_4 - 4) < null)
        {
            goto label_12;
        }
        
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712, formatting:  0);
    }
    private static System.Collections.Generic.List<BookInfo> DeserializeBooksFromSkuList(string skuJson)
    {
        var val_8;
        UnityEngine.Material val_9;
        var val_10;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  skuJson);
        val_8 = 4;
        goto label_3;
        label_19:
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_3 = BookList.BookInfos;
        if(skuJson.m_firstChar <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = mem[skuJson.m_stringLength + 16];
        val_9 = skuJson.m_stringLength + 16;
        if((0.ContainsKey(key:  val_9)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, BookInfo> val_5 = BookList.BookInfos;
            if(skuJson.m_firstChar <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_9 = mem[skuJson.m_stringLength + 16];
            val_9 = skuJson.m_stringLength + 16;
            string val_6 = 0.Item[val_9];
            val_10 = 0;
            Add(item:  0);
        }
        else
        {
                if(skuJson.m_firstChar <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_7 = System.String.Format(format:  -1701372816, arg0:  skuJson.m_stringLength + 16);
            val_10 = "TheLibraryLogic.DeserializeBooksFromSkuList: No known SKU matches SKU:`{0}`. This book will be lost, like... tears... in rain.";
            UnityEngine.Debug.LogError(message:  -1701372816);
        }
        
        val_8 = 5;
        label_3:
        if((val_8 - 4) < skuJson.m_firstChar)
        {
            goto label_19;
        }
    
    }
    private static System.Collections.Generic.Queue<TheLibraryServerQueuedItem> get_QueuedItems()
    {
        var val_3 = null;
        if(TheLibraryLogic._QueuedItems == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1701256400, defaultValue:  -2141227328);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1701256400);
            val_3 = null;
            val_3 = null;
            TheLibraryLogic._QueuedItems = "lib_svr_q";
        }
        
        val_3 = null;
    }
    private static void EnqueuePost(TheLibraryServerQueuedItem item)
    {
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_1 = TheLibraryLogic.QueuedItems;
        Enqueue(item:  item);
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_2 = TheLibraryLogic.QueuedItems;
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  299999232);
        UnityEngine.PlayerPrefs.SetString(key:  -1701256400, value:  299999232);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private static TheLibraryServerQueuedItem DequeuePost()
    {
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_1 = TheLibraryLogic.QueuedItems;
        object val_2 = Dequeue();
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_3 = TheLibraryLogic.QueuedItems;
        string val_4 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  299999232);
        UnityEngine.PlayerPrefs.SetString(key:  -1701256400, value:  299999232);
        bool val_5 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private static void PostAddedBookToServer(string sku, bool purchased)
    {
        TheLibraryServerQueuedItem val_1 = new TheLibraryServerQueuedItem(sku:  sku, purchased:  purchased);
        TheLibraryLogic.EnqueuePost(item:  300212224);
        if(TheLibraryLogic.IsPosting == true)
        {
                return;
        }
        
        TheLibraryLogic.DoPostNextQueuedItem();
    }
    private static void PostAddedBookToServer(string[] skus, bool purchased)
    {
        object val_1 = new System.Object();
        typeof(TheLibraryServerQueuedItem).__il2cppRuntimeField_C = purchased;
        typeof(TheLibraryServerQueuedItem).__il2cppRuntimeField_8 = skus;
        TheLibraryLogic.EnqueuePost(item:  300212224);
        if(TheLibraryLogic.IsPosting == true)
        {
                return;
        }
        
        TheLibraryLogic.DoPostNextQueuedItem();
    }
    private static void DoPostToServer(string sku, bool purchased)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        TheLibraryLogic.IsPosting = true;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -1700599024, arg0:  1835037);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(purchased == true)
        {
                "completed" = "purchased";
        }
        
        if(null != 0)
        {
                Add(key:  1392732736, value:  -1700598896);
        }
        else
        {
                Add(key:  1392732736, value:  -1700598896);
        }
        
        Add(key:  -1792403808, value:  sku);
        var val_5 = 25424610;
        val_5 = 10201448 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2594368496));
        App.networkManager.DoPost(path:  -1700599024, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private static void DoPostToServer(string[] skus, bool purchased)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        TheLibraryLogic.IsPosting = true;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -1700599024, arg0:  1835037);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(purchased == true)
        {
                "completed" = "purchased";
        }
        
        if(null != 0)
        {
                Add(key:  1392732736, value:  -1700598896);
        }
        else
        {
                Add(key:  1392732736, value:  -1700598896);
        }
        
        Add(key:  -1700444816, value:  skus);
        var val_5 = 25423890;
        val_5 = 10202168 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2594368496));
        App.networkManager.DoPost(path:  -1700599024, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private static void BookAddedServerResponse(string url, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = response;
        if((val_7 != 0) && ((val_7.ContainsKey(key:  1616271776)) != false))
        {
                object val_2 = val_7.Item[1616271776];
            val_8 = val_7;
            val_9 = null;
            val_8.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                object val_3 = val_7.Item[1616271776];
            val_8 = null;
            val_7 = val_7;
            val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                TheLibraryServerQueuedItem val_4 = TheLibraryLogic.DequeuePost();
        }
        
        }
        
        }
        
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_5 = TheLibraryLogic.QueuedItems;
        val_9 = 10202880 + 25423178;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(App.networkManager.Reachable() != false)
        {
                val_9 = 10203040 + 25424385;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_11 = null;
            val_11 = null;
            if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                TheLibraryLogic.DoPostNextQueuedItem();
            return;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        TheLibraryLogic.IsPosting = false;
    }
    private static void DoPostNextQueuedItem()
    {
        var val_3;
        System.Collections.Generic.Queue<TheLibraryServerQueuedItem> val_1 = TheLibraryLogic.QueuedItems;
        object val_2 = Peek();
        val_3 = TheLibraryLogic.__il2cppRuntimeField_name;
        if(TheLibraryLogic.__il2cppRuntimeField_namespaze != 0)
        {
                TheLibraryLogic.__il2cppRuntimeField_namespaze = 1;
        }
        
        TheLibraryLogic.DoPostToServer(sku:  TheLibraryLogic.__il2cppRuntimeField_10, purchased:  true);
    }
    private static void RequestPlayerBooksFromServer()
    {
        var val_4;
        var val_4 = 25449158;
        val_4 = 10176900 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -1700054464, arg0:  1835037);
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2594912960));
        App.networkManager.DoGet(path:  -1700054464, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  0, timeout:  20);
    }
    private static void PlayerBooksRequestServerResponse(string url, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_27;
        var val_28;
        System.Collections.Generic.List<System.String> val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        if(response == 0)
        {
                return;
        }
        
        if((response.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        val_27 = 1152921510385703632;
        object val_2 = response.Item[1616271776];
        val_28 = null;
        response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(0 != 3)
        {
                return;
        }
        
        if((response.ContainsKey(key:  -1699933120)) == false)
        {
                return;
        }
        
        object val_4 = response.Item[-1699933120];
        if(response == 0)
        {
                return;
        }
        
        object val_5 = response.Item[-1699933120];
        val_29 = 0;
        if(response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                response = 0;
        }
        
            val_29 = response;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((val_29.ContainsKey(key:  -2085442816)) != false)
        {
                string val_8 = val_29.Item[-2085442816];
            string val_9 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
            object val_10 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  null);
            val_30 = null;
            val_30 = null;
            TheLibraryLogic._SkusGrantedForCompletedBooks = val_29;
            System.Collections.Generic.List<BookInfo> val_11 = TheLibraryLogic.DeserializeBooksFromSkuList(skuJson:  null);
            val_28 = val_29;
            AddRange(collection:  0);
        }
        
        if((val_29.ContainsKey(key:  -1700598896)) != false)
        {
                string val_13 = val_29.Item[-1700598896];
            string val_14 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
            System.Collections.Generic.List<BookInfo> val_15 = TheLibraryLogic.DeserializeBooksFromSkuCount(skuJson:  null);
            val_28 = val_29;
            AddRange(collection:  0);
        }
        
        val_31 = 1152921504906846208;
        val_32 = null;
        val_32 = null;
        val_33 = null;
        val_33 = null;
        TheLibraryLogic.playerBooks = null;
        val_33 = null;
        if(TheLibraryLogic.MyEconVersion != 1)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Player val_18 = App.Player;
            val_28 = 0;
            val_34 = null;
            int val_20 = (ChapterBookLogic.GetCurrentBook(playerLevel:  0)) - 1;
            val_35 = (uint)(((uint)((TheLibraryLogic.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
            if(val_20 >= 1)
        {
                do
        {
            BookInfo val_21 = TheLibraryLogic.GetRandomBook();
            Add(item:  299999232);
            val_31 = val_31;
            Add(item:  -1673565760);
            val_34 = null;
            val_20 = val_20 - 1;
            val_35 = (uint)(((uint)((TheLibraryLogic.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        }
        while(null != 0);
        
        }
        
            TheLibraryLogic.MyEconVersion = 1;
            val_27 = 1152921510385703632;
            val_29 = val_29;
            T[] val_22 = ToArray();
            TheLibraryLogic.PostAddedBookToServer(skus:  80883712, purchased:  false);
        }
        
        if((val_29.ContainsKey(key:  -1699932000)) == false)
        {
                return;
        }
        
        string val_24 = val_29.Item[-1699932000];
        if((System.String.IsNullOrEmpty(value:  null)) != false)
        {
                return;
        }
        
        string val_26 = val_29.Item[-1699932000];
        TheLibraryLogic.CurrentBookUnlockTarget = null;
    }
    public static void PostCurrentUnlockTarget(string sku)
    {
        var val_5;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -1699807616, arg0:  1835037);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1792403808, value:  sku);
        val_5 = null;
        val_5 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2594912960));
        App.networkManager.DoPost(path:  -1699807616, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    public TheLibraryLogic()
    {
    
    }
    private static TheLibraryLogic()
    {
        var val_8;
        var val_9;
        TheLibraryLogic.prefs_server_queue = 0;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                Add(key:  0, value:  0);
            Add(key:  1, value:  0);
            Add(key:  2, value:  0);
        }
        else
        {
                Add(key:  0, value:  0);
            Add(key:  1, value:  0);
            Add(key:  2, value:  0);
        }
        
        Add(key:  3, value:  0);
        TheLibraryLogic.debug_rolledRarities = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        TheLibraryLogic.debug_rolledBooks = null;
        TheLibraryLogic.PurchasableRarityDispersion = null;
        TheLibraryLogic.PurchasableBookRefreshTimeHours = 24;
        TheLibraryLogic.CategoryCompleteLibraryBonus = 500;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_3 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        BookEconInfo val_4 = new BookEconInfo(rarity:  0, libraryValue:  25, goldenAppleCost:  100, freeBookChance:  56);
        Add(key:  0, value:  299307008);
        BookEconInfo val_5 = new BookEconInfo(rarity:  1, libraryValue:  50, goldenAppleCost:  350, freeBookChance:  27);
        Add(key:  1, value:  299307008);
        BookEconInfo val_6 = new BookEconInfo(rarity:  2, libraryValue:  100, goldenAppleCost:  1500, freeBookChance:  12);
        Add(key:  2, value:  299307008);
        BookEconInfo val_7 = new BookEconInfo(rarity:  3, libraryValue:  250, goldenAppleCost:  5500, freeBookChance:  5);
        Add(key:  3, value:  299307008);
        val_8 = null;
        TheLibraryLogic.BookEcon = null;
        TheLibraryLogic.BookPackGemCost = 5;
        TheLibraryLogic.BookPackBookCount = 5;
        TheLibraryLogic._MyEconVersion = 0;
        TheLibraryLogic._LastGrantedBook = 0;
        val_9 = null;
        val_9 = null;
        val_8 = 1152921504906846300;
        TheLibraryLogic._LastPurchasableRefreshDate = System.DateTime.MinValue;
        TheLibraryLogic.prefs_server_queue.__il2cppRuntimeField_3C = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        TheLibraryLogic.TL_Version = 2;
        TheLibraryLogic._LifetimeBookPacksPurchased = 0;
        TheLibraryLogic._LifetimeBooksPurchasedInPacks = 0;
        TheLibraryLogic.lastBookCount = 0;
        TheLibraryLogic.completedCollectionCount = 0;
        TheLibraryLogic.IsPosting = 0;
    }

}
