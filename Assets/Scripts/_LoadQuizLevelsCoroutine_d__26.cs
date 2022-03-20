using UnityEngine;
private sealed class ImageQuizDataManager.<LoadQuizLevelsCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.ImageQuiz.ImageQuizDataManager <>4__this;
    private SLC.Minigames.ImageQuiz.ImageQuizDataManager.<>c__DisplayClass26_0 <>8__1;
    private SLC.Minigames.ImageQuiz.ImageQuizDataManager.<>c__DisplayClass26_1 <>8__2;
    public int levelCount;
    private int <totalImageFailAttempts>5__2;
    private System.Collections.Generic.List<int> <successfulLevelIds>5__3;
    private System.Collections.Generic.List<int> <levelIdsAttempted>5__4;
    private SLC.Minigames.ImageQuiz.QuizLevelData[] <lDataArray>5__5;
    private int <i>5__6;
    private SLC.Minigames.ImageQuiz.QuizLevelData <lData>5__7;
    private int <wordIndex>5__8;
    private int <retries>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageQuizDataManager.<LoadQuizLevelsCoroutine>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SLC.Minigames.ImageQuiz.ImageQuizDataManager val_24;
        int val_25;
        int val_26;
        System.Collections.Generic.List<System.Int32> val_27;
        int val_28;
        var val_29;
        var val_30;
        string val_31;
        System.Action<System.Boolean> val_32;
        SLC.Minigames.ImageQuiz.QuizLevelData val_33;
        val_24 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_25 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
        val_26 = 0;
        this.<totalImageFailAttempts>5__2 = val_26;
        this.<>1__state = 0;
        this.<successfulLevelIds>5__3 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        this.<levelIdsAttempted>5__4 = val_2;
        val_27 = this.<successfulLevelIds>5__3;
        goto label_3;
        label_9:
        if(val_2 <= val_26)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_23 = val_23 + 0;
        this.<levelIdsAttempted>5__4.Add(item:  (0 + 0) + 16);
        val_26 = 1;
        label_3:
        if(val_26 < (this.<levelIdsAttempted>5__4))
        {
            goto label_9;
        }
        
        goto label_10;
        label_1:
        this.<>1__state = 0;
        if((this.<>8__2.CS$<>8__locals1.downloadSucceed) == false)
        {
            goto label_13;
        }
        
        this.<successfulLevelIds>5__3.Add(item:  this.<wordIndex>5__8);
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  1, height:  1);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  154206208, data:  this.<>8__2.imageRawData);
        SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_5 = val_4.GenerateLevelInfo(word:  this.<lData>5__7.word, img:  154206208);
        this.<>4__this.stageQuizLevels.Enqueue(item:  val_4);
        this.<>8__2 = 0;
        goto label_20;
        label_13:
        int val_24 = this.<retries>5__9;
        val_24 = val_24 + 1;
        this.<retries>5__9 = val_24;
        goto label_20;
        label_48:
        SLC.Minigames.ImageQuiz.QuizLevelData[] val_6 = val_24.GetUniqueLevelDatas(amountOfLevels:  1, filters:  this.<levelIdsAttempted>5__4);
        val_28 = 0;
        this.<lDataArray>5__5 = val_24;
        val_29 = val_24;
        mem[1152921514252003840] = val_28;
        goto label_22;
        label_46:
        this.<>8__1 = new System.Object();
        this.<lData>5__7 = this.<lDataArray>5__5[this.<i>5__6];
        string val_8 = this.<lDataArray>5__5[this.<i>5__6][0].word.ToLowerInvariant();
        string val_9 = 1055097744 + this.<lDataArray>5__5[this.<i>5__6][0].word(this.<lDataArray>5__5[this.<i>5__6][0].word) + 1975550080;
        this.<lDataArray>5__5[this.<i>5__6][0].imageUrl = "https://cdn.12gigs.com/mg/iq/";
        int val_10 = val_24.FindLevelIndexOfWord(word:  this.<lData>5__7.word);
        this.<wordIndex>5__8 = val_10;
        this.<levelIdsAttempted>5__4.Add(item:  val_10);
        string val_11 = SLC.Minigames.ImageQuiz.ImageQuizDataManager.LocalImageStoragePath;
        string val_12 = this.<lData>5__7.word.ToLowerInvariant();
        string val_13 = this.<levelIdsAttempted>5__4(this.<levelIdsAttempted>5__4) + 1115175264 + this.<lData>5__7.word(this.<lData>5__7.word);
        UnityEngine.Texture2D val_14 = ImageLoadingController.GetTexture2D(path:  this.<levelIdsAttempted>5__4);
        if((this.<levelIdsAttempted>5__4) == 0)
        {
            goto label_34;
        }
        
        this.<successfulLevelIds>5__3.Add(item:  this.<wordIndex>5__8);
        SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_16 = this.<successfulLevelIds>5__3.GenerateLevelInfo(word:  this.<lData>5__7.word, img:  this.<levelIdsAttempted>5__4);
        this.<>4__this.stageQuizLevels.Enqueue(item:  this.<successfulLevelIds>5__3);
        goto label_39;
        label_34:
        this.<retries>5__9 = 0;
        this.<>8__1.downloadSucceed = false;
        label_20:
        if((this.<>8__1.downloadSucceed) != true)
        {
                if((this.<retries>5__9) < 2)
        {
            goto label_43;
        }
        
        }
        
        if((this.<>8__1.downloadSucceed) == false)
        {
                this.<>8__1.downloadSucceed = this.<totalImageFailAttempts>5__2;
            this.<>8__1.downloadSucceed = (this.<>8__1.downloadSucceed) + 1;
            this.<totalImageFailAttempts>5__2 = this.<>8__1.downloadSucceed;
        }
        
        this.<lData>5__7 = 0;
        this.<>8__1 = 0;
        label_39:
        val_28 = (this.<i>5__6) + 1;
        mem2[0] = val_28;
        val_29 = mem[this.<lDataArray>5__5];
        label_22:
        if(val_28 < (mem[this.<lDataArray>5__5] + 12))
        {
            goto label_46;
        }
        
        val_27 = this.<successfulLevelIds>5__3;
        this.<lDataArray>5__5 = 0;
        label_10:
        if((mem[this.<successfulLevelIds>5__3.SyncRoot + 12]) < this.levelCount)
        {
                this.levelCount = this.<totalImageFailAttempts>5__2;
        }
        
        if(this.levelCount < 3)
        {
            goto label_48;
        }
        
        val_30 = 0;
        val_31 = 1152921510720759024;
        goto label_49;
        label_55:
        if((mem[this.<successfulLevelIds>5__3.SyncRoot + 12]) <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_26 = mem[this.<successfulLevelIds>5__3.SyncRoot + 8];
        val_26 = val_26 + 0;
        this.<>4__this.levelsLoadedButUnconsumed.Add(item:  (mem[this.<successfulLevelIds>5__3.SyncRoot + 8] + 0) + 16);
        val_30 = 1;
        label_49:
        if(val_30 < (mem[this.<successfulLevelIds>5__3.SyncRoot + 12]))
        {
            goto label_55;
        }
        
        this.<>4__this.<DataLoaderState>k__BackingField = 0;
        val_32 = this.<>4__this.OnDataLoaded;
        val_25 = 0;
        if((mem[this.<successfulLevelIds>5__3.SyncRoot + 12]) >= this.levelCount)
        {
                0 = 1;
        }
        
        val_32.Invoke(obj:  true);
        if((this.<totalImageFailAttempts>5__2) > 2)
        {
                return (bool)val_25;
        }
        
        if((this.<totalImageFailAttempts>5__2) <= 4)
        {
                this.<totalImageFailAttempts>5__2 = val_24;
            this.<totalImageFailAttempts>5__2.LoadQuizLevels();
        }
        
        return (bool)val_25;
        label_43:
        this.<>8__2 = new System.Object();
        typeof(ImageQuizDataManager.<>c__DisplayClass26_1).__il2cppRuntimeField_10 = this.<>8__1;
        this.<>8__2.onRequestComplete = false;
        this.<>8__2.imageRawData = false;
        val_33 = this.<lData>5__7;
        if((this.<lData>5__7) != 0)
        {
            goto label_65;
        }
        
        val_33 = this.<lData>5__7;
        if(val_33 == 0)
        {
            goto label_66;
        }
        
        label_65:
        val_31 = this.<lData>5__7.imageUrl;
        string val_18 = this.<lData>5__7.word.ToLowerInvariant();
        val_24 = this.<lData>5__7.word;
        string val_19 = SLC.Minigames.ImageQuiz.ImageQuizDataManager.LocalImageStoragePath;
        val_32 = this.<lData>5__7.word;
        System.Action<System.Boolean, TRVQuizProgress> val_20 = new System.Action<System.Boolean, TRVQuizProgress>(object:  this.<>8__2, method:  new IntPtr(1055192080));
        RemoteResourcesLoadingController.DownloadItem(uri:  val_31, fileName:  val_24, fileExtention:  null, localDirectory:  val_32, callback:  null);
        System.Func<System.Boolean> val_21 = new System.Func<System.Boolean>(object:  this.<>8__2, method:  new IntPtr(1055197200));
        val_25 = 1;
        this.<>1__state = val_25;
        this.<>2__current = new UnityEngine.WaitUntil(predicate:  7667712);
        return (bool)val_25;
        label_66:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
