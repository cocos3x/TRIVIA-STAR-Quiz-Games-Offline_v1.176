using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WordFillUIController : MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>
    {
        // Fields
        private UnityEngine.Canvas canvas;
        private UnityEngine.Canvas pauseCanvas;
        private UnityEngine.GameObject blur;
        private BlurCanvas blurCanvas;
        private UnityEngine.UI.Slider lifeMeter;
        private UnityEngine.GameObject lifeGainIndicator;
        private WFLifeIcon lifeCountIndicator1;
        private WFLifeIcon lifeCountIndicator2;
        private WFLifeIcon lifeCountIndicator3;
        private UnityEngine.UI.Text categoryText;
        private UnityEngine.UI.Text spellingWord;
        private UnityEngine.Transform boardTransform;
        private UnityEngine.GameObject boardLetter;
        private UnityEngine.UI.Button pauseButton;
        private UnityEngine.UI.Button quitButton;
        private UnityEngine.UI.Button resumeButton;
        private bool init;
        private float remainingTime;
        private float extraWordBonusDisplay;
        private float completedWordDisplay;
        private bool started;
        private bool ended;
        private bool overlay;
        private float endTimer;
        private SLC.Minigames.WordFill.WordFillLevel currentLevel;
        private System.Collections.Generic.List<WFLetter> allLetters;
        private System.Collections.Generic.List<WFLetter> spelling;
        private System.Collections.Generic.List<System.Collections.Generic.HashSet<int>> usedPaths;
        
        // Methods
        public override void InitMonoSingleton()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  958704000, method:  new IntPtr(958660544));
            this.pauseButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  958704000, method:  new IntPtr(958669760));
            this.quitButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  958704000, method:  new IntPtr(958678976));
            this.resumeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void Start()
        {
        
        }
        public void Initialize()
        {
            if(this.init == false)
            {
                    this.init = true;
                this.init = this.init;
            }
        
        }
        private void Update()
        {
            float val_12;
            if(this.overlay != false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            uint val_12 = 0;
            val_12 = this.extraWordBonusDisplay - val_12;
            this.extraWordBonusDisplay = val_12;
            float val_2 = UnityEngine.Time.deltaTime;
            val_12 = this.completedWordDisplay - 0;
            this.completedWordDisplay = val_12;
            this.RefreshPlayerDisplay();
            if(this.started != false)
            {
                    bool val_3 = this.pauseCanvas.enabled;
                if(val_3 == false)
            {
                    val_3 = this.ended;
                goto label_4;
            }
            
            }
            
            label_16:
            if(this.ended == false)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.deltaTime;
            uint val_13 = 0;
            val_13 = this.endTimer - val_13;
            this.endTimer = val_13;
            if(this.ended > false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.IEnumerator val_6 = OnStartNextLevel();
            UnityEngine.Coroutine val_7 = StartCoroutine(routine:  959044672);
            this.started = false;
            this.ended = false;
            return;
            label_4:
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_14 = this.remainingTime;
            float val_9 = UnityEngine.Time.deltaTime;
            val_12 = 0;
            val_14 = val_14 - val_12;
            this.remainingTime = val_14;
            this.HandleInput();
            goto label_16;
        }
        private void HandleInput()
        {
            float val_17;
            float val_18;
            var val_26;
            SLC.Minigames.WordFill.WordFillUIController val_64;
            var val_68;
            var val_69;
            float val_70;
            float val_71;
            System.Collections.Generic.List<WFLetter> val_75;
            val_64 = this;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if(UnityEngine.Input.touchCount < 1)
            {
                goto label_3;
            }
            
            UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  959278040);
            float val_5 = val_3.m_Radius + 24;
            val_68 = val_3.m_Pressure - 104;
            float val_6 = val_3.m_Radius + 16;
            val_69 = 0;
            val_70 = mem[val_3.m_Radius + 16];
            val_70 = val_3.m_Radius + 16;
            val_71 = mem[val_3.m_Radius + 20];
            val_71 = val_3.m_Radius + 20;
            goto label_4;
            label_3:
            val_68 = 0;
            if(((UnityEngine.Input.GetMouseButton(button:  0)) == true) || ((UnityEngine.Input.GetMouseButtonDown(button:  0)) == true))
            {
                goto label_6;
            }
            
            bool val_9 = UnityEngine.Input.GetMouseButtonUp(button:  0);
            if(val_9 == false)
            {
                goto label_7;
            }
            
            label_6:
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == true)
            {
                goto label_11;
            }
            
            if(((UnityEngine.Input.GetMouseButton(button:  0)) == false) || ((UnityEngine.Input.GetMouseButtonDown(button:  0)) == true))
            {
                goto label_10;
            }
            
            val_68 = 1;
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                goto label_11;
            }
            
            label_10:
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == true)
            {
                    val_68 = 3;
            }
            
            label_11:
            UnityEngine.Vector3 val_15 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0.0001653864f});
            val_70 = val_17;
            val_71 = val_18;
            label_4:
            if(3 > 3)
            {
                    return;
            }
            
            UnityEngine.Object val_19 = 13388524 + 4;
            var val_20 = val_19 + ((13388524 + 4) + 12);
            if(3 == 3)
            {
                    val_19 = val_19 & (val_19 << val_19);
                val_19 = val_19 & (((int)IP) >> R2);
                val_19 = val_19 & (val_19 >> ((13388524 + 4) + 12));
            }
            
            if(val_19 != 0)
            {
                    return;
            }
            
            WFLetter val_21 = val_19.GetTouchedLetter(touchPos:  new UnityEngine.Vector2() {x = val_70, y = val_71});
            if(val_19 == 0)
            {
                    return;
            }
            
            if((((((13388524 + 4) & ((13388524 + 4)) << (13388524 + 4)) & ((int)IP) >> R2) & ((((13388524 + 4) & ((13388524 + 4)) << (13388524 + 4)) & ((int)IP) >> R2)) >> (13388524 + 4) + 12) + 28) == 0)
            {
                    return;
            }
            
            this.spelling.Add(item:  val_19);
            val_19.SetSelected();
            this.completedWordDisplay = 0f;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  1, volumeScale:  val_16.x);
            return;
            label_7:
            if(val_9 < true)
            {
                    return;
            }
            
            List.Enumerator<T> val_24 = GetEnumerator();
            val_70 = 1152921514155961792;
            label_32:
            if(MoveNext() == false)
            {
                goto label_30;
            }
            
            val_26.SetAvailable();
            goto label_32;
            label_36:
            val_68 = "";
            if(MoveNext() == false)
            {
                goto label_34;
            }
            
            string val_30 = val_26.Letter.ToString();
            string val_31 = 1098586544 + 959278110;
            goto label_36;
            label_34:
            Dispose();
            System.Collections.Generic.HashSet<System.Int32> val_34 = this.ConstructSpellingPath();
            val_70 = 1152921514153591104;
            twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_36 = RequiredFtuxAnswer();
            if((public static WordFillFTUXManager MonoSingleton<WordFillFTUXManager>::get_Instance()) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_38 = RequiredFtuxAnswer();
                if((System.String.op_Inequality(a:  956809536, b:  1098586544)) != false)
            {
                    val_68 = "";
                this.Clear();
            }
            
            }
            
            bool val_40 = this.currentLevel.answers.Contains(item:  1098586544);
            if(val_40 == false)
            {
                goto label_57;
            }
            
            if((val_40.ContainsPath(pathset:  this.currentLevel.answerPaths, newpath:  959290240)) == false)
            {
                goto label_59;
            }
            
            List.Enumerator<T> val_42 = GetEnumerator();
            label_63:
            if(MoveNext() == false)
            {
                goto label_61;
            }
            
            val_26.SetUsed();
            goto label_63;
            label_30:
            Dispose();
            val_75 = this.spelling;
            goto label_64;
            label_57:
            bool val_44 = this.usedPaths.ContainsPath(pathset:  this.usedPaths.SyncRoot, newpath:  959290240);
            if(val_44 == true)
            {
                goto label_70;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_45 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_46 = ToLower();
            val_70 = val_70;
            if((IsValidWord(word:  1098586544)) == false)
            {
                goto label_70;
            }
            
            this.GainExtraWordBonus();
            twelvegigs.Autopilot.AutopilotManager val_48 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  2, volumeScale:  val_1.x);
            this.usedPaths.Add(item:  959290240);
            twelvegigs.Autopilot.AutopilotManager val_49 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FtuxProceed();
            goto label_80;
            label_70:
            if(val_44 >= true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_50 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayButtonSound(clipIndex:  3, volumeScale:  val_1.x);
            }
            
            label_80:
            List.Enumerator<T> val_51 = GetEnumerator();
            label_87:
            if(MoveNext() == false)
            {
                goto label_106;
            }
            
            val_26.SetAvailable();
            goto label_87;
            label_59:
            if((null.ContainsPath(pathset:  this.usedPaths, newpath:  959290240)) == false)
            {
                goto label_88;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_54 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  3, volumeScale:  val_1.x);
            goto label_92;
            label_61:
            Dispose();
            twelvegigs.Autopilot.AutopilotManager val_55 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  2, volumeScale:  val_1.x);
            this.usedPaths.Add(item:  959290240);
            this.CheckWin();
            twelvegigs.Autopilot.AutopilotManager val_56 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FtuxProceed();
            goto label_147;
            label_88:
            this.GainExtraWordBonus();
            twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  2, volumeScale:  val_1.x);
            this.usedPaths.Add(item:  959290240);
            label_92:
            List.Enumerator<T> val_58 = GetEnumerator();
            label_108:
            if(MoveNext() == false)
            {
                goto label_106;
            }
            
            val_26.SetAvailable();
            goto label_108;
            label_106:
            Dispose();
            label_147:
            val_75 = this.spelling;
            this.completedWordDisplay = 2f;
            label_64:
            val_75.Clear();
        }
        private WFLetter GetTouchedLetter(UnityEngine.Vector2 touchPos)
        {
            float val_4;
            float val_5;
            float val_14;
            var val_22;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0.0001684643f, y = touchPos.x});
            UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
            UnityEngine.Camera val_10 = UnityEngine.Camera.main;
            UnityEngine.Transform val_11 = 0.transform;
            UnityEngine.Vector3 val_12 = forward;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0.0001684637f});
            UnityEngine.RaycastHit2D val_16 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 0.0001684632f, y = val_9.x}, direction:  new UnityEngine.Vector2() {x = val_9.y, y = val_14});
            UnityEngine.Collider2D val_17 = val_16.m_Collider.collider;
            if(val_16.m_Collider == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_19 = 0.transform;
            UnityEngine.GameObject val_20 = 0.gameObject;
            object val_21 = 0.GetComponent<System.Object>();
            val_22 = ;
        }
        public void ToggleUI(bool show)
        {
            this.canvas.enabled = show;
        }
        public void RefreshPlayerDisplay()
        {
            var val_10;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordFill.WordFillManager MonoSingleton<SLC.Minigames.WordFill.WordFillManager>::get_Instance().__il2cppRuntimeField_38) > 0)
            {
                    0 = 1;
            }
            
            this.lifeCountIndicator1.SetAlive(alive:  true);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordFill.WordFillManager MonoSingleton<SLC.Minigames.WordFill.WordFillManager>::get_Instance().__il2cppRuntimeField_38) > 1)
            {
                    0 = 1;
            }
            
            this.lifeCountIndicator2.SetAlive(alive:  true);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordFill.WordFillManager MonoSingleton<SLC.Minigames.WordFill.WordFillManager>::get_Instance().__il2cppRuntimeField_38) > 2)
            {
                    0 = 1;
            }
            
            this.lifeCountIndicator3.SetAlive(alive:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_7 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  this.remainingTime / (public static SLC.Minigames.WordFill.WordFillManager MonoSingleton<SLC.Minigames.WordFill.WordFillManager>::get_Instance().__il2cppRuntimeField_30), b:  null), b:  null);
            if(this.lifeGainIndicator > 0)
            {
                    0 = 1;
            }
            
            this.lifeGainIndicator.SetActive(value:  true);
            if(this.lifeGainIndicator > 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_8 = GetEnumerator();
            1152921514155826240 = 1152921514155961792;
            label_18:
            if(MoveNext() == false)
            {
                goto label_16;
            }
            
            string val_12 = val_10.Letter.ToString();
            string val_13 = 1098586544 + 959750382;
            goto label_18;
            label_16:
            Dispose();
        }
        private void GainExtraWordBonus()
        {
            this.extraWordBonusDisplay = 2f;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_3 = 5f;
            val_3 = this.remainingTime + val_3;
            float val_2 = UnityEngine.Mathf.Min(a:  val_3, b:  null);
            this.remainingTime = val_3;
        }
        private void CheckWin()
        {
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if((val_3 + 30) != 0)
            {
                goto label_4;
            }
            
            Dispose();
            return;
            label_2:
            Dispose();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BeatLevel();
            this.ended = true;
            this.endTimer = 1.5f;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  928911072, clipIndex:  0, volumeScale:  null);
        }
        public void StartLevel(SLC.Minigames.WordFill.WordFillLevel level)
        {
            var val_8;
            if(this.init == false)
            {
                    this.init = true;
                this.init = this.init;
            }
            
            this.blur.SetActive(value:  false);
            this.pauseCanvas.enabled = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
            this.currentLevel = level;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.remainingTime = public static SLC.Minigames.WordFill.WordFillManager MonoSingleton<SLC.Minigames.WordFill.WordFillManager>::get_Instance().__il2cppRuntimeField_30;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.allLetters.Clear();
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.boardTransform);
            this.usedPaths.Clear();
            this.spelling.Clear();
            this.overlay = false;
            this.started = true;
            this.ended = false;
            this.endTimer = false;
            this.extraWordBonusDisplay = false;
            this.completedWordDisplay = false;
            object val_4 = this.boardTransform.GetComponent<System.Object>();
            val_8 = 0;
            this.boardTransform.constraintCount = this.boardTransform;
            if(this.boardTransform >= 1)
            {
                    do
            {
                if(this.boardTransform >= 1)
            {
                    var val_9 = 0;
                do
            {
                object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.boardLetter, parent:  this.boardTransform);
                object val_6 = this.boardLetter.GetComponent<System.Object>();
                System.Collections.Generic.List<WFLetter> val_8 = this.allLetters;
                val_8.Add(item:  this.boardLetter);
                val_8 = this.allLetters + (val_8 << 1);
                if(this.boardLetter != 0)
            {
                    this.boardLetter.Letter = this.allLetters;
            }
            else
            {
                    this.boardLetter.Letter = this.allLetters;
            }
            
                this.boardLetter.SetGridPos(x:  0, y:  0);
                val_9 = val_9 + 1;
            }
            while(val_9 < this.boardLetter);
            
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < this.boardLetter);
            
            }
            
            this.RefreshPlayerDisplay();
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FtuxProceed();
        }
        private System.Collections.Generic.HashSet<int> ConstructSpellingPath()
        {
            var val_4;
            var val_6;
            System.Collections.Generic.HashSet<System.Int32> val_1 = new System.Collections.Generic.HashSet<System.Int32>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_4 != 0)
            {
                    val_6 = mem[val_4 + 20];
                val_6 = val_4 + 20;
            }
            else
            {
                    val_6 = 1;
            }
            
            bool val_5 = Add(item:  959180224);
            goto label_7;
            label_2:
            Dispose();
        }
        private bool ContainsPath(System.Collections.Generic.List<System.Collections.Generic.HashSet<int>> pathset, System.Collections.Generic.HashSet<int> newpath)
        {
            var val_3;
            int val_5;
            var val_8;
            var val_9;
            var val_10;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_12:
            label_5:
            bool val_2 = MoveNext();
            if(val_2 == false)
            {
                goto label_2;
            }
            
            if((val_3 + 16) != val_2)
            {
                goto label_5;
            }
            
            HashSet.Enumerator<T> val_4 = GetEnumerator();
            val_8 = 1;
            goto label_6;
            label_8:
            val_8 = val_8 & (val_3.Contains(item:  val_5));
            label_6:
            if(MoveNext() == true)
            {
                goto label_8;
            }
            
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
                val_9 = 1 - 0;
            }
            else
            {
                    val_9 = 0;
            }
            
            if((val_8 & true) != 0)
            {
                goto label_12;
            }
            
            goto label_13;
            label_2:
            var val_8 = 1;
            val_8 = val_8 + 1;
            mem2[0] = 121;
            Dispose();
            label_29:
            if(val_8 != 1)
            {
                    var val_9 = 960471088 + ((1 + 1)) << 2;
                val_9 = val_9 - 123;
                val_9 = val_9 >> 5;
                val_10 = 0 & val_9;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
            label_13:
            val_9 = val_9 + 1;
            mem2[0] = 123;
            Dispose();
            goto label_29;
        }
        private void OnClick_Pause()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.blur.SetActive(value:  true);
            this.blurCanvas.DoBlur();
            this.pauseCanvas.enabled = true;
        }
        private void OnClick_Quit()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleHomeClicked(redirectToGameplay:  false);
        }
        private void OnClick_Resume()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.blur.SetActive(value:  false);
            this.blurCanvas.StopBlur();
            this.pauseCanvas.enabled = false;
        }
        public void SetOverlay(bool o)
        {
            this.overlay = o;
        }
        public UnityEngine.Transform GetGridPos(int x, int y)
        {
            if(true <= y)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (y << 2);
            if(((0 + (y) << 2) + 16) != 0)
            {
                    return (0 + (y) << 2) + 16.transform;
            }
            
            return (0 + (y) << 2) + 16.transform;
        }
        public WordFillUIController()
        {
            this.allLetters = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.spelling = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.usedPaths = null;
        }
    
    }

}
