using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesUIController : MonoSingleton<SLC.Minigames.Bubbles.WordBubblesUIController>
    {
        // Fields
        private UnityEngine.GameObject container;
        private UnityEngine.GameObject ChosenWordContent;
        private SLC.Minigames.Bubbles.WordBubblesBubble[] chosenBubbleElements;
        private UnityEngine.UI.Text levelTitle;
        private UnityEngine.GameObject hand;
        private UnityEngine.GameObject checkMark;
        private UnityEngine.GameObject BubbleElementsContent;
        private UnityEngine.Transform[] BubbleElementsPos;
        private UnityEngine.GameObject BubbleElementPrefab;
        private SLC.Minigames.Bubbles.WordBubblesBubble[] BubbleElements;
        private UnityEngine.UI.Slider TimerSlider;
        private UnityEngine.UI.Image[] Lives;
        private UnityEngine.Color[] ElementColors;
        private System.Collections.Generic.List<SLC.Minigames.Bubbles.WordBubblesBubble> chosenBubbleQueue;
        private bool initialized;
        
        // Methods
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            this.Initialize();
        }
        private void Initialize()
        {
            var val_4;
            if(this.initialized == true)
            {
                    return;
            }
            
            this.BubbleElements = null;
            val_4 = 4;
            goto label_3;
            label_15:
            UnityEngine.GameObject val_1 = this.BubbleElementPrefab.gameObject;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.BubbleElementPrefab, parent:  this.BubbleElementsPos[0]);
            object val_3 = this.BubbleElementPrefab.GetComponent<System.Object>();
            this.BubbleElements[0] = this.BubbleElementPrefab;
            val_4 = 5;
            label_3:
            if((val_4 - 4) < this.BubbleElementPrefab)
            {
                goto label_15;
            }
            
            this.hand.SetActive(value:  true);
            this.initialized = true;
        }
        public void StartLevel(SLC.Minigames.Bubbles.WordBubblesLevel currentLevel)
        {
            SLC.Minigames.Bubbles.WordBubblesLevel val_8;
            int val_9;
            val_8 = currentLevel;
            if(this.initialized == false)
            {
                    this.initialized = this;
                this.Initialize();
            }
            
            this.ResetUI();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.hand.SetActive(value:  false);
            val_9 = 0;
            if( >= (currentLevel + 12 + 12))
            {
                    this.container.SetActive(value:  true);
            }
        
        }
        public void SetTimerSlider(float value)
        {
            if(this.TimerSlider == 0)
            {
                
            }
        
        }
        public void ToggleUI(bool state)
        {
            this.container.SetActive(value:  state);
        }
        public void ChooseWordElement(SLC.Minigames.Bubbles.WordBubblesBubble bubble)
        {
            var val_3;
            if(this.chosenBubbleQueue < )
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_4 = val_3.gameObject;
            val_3.SetActive(value:  true);
            goto label_8;
            label_5:
            Dispose();
            this.chosenBubbleQueue.Clear();
            label_3:
            this.chosenBubbleQueue.Add(item:  bubble);
            UnityEngine.GameObject val_5 = bubble.gameObject;
            bubble.SetActive(value:  false);
            this.ValidWord();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckTotural();
            this.UpdateChosenBubblesUI();
        }
        public void TurnBackWordElement(WordBubblesBubbleSelect select)
        {
            SLC.Minigames.Bubbles.WordBubblesBubble val_3;
            System.Collections.Generic.List<SLC.Minigames.Bubbles.WordBubblesBubble> val_6;
            val_6 = this.chosenBubbleQueue;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            bool val_2 = MoveNext();
            if(val_2 == false)
            {
                goto label_2;
            }
            
            val_6 = val_3;
            if((val_3 + 40) != val_2)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_4 = val_6.gameObject;
            val_6.SetActive(value:  true);
            bool val_5 = this.chosenBubbleQueue.Remove(item:  val_6);
            label_2:
            Dispose();
            this.ValidWord();
            this.UpdateChosenBubblesUI();
        }
        private void UpdateChosenBubblesUI()
        {
            var val_3;
            var val_4;
            val_3 = 4;
            goto label_1;
            label_24:
            SLC.Minigames.Bubbles.WordBubblesBubble val_4 = this.chosenBubbleElements[0];
            if(this.chosenBubbleQueue > R7)
            {
                    if(true <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if(5890 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4.Setup(text:  static_value_00280017, c:  new UnityEngine.Color() {r = 2.48962E-24f, g = 8.253648E-42f, b = static_value_00280023, a = static_value_00280027}, index:  static_value_0028002B);
                UnityEngine.GameObject val_1 = this.chosenBubbleElements[0].gameObject;
                val_4 = 1;
            }
            else
            {
                    UnityEngine.GameObject val_2 = val_4.gameObject;
                val_4 = 0;
            }
            
            val_4.SetActive(value:  false);
            val_3 = 5;
            label_1:
            if((val_3 - 4) < val_4)
            {
                goto label_24;
            }
        
        }
        private void ValidWord()
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_5 = Append(value:  val_4 + 20);
            goto label_5;
            label_2:
            Dispose();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((SubmitWords(word:  24121344)) == false)
            {
                    return;
            }
            
            this.chosenBubbleQueue.Clear();
            this.UpdateChosenBubblesUI();
        }
        public void PointTo(int bubbleIndex)
        {
            var val_4;
            System.Collections.IEnumerator val_1 = this.ActuralPoint(bubbleIndex:  bubbleIndex);
            val_4 = 0;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  979891328);
            goto label_1;
            label_6:
            object val_3 = 1152921508447513984.GetComponent<System.Object>();
            1152921508447513984.enabled = false;
            val_4 = 1;
            label_1:
            if(val_4 < 1152921508447513984)
            {
                goto label_6;
            }
        
        }
        private System.Collections.IEnumerator ActuralPoint(int bubbleIndex)
        {
            typeof(WordBubblesUIController.<ActuralPoint>d__25).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordBubblesUIController.<ActuralPoint>d__25).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WordBubblesUIController.<ActuralPoint>d__25).__il2cppRuntimeField_14 = bubbleIndex;
        }
        public void LevelComplete(bool victory)
        {
            this.BubbleElementsContent.SetActive(value:  false);
            this.ChosenWordContent.SetActive(value:  false);
            this.checkMark.SetActive(value:  victory);
        }
        public void ResetUI()
        {
            var val_6;
            var val_7;
            val_6 = 0;
            goto label_1;
            label_8:
            UnityEngine.GameObject val_1 = 1152921508447513984.gameObject;
            1152921508447513984.SetActive(value:  false);
            object val_2 = 1152921508447513984.GetComponent<System.Object>();
            1152921508447513984.enabled = true;
            val_6 = 1;
            label_1:
            if(val_6 < 1152921508447513984)
            {
                goto label_8;
            }
            
            val_7 = 0;
            goto label_9;
            label_16:
            UnityEngine.GameObject val_3 = 1152921508447513984.gameObject;
            1152921508447513984.SetActive(value:  false);
            object val_4 = 1152921508447513984.GetComponent<System.Object>();
            1152921508447513984.enabled = true;
            val_7 = 1;
            label_9:
            if(val_7 < 1152921508447513984)
            {
                goto label_16;
            }
            
            this.checkMark.SetActive(value:  false);
            this.BubbleElementsContent.SetActive(value:  true);
            this.ChosenWordContent.SetActive(value:  true);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.chosenBubbleQueue = null;
            if(this.TimerSlider == 0)
            {
                
            }
        
        }
        public void UpdateLives(int count)
        {
            var val_3 = 0;
            goto label_0;
            label_8:
            UnityEngine.UI.Image val_3 = this.Lives[val_3];
            if(val_3 < count)
            {
                    UnityEngine.Color val_1 = UnityEngine.Color.red;
                val_3.color = new UnityEngine.Color() {a = ???};
            }
            else
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.gray;
                val_3.color = new UnityEngine.Color() {a = ???};
            }
            
            val_3 = 1;
            label_0:
            if(val_3 < val_3)
            {
                goto label_8;
            }
        
        }
        public WordBubblesUIController()
        {
        
        }
    
    }

}
