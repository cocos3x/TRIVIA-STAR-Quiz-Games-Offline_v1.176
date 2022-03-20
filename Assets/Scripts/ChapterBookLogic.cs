using UnityEngine;
public class ChapterBookLogic : MonoSingleton<ChapterBookLogic>
{
    // Fields
    private static System.Collections.Generic.List<System.Collections.Generic.List<int>> EarlyLevelChapterBooks;
    private const int early_list_index_level = 0;
    private const int early_list_index_chapter = 1;
    private const int early_list_index_book = 2;
    public static int _ChaptersPerBook;
    public static int _LevelsPerChapter;
    
    // Methods
    public override void InitMonoSingleton()
    {
        var val_4;
        this.InitMonoSingleton();
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action val_2 = new System.Action(object:  -1710804848, method:  new IntPtr(2584137424));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_C, b:  7454720);
        val_4 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public static bool ShowBookComplete(int playerLevel = -1)
    {
        int val_3 = playerLevel;
        if(val_3 <= 0)
        {
                Player val_1 = App.Player;
            val_3 = 0;
        }
        
        int val_2 = ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0);
        val_2 = val_2 - val_3;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public static bool ShowBookIntro(int playerLevel = -1)
    {
        int val_3 = playerLevel;
        if(val_3 <= 0)
        {
                Player val_1 = App.Player;
            val_3 = 0;
        }
        
        int val_2 = ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0);
        val_2 = val_2 - (val_3 - 1);
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public static bool ShowChapterComplete(int playerLevel = -1)
    {
        int val_3 = playerLevel;
        if(val_3 <= 0)
        {
                Player val_1 = App.Player;
            val_3 = 0;
        }
        
        int val_2 = ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  0);
        val_2 = val_2 - val_3;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public static int GetCurrentBook(int playerLevel = -1)
    {
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_13;
        var val_14;
        var val_15;
        val_8 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetCurrentBook(playerLevel:  val_8);
        }
        
        if(val_8 <= 0)
        {
                Player val_2 = App.Player;
            val_8 = 0;
        }
        
        val_9 = null;
        val_9 = null;
        if(ChapterBookLogic.early_list_index_book == 0)
        {
                val_9 = null;
        }
        
        if(val_8 < (ChapterBookLogic.early_list_index_book + 12))
        {
                val_10 = null;
            if((ChapterBookLogic.early_list_index_book + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = ChapterBookLogic.early_list_index_book + 8;
            val_9 = val_9 + 0;
            if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) > 2)
        {
                return (int)(ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24;
        }
        
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (int)(ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24;
        }
        
        val_11 = null;
        val_13 = mem[ChapterBookLogic.early_list_index_book + 12];
        val_13 = ChapterBookLogic.early_list_index_book + 12;
        float val_10 = (float)(ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0)) * ChapterBookLogic._ChaptersPerBook;
        val_10 = ((float)(val_8 + 1) - val_13) / val_10;
        if(ChapterBookLogic.early_list_index_book != 0)
        {
                val_14 = mem[ChapterBookLogic.early_list_index_book + 12];
            val_14 = ChapterBookLogic.early_list_index_book + 12;
            val_15 = val_14;
        }
        else
        {
                val_13 = 12;
            val_15 = 0;
            val_14 = 0;
        }
        
        if(val_14 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = ChapterBookLogic.early_list_index_book + 8;
        val_11 = val_11 + 4294967292;
        if(((ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = (ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 8 + 24;
        val_12 = (UnityEngine.Mathf.FloorToInt(f:  val_10)) + val_12;
        val_12 = val_12 + 1;
        return (int)val_12;
    }
    public static int GetFirstLevelOfBook(int playerLevel = -1)
    {
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        val_10 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetFirstLevelOfBook(playerLevel:  val_10);
        }
        
        if(val_10 <= 0)
        {
                Player val_2 = App.Player;
            val_10 = 0;
        }
        
        val_11 = 1152921504906526720;
        val_12 = null;
        val_12 = null;
        if(ChapterBookLogic.early_list_index_book == 0)
        {
                val_12 = null;
        }
        
        if(val_10 >= (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_15;
        }
        
        val_13 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = ChapterBookLogic.early_list_index_book + 8;
        val_10 = val_10 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = 0;
        goto label_22;
        label_33:
        val_15 = null;
        val_15 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = ChapterBookLogic.early_list_index_book + 8;
        val_11 = val_11 + 0;
        val_16 = mem[(ChapterBookLogic.early_list_index_book + 8 + 0) + 16];
        val_16 = (ChapterBookLogic.early_list_index_book + 8 + 0) + 16;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24) == ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24))
        {
                return (int)val_10;
        }
        
        val_14 = 1;
        label_22:
        val_17 = null;
        val_17 = null;
        val_16 = ChapterBookLogic.early_list_index_book;
        if(val_14 < (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_33;
        }
        
        val_18 = 0;
        return (int)val_10;
        label_15:
        val_19 = null;
        float val_12 = (float)val_10 - (ChapterBookLogic.early_list_index_book + 12);
        val_12 = val_12 / ((float)(ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0)) * ChapterBookLogic._ChaptersPerBook);
        val_11 = mem[ChapterBookLogic.early_list_index_book + 12];
        val_11 = ChapterBookLogic.early_list_index_book + 12;
        val_16 = ChapterBookLogic._ChaptersPerBook;
        int val_8 = ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
        int val_9 = val_16 * (UnityEngine.Mathf.FloorToInt(f:  val_12));
        return (int)val_10;
    }
    public static int GetFirstLevelOfSecondBook()
    {
        var val_2;
        var val_3;
        int val_4;
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetFirstLevelOfSecondBook();
        }
        
        val_2 = 0;
        goto label_8;
        label_19:
        val_3 = null;
        val_3 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = ChapterBookLogic.early_list_index_book + 8;
        val_2 = val_2 + 0;
        val_4 = mem[(ChapterBookLogic.early_list_index_book + 8 + 0) + 16];
        val_4 = (ChapterBookLogic.early_list_index_book + 8 + 0) + 16;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24) == 2)
        {
                return 1;
        }
        
        val_2 = 1;
        label_8:
        val_5 = null;
        val_5 = null;
        val_4 = ChapterBookLogic.early_list_index_book;
        if(val_2 < (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_19;
        }
        
        return 1;
    }
    public static int GetCurrentChapter(int playerLevel = -1)
    {
        int val_8;
        var val_9;
        val_8 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetCurrentChapter(playerLevel:  val_8);
        }
        
        if(val_8 <= 0)
        {
                Player val_2 = App.Player;
            val_8 = 0;
        }
        
        val_9 = null;
        val_9 = null;
        if(ChapterBookLogic.early_list_index_book == 0)
        {
                val_9 = null;
        }
        
        if(val_8 < (ChapterBookLogic.early_list_index_book + 12))
        {
                val_9 = null;
            if((ChapterBookLogic.early_list_index_book + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_8 = ChapterBookLogic.early_list_index_book + 8;
            val_8 = val_8 + 0;
            if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) > 1)
        {
                return (int)(ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 20;
        }
        
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (int)(ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 20;
        }
        
        float val_9 = (float)ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
        val_9 = ((float)val_8 - (ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0))) / val_9;
        int val_7 = UnityEngine.Mathf.FloorToInt(f:  val_9);
        val_7 = val_7 + 1;
        return (int)val_7;
    }
    public static int GetCurrentCumulativeChapter(int playerLevel = -1)
    {
        int val_11;
        var val_12;
        var val_13;
        val_11 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetCurrentCumulativeChapter(playerLevel:  val_11);
        }
        
        if(val_11 <= 0)
        {
                Player val_2 = App.Player;
            val_11 = 0;
        }
        
        val_12 = null;
        int val_4 = (ChapterBookLogic.GetCurrentBook(playerLevel:  0)) - 1;
        val_13 = 0;
        if(val_4 >= 1)
        {
                var val_9 = 1;
            do
        {
            val_12 = null;
            val_13 = (ChapterBookLogic.GetChaptersFromBook(bookNum:  1)) + val_13;
            val_9 = val_9 + 1;
        }
        while(val_9 <= val_4);
        
        }
        
        int val_8 = ChapterBookLogic.GetCurrentChapter(playerLevel:  0);
        val_8 = val_8 + val_13;
        return (int)val_8;
    }
    public static int GetFirstLevelOfChapter(int playerLevel = -1)
    {
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        val_8 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetFirstLevelOfChapter(playerLevel:  val_8);
        }
        
        if(val_8 <= 0)
        {
                Player val_2 = App.Player;
            val_8 = 0;
        }
        
        val_9 = null;
        val_9 = null;
        if(ChapterBookLogic.early_list_index_book == 0)
        {
                val_9 = null;
        }
        
        if(val_8 >= (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_15;
        }
        
        val_9 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = ChapterBookLogic.early_list_index_book + 8;
        val_8 = val_8 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = ChapterBookLogic.early_list_index_book + 8;
        val_9 = val_9 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = 4;
        goto label_26;
        label_44:
        val_11 = null;
        val_11 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 8 + 24) == ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24))
        {
                val_12 = null;
            val_12 = null;
            if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = mem[ChapterBookLogic.early_list_index_book + 8 + 16];
            val_13 = ChapterBookLogic.early_list_index_book + 8 + 16;
            if((ChapterBookLogic.early_list_index_book + 8 + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((ChapterBookLogic.early_list_index_book + 8 + 16 + 8 + 20) == ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 20))
        {
                return (int)val_8;
        }
        
        }
        
        val_10 = 5;
        label_26:
        val_14 = null;
        val_14 = null;
        val_13 = ChapterBookLogic.early_list_index_book;
        if((val_10 - 4) < (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_44;
        }
        
        val_15 = 0;
        return (int)val_8;
        label_15:
        val_13 = (ChapterBookLogic.GetCurrentChapter(playerLevel:  0)) - 1;
        int val_6 = ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0);
        int val_7 = ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
        return (int)val_8;
    }
    public static int GetLastLevelOfChapter(int playerLevel = -1)
    {
        int val_5 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetLastLevelOfChapter(playerLevel:  val_5 = playerLevel);
        }
        
        if(val_5 <= 0)
        {
                Player val_2 = App.Player;
            val_5 = 0;
        }
        
        int val_4 = ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
        val_4 = (ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  0)) + val_4;
        val_4 = val_4 - 1;
        return (int)val_4;
    }
    public static int GetLevelWithinChapter(int playerLevel = -1)
    {
        int val_4 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetLevelWithinChapter(playerLevel:  val_4 = playerLevel);
        }
        
        if(val_4 <= 0)
        {
                Player val_2 = App.Player;
            val_4 = 0;
        }
        
        int val_3 = ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  0);
        val_3 = (val_4 + 1) - val_3;
        return (int)val_3;
    }
    public static int GetChaptersPerBook(int playerLevel = -1)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_4 = playerLevel;
        val_5 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        val_6 = 4;
        if(0 != 0)
        {
                return (int)val_15;
        }
        
        if(val_4 <= 0)
        {
                Player val_2 = App.Player;
            val_4 = 0;
        }
        
        val_7 = null;
        val_7 = null;
        if(ChapterBookLogic.early_list_index_book == 0)
        {
                val_7 = null;
        }
        
        if(val_4 >= (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_13;
        }
        
        val_8 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = ChapterBookLogic.early_list_index_book + 8;
        val_5 = val_5 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = 0;
        val_10 = 4;
        val_5 = mem[(ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24];
        val_5 = (ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24;
        label_36:
        val_11 = null;
        val_11 = null;
        var val_4 = val_10 - 4;
        if(val_4 >= (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_23;
        }
        
        val_12 = null;
        val_12 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = null;
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 8 + 24) == val_5)
        {
                val_9 = val_4;
        }
        
        val_13 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 1;
        if((ChapterBookLogic.early_list_index_book + 8 + 16 + 8 + 24) <= val_5)
        {
            goto label_36;
        }
        
        label_23:
        val_14 = null;
        val_14 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = ChapterBookLogic.early_list_index_book + 8;
        val_6 = val_6 + (val_9 << 2);
        if(((ChapterBookLogic.early_list_index_book + 8 + ((val_10 - 4)) << 2) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = ((ChapterBookLogic.early_list_index_book + 8 + ((val_10 - 4)) << 2) + 16 + 8) + 20;
        return (int)val_15;
        label_13:
        val_16 = null;
        val_15 = 1152921504906530820;
        return (int)val_15;
    }
    public static int GetChaptersFromBook(int bookNum)
    {
        var val_8;
        var val_9;
        System.Predicate<ZooTile> val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        object val_1 = new System.Object();
        typeof(ChapterBookLogic.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = bookNum;
        GameBehavior val_2 = App.getBehavior;
        val_8 = 4;
        if(0 != 0)
        {
                return (int)val_13;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = new System.Predicate<ZooTile>(object:  299732992, method:  new IntPtr(2585594448));
        val_11 = null;
        if((ChapterBookLogic.early_list_index_book.Exists(match:  8040448)) != false)
        {
                val_12 = null;
            val_10 = null;
            val_10 = new System.Predicate<ZooTile>(object:  299732992, method:  new IntPtr(2585597520));
            int val_7 = ChapterBookLogic.early_list_index_book.FindLastIndex(match:  8040448);
            if((ChapterBookLogic.early_list_index_book + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_8 = ChapterBookLogic.early_list_index_book + 8;
            val_8 = val_8 + (val_7 << 2);
            if(((ChapterBookLogic.early_list_index_book + 8 + (val_7) << 2) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = ((ChapterBookLogic.early_list_index_book + 8 + (val_7) << 2) + 16 + 8) + 20;
            return (int)val_13;
        }
        
        val_14 = null;
        val_13 = 1152921504906530820;
        return (int)val_13;
    }
    public static int GetLevelsPerChapter(int playerLevel = -1)
    {
        int val_7;
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_7 = playerLevel;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return WordLevelGen.GetLevelsPerChapter(playerLevel:  val_7);
        }
        
        if(val_7 <= 0)
        {
                Player val_2 = App.Player;
            val_7 = 0;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = ChapterBookLogic.early_list_index_book;
        if(val_9 == 0)
        {
                val_8 = null;
        }
        
        if(val_7 >= (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_15;
        }
        
        val_10 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = ChapterBookLogic.early_list_index_book + 8;
        val_6 = val_6 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = ChapterBookLogic.early_list_index_book + 8;
        val_7 = val_7 + 0;
        if(((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = (ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0)) + 4;
        val_12 = 0;
        goto label_26;
        label_59:
        val_13 = null;
        val_13 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 8 + 24) != ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24))
        {
            goto label_40;
        }
        
        val_14 = null;
        val_14 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 8 + 20) != ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 20))
        {
            goto label_40;
        }
        
        val_12 = 1;
        goto label_41;
        label_40:
        val_15 = null;
        val_15 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = mem[ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2];
        val_9 = ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2;
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 8 + 24) > ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 24))
        {
                return val_12;
        }
        
        val_16 = null;
        val_16 = null;
        if((ChapterBookLogic.early_list_index_book + 12) <= ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = mem[ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2];
        val_9 = ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2;
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((ChapterBookLogic.early_list_index_book + 8 + ((val_4 + 4)) << 2 + 8 + 20) > ((ChapterBookLogic.early_list_index_book + 8 + 0) + 16 + 8 + 20))
        {
                return val_12;
        }
        
        label_41:
        val_11 = val_11 + 1;
        label_26:
        val_17 = null;
        val_17 = null;
        val_9 = ChapterBookLogic.early_list_index_book;
        if((val_11 - 4) < (ChapterBookLogic.early_list_index_book + 12))
        {
            goto label_59;
        }
        
        return val_12;
        label_15:
        val_18 = null;
        val_12 = ChapterBookLogic._LevelsPerChapter;
        return val_12;
    }
    public static int GetLevelsPerChapter(int book, int chapter)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_7 = val_1;
            typeof(ChapterBookLogic.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = book;
        }
        else
        {
                val_7 = 8;
            mem[8] = book;
        }
        
        typeof(ChapterBookLogic.<>c__DisplayClass21_0).__il2cppRuntimeField_C = chapter;
        GameBehavior val_2 = App.getBehavior;
        if(mem[8] != 0)
        {
                return WordLevelGen.GetLevelsForChapter(chapter:  ((chapter + (book) << 2)) - 4);
        }
        
        val_8 = null;
        val_8 = null;
        if(ChapterBookLogic.early_list_index_book != 0)
        {
                val_9 = mem[ChapterBookLogic.early_list_index_book + 12];
            val_9 = ChapterBookLogic.early_list_index_book + 12;
            val_10 = val_9;
        }
        else
        {
                val_10 = 0;
            val_9 = 0;
        }
        
        if(val_9 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = ChapterBookLogic.early_list_index_book + 8;
        val_7 = val_7 + 4294967292;
        if(((ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = null;
        if(((ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 8 + 24) < mem[8])
        {
                val_12 = null;
            return (int)ChapterBookLogic._LevelsPerChapter;
        }
        
        val_13 = null;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  299786240, method:  new IntPtr(2585823568));
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  ChapterBookLogic.early_list_index_book, predicate:  7720960);
    }
    public static int GetCumulativeLevelFromBookAndChapter(int book, int chapter, int levelInChapterIndex)
    {
        int val_13;
        var val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        int val_22;
        var val_23;
        var val_24;
        val_13 = book;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_14 = val_1;
            typeof(ChapterBookLogic.<>c__DisplayClass22_0).__il2cppRuntimeField_8 = val_13;
        }
        else
        {
                val_14 = 8;
            mem[8] = val_13;
        }
        
        typeof(ChapterBookLogic.<>c__DisplayClass22_0).__il2cppRuntimeField_C = chapter;
        GameBehavior val_2 = App.getBehavior;
        val_15 = mem[8];
        if(val_15 != 0)
        {
                int val_5 = WordLevelGen.GetLevelsThroughChapter(chapter:  ((chapter + (book) << 2)) - 5);
            val_5 = levelInChapterIndex + val_5;
            val_16 = val_5 + 1;
            return (int)val_16;
        }
        
        val_17 = null;
        val_17 = null;
        if(ChapterBookLogic.early_list_index_book != 0)
        {
                val_18 = mem[ChapterBookLogic.early_list_index_book + 12];
            val_18 = ChapterBookLogic.early_list_index_book + 12;
            val_19 = val_18;
        }
        else
        {
                val_19 = 0;
            val_18 = 0;
        }
        
        if(val_18 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = ChapterBookLogic.early_list_index_book + 8;
        val_12 = val_12 + 4294967292;
        if(((ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = null;
        if(((ChapterBookLogic.early_list_index_book + 8 + 4294967292) + 16 + 8 + 24) >= mem[8])
        {
            goto label_18;
        }
        
        val_21 = null;
        val_22 = ChapterBookLogic.early_list_index_book;
        if(val_22 == 0)
        {
            goto label_21;
        }
        
        val_23 = mem[ChapterBookLogic.early_list_index_book + 12];
        val_23 = ChapterBookLogic.early_list_index_book + 12;
        goto label_22;
        label_18:
        val_24 = null;
        val_15 = ChapterBookLogic.early_list_index_book;
        val_13 = null;
        val_13 = new System.Predicate<ZooTile>(object:  299839488, method:  new IntPtr(2585938640));
        val_16 = (val_15.FindIndex(match:  8040448)) + levelInChapterIndex;
        return (int)val_16;
        label_21:
        val_23 = mem[ChapterBookLogic.early_list_index_book + 12];
        val_23 = ChapterBookLogic.early_list_index_book + 12;
        val_22 = ChapterBookLogic.early_list_index_book;
        if(val_22 == 0)
        {
            goto label_45;
        }
        
        label_22:
        label_45:
        val_13 = (ChapterBookLogic.early_list_index_book + 12) - 1;
        if((ChapterBookLogic.early_list_index_book + 12) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_13 = ChapterBookLogic.early_list_index_book + 8;
        val_13 = val_13 + (val_13 << 2);
        if(((ChapterBookLogic.early_list_index_book + 8 + ((ChapterBookLogic.early_list_index_book + 12 - 1)) << 2) + 16 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_14 = (ChapterBookLogic.early_list_index_book + 8 + ((ChapterBookLogic.early_list_index_book + 12 - 1)) << 2) + 16 + 8 + 24;
        goto label_31;
        label_39:
        val_13 = 0;
        goto label_32;
        label_37:
        val_23 = (ChapterBookLogic.GetLevelsPerChapter(book:  val_14, chapter:  0)) + val_23;
        val_13 = 1;
        label_32:
        if(val_13 < (ChapterBookLogic.GetChaptersFromBook(bookNum:  val_14)))
        {
            goto label_37;
        }
        
        label_31:
        val_14 = val_14 + 1;
        if(val_14 < mem[8])
        {
            goto label_39;
        }
        
        val_15 = 0;
        goto label_40;
        label_44:
        val_13 = mem[8];
        val_23 = (ChapterBookLogic.GetLevelsPerChapter(book:  val_13, chapter:  0)) + val_23;
        val_15 = 1;
        label_40:
        if(val_15 < ((chapter - 1)))
        {
            goto label_44;
        }
        
        val_16 = val_23 + levelInChapterIndex;
        return (int)val_16;
    }
    private void HandleLevelCompleted()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        if((ChapterBookLogic.ShowBookComplete(playerLevel:  0)) == false)
        {
                return;
        }
        
        TheLibraryLogic.GrantTargetBook();
    }
    public ChapterBookLogic()
    {
    
    }
    private static ChapterBookLogic()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  0);
            Add(item:  0);
        }
        else
        {
                Add(item:  0);
            Add(item:  0);
        }
        
        Add(item:  0);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  1);
            Add(item:  1);
        }
        else
        {
                Add(item:  1);
            Add(item:  1);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  1);
        }
        else
        {
                Add(item:  2);
            Add(item:  1);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  3);
            Add(item:  1);
        }
        else
        {
                Add(item:  3);
            Add(item:  1);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  4);
            Add(item:  1);
        }
        else
        {
                Add(item:  4);
            Add(item:  1);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  5);
            Add(item:  1);
        }
        else
        {
                Add(item:  5);
            Add(item:  1);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  6);
            Add(item:  2);
        }
        else
        {
                Add(item:  6);
            Add(item:  2);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  7);
            Add(item:  2);
        }
        else
        {
                Add(item:  7);
            Add(item:  2);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  8);
            Add(item:  2);
        }
        else
        {
                Add(item:  8);
            Add(item:  2);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  9);
            Add(item:  2);
        }
        else
        {
                Add(item:  9);
            Add(item:  2);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  10);
            Add(item:  2);
        }
        else
        {
                Add(item:  10);
            Add(item:  2);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  11);
            Add(item:  3);
        }
        else
        {
                Add(item:  11);
            Add(item:  3);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  12);
            Add(item:  3);
        }
        else
        {
                Add(item:  12);
            Add(item:  3);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  13);
            Add(item:  3);
        }
        else
        {
                Add(item:  13);
            Add(item:  3);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  14);
            Add(item:  3);
        }
        else
        {
                Add(item:  14);
            Add(item:  3);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  15);
            Add(item:  3);
        }
        else
        {
                Add(item:  15);
            Add(item:  3);
        }
        
        Add(item:  1);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  16);
            Add(item:  1);
        }
        else
        {
                Add(item:  16);
            Add(item:  1);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  17);
            Add(item:  1);
        }
        else
        {
                Add(item:  17);
            Add(item:  1);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  18);
            Add(item:  1);
        }
        else
        {
                Add(item:  18);
            Add(item:  1);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  19);
            Add(item:  1);
        }
        else
        {
                Add(item:  19);
            Add(item:  1);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  20);
            Add(item:  1);
        }
        else
        {
                Add(item:  20);
            Add(item:  1);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  21);
            Add(item:  2);
        }
        else
        {
                Add(item:  21);
            Add(item:  2);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  22);
            Add(item:  2);
        }
        else
        {
                Add(item:  22);
            Add(item:  2);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  23);
            Add(item:  2);
        }
        else
        {
                Add(item:  23);
            Add(item:  2);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  24);
            Add(item:  2);
        }
        else
        {
                Add(item:  24);
            Add(item:  2);
        }
        
        Add(item:  2);
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  25);
            Add(item:  2);
        }
    
    }

}
