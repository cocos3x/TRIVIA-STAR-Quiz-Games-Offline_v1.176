using UnityEngine;

namespace WordPets
{
    public class WordPetsController : MonoSingleton<WordPets.WordPetsController>
    {
        // Fields
        private WordPets.WPTGameMode chapterMode;
        private WordPets.WPTGameMode dailyChallenge;
        private WordPets.WordPetsGameMode currentMode;
        
        // Properties
        public WordPets.WPTGameMode currentGame { get; }
        
        // Methods
        public override void InitMonoSingleton()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  225526848, method:  new IntPtr(225501824));
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
        private void OnDestroy()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  225638848, method:  new IntPtr(225501824));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
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
        private void OnSceneChange(SceneType obj)
        {
            if(obj != 2)
            {
                    return;
            }
            
            WordPets.WPTGameMode val_1 = this.currentGame;
            if(this == 0)
            {
                
            }
        
        }
        public WordPets.WPTGameMode get_currentGame()
        {
            WordPets.WPTGameMode val_3;
            if(this.currentMode != 0)
            {
                    val_3 = this.dailyChallenge;
                if(val_3 != 0)
            {
                    return;
            }
            
                WordPets.WPTDailyChallenge val_1 = null;
                val_3 = val_1;
                val_1 = new WordPets.WPTDailyChallenge();
                this.dailyChallenge = val_3;
                return;
            }
            
            val_3 = this.chapterMode;
            if(val_3 != 0)
            {
                    return;
            }
            
            WordPets.WPTChapterMode val_2 = null;
            val_3 = val_2;
            val_2 = new WordPets.WPTChapterMode();
            this.chapterMode = val_3;
        }
        public void Reset()
        {
        
        }
        public void Init(WordPets.WordPetsGameMode mode)
        {
        
        }
        public void LoadGame(WordPets.WordPetsGameMode mode)
        {
            this.currentMode = mode;
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public WordPetsController()
        {
        
        }
    
    }

}
