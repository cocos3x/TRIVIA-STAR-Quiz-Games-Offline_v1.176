using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackUIController : MonoSingleton<SLC.Minigames.Whack.WhackUIController>
    {
        // Fields
        private const int SLOTS = 7;
        private UnityEngine.CanvasGroup mainCanvasGroup;
        public System.Collections.Generic.List<SLC.Minigames.Whack.WhackItem> whackItems;
        private UnityEngine.GameObject itemPrefab;
        private System.Collections.Generic.List<UnityEngine.GameObject> slots;
        private UnityEngine.UI.Text timer;
        private UnityEngine.UI.Slider timerSlider;
        private UnityEngine.UI.Image sliderFill;
        private UnityEngine.Color sliderFillColor;
        private SLC.Minigames.MinigamesCheckpointSlider cpSlider;
        private UnityEngine.GameObject[] lives;
        private UnityEngine.GameObject tapToContinueGroup;
        private UnityEngine.GameObject hammer;
        private UnityEngine.GameObject ftuxText;
        private UnityEngine.GameObject pauseMenu;
        private bool paused;
        private int[] emptyIndices;
        private RandomSet randomSet;
        private SLC.Minigames.Whack.WhackLevel currentLevel;
        private System.DateTime levelExpired;
        private System.TimeSpan remainingTime;
        private bool timerHasStarted;
        private bool firstLevelThisSession;
        
        // Methods
        public override void InitMonoSingleton()
        {
            var val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1005972720, method:  new IntPtr(1005939504));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, b:  7454720);
            val_5 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_5 != 0)
            {
                    if(val_5 == null)
            {
                goto label_6;
            }
            
            }
            
            val_5 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_5;
            UnityEngine.Color val_4 = color;
        }
        public void HideUIForPopup(bool showingPopup)
        {
            if(showingPopup == true)
            {
                    1f = 0;
            }
            
            this.mainCanvasGroup.alpha = 0f;
        }
        private void OnDestroy()
        {
            var val_6;
            System.Action val_7;
            var val_8;
            val_6 = 1152921504901095424;
            val_7 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action(object:  1006213104, method:  new IntPtr(1005939504));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, value:  7454720);
            val_8 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_8;
        }
        private void PauseLevel()
        {
            System.TimeSpan val_10;
            UnityEngine.GameObject val_1 = this.pauseMenu.gameObject;
            if(this.pauseMenu.activeSelf == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.timerHasStarted = false;
            this.paused = true;
            UnityEngine.Color val_4 = UnityEngine.Color.red;
            this.timer.color = new UnityEngine.Color() {a = ???};
            System.DateTime val_5 = System.DateTime.UtcNow;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514203106904}, d2:  new System.DateTime() {dateData = this.levelExpired});
            this.remainingTime = val_10;
            UnityEngine.GameObject val_11 = this.pauseMenu.gameObject;
            this.pauseMenu.SetActive(value:  true);
        }
        public void ResumeLevel()
        {
            System.DateTime val_10;
            UnityEngine.GameObject val_1 = this.ftuxText.gameObject;
            bool val_2 = this.ftuxText.activeSelf;
            if(val_2 == false)
            {
                    val_2 = this.firstLevelThisSession;
                val_2 = false;
                this.paused = val_2;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            System.DateTime val_4 = System.DateTime.UtcNow;
            System.DateTime val_8 = AddMilliseconds(value:  this.remainingTime.TotalMilliseconds);
            this.levelExpired = val_10;
            this.timerHasStarted = true;
            UnityEngine.GameObject val_11 = this.pauseMenu.gameObject;
            this.pauseMenu.SetActive(value:  false);
        }
        public void Initialize(SLC.Minigames.Whack.WhackLevel level)
        {
            var val_13;
            var val_15 = 0;
            this.ClearUI();
            this.currentLevel = level;
            this.CreateEmptySlots();
            val_13 = 0;
            do
            {
                if(this <= val_15)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + 0;
                UnityEngine.Transform val_1 = (0 + 0) + 16.transform;
                object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.itemPrefab, parent:  (0 + 0) + 16);
                object val_3 = this.itemPrefab.GetComponent<System.Object>();
                this.whackItems.Add(item:  this.itemPrefab);
                bool val_4 = System.Linq.Enumerable.Contains<System.Int32>(source:  this.emptyIndices, value:  0);
                if(val_4 != false)
            {
                    this.itemPrefab.Setup(wordDefinition:  0);
            }
            else
            {
                    if(val_4 <= val_13)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + 0;
                this.itemPrefab.Setup(wordDefinition:  (0 + 0) + 16);
                val_13 = val_13 + 1;
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 != 7);
            
            this.timerHasStarted = false;
            float val_5 = this.timerSlider.TimeRemaining;
            string val_6 = this.timerSlider.ToString(format:  1006634672);
            UnityEngine.Color val_7 = UnityEngine.Color.white;
            this.timer.color = new UnityEngine.Color() {a = ???};
            this.StartTimer();
            this.cpSlider.UpdateUI();
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayerLife == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayerLife = 3;
            }
            
            this.UIResetLife();
            this.hammer.SetActive(value:  false);
            this.paused = false;
            if((CPlayerPrefs.GetInt(key:  1006647056, defaultValue:  0)) == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            this.ftuxText.SetActive(value:  false);
            if(this.firstLevelThisSession == true)
            {
                    this.firstLevelThisSession = true;
                this.paused = this.firstLevelThisSession;
            }
        
        }
        public void DisplayResult(SLC.Minigames.Whack.WhackItem item, bool won)
        {
            System.Collections.IEnumerator val_1 = this.displayResult(item:  item, won:  won);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1006881456);
        }
        private System.Collections.IEnumerator displayResult(SLC.Minigames.Whack.WhackItem item, bool won)
        {
            typeof(WhackUIController.<displayResult>d__30).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WhackUIController.<displayResult>d__30).__il2cppRuntimeField_10 = this;
                typeof(WhackUIController.<displayResult>d__30).__il2cppRuntimeField_14 = item;
            }
            else
            {
                    mem[16] = this;
                mem[20] = item;
            }
            
            typeof(WhackUIController.<displayResult>d__30).__il2cppRuntimeField_18 = won;
        }
        private void setAllWackItemsClickable(bool clickable)
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_3.SetInteractable(state:  clickable);
            goto label_4;
            label_2:
            Dispose();
        }
        private void UIWon(SLC.Minigames.Whack.WhackItem item)
        {
            var val_6;
            this.timerHasStarted = false;
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            this.timer.color = new UnityEngine.Color() {a = ???};
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  928911072, clipIndex:  0, volumeScale:  val_1.r);
            if((CPlayerPrefs.GetInt(key:  1006647056, defaultValue:  0)) == 0)
            {
                    CPlayerPrefs.SetInt(key:  1006647056, val:  1);
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_16:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            if((val_6 + 48) == 0)
            {
                goto label_16;
            }
            
            if((val_6 + 48 + 12) == 0)
            {
                goto label_14;
            }
            
            val_6.SetDisplayState(state:  4);
            goto label_16;
            label_14:
            val_6.SetDisplayState(state:  3);
            goto label_16;
            label_11:
            Dispose();
        }
        private void UILose(SLC.Minigames.Whack.WhackItem item)
        {
            UnityEngine.Object val_4;
            this.UILoseLife();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  928916272, clipIndex:  0, volumeScale:  null);
            List.Enumerator<T> val_2 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            if((val_4 + 48) == 0)
            {
                goto label_14;
            }
            
            if((val_4 + 48 + 12) == 0)
            {
                goto label_8;
            }
            
            val_4.SetDisplayState(state:  6);
            goto label_14;
            label_8:
            if(val_4 != item)
            {
                goto label_12;
            }
            
            val_4.SetDisplayState(state:  5);
            goto label_14;
            label_12:
            val_4.SetDisplayState(state:  7);
            goto label_14;
            label_5:
            Dispose();
        }
        public void ClearUI()
        {
            UnityEngine.Object val_4;
            UnityEngine.Transform val_1 = this.hammer.transform;
            this.hammer.SetParent(p:  0);
            List.Enumerator<T> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            UnityEngine.GameObject val_5 = val_4.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  val_4);
            goto label_8;
            label_4:
            Dispose();
            this.whackItems.Clear();
        }
        public void OnQuit()
        {
            UnityEngine.GameObject val_1 = this.pauseMenu.gameObject;
            this.pauseMenu.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void Update()
        {
            var val_5;
            if(this.paused != false)
            {
                    return;
            }
            
            if(this.timerHasStarted == false)
            {
                    return;
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514204553744}, d2:  new System.DateTime() {dateData = this.levelExpired});
            double val_7 = val_5.TotalMilliseconds;
            this.setAllWackItemsClickable(clickable:  false);
            this.timerHasStarted = false;
            string val_8 = 0.ToString(format:  1006634672);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelFailed(itemClicked:  0);
        }
        private void CreateEmptySlots()
        {
            this.randomSet = new RandomSet();
            addIntRange(lowest:  0, highest:  6);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = this.randomSet.roll(unweighted:  false);
            typeof(System.Int32[]).__il2cppRuntimeField_14 = this.randomSet.roll(unweighted:  false);
            this.emptyIndices = null;
        }
        private void StartTimer()
        {
            System.DateTime val_7;
            System.DateTime val_1 = System.DateTime.UtcNow;
            float val_4 = this.currentLevel.TimeRemaining;
            float val_8 = 1000f;
            val_8 = this.currentLevel * val_8;
            System.DateTime val_5 = AddMilliseconds(value:  null);
            this.levelExpired = val_7;
            this.timerHasStarted = true;
        }
        private void UILoseLife()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_2 = PlayerLife;
            if(val_2 > 2)
            {
                    return;
            }
            
            do
            {
                var val_3 = 6 - 4;
                UnityEngine.GameObject val_7 = this.lives[2];
                UnityEngine.GameObject val_4 = val_7.gameObject;
                val_7.SetActive(value:  false);
                var val_5 = 6 - 1;
            }
            while((6 - 5) >= val_2);
        
        }
        private void HammerHit(SLC.Minigames.Whack.WhackItem hitDude)
        {
            UnityEngine.Transform val_1 = this.hammer.transform;
            UnityEngine.Transform val_2 = hitDude.transform;
            this.hammer.SetParent(p:  hitDude);
            UnityEngine.Transform val_3 = this.hammer.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0.009424239f}, d:  val_4.x);
            this.hammer.localPosition = new UnityEngine.Vector3();
            UnityEngine.GameObject val_6 = this.hammer.gameObject;
            this.hammer.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  907414048, clipIndex:  0, volumeScale:  val_5.x);
        }
        private void UIResetLife()
        {
            var val_5 = 0;
            do
            {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                int val_2 = PlayerLife;
                UnityEngine.GameObject val_4 = this.lives[val_5];
                UnityEngine.GameObject val_3 = val_4.gameObject;
                if(val_5 >= val_2)
            {
                    0 = 0;
            }
            
                if(val_5 < val_2)
            {
                    0 = 1;
            }
            
                val_4.SetActive(value:  true);
                val_5 = val_5 + 1;
            }
            while(val_5 != 3);
        
        }
        public void PauseHack()
        {
            System.TimeSpan val_9;
            bool val_10;
            UnityEngine.GameObject val_1 = this.pauseMenu.gameObject;
            val_10 = false;
            if(this.pauseMenu.activeSelf == true)
            {
                    return;
            }
            
            this.timerHasStarted = val_10;
            this.paused = true;
            UnityEngine.Color val_3 = UnityEngine.Color.blue;
            this.sliderFill.color = new UnityEngine.Color() {a = ???};
            val_10 = this.levelExpired;
            System.DateTime val_4 = System.DateTime.UtcNow;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514205475704}, d2:  new System.DateTime() {dateData = val_10});
            this.remainingTime = val_9;
            this.Invoke(methodName:  1008682096, time:  val_3.r);
        }
        public void StopTimerHack()
        {
            System.TimeSpan val_9;
            bool val_10;
            UnityEngine.GameObject val_1 = this.pauseMenu.gameObject;
            val_10 = false;
            if(this.pauseMenu.activeSelf == true)
            {
                    return;
            }
            
            this.timerHasStarted = val_10;
            this.paused = true;
            UnityEngine.Color val_3 = UnityEngine.Color.blue;
            this.sliderFill.color = new UnityEngine.Color() {a = ???};
            val_10 = this.levelExpired;
            System.DateTime val_4 = System.DateTime.UtcNow;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514205604088}, d2:  new System.DateTime() {dateData = val_10});
            this.remainingTime = val_9;
        }
        public void ResumeTimerHack()
        {
            this.ResumeLevel();
        }
        public WhackUIController()
        {
            this.firstLevelThisSession = true;
        }
    
    }

}
