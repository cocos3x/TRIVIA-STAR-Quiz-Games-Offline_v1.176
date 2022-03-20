using UnityEngine;

namespace SLC.Minigames.EmojiMatch
{
    public class EmojiMatchUIController : MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchUIController>, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private const float wait_for_answer_time = 1.5;
        private float timerSpeed;
        private SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay selectedCard;
        private SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay selectedPhrase;
        private UnityEngine.LineRenderer draggingLine;
        private UnityEngine.Transform phraseParent;
        private UnityEngine.Transform cardParent;
        private SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay matchCardPrefab;
        private SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay phraseCardPrefab;
        private UnityEngine.LineRenderer lrPrefab;
        private SLC.Minigames.MinigameLivesDisplay livesDisplay;
        private System.Collections.Generic.List<SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay> spawnedCards;
        private UnityEngine.Vector3[] linePoints;
        private UnityEngine.UI.Slider timerSlider;
        private UnityEngine.UI.Image FTUXHand;
        private UnityEngine.LineRenderer FTUXRenderer;
        private UnityEngine.UI.Text FTUXText;
        private UnityEngine.GameObject gameplayContainer;
        private UnityEngine.GameObject pausedContainer;
        private UnityEngine.UI.Button buttonQuit;
        private UnityEngine.UI.Button buttonResume;
        private UnityEngine.Canvas gameCanvas;
        private bool blockInput;
        private bool firstSession;
        private float timerDurationToWait;
        private float timerFullDuration;
        
        // Properties
        private UnityEngine.Color BrownPathColor { get; }
        private UnityEngine.Color GreenPathColor { get; }
        private UnityEngine.Color RedPathColor { get; }
        
        // Methods
        private UnityEngine.Color get_BrownPathColor()
        {
            val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            return new UnityEngine.Color();
        }
        private UnityEngine.Color get_GreenPathColor()
        {
            val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            return new UnityEngine.Color();
        }
        private UnityEngine.Color get_RedPathColor()
        {
            val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            return new UnityEngine.Color();
        }
        private void Start()
        {
            var val_10;
            System.Action<System.Boolean> val_11;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1088250912, method:  new IntPtr(1088210528));
            this.buttonQuit.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1088250912, method:  new IntPtr(1088219744));
            this.buttonResume.m_OnClick.AddListener(call:  162246656);
            val_10 = 1152921504901095424;
            val_11 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                goto label_9;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_6 = new System.Action(object:  1088250912, method:  new IntPtr(1088220768));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = null;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = null;
            val_11 = new System.Action<System.Boolean>(object:  1088250912, method:  new IntPtr(1088221792));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_10 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_10 != 0)
            {
                    if(val_10 == null)
            {
                goto label_16;
            }
            
            }
            
            val_10 = 0;
            label_16:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_10;
            label_9:
            this.GetAndDisplayLevel();
            this.FTUXText.enabled = true;
        }
        private void TogglePopupWindow(bool showUI)
        {
            showUI = showUI ^ 1;
            this.gameCanvas.enabled = showUI;
        }
        public void GetAndDisplayLevel()
        {
            var val_19;
            var val_20;
            float val_21;
            val_19 = 1152921504901095424;
            val_20 = 1152921512348104960;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.livesDisplay.UpdateLivesDisplay(currentHearts:  public static SLC.Minigames.EmojiMatch.EmojiMatchController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchController>::get_Instance().__il2cppRuntimeField_18);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.phraseParent);
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.cardParent);
            if(this.spawnedCards != 0)
            {
                    this.spawnedCards.Clear();
            }
            else
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.spawnedCards = null;
            }
            
            this.draggingLine.enabled = false;
            this.blockInput = false;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = getLevel();
            string val_6 = Item[937415120];
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(as. 
               
               
              
            
            
            
             >= 1)
            {
                    do
            {
                val_20 = 0 + 1;
                string val_7 = val_20.ToString();
                string val_8 = 1088502112 + 1088514232;
                string val_9 = val_20.ToString();
                string val_10 = 1088502192 + 1088514232;
                string val_11 = Item[1088502192];
                this.DisplayCard(card:  -848676608, index:  0);
                string val_12 = Item[1088502112];
                this.DisplayPhrase(phrase:  -848676608, index:  0);
                val_19 = val_20;
            }
            while(as. 
               
               
              
            
            
            
             != val_20);
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_14 = getLevelDuration;
            mem[1152921514285307940] = public static SLC.Minigames.EmojiMatch.EmojiMatchController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchController>::get_Instance();
            mem[1152921514285307944] = public static SLC.Minigames.EmojiMatch.EmojiMatchController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchController>::get_Instance();
            if(mem[1152921514285307937] != false)
            {
                    val_21 = -1f;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                float val_16 = getLevelDuration;
                val_21 = 3446290688;
            }
            
            mem[1152921514285307940] = val_21;
            mem[1152921514285307944] = val_21;
            System.Collections.IEnumerator val_17 = this.Timer();
            UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  1088526272);
        }
        private System.Collections.IEnumerator Timer()
        {
            object val_1 = new System.Object();
            typeof(EmojiMatchUIController.<Timer>d__35).__il2cppRuntimeField_8 = 0;
            typeof(EmojiMatchUIController.<Timer>d__35).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator MoveFTUXHand()
        {
            object val_1 = new System.Object();
            typeof(EmojiMatchUIController.<MoveFTUXHand>d__36).__il2cppRuntimeField_8 = 0;
            typeof(EmojiMatchUIController.<MoveFTUXHand>d__36).__il2cppRuntimeField_10 = this;
        }
        private void DisplayCard(string card, int index)
        {
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.matchCardPrefab, parent:  this.cardParent);
            this.spawnedCards.Add(item:  this.matchCardPrefab);
            this.matchCardPrefab.Init(emojiUnparsed:  card, myIndex:  index);
            if((UnityEngine.Random.Range(min:  0, max:  index + 2)) < 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.matchCardPrefab.transform;
            this.matchCardPrefab.SetAsFirstSibling();
        }
        private void DisplayPhrase(string phrase, int index)
        {
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.phraseCardPrefab, parent:  this.phraseParent);
            this.phraseCardPrefab.Init(myPhrase:  phrase, myIndex:  index);
            if((UnityEngine.Random.Range(min:  0, max:  index + 2)) < 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.phraseCardPrefab.transform;
            this.phraseCardPrefab.SetAsFirstSibling();
        }
        public void SelectPhrase(SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay phrase)
        {
            UnityEngine.Object val_4;
            if(this.blockInput == true)
            {
                    return;
            }
            
            val_4 = mem[R5 + 20];
            val_4 = R5 + 20;
            if(val_4 != 0)
            {
                    val_4 = mem[R5 + 20];
                val_4 = R5 + 20;
                if(val_4 == R4)
            {
                    return;
            }
            
                val_4 = mem[R5 + 20];
                val_4 = R5 + 20;
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  R4, y:  0);
            mem2[0] = ???;
        }
        public void MaybeDeselectPhrase(SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay phrase, bool isDragging)
        {
            var val_5;
            UnityEngine.Object val_7;
            if(this.blockInput == true)
            {
                    return;
            }
            
            if(R6 != 0)
            {
                    val_7 = mem[R5 + 16];
                val_7 = R5 + 16;
                if(val_7 == 0)
            {
                    return;
            }
            
            }
            
            val_5 = 1152921504765685760;
            val_7 = mem[R5 + 20];
            val_7 = R5 + 20;
            if(val_7 != 0)
            {
                    val_7 = mem[R5 + 20];
                val_7 = R5 + 20;
                if(val_7 == R4)
            {
                    val_7 = 0;
                mem2[0] = val_7;
                return;
            }
            
            }
            
            if(R4 == 0)
            {
                    return;
            }
            
            if(R4 == 0)
            {
                
            }
        
        }
        public void SelectCard(SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay card)
        {
            UnityEngine.Object val_4;
            if(this.blockInput == true)
            {
                    return;
            }
            
            val_4 = mem[R5 + 16];
            val_4 = R5 + 16;
            if(val_4 != 0)
            {
                    val_4 = mem[R5 + 16];
                val_4 = R5 + 16;
                if(val_4 == R4)
            {
                    return;
            }
            
                val_4 = mem[R5 + 16];
                val_4 = R5 + 16;
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  R4, y:  0);
            mem2[0] = ???;
        }
        public void MaybeDeselectCard(SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay card, bool isDragging)
        {
            var val_5;
            UnityEngine.Object val_7;
            if(this.blockInput == true)
            {
                    return;
            }
            
            if(R6 != 0)
            {
                    val_7 = mem[R5 + 20];
                val_7 = R5 + 20;
                if(val_7 == 0)
            {
                    return;
            }
            
            }
            
            val_5 = 1152921504765685760;
            val_7 = mem[R5 + 16];
            val_7 = R5 + 16;
            if(val_7 != 0)
            {
                    val_7 = mem[R5 + 16];
                val_7 = R5 + 16;
                if(val_7 == R4)
            {
                    val_7 = 0;
                mem2[0] = val_7;
                return;
            }
            
            }
            
            if(R4 == 0)
            {
                    return;
            }
            
            if(R4 == 0)
            {
                
            }
        
        }
        private void UpdateDraggingLine()
        {
        
        }
        private bool CheckMatch()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_18;
            SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay val_19;
            SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay val_20;
            var val_21;
            val_18 = 0;
            if(this.blockInput == true)
            {
                    return (bool)val_18;
            }
            
            val_19 = 1152921504765685760;
            val_20 = this.selectedPhrase;
            val_18 = 0;
            if(val_20 == 0)
            {
                    return (bool)val_18;
            }
            
            val_20 = this.selectedCard;
            val_18 = 0;
            if(val_20 == 0)
            {
                    return (bool)val_18;
            }
            
            UnityEngine.Transform val_3 = this.selectedCard.transform;
            if((this.selectedCard.<index>k__BackingField) == (this.selectedPhrase.<index>k__BackingField))
            {
                    object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.lrPrefab, parent:  this.selectedCard);
                val_21 = this.lrPrefab;
                UnityEngine.Vector3 val_6 = GetLinePosition();
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_10 = val_7;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 = val_8;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = val_9;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = 1065353216;
                UnityEngine.Vector3 val_10 = GetLinePosition();
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = 1065353216;
                val_21.SetPositions(positions:  533912224);
                UnityEngine.Color val_11 = new UnityEngine.Color(r:  val_10.x, g:  val_10.y, b:  val_10.z);
                val_21.startColor = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
                UnityEngine.Color val_12 = new UnityEngine.Color(r:  val_10.x, g:  val_10.y, b:  val_10.z);
                val_21.endColor = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
                val_19 = 0;
                this.draggingLine.enabled = false;
                val_18 = 1;
                this.selectedPhrase.CompleteMe(matched:  true);
                val_20 = this.selectedCard;
                this.selectedPhrase = val_19;
                val_20.CompleteMe(matched:  true);
                this.selectedCard = 0;
                return (bool)val_18;
            }
            
            object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  this.lrPrefab, parent:  this.selectedCard);
            val_21 = this.lrPrefab;
            UnityEngine.Vector3 val_14 = GetLinePosition();
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_10 = val_7;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 = val_8;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = val_9;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = 1065353216;
            UnityEngine.Vector3 val_15 = GetLinePosition();
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = 1065353216;
            val_21.SetPositions(positions:  533912224);
            UnityEngine.Color val_16 = new UnityEngine.Color(r:  val_15.x, g:  val_15.y, b:  val_15.z);
            val_21.startColor = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
            UnityEngine.Color val_17 = new UnityEngine.Color(r:  val_15.x, g:  val_15.y, b:  val_15.z);
            val_19 = 0;
            val_21.endColor = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a};
            this.draggingLine.enabled = false;
            val_20 = this.selectedPhrase;
            val_18 = 0;
            val_20.CompleteMe(matched:  false);
            this.selectedCard.CompleteMe(matched:  false);
            return (bool)val_18;
        }
        private bool CheckGameComplete()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= true)
            {
                    return true;
            }
            
                if(true <= val_2)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_2 = val_2 + 1;
            }
            while(((0 + 0) + 16 + 40) != 0);
            
            return false;
        }
        private void OnLevelComplete()
        {
            this.StopAllCoroutines();
            if(this.FTUXText.enabled != false)
            {
                    this.FTUXText.enabled = false;
            }
            
            if(this.firstSession == true)
            {
                    this.firstSession = false;
                this.firstSession = this.firstSession;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                goto label_8;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(HandleLevelComplete() == false)
            {
                goto label_12;
            }
            
            this.ClearLevel();
            goto label_13;
            label_8:
            this.blockInput = true;
            System.Collections.IEnumerator val_6 = this.WaitThenReset();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  1090140608);
            return;
            label_12:
            this.blockInput = true;
            System.Collections.IEnumerator val_8 = this.WaitThenReset();
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  1090140608);
            label_13:
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_5;
            if(this.blockInput == true)
            {
                    return;
            }
            
            val_5 = 1152921504765685760;
            if(this.selectedCard == 0)
            {
                    if(this.selectedPhrase == 0)
            {
                    return;
            }
            
            }
            
            this.draggingLine.enabled = true;
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.draggingLine.startColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            val_5 = 0;
            this.draggingLine.endColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        }
        private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_11;
            if(this.blockInput == true)
            {
                    return;
            }
            
            if((R4 + 16) != 0)
            {
                    if((R4 + 20) != 0)
            {
                goto label_6;
            }
            
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  R4 + 16, y:  0);
            bool val_4 = UnityEngine.Object.op_Inequality(x:  R4 + 20, y:  0);
            mem2[0] = 0;
            mem2[0] = 0;
            R4 + 24.enabled = false;
            return;
            label_6:
            if(R4.CheckMatch() != false)
            {
                    if(R4.CheckGameComplete() == false)
            {
                    return;
            }
            
                R4.StopAllCoroutines();
                mem2[0] = 1;
                UnityEngine.GameObject val_7 = R4 + 68.gameObject;
                R4 + 68.SetActive(value:  false);
                UnityEngine.GameObject val_8 = R4 + 64.gameObject;
                R4 + 64.SetActive(value:  false);
                val_11 = "OnLevelComplete";
            }
            else
            {
                    R4.StopAllCoroutines();
                mem2[0] = 1;
                UnityEngine.GameObject val_9 = R4 + 68.gameObject;
                R4 + 68.SetActive(value:  false);
                UnityEngine.GameObject val_10 = R4 + 64.gameObject;
                R4 + 64.SetActive(value:  false);
                val_11 = "OnFailure";
            }
            
            R4.Invoke(methodName:  1090402160, time:  null);
        }
        public void OnFailure()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldReset() != false)
            {
                    this.blockInput = true;
                System.Collections.IEnumerator val_4 = this.WaitThenReset();
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1090542352);
                return;
            }
            
            this.ClearLevel();
        }
        public void ClearLevel()
        {
            if(this.selectedCard != 0)
            {
                    this.selectedCard.CompleteMe(matched:  false);
            }
            
            this.selectedCard = 0;
            if(this.selectedPhrase != 0)
            {
                    this.selectedPhrase.CompleteMe(matched:  false);
            }
            
            this.selectedPhrase = 0;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.cardParent);
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.phraseParent);
            this.draggingLine.enabled = false;
        }
        public void ResetLevel()
        {
            this.blockInput = true;
            System.Collections.IEnumerator val_1 = this.WaitThenReset();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1090823696);
        }
        private System.Collections.IEnumerator WaitThenReset()
        {
            object val_1 = new System.Object();
            typeof(EmojiMatchUIController.<WaitThenReset>d__52).__il2cppRuntimeField_8 = 0;
            typeof(EmojiMatchUIController.<WaitThenReset>d__52).__il2cppRuntimeField_10 = this;
        }
        private void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.blockInput == true)
            {
                    return;
            }
            
            this.UpdateLineRenderer(data:  eventData);
        }
        private void UpdateLineRenderer(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_10;
            float val_11;
            UnityEngine.Vector3 val_16;
            UnityEngine.Vector3 val_17;
            UnityEngine.Vector3 val_18;
            var val_19;
            UnityEngine.Vector3 val_20;
            SLC.Minigames.EmojiMatch.EmojiMatchPhraseDisplay val_21;
            UnityEngine.Vector3[] val_22;
            val_19 = data;
            val_20 = 1152921504765685760;
            if(this.selectedCard == 0)
            {
                    val_21 = this.selectedPhrase;
                if(val_21 == 0)
            {
                    return;
            }
            
            }
            
            if((this.selectedPhrase != 0) && (this.selectedCard != 0))
            {
                    UnityEngine.Vector3 val_5 = GetLinePosition();
                this.linePoints[0] = 1065353216;
                val_22 = this.linePoints;
                UnityEngine.Vector3 val_6 = GetLinePosition();
            }
            else
            {
                    UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                bool val_8 = UnityEngine.Object.op_Inequality(x:  this.selectedPhrase, y:  0);
                if(val_8 == false)
            {
                    this.selectedPhrase = this.selectedCard;
            }
            
                if(val_8 == true)
            {
                    this.selectedPhrase = this.selectedPhrase;
            }
            
                UnityEngine.Vector3 val_9 = GetLinePosition();
                this.linePoints[0] = 1065353216;
                val_22 = this.linePoints;
                UnityEngine.Camera val_13 = UnityEngine.Camera.main;
                val_19 = 0;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 8.931522f, y = data.<position>k__BackingField});
                UnityEngine.Vector3 val_15 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = val_11});
            }
            
            val_21 = val_17;
            val_20 = val_18;
            val_22[1] = val_16;
            val_22[1] = val_21;
            val_22[1] = val_20;
            this.linePoints[1] = 1065353216;
            this.draggingLine.SetPositions(positions:  this.linePoints);
        }
        private void OnPauseClicked()
        {
            this.PauseGame(paused:  true);
        }
        public void PauseGame(bool paused)
        {
            bool val_5;
            var val_6;
            val_5 = paused;
            val_6 = this;
            if(paused != false)
            {
                    if(this.blockInput == true)
            {
                    return;
            }
            
                R5.StopAllCoroutines();
            }
            else
            {
                    System.Collections.IEnumerator val_1 = this.Timer();
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1092080016);
            }
            
            this.pausedContainer.SetActive(value:  val_5);
            this.gameplayContainer.SetActive(value:  val_5 ^ 1);
        }
        public void UnpauseForRestart()
        {
            this.StopAllCoroutines();
            this.pausedContainer.SetActive(value:  false);
            this.gameplayContainer.SetActive(value:  true);
        }
        private void OnPausedQuit()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void OnPausedResume()
        {
            this.PauseGame(paused:  false);
        }
        public void SetTimerSpeedForHack(float speed)
        {
            this.timerSpeed = ;
        }
        public EmojiMatchUIController()
        {
            this.timerSpeed = 1f;
            this.linePoints = null;
            this.firstSession = true;
        }
    
    }

}
