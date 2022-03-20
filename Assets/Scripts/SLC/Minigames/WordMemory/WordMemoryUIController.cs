using UnityEngine;

namespace SLC.Minigames.WordMemory
{
    public class WordMemoryUIController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject cardItemPrefab;
        private UnityEngine.Transform cardHolder;
        private UnityEngine.GameObject cardRowPrefab;
        private UnityEngine.UI.Text livesText;
        private int lives;
        private int maxLives;
        private System.Collections.Generic.List<SLC.Minigames.WordMemory.CardItem> cards;
        private System.Collections.Generic.Dictionary<int, int[]> layout;
        
        // Methods
        public void LoadLevel(int maxLives, int lives, int pairs, string[] words)
        {
            UnityEngine.Transform val_9;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32[]> val_10;
            var val_11;
            val_9 = 35631662;
            this.SetLives(lives:  lives, maxLives:  lives);
            System.Int32[] val_1 = this.layout.Item[pairs];
            val_10 = this.layout;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.cardHolder);
            this.cards.Clear();
            goto label_3;
            label_18:
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.cardRowPrefab, parent:  this.cardHolder);
            val_9 = this.cardRowPrefab;
            System.String[] val_11 = words[16];
            val_11 = 0;
            val_11 = val_11 + 0;
            val_10 = val_10;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32[]> val_3 = val_10 + 0;
            val_3 = val_3 + 16;
            goto label_6;
            label_16:
            UnityEngine.Transform val_4 = val_9.transform;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.cardItemPrefab, parent:  val_9);
            object val_6 = this.cardItemPrefab.GetComponent<System.Object>();
            this.cards.Add(item:  this.cardItemPrefab);
            this.cardItemPrefab.Init(_index:  R7, _word:  (words[0x10] + 0) + 0);
            val_10 = val_10;
            val_11 = 1;
            label_6:
            var val_7 = 0 + val_11;
            if(val_11 < val_3)
            {
                goto label_16;
            }
            
            label_3:
            if(1 < (this.layout + 12))
            {
                goto label_18;
            }
            
            System.Collections.IEnumerator val_8 = this.FaceUpOnStart();
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  937623904);
        }
        public void SetLives(int lives, int maxLives)
        {
            string val_1 = System.String.Format(format:  -1222347616, arg0:  13152256, arg1:  13152256);
            if(this.livesText != 0)
            {
                    return;
            }
        
        }
        public void HandleComplete()
        {
        
        }
        public void HandleContinue()
        {
        
        }
        private System.Collections.IEnumerator FaceUpOnStart()
        {
            object val_1 = new System.Object();
            typeof(WordMemoryUIController.<FaceUpOnStart>d__12).__il2cppRuntimeField_8 = 0;
            typeof(WordMemoryUIController.<FaceUpOnStart>d__12).__il2cppRuntimeField_10 = this;
        }
        public void FaceUpAll()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.FaceUp();
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_6;
            }
        
        }
        public void FaceDownAll()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.FaceDown();
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_6;
            }
        
        }
        public void FaceDown(int card1, int card2)
        {
            System.Collections.IEnumerator val_1 = this.DelayFaceDownPair(card1:  card1, card2:  card2);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  938514400);
        }
        public void HidePair(int card1, int card2)
        {
            System.Collections.IEnumerator val_1 = this.DelayHidePair(card1:  card1, card2:  card2);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  938626400);
        }
        private System.Collections.IEnumerator DelayHidePair(int card1, int card2)
        {
            typeof(WordMemoryUIController.<DelayHidePair>d__17).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordMemoryUIController.<DelayHidePair>d__17).__il2cppRuntimeField_10 = this;
                typeof(WordMemoryUIController.<DelayHidePair>d__17).__il2cppRuntimeField_14 = card1;
            }
            else
            {
                    mem[16] = this;
                mem[20] = card1;
            }
            
            typeof(WordMemoryUIController.<DelayHidePair>d__17).__il2cppRuntimeField_18 = card2;
        }
        private System.Collections.IEnumerator DelayFaceDownPair(int card1, int card2)
        {
            typeof(WordMemoryUIController.<DelayFaceDownPair>d__18).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordMemoryUIController.<DelayFaceDownPair>d__18).__il2cppRuntimeField_10 = this;
                typeof(WordMemoryUIController.<DelayFaceDownPair>d__18).__il2cppRuntimeField_14 = card1;
            }
            else
            {
                    mem[16] = this;
                mem[20] = card1;
            }
            
            typeof(WordMemoryUIController.<DelayFaceDownPair>d__18).__il2cppRuntimeField_18 = card2;
        }
        private void Start()
        {
        
        }
        private void Update()
        {
        
        }
        public WordMemoryUIController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.cards = null;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 3;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = 3;
            Add(key:  3, value:  478302960);
            Add(key:  4, value:  478302960);
            Add(key:  5, value:  478302960);
            Add(key:  6, value:  478302960);
            Add(key:  7, value:  478302960);
            Add(key:  8, value:  478302960);
            Add(key:  9, value:  478302960);
            Add(key:  10, value:  478302960);
            this.layout = null;
        }
    
    }

}
