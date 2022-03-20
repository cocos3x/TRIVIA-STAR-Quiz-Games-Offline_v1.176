using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLDataParser : MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>
    {
        // Fields
        private int totalPredefinedLevels;
        private System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.ChapterRef> chaptersReference;
        private BlockPuzzleMagic.ChapterRef tutorialChapter;
        private bool isInitialized;
        private const string PP_HasSynched = "PP_123j86_Sync";
        
        // Properties
        public int TotalPredefinedLevels { get; }
        public int TotalPredefinedChapters { get; }
        public BlockPuzzleMagic.ChapterRef TutorialChapter { get; }
        
        // Methods
        public int get_TotalPredefinedLevels()
        {
            return (int)this.totalPredefinedLevels;
        }
        public int get_TotalPredefinedChapters()
        {
            if(this.chaptersReference != 0)
            {
                    return this.chaptersReference.Count;
            }
            
            return this.chaptersReference.Count;
        }
        public BlockPuzzleMagic.ChapterRef get_TutorialChapter()
        {
        
        }
        private void Awake()
        {
            this.Initialize();
        }
        public void Initialize()
        {
            if(this.isInitialized == true)
            {
                    return;
            }
            
            this.isInitialized.LoadFromResources();
            R4.LoadDataIntoMemory();
            UnityEngine.GameObject val_1 = R4.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  R4);
            mem2[0] = 1;
        }
        private void LoadData()
        {
            this.LoadFromResources();
            this.LoadDataIntoMemory();
        }
        private void LoadFromResources()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            string val_1 = DeviceIdPlugin.GetClientVersion();
            if((UnityEngine.PlayerPrefs.HasKey(key:  1207122000)) != false)
            {
                    string val_3 = UnityEngine.PlayerPrefs.GetString(key:  1207122000, defaultValue:  System.String.alignConst);
                if((System.String.op_Inequality(a:  1207122000, b:  null)) == false)
            {
                    return;
            }
            
            }
            
            val_16 = 10332192 + 25293595;
            if(val_16 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_17 = null;
            val_17 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_5 = 1207122096 + 295313408 + 137207664;
            string val_6 = UnityEngine.Application.dataPath;
            if(val_16 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_18 = null;
            val_18 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_7 = -1655690384(-1655690384) + 295313408 + 137207664;
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(158519296)});
            UnityEngine.Object[] val_9 = UnityEngine.Resources.LoadAll(path:  -1655690384, systemTypeInstance:  158519296);
            val_19 = 0;
            UnityEngine.PlayerPrefs.SetString(key:  1207122000, value:  null);
            bool val_15 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private void LoadDataIntoMemory()
        {
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            val_8 = this;
            var val_8 = 0;
            val_9 = 0;
            string val_1 = UnityEngine.Application.persistentDataPath;
            System.String[] val_2 = System.IO.Directory.GetFiles(path:  null, searchPattern:  1207234208);
            val_10 = val_8;
            val_8 = val_8 + 16;
            val_11 = 0;
            goto label_1;
            label_14:
            string val_3 = System.IO.File.ReadAllText(path:  (0 + 16) + 0);
            BlockPuzzleMagic.ChapterRef val_4 = BlockPuzzleMagic.ChapterRef.Parse(_jsonString:  (0 + 16) + 0);
            if(((0 + 16) + 0 + 8) <= 0)
            {
                goto label_4;
            }
            
            if((this.chaptersReference.ContainsKey(key:  (0 + 16) + 0 + 8)) == false)
            {
                goto label_7;
            }
            
            this.chaptersReference.set_Item(key:  (0 + 16) + 0 + 8, value:  (0 + 16) + 0);
            goto label_8;
            label_4:
            this.tutorialChapter = (0 + 16) + 0;
            goto label_9;
            label_7:
            this.chaptersReference.Add(key:  (0 + 16) + 0 + 8, value:  (0 + 16) + 0);
            label_8:
            BlockPuzzleMagic.LevelRef val_6 = (0 + 16) + 0.LastLevel;
            val_8 = val_8;
            val_10 = val_10;
            val_11 = UnityEngine.Mathf.Max(a:  0, b:  (0 + 16) + 0 + 8);
            label_9:
            val_9 = 1;
            label_1:
            if(val_9 < 0)
            {
                goto label_14;
            }
            
            this.totalPredefinedLevels = val_11;
        }
        public BlockPuzzleMagic.ChapterRef GetPredefinedChapterDataFromLevel(int levelId)
        {
            var val_5;
            int val_10;
            var val_11;
            var val_12;
            System.Predicate<ZooTile> val_13;
            val_10 = levelId;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(BBLDataParser.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = val_10;
            }
            else
            {
                    val_11 = 8;
                mem[8] = val_10;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_19:
            if(0.MoveNext() == false)
            {
                goto label_6;
            }
            
            val_12 = val_5;
            BlockPuzzleMagic.LevelRef val_6 = val_12.FirstLevel;
            if(val_11 < (val_5 + 8))
            {
                goto label_19;
            }
            
            BlockPuzzleMagic.LevelRef val_7 = val_12.LastLevel;
            if(mem[8] > (val_5 + 8))
            {
                goto label_19;
            }
            
            val_10 = mem[val_5 + 12];
            val_10 = val_5 + 12;
            val_13 = null;
            val_13 = new System.Predicate<ZooTile>(object:  462086144, method:  new IntPtr(1207371888));
            typeof(BBLDataParser.<>c__DisplayClass16_0).__il2cppRuntimeField_C = val_13;
            object val_9 = val_10.Find(match:  8040448);
            if(val_10 == 0)
            {
                goto label_19;
            }
            
            goto label_20;
            label_6:
            val_12 = 0;
            label_20:
            0.Dispose();
        }
        public BlockPuzzleMagic.ChapterRef GetPredefinedChapterFromChapterId(int chapterId)
        {
            if((this.chaptersReference.ContainsKey(key:  chapterId)) == false)
            {
                    return;
            }
            
            BlockPuzzleMagic.ChapterRef val_2 = this.chaptersReference.Item[chapterId];
        }
        public BBLDataParser()
        {
            this.totalPredefinedLevels = 20;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.chaptersReference = null;
        }
    
    }

}
