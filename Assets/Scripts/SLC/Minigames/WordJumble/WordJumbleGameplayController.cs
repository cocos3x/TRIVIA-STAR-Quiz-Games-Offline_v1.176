using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleGameplayController : MonoSingleton<SLC.Minigames.WordJumble.WordJumbleGameplayController>
    {
        // Fields
        private UnityEngine.RectTransform wordAreaParent;
        private SLC.Minigames.WordJumble.WordJumbleWordArea wordAreaPrefab;
        private SLC.Minigames.WordJumble.WordJumbleAnswerLetter answerLetterPrefab;
        private SLC.Minigames.WordJumble.WordJumbleLetterTile letterTilePrefab;
        private System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleWordArea> wordAreas;
        
        // Properties
        public System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleWordArea> getWordAreas { get; }
        
        // Methods
        public System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleWordArea> get_getWordAreas()
        {
        
        }
        private void Start()
        {
            var val_10;
            var val_11;
            var val_12;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  923857456, method:  new IntPtr(923830384));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_10 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_10 != 0)
            {
                    if(val_10 == null)
            {
                goto label_6;
            }
            
            }
            
            val_10 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_10;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_5 = new System.Action(object:  923857456, method:  new IntPtr(923831408));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_11 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_11 != 0)
            {
                    if(val_11 == null)
            {
                goto label_10;
            }
            
            }
            
            val_11 = 0;
            label_10:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_11;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_8 = new System.Action(object:  923857456, method:  new IntPtr(923832432));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_12 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_12 != 0)
            {
                    if(val_12 == null)
            {
                goto label_14;
            }
            
            }
            
            val_12 = 0;
            label_14:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_12;
            this.StartGame();
        }
        private void StartGame()
        {
            string val_11;
            var val_18;
            UnityEngine.Transform val_1 = this.wordAreaParent.transform;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.wordAreaParent);
            this.wordAreas.Clear();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = 100;
            if((-1745297776) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UpdateUI();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.WordJumble.WordJumbleLevel val_7 = getLevel(currentLevel:  923954672);
            List.Enumerator<T> val_9 = GetEnumerator();
            label_23:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.wordAreaPrefab, parent:  this.wordAreaParent);
            this.wordAreaPrefab.Init(word:  val_11, _answerLetter:  this.answerLetterPrefab, _letterTile:  this.letterTilePrefab);
            this.wordAreas.Add(item:  this.wordAreaPrefab);
            goto label_23;
            label_18:
            Dispose();
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_16 = this.gameObject;
            object val_17 = this.GetComponent<System.Object>();
            this.Init(controller:  924003248);
        }
        private void OnRestartFromCheckpoint()
        {
            this.StartGame();
        }
        private void OnContinue()
        {
            this.StartGame();
        }
        private void OnRankUpContinue()
        {
            this.StartGame();
        }
        public void HandleFailed()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_4 = HandleLevelFailed();
                return;
            }
            
            this.StartGame();
        }
        public void HandleComplete()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelComplete();
        }
        public void HACK_InstantWin()
        {
            this.HandleComplete();
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
            {
                    return;
            }
            
            R4.Hint();
        }
        public void Hint()
        {
            var val_6;
            System.Func<SLC.Minigames.WordJumble.WordJumbleWordArea, System.Boolean> val_8;
            var val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            val_8 = WordJumbleGameplayController.<>c.<>9__16_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordJumbleGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(924908016));
                WordJumbleGameplayController.<>c.<>9__16_0 = val_8;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Where<System.Object>(source:  this.wordAreas, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  this.wordAreas);
            if(this.wordAreas != 0)
            {
                    val_9 = this.wordAreas;
                val_10 = UnityEngine.Random.Range(min:  0, max:  924911088);
            }
            else
            {
                    val_9 = 12;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_9 <= val_10)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_10 << 2);
            (0 + (val_5) << 2) + 16.Hint();
        }
        public WordJumbleGameplayController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.wordAreas = null;
        }
    
    }

}
