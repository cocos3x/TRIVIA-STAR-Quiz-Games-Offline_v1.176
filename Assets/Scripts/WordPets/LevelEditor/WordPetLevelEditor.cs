using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WordPetLevelEditor : MonoSingleton<WordPets.LevelEditor.WordPetLevelEditor>
    {
        // Fields
        private UnityEngine.GameObject editModeParent;
        private UnityEngine.GameObject playModeParent;
        private bool levelEditEnabled;
        
        // Properties
        public bool isInEditMode { get; }
        public bool isInPlayMode { get; }
        
        // Methods
        public bool get_isInEditMode()
        {
            UnityEngine.GameObject val_1 = this.editModeParent.gameObject;
            if(this.editModeParent.activeSelf == false)
            {
                    return (bool)0;
            }
            
            UnityEngine.GameObject val_3 = this.playModeParent.gameObject;
            0 = this.playModeParent.activeSelf ^ 1;
            return (bool)0;
        }
        public bool get_isInPlayMode()
        {
            bool val_1 = this.isInEditMode;
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        private void Start()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  234483120, method:  new IntPtr(234458096));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        }
        private void OnSceneChange(SceneType scene)
        {
            if(scene != 2)
            {
                    return;
            }
            
            this.editModeParent.SetActive(value:  true);
            this.playModeParent.SetActive(value:  false);
        }
        public void UpdateLevelData(int level, WordPets.WPTLevelData newData)
        {
            int val_16;
            var val_17;
            var val_18;
            float val_19;
            var val_20;
            val_16 = level;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = getLevelChapterData(level:  val_16);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_6 = GetChapterForPlayerLevel(level:  val_16).ToString();
            Add(key:  -1340671904, value:  234724856);
            val_17 = 4;
            val_18 = 1152921510392296080;
            val_19 = 1152921510385703632;
            val_20 = public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance();
            var val_10 =  - 4;
            if(val_20 != 0)
            {
                    return;
            }
        
        }
        private void WriteCachedData(int chapter, System.Collections.Generic.Dictionary<string, object> modifiedChapterData)
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_2 = GetChapterFilePath(chapter:  chapter);
            string val_3 = MiniJSON.Json.Serialize(obj:  modifiedChapterData);
            System.IO.File.WriteAllText(path:  -801937664, contents:  modifiedChapterData);
            string val_4 = System.Environment.NewLine;
            string val_5 = PrettyPrint.printJSON(obj:  modifiedChapterData, types:  false, singleLineOutput:  false);
            string val_6 = 234833088 + null + modifiedChapterData;
            UnityEngine.Debug.LogError(message:  234833088);
        }
        public void DisplayChapterData()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_2 = App.Player;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = getLevelChapterData(level:  0);
            string val_4 = PrettyPrint.printJSON(obj:  -801937664, types:  false, singleLineOutput:  false);
            UnityEngine.Debug.LogError(message:  -801937664);
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_6 = App.Player;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_7 = getLevelChapterData(level:  0);
            string val_8 = PrettyPrint.printJSON(obj:  -801937664, types:  false, singleLineOutput:  false);
            WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_10 = App.Player;
            int val_11 = GetChapterForPlayerLevel(level:  0);
            string val_12 = 234949296 + 13152256;
            UnityBridge.OpenUrl(url:  234949392, text:  -801937664, title:  234949296);
        }
        public void SwitchToEditMode()
        {
            this.playModeParent.SetActive(value:  false);
            this.editModeParent.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TestLevel();
        }
        public void SwitchToPlayMode()
        {
            this.playModeParent.SetActive(value:  true);
            this.editModeParent.SetActive(value:  false);
        }
        public void QAHack_ToggleEditMode()
        {
            bool val_1 = this.levelEditEnabled;
            val_1 = val_1 ^ 1;
            this.levelEditEnabled = val_1;
        }
        public WordPetLevelEditor()
        {
        
        }
    
    }

}
