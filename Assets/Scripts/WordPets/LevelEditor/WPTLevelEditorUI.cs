using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WPTLevelEditorUI : MonoSingleton<WordPets.LevelEditor.WPTLevelEditorUI>
    {
        // Fields
        private UnityEngine.UI.Button testLevelButton;
        private UnityEngine.UI.Button resetLevelButton;
        private UnityEngine.UI.Button saveLevelButton;
        private UnityEngine.UI.Button displayDiffButton;
        private UnityEngine.UI.InputField chooseLevel;
        private UnityEngine.GameObject ColDataDisplay;
        public WordPets.LevelEditor.WPTLEColInformation colInfoDisplay;
        private UnityEngine.RectTransform AddColButton;
        private UnityEngine.Transform parentTransform;
        private WordPets.WPTLevelData <curData>k__BackingField;
        public System.Collections.Generic.Dictionary<WordPets.WPTGameColumn, UnityEngine.GameObject> colButtons;
        private UnityEngine.UI.Text curPetsRequiredText;
        
        // Properties
        public WordPets.WPTLevelData curData { get; set; }
        
        // Methods
        public WordPets.WPTLevelData get_curData()
        {
        
        }
        private void set_curData(WordPets.WPTLevelData value)
        {
            this.<curData>k__BackingField = value;
        }
        private void Update()
        {
            bool val_1 = UnityEngine.Input.GetKeyDown(key:  32);
        }
        public override void InitMonoSingleton()
        {
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  228956352, method:  new IntPtr(228908800));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4, b:  7454720);
            val_8 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_6;
            }
            
            }
            
            val_8 = 0;
            label_6:
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4 = val_8;
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  228956352, method:  new IntPtr(228918016));
            this.testLevelButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  228956352, method:  new IntPtr(228927232));
            this.chooseLevel.m_OnEndEdit.AddListener(call:  162353152);
            Player val_6 = App.Player;
            string val_7 = 0.ToString();
            this.chooseLevel.text = 228944316;
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.SetEnabled(enabled:  false, updateMusic:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.SetEnabled(enabled:  false, isTracking:  true);
        }
        private void BuildUI()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(isInEditMode == false)
            {
                    return;
            }
            
            if(this.parentTransform != 0)
            {
                    UnityEngine.GameObject val_4 = this.parentTransform.gameObject;
                UnityEngine.Object.Destroy(obj:  this.parentTransform);
                this.parentTransform = 0;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.<curData>k__BackingField = null;
            UnityEngine.Transform val_7 = transform;
            this.parentTransform = new UnityEngine.GameObject();
            UnityEngine.Transform val_8 = this.transform;
            SetParent(parent:  229213120, worldPositionStays:  false);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.parentTransform.localPosition = new UnityEngine.Vector3();
            this.UpdatePetRequiredText();
            this.RefreshRowButtons(delay:  val_9.x);
            this.CheckDiff();
        }
        private void UpdatePetRequiredText()
        {
            string val_2 = this.<curData>k__BackingField.petsRequired.ToString();
            if(this.curPetsRequiredText != 0)
            {
                    return;
            }
        
        }
        public void UpdatePetsRequired(int petShift)
        {
        
        }
        public void RefreshRowButtons(float delay = 0)
        {
            UnityEngine.GameObject val_1 = this.AddColButton.gameObject;
            this.AddColButton.SetActive(value:  false);
            this.StopAllCoroutines();
            System.Collections.IEnumerator val_2 = this.WaitThenRefreshRowButtons(startDelay:  delay);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  229581888);
        }
        public System.Collections.IEnumerator WaitThenRefreshRowButtons(float startDelay = 0)
        {
            typeof(WPTLevelEditorUI.<WaitThenRefreshRowButtons>d__22).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTLevelEditorUI.<WaitThenRefreshRowButtons>d__22).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(WPTLevelEditorUI.<WaitThenRefreshRowButtons>d__22).__il2cppRuntimeField_10 = R1;
        }
        public void TryDeleteButtons()
        {
            WordPets.WPTGameColumn val_4;
            Dictionary.KeyCollection<TKey, TValue> val_1 = this.colButtons.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_5 = this.colButtons.Item[val_4];
            UnityEngine.GameObject val_6 = this.colButtons.gameObject;
            UnityEngine.Object.Destroy(obj:  this.colButtons);
            goto label_8;
            label_3:
            Dispose();
        }
        public void AddCol()
        {
            this.TryDeleteButtons();
            System.Collections.IEnumerator val_1 = this.ActuallyAddCol();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  229947584);
            UnityEngine.GameObject val_3 = this.AddColButton.gameObject;
            this.AddColButton.SetActive(value:  false);
        }
        private System.Collections.IEnumerator ActuallyAddCol()
        {
            object val_1 = new System.Object();
            typeof(WPTLevelEditorUI.<ActuallyAddCol>d__25).__il2cppRuntimeField_8 = 0;
            typeof(WPTLevelEditorUI.<ActuallyAddCol>d__25).__il2cppRuntimeField_10 = this;
        }
        private void AddColInformation(WordPets.WPTGameColumn row)
        {
            float val_8;
            float val_9;
            float val_10;
            float val_16;
            float val_20;
            float val_22;
            float val_23;
            UnityEngine.GameObject val_29;
            WordPets.WPTGameColumn val_30;
            var val_31;
            var val_32;
            if(new System.Object() != 0)
            {
                    typeof(WPTLevelEditorUI.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WPTLevelEditorUI.<>c__DisplayClass26_0).__il2cppRuntimeField_C = row;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ColDataDisplay, parent:  this.parentTransform);
            val_29 = this.ColDataDisplay;
            UnityEngine.Transform val_3 = val_29.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_29.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_5 = val_29.transform;
            val_30 = typeof(WPTLevelEditorUI.<>c__DisplayClass26_0).__il2cppRuntimeField_C;
            if((row + 16 + 12) >= 1)
            {
                    if((row + 16 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30 = mem[row + 16 + 8 + 16];
                val_30 = row + 16 + 8 + 16;
            }
            
            UnityEngine.Transform val_6 = val_30.transform;
            UnityEngine.Vector3 val_7 = position;
            val_29.position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
            if(val_29 != 0)
            {
                    object val_11 = val_29.GetComponent<System.Object>();
                val_31 = val_29;
            }
            else
            {
                    object val_12 = val_29.GetComponent<System.Object>();
                val_31 = val_29;
            }
            
            object val_13 = val_29.GetComponent<System.Object>();
            UnityEngine.Vector2 val_14 = anchoredPosition;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1.135833E-30f, y = val_16}, d:  val_15.x);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 1.135832E-30f, y = val_8}, b:  new UnityEngine.Vector2() {x = val_9, y = val_20});
            val_31.anchoredPosition = new UnityEngine.Vector2() {x = val_22, y = val_23};
            object val_24 = val_29.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_25 = new UnityEngine.Events.UnityAction(object:  402980864, method:  new IntPtr(230163968));
            val_31.AddListener(call:  162246656);
            this.colButtons.Add(key:  typeof(WPTLevelEditorUI.<>c__DisplayClass26_0).__il2cppRuntimeField_C, value:  val_29);
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(isInEditMode == false)
            {
                    return;
            }
            
            val_32 = 0;
            goto label_33;
            label_48:
            val_29 = mem[row + 20 + 28];
            val_29 = row + 20 + 28;
            if(val_32 >= (row + 20 + 28 + 8))
            {
                    return;
            }
            
            if((row + 20 + 28.Chars[0]) == ('-'))
            {
                    if((row + 16 + 12) <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_29 = row + 16 + 8;
                val_29 = val_29 + 0;
            }
            
            val_32 = 1;
            label_33:
            val_29 = mem[row + 16];
            val_29 = row + 16;
            if(val_32 < (row + 16 + 12))
            {
                goto label_48;
            }
        
        }
        public void EditLevel()
        {
            UnityEngine.GameObject val_1 = this.saveLevelButton.gameObject;
            this.saveLevelButton.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.testLevelButton.gameObject;
            this.testLevelButton.SetActive(value:  true);
        }
        public void TestLevel()
        {
            this.TryDeleteButtons();
            UnityEngine.GameObject val_1 = this.AddColButton.gameObject;
            this.AddColButton.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.saveLevelButton.gameObject;
            this.saveLevelButton.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LoadGame(mode:  0);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init(incData:  this.<curData>k__BackingField);
            this.CheckDiff();
        }
        public void IndexLevel(int move)
        {
            Player val_1 = App.Player;
            var val_4 = 0;
            val_4 = val_4 + move;
            if(val_4 < 1)
            {
                    return;
            }
            
            Player val_2 = App.Player;
            this.ChangeLevel(newLevel:  0 + move);
        }
        public void ChangeLevel()
        {
            if((System.Int32.TryParse(s:  this.chooseLevel.m_Text, result: out  int val_1 = 230695628)) == false)
            {
                    return;
            }
            
            this.ChangeLevel(newLevel:  0);
        }
        public void ChangeLevel(string newLevel)
        {
            if((System.Int32.TryParse(s:  newLevel, result: out  int val_1 = 230819916)) == false)
            {
                    return;
            }
            
            this.ChangeLevel(newLevel:  0);
        }
        public void ChangeLevel(int newLevel)
        {
            if(newLevel < 1)
            {
                    return;
            }
            
            UnityEngine.GameObject val_1 = this.AddColButton.gameObject;
            this.AddColButton.SetActive(value:  false);
            this.TryDeleteButtons();
            Player val_2 = App.Player;
            Player val_3 = App.Player;
            string val_4 = 0.ToString();
            this.chooseLevel.text = 230944196;
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            35636654 = public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance();
            WordPets.WPTLevelData val_6 = GetLevelData(level:  newLevel);
            this.<curData>k__BackingField = 35636654;
            Player val_7 = App.Player;
            this.TestLevel();
            this.CheckDiff();
        }
        public void ResetLevelData()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_2 = App.Player;
            WordPets.WPTLevelData val_3 = GetLevelData(level:  0);
            this.<curData>k__BackingField = new WordPets.WPTLevelData(copyData:  -801937664);
            this.TestLevel();
        }
        public void SaveLevel()
        {
            string val_1 = this.getDiff();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Player val_3 = App.Player;
            UpdateLevelData(level:  0, newData:  this.<curData>k__BackingField);
            this.CheckDiff();
        }
        public void DisplayChapterData()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DisplayChapterData();
        }
        private void TestInTestMode()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SwitchToPlayMode();
        }
        public void CheckDiff()
        {
            var val_8;
            string val_1 = this.getDiff();
            UnityEngine.GameObject val_3 = this.saveLevelButton.gameObject;
            if((System.String.op_Equality(a:  231553088, b:  System.String.alignConst)) != false)
            {
                    this.saveLevelButton.SetActive(value:  false);
                UnityEngine.GameObject val_4 = this.resetLevelButton.gameObject;
                this.resetLevelButton.SetActive(value:  false);
                UnityEngine.GameObject val_5 = this.displayDiffButton.gameObject;
                val_8 = 0;
            }
            else
            {
                    this.saveLevelButton.SetActive(value:  true);
                UnityEngine.GameObject val_6 = this.resetLevelButton.gameObject;
                this.resetLevelButton.SetActive(value:  true);
                UnityEngine.GameObject val_7 = this.displayDiffButton.gameObject;
                val_8 = 1;
            }
            
            this.displayDiffButton.SetActive(value:  true);
        }
        public string getDiff()
        {
            WordPets.LevelEditor.WPTLevelEditorUI val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_18 = this;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_2 = App.Player;
            WordPets.WPTLevelData val_3 = GetLevelData(level:  0);
            val_19 = public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance();
            System.Text.StringBuilder val_4 = new System.Text.StringBuilder();
            if((this.<curData>k__BackingField.petsRequired) != petsRequired)
            {
                    int val_7 = petsRequired;
                int val_8 = this.<curData>k__BackingField.petsRequired;
                string val_9 = System.String.Format(format:  231665664, arg0:  13152256, arg1:  13152256);
                System.Text.StringBuilder val_10 = AppendLine(value:  231665664);
                val_18 = val_18;
                val_19 = val_19;
            }
            
            val_20 = null;
            val_21 = null;
            val_22 = "Total cols reduced! from {0} to {1}";
            string val_11 = System.String.Format(format:  231682336, arg0:  13152256, arg1:  13152256);
            System.Text.StringBuilder val_12 = AppendLine(value:  231682336);
            val_18 = val_18;
            val_19 = val_19;
            val_23 = 4;
            goto label_29;
            label_45:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance().__il2cppRuntimeField_8 + 8 + 16 + 16) != 0)
            {
                    public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance().__il2cppRuntimeField_8 + 8 + 16 + 16 = 1;
            }
            
            if(static_value_00280013 == true)
            {
                    static_value_00280013 = 1;
            }
            
            if(1 != 1)
            {
                    string val_13 = System.String.Format(format:  231686576, arg0:  13152256, arg1:  8945664, arg2:  8945664);
                System.Text.StringBuilder val_14 = AppendLine(value:  231686576);
                val_18 = val_18;
                val_19 = val_19;
            }
            
            if((System.String.op_Inequality(a:  public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance().__il2cppRuntimeField_8 + 8 + 16 + 28, b:  5890)) != false)
            {
                    string val_16 = System.String.Format(format:  231686736, arg0:  13152256, arg1:  public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance().__il2cppRuntimeField_8 + 8 + 16 + 28, arg2:  5890);
                System.Text.StringBuilder val_17 = AppendLine(value:  231686736);
            }
            
            val_23 = 5;
            label_29:
            if((val_23 - 4) < val_4)
            {
                goto label_45;
            }
            
            if(val_4 != 0)
            {
                    return;
            }
        
        }
        public WPTLevelEditorUI()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.colButtons = null;
        }
    
    }

}
