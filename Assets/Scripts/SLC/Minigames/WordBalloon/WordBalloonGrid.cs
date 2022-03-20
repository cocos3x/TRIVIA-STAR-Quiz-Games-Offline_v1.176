using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonGrid : MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        private const int MINIMUM_LENGTH_PER_WORD = 2;
        private string flyoutMessageNoMovesLeft;
        private string flyoutMessageWrongWordSubmitted;
        private UnityEngine.GameObject gridColumnPrefab;
        private UnityEngine.GameObject letterSlotPrefab;
        private UnityEngine.GameObject letterTilePrefab;
        private UnityEngine.GameObject letterSlotGridParent;
        private UnityEngine.GameObject letterTileParent;
        private System.Collections.Generic.Dictionary<int, UnityEngine.UI.VerticalLayoutGroup> gridColumnCollection;
        private System.Collections.Generic.Dictionary<int, SLC.Minigames.WordBalloon.WordBalloonLetterSlot> letterSlotCollection;
        private int initialColumnCount;
        private System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> currentInputQueue;
        private bool isInputModeOn;
        public System.Action OnGridChanged;
        public System.Action<bool, string> OnWordProcessed;
        
        // Properties
        public System.Collections.Generic.Dictionary<int, SLC.Minigames.WordBalloon.WordBalloonLetterSlot> LetterSlots { get; }
        public bool IsInputModeOn { get; }
        
        // Methods
        public System.Collections.Generic.Dictionary<int, SLC.Minigames.WordBalloon.WordBalloonLetterSlot> get_LetterSlots()
        {
        
        }
        public bool get_IsInputModeOn()
        {
            return (bool)this.isInputModeOn;
        }
        private SLC.Minigames.WordBalloon.WordBalloonLetterSlot GetSlotFromUid(int id)
        {
            System.Collections.Generic.Dictionary<System.Int32, SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_5;
            var val_6;
            val_5 = this.letterSlotCollection;
            val_6 = 0;
            if((val_5.ContainsKey(key:  id)) == false)
            {
                    return;
            }
            
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_2 = this.letterSlotCollection.Item[id];
            val_5 = this.letterSlotCollection;
            val_6 = 0;
            if(val_5 == 0)
            {
                    return;
            }
            
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_4 = this.letterSlotCollection.Item[id];
            val_6 = this.letterSlotCollection;
        }
        private SLC.Minigames.WordBalloon.WordBalloonLetterSlot GetSlotFromLetterValue(string letter)
        {
            var val_6;
            Dictionary.Enumerator<TKey, TValue> val_1 = 0.GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_6 = 0;
            string val_3 = 23.ToLowerInvariant();
            string val_4 = letter.ToLowerInvariant();
            if((System.String.op_Equality(a:  23, b:  letter)) == false)
            {
                goto label_7;
            }
            
            goto label_8;
            label_2:
            val_6 = 0;
            label_8:
            0.Dispose();
        }
        private bool SlotHasLetterValue(SLC.Minigames.WordBalloon.WordBalloonLetterSlot comparisonSlot, string value)
        {
            if(comparisonSlot == 0)
            {
                    return false;
            }
            
            if(comparisonSlot.HasLetterTile == false)
            {
                    return false;
            }
            
            string val_3 = comparisonSlot.letterTile.value.ToLowerInvariant();
            string val_4 = value.ToLowerInvariant();
            return System.String.op_Equality(a:  comparisonSlot.letterTile.value, b:  value);
        }
        public void HighlightSlots(System.Collections.Generic.List<int> slotsToUse)
        {
            System.Collections.Generic.Dictionary<System.Int32, UnityEngine.UI.VerticalLayoutGroup> val_2;
            var val_3;
            val_2 = 35639379;
            val_3 = 0;
            goto label_1;
            label_6:
            if(true <= val_3)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_1 = this.GetSlotFromUid(id:  (0 + 0) + 16);
            val_2 = this.gridColumnCollection;
            val_2.Highlight();
            val_3 = 1;
            label_1:
            if(val_3 < val_2)
            {
                goto label_6;
            }
        
        }
        public System.Collections.Generic.List<int> GetSolvableSlotSequence()
        {
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_22 = 1152921514180672320;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_23 = 0;
            goto label_6;
            label_64:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_7 = this.GetSlotFromUid(id:  ((public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_20 + 24 + 8 + 0) + 16 + 12 + 8 + 0) + 16);
            val_24 =  + 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_8 = this.GetSlotFromUid(id:  ((public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_20 + 24 + 8 + 0) + 16 + 12 + 8 + 0) + 20);
            if((983964928 == 0) || (983964928 == 0))
            {
                goto label_62;
            }
            
            if((this.letterSlotPrefab == 0) || (this.letterSlotPrefab != this.flyoutMessageNoMovesLeft))
            {
                goto label_40;
            }
            
            val_26 = 0;
            val_27 = 1152921510204061312;
            goto label_55;
            label_40:
            if((this.letterTilePrefab == 0) || (this.letterTilePrefab != this.flyoutMessageNoMovesLeft))
            {
                goto label_47;
            }
            
            val_26 = 1;
            val_27 = 1152921510204061312;
            goto label_55;
            label_47:
            if((this.letterSlotGridParent == 0) || (this.letterSlotGridParent != this.flyoutMessageNoMovesLeft))
            {
                goto label_54;
            }
            
            val_26 = 2;
            val_27 = 1152921510204061312;
            goto label_55;
            label_54:
            if((this.letterTileParent == 0) || (this.letterTileParent != this.flyoutMessageNoMovesLeft))
            {
                goto label_61;
            }
            
            val_26 = 1;
            val_27 = 1152921510204061312;
            label_55:
            System.Nullable<System.Int32> val_15 = new System.Nullable<System.Int32>(value:  1);
            label_61:
            if(0 == 0)
            {
                goto label_62;
            }
            
            if(0 == 0)
            {
                    System.Nullable<System.Int32> val_17 = new System.Nullable<System.Int32>(value:  val_15.HasValue.Value);
            }
            
            if(val_17.HasValue.Value == val_15.HasValue.Value)
            {
                goto label_64;
            }
            
            label_62:
            val_23 = val_23 + 1;
            val_22 = 1152921514180672320;
            label_6:
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_21 = this.GetSolvableSlotSequenceByScanningGrid();
            val_25 = this;
        }
        private System.Collections.Generic.List<int> GetSolvableSlotSequenceByScanningGrid()
        {
            float val_6;
            var val_20;
            var val_21;
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<System.Int32> val_25;
            var val_26;
            var val_27;
            val_21 = 1152921514180672320;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_21 = mem[(public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16];
            val_21 = (public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            label_27:
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            if(0.HasLetterTile == false)
            {
                goto label_27;
            }
            
            string val_9 = 23.ToLowerInvariant();
            char val_10 = val_21.Chars[0];
            string val_11 = val_10.ToString();
            string val_12 = val_10.ToLowerInvariant();
            if((System.String.op_Equality(a:  23, b:  984116062)) == false)
            {
                goto label_27;
            }
            
            Add(item:  0);
            goto label_27;
            label_17:
            val_6.Dispose();
            if(1 != 1)
            {
                
            }
            
            val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_23 = 0;
            val_20 = mem[List<T>.__il2cppRuntimeField_10 + 28];
            val_20 = List<T>.__il2cppRuntimeField_10 + 28;
            val_22 = mem[List<T>.__il2cppRuntimeField_10 + 36];
            val_22 = List<T>.__il2cppRuntimeField_10 + 36;
            val_25 = null;
            val_25 = new System.Collections.Generic.List<System.Int32>();
            Add(item:  List<T>.__il2cppRuntimeField_10 + 12);
            System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
            Add(item:  List<T>.__il2cppRuntimeField_10 + 12);
            val_26 = 1;
            goto label_38;
            label_50:
            string val_17 = val_21.Chars[1].ToString();
            val_24;
            if((SlotHasLetterValue(comparisonSlot:  52, value:  984116062)) != false)
            {
                    if( != 0)
            {
                    Add(item:  52);
            }
            else
            {
                    Add(item:  52);
            }
            
                val_20 = 4;
            }
            
            if((SlotHasLetterValue(comparisonSlot:  val_22, value:  984116062)) != false)
            {
                    if(val_22 != 0)
            {
                    Add(item:  List<T>.__il2cppRuntimeField_10 + 36 + 12);
            }
            else
            {
                    Add(item:  List<T>.__il2cppRuntimeField_10 + 36 + 12);
            }
            
                val_22 = mem[List<T>.__il2cppRuntimeField_10 + 36 + 36];
                val_22 = List<T>.__il2cppRuntimeField_10 + 36 + 36;
            }
            
            val_26 = 2;
            label_38:
            val_27 = mem[(public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8];
            val_27 = (public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8;
            if(val_26 < val_27)
            {
                goto label_50;
            }
            
            if(val_25 == 0)
            {
                    val_27 = mem[(public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8];
                val_27 = (public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8;
            }
            
            if(null == 0)
            {
                    val_27 = mem[(public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8];
                val_27 = (public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 8;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_22 = 0.00128494f;
            val_25 = null;
        }
        private bool CheckSlotsLinkedInDirection(SLC.Minigames.WordBalloon.WordBalloonLetterSlot originSlot, SLC.Minigames.WordBalloon.WordBalloonLetterSlot destinationSlot, SLC.Minigames.WordBalloon.SlotDirection directionToCheck, out System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> slotsInPath)
        {
            SLC.Minigames.WordBalloon.LetterSlotLink val_6;
            UnityEngine.Object val_7;
            var val_8;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            SLC.Minigames.WordBalloon.SlotDirection val_2 = directionToCheck - 1;
            if(val_2 > 3)
            {
                goto label_2;
            }
            
            var val_3 = 13302376 + (13302376 + ((directionToCheck - 1)) << 2);
            if(val_2 == 3)
            {
                    13302376 = 13302376;
                13302376 = 13302376 & (destinationSlot >> 32);
                13302376 = 13302376 & ((IP) >> 32);
                13302376 = 13302376 & (destinationSlot >> 13302376);
            }
            
            val_6 = originSlot.SlotLink;
            goto label_6;
            label_2:
            val_6 = 0;
            val_7 = 0;
            goto label_12;
            label_6:
            val_7 = val_6;
            goto label_12;
            label_18:
            if((originSlot.<Uid>k__BackingField) == (destinationSlot.<Uid>k__BackingField))
            {
                goto label_10;
            }
            
            Add(item:  originSlot);
            val_6 = 0;
            val_7 = 0;
            if(val_2 <= 3)
            {
                    var val_4 = 13302552 + (13302552 + ((directionToCheck - 1)) << 2);
                if(val_2 == 3)
            {
                    13302552 = 13302552;
                13302552 = 13302552 & (val_2 << 13302552);
                13302552 = 13302552 & (13302552 >> 32);
                13302552 = 13302552 & (val_2 >> 32);
            }
            
                val_6 = originSlot.SlotLink;
                val_7 = val_6;
            }
            
            label_12:
            val_8 = 0;
            if(val_7 != 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_10:
            val_8 = 1;
            label_19:
            slotsInPath = null;
            return (bool)val_8;
        }
        public void RegisterSlotForInput(SLC.Minigames.WordBalloon.WordBalloonLetterSlot incomingSlot)
        {
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_17;
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_18;
            float val_19;
            var val_20;
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_21;
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_22;
            var val_23;
            val_17 = incomingSlot;
            typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = val_17;
            val_18 = this.currentInputQueue;
            if(val_18 == 0)
            {
                goto label_2;
            }
            
            if(new System.Object() <= 0)
            {
                goto label_3;
            }
            
            label_16:
            bool val_2 = val_18.Contains(item:  val_17);
            val_17 = this.currentInputQueue;
            if(val_2 == false)
            {
                goto label_4;
            }
            
            val_18 = null;
            val_18 = new System.Predicate<ZooTile>(object:  451649536, method:  new IntPtr(984374080));
            int val_4 = val_17.FindIndex(match:  8040448);
            if((val_4 - 1) <= val_4)
            {
                    return;
            }
            
            int val_6 = val_4 + 3;
            val_19 = 1152921514181162816;
            do
            {
                val_17 = val_6 - 4;
                if(val_4 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                0 + ((val_4 + 3)) << 2 + 40.ChangeState(incomingState:  0);
                val_18 = this.currentInputQueue;
                val_18.RemoveAt(index:  val_17);
                int val_7 = val_6 - 1;
            }
            while((val_6 - 5) > val_4);
            
            return;
            label_2:
            val_18 = this.currentInputQueue;
            val_17 = typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8;
            if(val_18 == 0)
            {
                    val_18 = 0;
            }
            
            if(35639383 > 0)
            {
                goto label_16;
            }
            
            label_3:
            val_20 = public System.Void System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot>::Add(SLC.Minigames.WordBalloon.WordBalloonLetterSlot item);
            goto label_17;
            label_4:
            if(val_2 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = 0;
            bool val_10 = this.CheckSlotsLinkedInDirection(originSlot:  2621443, destinationSlot:  typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8, directionToCheck:  2, slotsInPath: out  val_21);
            if(val_10 == true)
            {
                goto label_23;
            }
            
            bool val_12 = val_10.CheckSlotsLinkedInDirection(originSlot:  2621443, destinationSlot:  typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8, directionToCheck:  1, slotsInPath: out  val_21);
            if(val_12 == true)
            {
                goto label_23;
            }
            
            bool val_14 = val_12.CheckSlotsLinkedInDirection(originSlot:  2621443, destinationSlot:  typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8, directionToCheck:  4, slotsInPath: out  val_21);
            if((val_14 == true) || ((val_14.CheckSlotsLinkedInDirection(originSlot:  2621443, destinationSlot:  typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8, directionToCheck:  3, slotsInPath: out  val_21)) == true))
            {
                goto label_23;
            }
            
            return;
            label_30:
            val_22 = this.currentInputQueue;
            if(val_22 == 0)
            {
                    val_22 = 0;
            }
            
            if(val_21 >= 984428024)
            {
                goto label_26;
            }
            
            label_31:
            if(0 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = 0;
            val_19 = val_19 + 0;
            (0 + 0) + 16 + 40.ChangeState(incomingState:  0);
            val_23 = 1;
            label_23:
            val_22 = this.currentInputQueue;
            if(val_22 == 0)
            {
                goto label_30;
            }
            
            if(val_23 < ((0 + 0) + 16 + 40))
            {
                goto label_31;
            }
            
            label_26:
            val_22.Clear();
            val_18 = this.currentInputQueue;
            val_18.Add(item:  2621443);
            static_value_0028002B.ChangeState(incomingState:  1);
            if((val_21 != 0) && (0 >= 1))
            {
                    do
            {
                val_19 = 4 - 4;
                if(0 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_18 = 2621443;
                this.currentInputQueue.Add(item:  2621443);
                if(0 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                static_value_0028002B.ChangeState(incomingState:  1);
                var val_17 = 4 + 1;
            }
            while((4 - 3) < 0);
            
            }
            
            val_17 = typeof(WordBalloonGrid.<>c__DisplayClass26_0).__il2cppRuntimeField_8;
            val_20 = public System.Void System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot>::Add(SLC.Minigames.WordBalloon.WordBalloonLetterSlot item);
            label_17:
            this.currentInputQueue.Add(item:  val_17);
            incomingSlot + 40.ChangeState(incomingState:  1);
        }
        private void ResolveInput()
        {
            var val_20;
            var val_21;
            int val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_25;
            if(true < 2)
            {
                goto label_70;
            }
            
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.currentInputQueue != 0)
            {
                    val_21 = 0;
            }
            else
            {
                    val_21 = 0;
                val_20 = 0;
            }
            
            if(val_20 <= (-1))
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + 4294967292;
            val_22 = System.String.alignConst;
            val_23 = 0;
            goto label_12;
            label_18:
            var val_21 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_21 = val_21 + 0;
            string val_1 = val_22 + (0 + 0) + 16 + 40 + 20((0 + 0) + 16 + 40 + 20);
            val_23 = 1;
            val_22 = val_22;
            label_12:
            if(val_23 < val_22)
            {
                goto label_18;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((IsWordRequired(submittedWord:  val_22 =)) == false)
            {
                goto label_31;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((HasWordBeenSubmitted(submittedWord:  val_22)) == false)
            {
                goto label_35;
            }
            
            label_31:
            if(this.OnWordProcessed != 0)
            {
                    this.OnWordProcessed.Invoke(arg1:  false, arg2:  val_22);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_13 = System.String.Format(format:  this.flyoutMessageWrongWordSubmitted, arg0:  val_22);
            ShowFlyoutStatus(message:  this.flyoutMessageWrongWordSubmitted);
            label_70:
            val_24 = 0;
            goto label_40;
            label_46:
            if(this.currentInputQueue == 0)
            {
                goto label_41;
            }
            
            val_25 = this.currentInputQueue;
            if(val_24 >= this.flyoutMessageWrongWordSubmitted.m_firstChar)
            {
                goto label_48;
            }
            
            label_47:
            if(this.currentInputQueue <= val_24)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + 0;
            (0 + 0) + 16 + 40.ChangeState(incomingState:  0);
            val_24 = 1;
            label_40:
            val_25 = this.currentInputQueue;
            if(val_25 == 0)
            {
                goto label_46;
            }
            
            if(val_24 < ((0 + 0) + 16 + 40))
            {
                goto label_47;
            }
            
            goto label_48;
            label_41:
            val_25 = 0;
            label_48:
            val_25.Clear();
            return;
            label_35:
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            MarkWordAsFound(submittedWord:  val_22);
            this.RemoveSlotsFromGrid(slotsToRemove:  this.currentInputQueue);
            if(this.OnWordProcessed != 0)
            {
                    this.OnWordProcessed.Invoke(arg1:  true, arg2:  val_22);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_16 = this.GetSolvableSlotSequence();
            if(this != 0)
            {
                goto label_70;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowFlyoutStatus(message:  this.flyoutMessageNoMovesLeft);
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EndGame();
            goto label_70;
        }
        private void RemoveSlotsFromGrid(System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> slotsToRemove)
        {
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_28;
            var val_29;
            System.Comparison<SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_31;
            System.Collections.Generic.List<System.Int32> val_32;
            var val_33;
            var val_34;
            float val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            UnityEngine.Object val_41;
            var val_42;
            var val_43;
            var val_44;
            val_28 = slotsToRemove;
            val_29 = null;
            val_29 = null;
            val_31 = WordBalloonGrid.<>c.<>9__28_0;
            if(val_31 == 0)
            {
                    val_31 = null;
                val_31 = new System.Comparison<WordForest.NewsArticle>(object:  WordBalloonGrid.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(984809024));
                WordBalloonGrid.<>c.<>9__28_0 = val_31;
            }
            
            val_28.Sort(comparison:  7933952);
            val_32 = null;
            val_32 = new System.Collections.Generic.List<System.Int32>();
            val_33 = 0;
            goto label_7;
            label_85:
            if(val_32 <= val_33)
            {
                    var val_31 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_31 = val_31 + 0;
            if(((0 + 0) + 16) != 0)
            {
                    val_34 = mem[(0 + 0) + 16 + 24];
                val_34 = (0 + 0) + 16 + 24;
                val_35 = mem[(0 + 0) + 16 + 28];
                val_35 = (0 + 0) + 16 + 28;
                val_36 = mem[(0 + 0) + 16 + 36];
                val_36 = (0 + 0) + 16 + 36;
            }
            else
            {
                    val_34 = 0;
                val_35 = 7.286752E-44f;
                val_36 = 83886592;
            }
            
            if((((0 + 0) + 16 + 32) == 0) && (83886592 == 0))
            {
                    do
            {
                if(0 != 0)
            {
                    mem[28] = val_35;
            }
            
                if(52 != 0)
            {
                    mem[76] = val_34;
            }
            
                val_37 = 0;
                if(0 != 0)
            {
                    val_37 = 83886592;
            }
            
                val_38 = 0;
                if(52 != 0)
            {
                    val_38 = 0;
            }
            
            }
            while((83886592 != 0) || (0 != 0));
            
                Add(item:  mem[1152921514181620784]);
            }
            else
            {
                    if(83886592 != 0)
            {
                    mem[83886624] = (0 + 0) + 16 + 32;
            }
            
                if(((0 + 0) + 16 + 32) != 0)
            {
                    mem2[0] = val_36;
            }
            
                do
            {
                if(83886592 != 0)
            {
                    if(val_36 != 0)
            {
                    val_39 = val_36;
                val_40 = mem[83886612];
            }
            else
            {
                    mem[24] = val_34;
                mem[28] = val_35;
                val_39 = 20;
                val_40 = 1;
            }
            
                mem[20] = 0;
            }
            
                if(0 != 0)
            {
                    mem[28] = val_36;
            }
            
                if(52 != 0)
            {
                    mem[76] = val_36;
            }
            
                val_41 = 0;
                if(83886592 != 0)
            {
                    val_41 = mem[83886628];
            }
            
                val_42 = 0;
                if(0 != 0)
            {
                    val_42 = 83886592;
            }
            
                val_43 = 0;
                if(52 != 0)
            {
                    val_43 = 0;
            }
            
            }
            while(((83886592 != 0) || (0 != 0)) || (val_41 != 0));
            
            }
            
            val_32 = val_32;
            val_28 = val_28;
            val_33 = val_33 + 1;
            label_7:
            if(val_33 < (slotsToRemove + 12))
            {
                goto label_85;
            }
            
            if((slotsToRemove + 12) >= 1)
            {
                    do
            {
                var val_22 = 4 - 4;
                if((slotsToRemove + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_23 = mem[1152921514181620780].Remove(key:  slotsToRemove + 8 + 16 + 12);
                if((slotsToRemove + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = val_32;
                UnityEngine.GameObject val_24 = slotsToRemove + 8 + 16 + 40.gameObject;
                UnityEngine.Object.Destroy(obj:  slotsToRemove + 8 + 16 + 40);
                if((slotsToRemove + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.GameObject val_25 = slotsToRemove + 8 + 16.gameObject;
                UnityEngine.Object.Destroy(obj:  slotsToRemove + 8 + 16);
                var val_26 = 4 + 1;
            }
            while((4 - 3) < (slotsToRemove + 12));
            
            }
            
            val_44 = 4;
            if(mem[1152921514181620796] == 0)
            {
                    return;
            }
            
            mem[1152921514181620796].Invoke();
        }
        public void CreateGrid(System.Collections.Generic.List<string> letterTileData, int columnLimit)
        {
            var val_16;
            var val_17;
            System.Collections.Generic.List<System.String> val_18;
            System.Collections.Generic.Dictionary<System.Int32, SLC.Minigames.WordBalloon.WordBalloonLetterSlot> val_19;
            SLC.Minigames.WordBalloon.WordBalloonGrid val_20;
            var val_18 = 0;
            this.initialColumnCount = columnLimit;
            if(columnLimit >= 1)
            {
                    val_16 = 1152921514181716928;
                do
            {
                UnityEngine.UI.VerticalLayoutGroup val_1 = this.CreateGridColumn();
                this.gridColumnCollection.Add(key:  0, value:  984985984);
                val_18 = val_18 + 1;
            }
            while(columnLimit != val_18);
            
            }
            
            val_17 = 4;
            val_18 = letterTileData;
            goto label_4;
            label_16:
            if(columnLimit <= this)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.IsNullOrEmpty(value:  letterTileData + 8 + 16)) != true)
            {
                    float val_19 = 9.84986E+08f;
                val_19 = val_19 / (float)columnLimit;
                UnityEngine.UI.VerticalLayoutGroup val_4 = this.gridColumnCollection.Item[columnLimit];
                UnityEngine.Transform val_5 = this.gridColumnCollection.transform;
                SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_6 = this.CreateLetterSlot(uid:  1152921514181716928, colId:  columnLimit, rowId:  UnityEngine.Mathf.FloorToInt(f:  val_19), parent:  this.gridColumnCollection);
                val_18 = letterTileData;
                if((letterTileData + 12) <= this)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                SLC.Minigames.WordBalloon.WordBalloonLetterTile val_7 = this.CreateLetterTile(slot:  984985984, letterValue:  letterTileData + 8 + 16);
                if(this != 0)
            {
                    this.gridColumnCollection = this;
                val_19 = this.letterSlotCollection;
            }
            else
            {
                    mem[40] = this;
                val_19 = this.letterSlotCollection;
            }
            
                val_19.Add(key:  this.flyoutMessageNoMovesLeft, value:  984985984);
            }
            
            val_17 = 5;
            label_4:
            val_20 = val_17 - 4;
            if(val_20 < (letterTileData + 12))
            {
                goto label_16;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_8 = val_18.GetEnumerator();
            int val_20 = columnLimit;
            val_20 = val_20 - 1;
            goto label_18;
            label_22:
            val_16 = val_18;
            val_20 = 0;
            val_18 = 0;
            if(columnLimit != 0)
            {
                    SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_10 = this.GetSlotFromUid(id:  0 - 1);
                val_18 = this;
            }
            
            if(columnLimit != val_20)
            {
                    SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_12 = this.GetSlotFromUid(id:  0 + 1);
                val_20 = this;
            }
            
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_14 = this.GetSlotFromUid(id:  0 - columnLimit);
            SLC.Minigames.WordBalloon.WordBalloonLetterSlot val_16 = this.GetSlotFromUid(id:  0 + columnLimit);
            mem[24] = val_18;
            mem[28] = val_20;
            mem[32] = this;
            mem[36] = this;
            label_18:
            if(val_18.MoveNext() == true)
            {
                goto label_22;
            }
            
            val_18.Dispose();
        }
        private SLC.Minigames.WordBalloon.WordBalloonLetterSlot CreateLetterSlot(int uid, int colId, int rowId, UnityEngine.Transform parent)
        {
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterSlotPrefab, parent:  parent);
            string val_2 = 985110848 + 13152256;
            if(this.letterSlotPrefab != 0)
            {
                    this.letterSlotPrefab.name = 985110848;
            }
            else
            {
                    0.name = 985110848;
            }
            
            object val_3 = this.letterSlotPrefab.GetComponent<System.Object>();
            mem2[0] = uid;
            mem2[0] = colId;
            mem2[0] = rowId;
        }
        private SLC.Minigames.WordBalloon.WordBalloonLetterTile CreateLetterTile(SLC.Minigames.WordBalloon.WordBalloonLetterSlot slot, string letterValue)
        {
            UnityEngine.Transform val_1 = this.letterTileParent.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTilePrefab, parent:  this.letterTileParent);
            string val_3 = System.String.Format(format:  985248544, arg0:  13152256, arg1:  letterValue);
            if(this.letterTilePrefab != 0)
            {
                    this.letterTilePrefab.name = 985248544;
            }
            else
            {
                    0.name = 985248544;
            }
            
            object val_4 = this.letterTilePrefab.GetComponent<System.Object>();
            this.letterTilePrefab.Initialize(slotToAttachTo:  slot, letter:  letterValue);
        }
        private UnityEngine.UI.VerticalLayoutGroup CreateGridColumn()
        {
            UnityEngine.Transform val_1 = this.letterSlotGridParent.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.gridColumnPrefab, parent:  this.letterSlotGridParent);
            if(this.gridColumnPrefab != 0)
            {
                    return this.gridColumnPrefab.GetComponent<System.Object>();
            }
            
            return this.gridColumnPrefab.GetComponent<System.Object>();
        }
        public void ClearGrid()
        {
            UnityEngine.Object val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            UnityEngine.GameObject val_5 = val_4 + 40.gameObject;
            UnityEngine.Object.Destroy(obj:  val_4 + 40);
            UnityEngine.GameObject val_6 = val_4.gameObject;
            UnityEngine.Object.Destroy(obj:  val_4);
            goto label_7;
            label_2:
            0.Dispose();
            this.letterSlotCollection.Clear();
            Dictionary.Enumerator<TKey, TValue> val_7 = 0.GetEnumerator();
            label_14:
            if(0.MoveNext() == false)
            {
                goto label_10;
            }
            
            UnityEngine.GameObject val_9 = 0.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_14;
            label_10:
            0.Dispose();
            mem[1152921514182322296].Clear();
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isInputModeOn = true;
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isInputModeOn = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_10) != 1)
            {
                    return;
            }
            
            R4.ResolveInput();
        }
        public WordBalloonGrid()
        {
            this.flyoutMessageNoMovesLeft = "<b><size=90>No Moves Left</size></b>\nPlan ahead to identify every word!";
            this.flyoutMessageWrongWordSubmitted = "{0} is not used in this level";
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.gridColumnCollection = null;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.letterSlotCollection = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.currentInputQueue = null;
        }
    
    }

}
