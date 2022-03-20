using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class WGSnakesAndLaddersBoardUI : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.ScrollRect boardScrollRect;
        private System.Collections.Generic.List<UnityEngine.Transform> boards;
        private UnityEngine.GameObject boardSpacePrefab;
        private UnityEngine.GameObject pawnPrefab;
        private float pawnMoveDurationInSec;
        private SnakesAndLaddersEvent.Board currentBoard;
        private UnityEngine.GameObject pawn;
        private UnityEngine.Transform board;
        private System.Collections.Generic.List<float> scrollPositions;
        private FrameSkipper frameSkipper;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  682109312);
            this.frameSkipper = this;
        }
        private void OnEnable()
        {
            this.UpdateBoard(forceUpdateBoard:  0);
        }
        public SnakesAndLaddersBoardSpace GetBoardSpace(int num)
        {
            object val_1 = new System.Object();
            typeof(WGSnakesAndLaddersBoardUI.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = num;
            T[] val_2 = this.board.GetComponentsInChildren<System.Object>();
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  this.board);
            System.Predicate<ZooTile> val_4 = new System.Predicate<ZooTile>(object:  432746496, method:  new IntPtr(682315456));
            if(this.board != 0)
            {
                    return this.board.Find(match:  8040448);
            }
            
            return this.board.Find(match:  8040448);
        }
        public void UpdateBoard(SnakesAndLaddersEvent.Board forceUpdateBoard)
        {
            UnityEngine.Object val_6;
            SnakesAndLaddersEvent.Board val_17;
            var val_18;
            var val_19;
            SnakesAndLaddersEventHandler val_20;
            UnityEngine.Transform val_21;
            float val_22;
            var val_23;
            var val_24;
            val_17 = forceUpdateBoard;
            if(mem[1152921513879245344] != 0)
            {
                    if(mem[1152921513879245344].IsFinished() == false)
            {
                    return;
            }
            
            }
            
            if(val_17 != 0)
            {
                    val_19 = mem[1152921513879245328];
                mem[1152921513879245344] = val_17;
            }
            else
            {
                    var val_17 = 19730840;
                val_17 = 15894952 + val_17;
                if(val_17 == 0)
            {
                    mem2[0] = 1;
            }
            
                SnakesAndLaddersEvent.Board val_2 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetCurrentBoard();
                val_20 = SnakesAndLaddersEventHandler.<Instance>k__BackingField;
                val_19 = mem[1152921513879245328];
                mem[1152921513879245344] = val_20;
                if(val_20 == 0)
            {
                    val_20 = 0;
            }
            
            }
            
            int val_3 = val_20.GetIndex();
            if((mem[1152921513879245328] + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = mem[1152921513879245328] + 8;
            val_18 = val_18 + (val_3 << 2);
            val_21 = mem[1152921513879245328];
            mem[1152921513879245352] = (mem[1152921513879245328] + 8 + (val_3) << 2) + 16;
            List.Enumerator<T> val_4 = GetEnumerator();
            val_22 = 1152921513287257664;
            label_18:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            UnityEngine.GameObject val_7 = val_6.gameObject;
            UnityEngine.GameObject val_8 = val_6.gameObject;
            UnityEngine.GameObject val_9 = mem[1152921513879245352].gameObject;
            val_6.SetActive(value:  UnityEngine.Object.op_Equality(x:  val_6, y:  mem[1152921513879245352]));
            goto label_18;
            label_11:
            Dispose();
            object val_11 = mem[1152921513879245352].GetComponent<System.Object>();
            mem2[0] = mem[1152921513879245352];
            this.SetupScrollPositions();
            val_23 = 0;
            MethodExtensionForMonoBehaviourTransform.DestroyChildrenImmediate(t:  mem[1152921513879245352]);
            val_18 = 5;
            val_24 = 0;
            goto label_21;
            label_34:
            do
            {
                if(0 == 0)
            {
                    val_18 = val_23 + 0;
            }
            
                if((SnakesAndLaddersEventHandler.<Instance>k__BackingField + 8 + 12 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_19 = SnakesAndLaddersEventHandler.<Instance>k__BackingField + 8 + 12 + 8;
                val_19 = val_19 + (val_18 << 2);
                UnityEngine.Transform val_12 = mem[1152921513879245352].transform;
                val_21 = mem[1152921513879245352];
                object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921513879245332], parent:  val_21);
                object val_14 = mem[1152921513879245332].GetComponent<System.Object>();
                val_22 = 0 + 1;
                mem2[0] = (SnakesAndLaddersEventHandler.<Instance>k__BackingField + 8 + 12 + 8 + ((val_23 + 0)) << 2) + 16;
            }
            while(val_22 != 6);
            
            val_23 = 6;
            val_18 = 11;
            val_24 = 1;
            label_21:
            var val_20 = SnakesAndLaddersEventHandler.<Instance>k__BackingField + 8 + 8;
            val_20 = val_20 + (val_20 >> 31);
            if(val_24 < val_20)
            {
                goto label_34;
            }
            
            System.Collections.IEnumerator val_15 = this.ShowTargetArea();
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  682463744);
        }
        public void MovePawn(int start, int end, int final, System.Action onPawnLanded)
        {
            System.Collections.IEnumerator val_1 = this.MovePawnAndScrollCoroutine(start:  start, end:  end, final:  final, onPawnLanded:  onPawnLanded);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  682583936);
        }
        private void SetupScrollPositions()
        {
            float val_4;
            SnakesAndLaddersEvent.Board val_5;
            var val_6;
            var val_7;
            System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
            this.scrollPositions = null;
            val_4 = (1.396984E-09f) * 0.7f;
            this.scrollPositions.Add(item:  val_4);
            if(this.currentBoard.Definition.MaxSpaceCount < 12)
            {
                goto label_4;
            }
            
            label_13:
            if(715827883 != 2)
            {
                goto label_5;
            }
            
            val_5 = this.currentBoard;
            if(val_5.GetIndex() != 3)
            {
                goto label_7;
            }
            
            val_6 = 1064933786;
            goto label_8;
            label_5:
            val_5 = 2 - 1;
            val_4 = (1.396984E-09f) * (float)val_5;
            val_7 = val_4;
            goto label_10;
            label_7:
            val_5 = this.currentBoard;
            if(val_5.GetIndex() == 4)
            {
                    val_6 = 1064933786;
            }
            
            label_8:
            val_7 = 1064933786;
            label_10:
            this.scrollPositions.Add(item:  val_4);
            var val_4 = 2 + 1;
            if(2 < 715827883)
            {
                goto label_13;
            }
            
            label_4:
            this.scrollPositions.Add(item:  val_4);
        }
        private System.Collections.IEnumerator ShowTargetArea()
        {
            object val_1 = new System.Object();
            typeof(WGSnakesAndLaddersBoardUI.<ShowTargetArea>d__16).__il2cppRuntimeField_8 = 0;
            typeof(WGSnakesAndLaddersBoardUI.<ShowTargetArea>d__16).__il2cppRuntimeField_10 = this;
        }
        private void SpawnPawn(int num)
        {
            UnityEngine.Transform val_1 = this.boardScrollRect.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.pawnPrefab, parent:  this.boardScrollRect);
            this.pawn = this.pawnPrefab;
            UnityEngine.Transform val_3 = this.pawnPrefab.transform;
            SnakesAndLaddersBoardSpace val_4 = this.GetBoardSpace(num:  num);
            UnityEngine.Transform val_5 = this.transform;
            this.pawnPrefab.parent = 682993664;
            UnityEngine.Transform val_6 = this.pawn.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.pawn.localPosition = new UnityEngine.Vector3();
        }
        private int GetRowIndex(int spaceNum)
        {
            int val_1 = spaceNum - 1;
            val_1 = val_1 + (val_1 >> 31);
            return (int)val_1;
        }
        private bool IsDifferentRow(int num1, int num2)
        {
            int val_1 = num2 - 1;
            num1 = num1 - 1;
            val_1 = val_1 + (val_1 >> 31);
            num1 = num1 + (num1 >> 31);
            val_1 = num1 - val_1;
            if()
            {
                    val_1 = 1;
            }
            
            return true;
        }
        private System.Collections.IEnumerator ScrollToPosition(int startSpace, int endSpace)
        {
            typeof(WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20).__il2cppRuntimeField_10 = this;
                typeof(WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20).__il2cppRuntimeField_14 = startSpace;
            }
            else
            {
                    mem[16] = this;
                mem[20] = startSpace;
            }
            
            typeof(WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20).__il2cppRuntimeField_18 = endSpace;
        }
        private void StartScrolling(bool fromBottomToTop, float targetScrollPosition, float interpolation)
        {
            var val_8;
            var val_8 = R3;
            float val_1 = this.boardScrollRect.verticalNormalizedPosition;
            val_8 = this.boardScrollRect + val_8;
            if(fromBottomToTop != false)
            {
                    val_8 = val_8;
                float val_3 = UnityEngine.Mathf.Min(a:  this.boardScrollRect, b:  interpolation);
            }
            else
            {
                    val_8 = val_8;
            }
            
            this.boardScrollRect.verticalNormalizedPosition = UnityEngine.Mathf.Max(a:  this.boardScrollRect, b:  interpolation);
            float val_5 = this.boardScrollRect.verticalNormalizedPosition;
            if(this.boardScrollRect > 0)
            {
                    float val_6 = this.boardScrollRect.verticalNormalizedPosition;
                if(this.boardScrollRect < 0)
            {
                    float val_7 = this.boardScrollRect.verticalNormalizedPosition;
                if(this.boardScrollRect != 0)
            {
                    return;
            }
            
            }
            
            }
            
            this.frameSkipper.updateLogic = 0;
        }
        private void SnapToPosition(int spaceNum)
        {
            int val_1 = spaceNum - 1;
            int val_2 = val_1 + (val_1 >> 31);
            if(val_1 <= val_2)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_2 << 2);
            this.boardScrollRect.verticalNormalizedPosition = null;
        }
        private void SetPawnOnTop()
        {
            UnityEngine.Transform val_1 = this.pawn.transform;
            UnityEngine.Transform val_2 = this.transform;
            this.pawn.parent = 683747584;
        }
        private System.Collections.IEnumerator MovePawnAndScrollCoroutine(int start, int end, int final, System.Action onPawnLanded)
        {
            typeof(WGSnakesAndLaddersBoardUI.<MovePawnAndScrollCoroutine>d__24).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WGSnakesAndLaddersBoardUI.<MovePawnAndScrollCoroutine>d__24).__il2cppRuntimeField_1C = final;
            }
            else
            {
                    mem[16] = this;
                mem[20] = start;
                mem[24] = end;
                mem[28] = final;
            }
            
            typeof(WGSnakesAndLaddersBoardUI.<MovePawnAndScrollCoroutine>d__24).__il2cppRuntimeField_20 = onPawnLanded;
        }
        public WGSnakesAndLaddersBoardUI()
        {
            this.pawnMoveDurationInSec = 0.5f;
        }
    
    }

}
