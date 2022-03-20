using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIPathFinding
    {
        // Fields
        public const int MAX_LINES = 3;
        private SLC.MatchyPics.MPINode[,] nodes;
        private int <Width>k__BackingField;
        private int <Height>k__BackingField;
        private SLC.MatchyPics.MPINode startNode;
        private SLC.MatchyPics.MPINode endNode;
        
        // Properties
        public int Width { get; set; }
        public int Height { get; set; }
        
        // Methods
        public int get_Width()
        {
            return (int)this.<Width>k__BackingField;
        }
        private void set_Width(int value)
        {
            this.<Width>k__BackingField = value;
        }
        public int get_Height()
        {
            return (int)this.<Height>k__BackingField;
        }
        private void set_Height(int value)
        {
            this.<Height>k__BackingField = value;
        }
        public SLC.MatchyPics.MPINode RandomNode()
        {
            return this.GetNode(x:  UnityEngine.Random.Range(min:  0, max:  this.<Width>k__BackingField), y:  UnityEngine.Random.Range(min:  0, max:  this.<Height>k__BackingField));
        }
        public void LoadBoard(int[,] board)
        {
            var val_5;
            var val_6;
            int val_7;
            var val_10;
            val_5 = this;
            int val_1 = board.GetUpperBound(dimension:  0);
            val_1 = val_1 + 1;
            this.<Width>k__BackingField = val_1;
            val_6 = 0;
            this.<Height>k__BackingField = (board.GetUpperBound(dimension:  1)) + 1;
            this.nodes = null;
            val_7 = this.<Height>k__BackingField;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_6 = 0;
                do
            {
                typeof(SLC.MatchyPics.MPINode).__il2cppRuntimeField_14 = 2;
                typeof(SLC.MatchyPics.MPINode).__il2cppRuntimeField_8 = val_6;
                typeof(SLC.MatchyPics.MPINode).__il2cppRuntimeField_C = val_6;
                val_5 = val_5;
                this.nodes[new System.Object()] = null;
                SLC.MatchyPics.MPINode val_5 = this.nodes[this.nodes[new System.Object()]];
                val_10 = mem[board + 8];
                val_10 = board + 8;
                if(val_10 <= val_6)
            {
                    val_10 = mem[board + 8];
                val_10 = board + 8;
            }
            
                val_10 = board + (val_10 << 2);
                var val_7 = 1;
                val_6 = val_6 + 1;
                val_7 = val_7 ^ (((board + (board + 8) << 2) + 16) >> 31);
                mem2[0] = val_7;
            }
            while(val_6 < (this.<Width>k__BackingField));
            
                val_7 = this.<Height>k__BackingField;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_7);
        
        }
        public SLC.MatchyPics.MPINode GetNode(int x, int y)
        {
            if(y < 0)
            {
                    return;
            }
            
            if((this.<Width>k__BackingField) > x)
            {
                    this.<Width>k__BackingField = this.<Height>k__BackingField;
            }
            
            if((this.<Width>k__BackingField) <= y)
            {
                    return;
            }
            
            SLC.MatchyPics.MPINode val_1 = this.nodes[0];
        }
        public string BoardToString(System.Func<SLC.MatchyPics.MPINode, string> nodeString)
        {
            int val_5;
            string val_7;
            var val_8;
            val_5 = System.String.alignConst;
            if((this.<Height>k__BackingField) < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_6 = 0;
                do
            {
                string val_1 = nodeString.Invoke(arg:  this.nodes[this.<Width>k__BackingField]);
                string val_2 = System.String.Format(format:  753614816, arg0:  nodeString);
                string val_3 = val_5 + 753614816;
                val_7 = val_5;
                val_6 = val_6 + 1;
            }
            while(val_6 < (this.<Width>k__BackingField));
            
            }
            
                string val_4 = val_7 + 709645840;
                val_8 = val_7;
                val_7 = val_7 + 1;
            }
            while(val_7 < (this.<Height>k__BackingField));
        
        }
        public System.Collections.Generic.List<UnityEngine.Vector2Int> ValidatePath(UnityEngine.Vector2Int from, UnityEngine.Vector2Int to)
        {
            int val_1 = from.m_X.x;
            int val_3 = to.m_X.x;
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_5 = this.ValidatePath(from:  this.nodes[from.m_X.y], to:  this.nodes[to.m_X.y]);
        }
        public int PerformMovement(int[,] tiles, UnityEngine.Vector2Int direction)
        {
            int val_14;
            var val_15;
            var val_16;
            int val_17;
            int val_19;
            var val_23;
            if(tiles != 0)
            {
                    val_14 = tiles.GetUpperBound(dimension:  0);
            }
            else
            {
                    val_14 = tiles.GetUpperBound(dimension:  0);
            }
            
            int val_3 = tiles.GetUpperBound(dimension:  1);
            if(direction.m_X.y == 0)
            {
                goto label_2;
            }
            
            if(direction.m_X.y > 0)
            {
                    val_3 - 1 = 1;
            }
            
            if(val_14 < 2)
            {
                    return 1;
            }
            
            if(1 < val_3)
            {
                    0 = 1;
            }
            
            if(1 > 0)
            {
                    0 = 1;
            }
            
            label_22:
            if(1 == 0)
            {
                goto label_20;
            }
            
            val_16 = 0;
            val_17 = val_3;
            label_21:
            if(val_16 <= 1)
            {
                goto label_5;
            }
            
            val_19 = 0;
            int val_14 = tiles[1];
            if(val_14 < 0)
            {
                goto label_16;
            }
            
            val_19 = tiles[0];
            tiles[val_14] = val_19;
            tiles[tiles[val_14]] = 0;
            val_17 = val_3;
            val_16 = direction.m_X.y + val_16;
            goto label_16;
            label_5:
            val_19 = 0;
            if(tiles[1] <= 1)
            {
                    val_16 = 1;
            }
            
            label_16:
            val_14 = direction.m_X.y + 1;
            if(val_14 >= 1)
            {
                    if(val_14 < val_17)
            {
                goto label_21;
            }
            
            }
            
            label_20:
            val_23 = 1 + 1;
            if(val_23 != val_14)
            {
                goto label_22;
            }
            
            return 1;
            label_2:
            val_15 = 0;
            val_19 = val_3;
            UnityEngine.Vector2Int val_10 = new UnityEngine.Vector2Int(x:  0, y:  0);
            if(direction.m_X.x < 0)
            {
                    val_14 - 1 = 1;
            }
            
            if(val_19 < 2)
            {
                    return 1;
            }
            
            if(1 < val_14)
            {
                    0 = 1;
            }
            
            if(1 > 0)
            {
                    0 = 1;
            }
            
            label_43:
            if(1 == 0)
            {
                goto label_41;
            }
            
            val_16 = 0;
            label_42:
            if(val_16 <= 1)
            {
                goto label_26;
            }
            
            val_19 = 0;
            int val_16 = tiles[1];
            if(val_16 < 0)
            {
                goto label_37;
            }
            
            tiles[val_16] = tiles[0];
            val_14 = val_14;
            tiles[tiles[val_16]] = 0;
            val_16 = val_16 - direction.m_X.x;
            goto label_37;
            label_26:
            val_19 = 0;
            if(tiles[1] <= 1)
            {
                    val_16 = 1;
            }
            
            label_37:
            val_15 = 1 - direction.m_X.x;
            if(val_15 >= 1)
            {
                    if(val_15 < val_14)
            {
                goto label_42;
            }
            
            }
            
            label_41:
            val_23 = 1 + 1;
            if(val_23 != val_3)
            {
                goto label_43;
            }
            
            return 1;
        }
        private System.Collections.Generic.List<UnityEngine.Vector2Int> ValidatePath(SLC.MatchyPics.MPINode from, SLC.MatchyPics.MPINode to)
        {
            SLC.MatchyPics.MPINode val_6;
            SLC.MatchyPics.MPINode val_7;
            SLC.MatchyPics.MPINode val_8;
            val_6 = from;
            this.startNode = val_6;
            this.endNode = to;
            this.Clear();
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
            if((this.Search(currentNode:  this.startNode)) == false)
            {
                    return;
            }
            
            val_7 = this.endNode;
            val_6 = true;
            goto label_2;
            label_5:
             = new UnityEngine.Vector2Int(x:  this.endNode.x, y:  this.endNode.y);
            Add(item:  new UnityEngine.Vector2Int() {m_X = val_3.m_X, m_Y = val_3.m_Y});
            this.endNode.path = val_6;
            val_7 = this.endNode._parent;
            label_2:
            if(this.endNode._parent._parent != 0)
            {
                goto label_5;
            }
            
            val_8 = this.startNode;
            if(this.startNode != 0)
            {
                goto label_6;
            }
            
            val_8 = this.startNode;
            if(val_8 == 0)
            {
                goto label_7;
            }
            
            label_6:
            UnityEngine.Vector2Int val_4 = new UnityEngine.Vector2Int(x:  this.startNode.x, y:  this.startNode.y);
            if(null != 0)
            {
                    Add(item:  new UnityEngine.Vector2Int() {m_X = val_4.m_X, m_Y = val_4.m_Y});
            }
            else
            {
                    Add(item:  new UnityEngine.Vector2Int() {m_X = val_4.m_X, m_Y = val_4.m_Y});
            }
            
            Reverse();
            return;
            label_7:
        }
        public System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> FindPaths(System.Collections.Generic.List<UnityEngine.Vector2Int> fnodes)
        {
            var val_3;
            var val_11;
            var val_12;
            System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> val_13;
            SLC.MatchyPics.MPINode val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            int val_6 = 0.y;
            val_12 = mem[mem[1152921513986336232] + 8];
            val_12 = mem[1152921513986336232] + 8;
            if(val_12 <= 0.x)
            {
                    val_12 = mem[mem[1152921513986336232] + 8];
                val_12 = mem[1152921513986336232] + 8;
            }
            
            val_12 = mem[1152921513986336232] + (val_12 << 2);
            Add(item:  (mem[1152921513986336232] + (mem[1152921513986336232] + 8) << 2) + 16);
            goto label_7;
            label_2:
            0.Dispose();
            label_20:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = 0;
            RemoveAt(index:  0);
            val_14 = List<T>.__il2cppRuntimeField_10;
            System.Tuple<SLC.MatchyPics.MPINode, SLC.MatchyPics.MPINode> val_7 = this.FindPath(node0:  val_14, fnodes:  80883712);
            if(this == 0)
            {
                    return;
            }
            
            val_15 = mem[1152921513986336232];
            if(mem[1152921513986336232] == 0)
            {
                    val_16 = mem[1152921513986336232];
                if(val_16 == 0)
            {
                goto label_17;
            }
            
            }
            
            val_14 = mem[mem[1152921513986336232] + 8];
            val_14 = mem[1152921513986336232] + 8;
            val_3 = 0;
            UnityEngine.Vector2Int val_8 = new UnityEngine.Vector2Int(x:  val_14, y:  mem[1152921513986336232] + 12);
            val_17 = mem[1152921513986336236];
            if(mem[1152921513986336236] == 0)
            {
                    val_18 = mem[1152921513986336236];
                if(val_18 == 0)
            {
                goto label_17;
            }
            
            }
            
            UnityEngine.Vector2Int val_9 = new UnityEngine.Vector2Int(x:  mem[1152921513986336236] + 8, y:  mem[1152921513986336236] + 12);
            val_13 = null;
            val_11 = public System.Void System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int>::.ctor(UnityEngine.Vector2Int item1, UnityEngine.Vector2Int item2);
            val_13 = new System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int>(item1:  new UnityEngine.Vector2Int() {m_X = val_8.m_X, m_Y = val_8.m_Y}, item2:  new UnityEngine.Vector2Int() {m_X = val_9.m_X, m_Y = val_9.m_Y});
            return;
            label_17:
            if(val_14 != 1)
            {
                goto label_18;
            }
            
            0.Dispose();
            if(val_16 == 0)
            {
                goto label_20;
            }
            
            goto label_20;
            label_18:
        }
        private System.Tuple<SLC.MatchyPics.MPINode, SLC.MatchyPics.MPINode> FindPath(SLC.MatchyPics.MPINode node0, System.Collections.Generic.List<SLC.MatchyPics.MPINode> fnodes)
        {
            SLC.MatchyPics.MPINode val_3;
            System.Collections.Generic.List<SLC.MatchyPics.MPINode> val_11;
            var val_12;
            var val_14;
            System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_15;
            var val_16;
            System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_17;
            var val_18;
            System.Comparison<SLC.MatchyPics.MPINode> val_20;
            var val_21;
            val_11 = fnodes;
            if(true >= 2)
            {
                goto label_2;
            }
            
            val_12 = 0;
            goto label_3;
            label_2:
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            float val_4 = SLC.MatchyPics.MPINode.Heuristic(a:  val_3, b:  node0);
            if(val_3 != 0)
            {
                    mem2[0] = val_3;
            }
            else
            {
                    mem[36] = val_3;
            }
            
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            val_14 = 789674000;
            val_15 = null;
            val_15 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  node0, item2:  val_3);
            val_11 = val_11;
            val_16 = 236;
            goto label_8;
            label_4:
            val_15 = 0;
            val_16 = 90;
            val_11 = val_11;
            val_14 = 789674000;
            label_8:
            Dispose();
            if(val_16 == 236)
            {
                    val_17 = val_15;
                return;
            }
            
            if(val_16 == 90)
            {
                    val_12 = 0;
            }
            
            val_18 = null;
            val_18 = null;
            val_20 = MPIPathFinding.<>c.<>9__20_0;
            if(val_20 == 0)
            {
                    val_20 = null;
                val_20 = new System.Comparison<WordForest.NewsArticle>(object:  MPIPathFinding.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(789659040));
                MPIPathFinding.<>c.<>9__20_0 = val_20;
            }
            
            val_11.Sort(comparison:  7933952);
            label_3:
            List.Enumerator<T> val_7 = GetEnumerator();
            label_20:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_9 = this.ValidatePath(from:  node0, to:  val_3);
            if((this.<Width>k__BackingField) < 1)
            {
                goto label_20;
            }
            
            val_17 = null;
            val_17 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  node0, item2:  val_3);
            val_21 = 236;
            goto label_21;
            label_18:
            val_17 = val_15;
            val_21 = 195;
            label_21:
            val_15 = val_12 + 1;
            mem2[0] = val_21;
            Dispose();
            if(val_15 != 1)
            {
                    if((789674000 + ((val_12 + 1)) << 2) == 236)
            {
                    return;
            }
            
            }
            
            val_17 = 0;
            if((fnodes + 12) < 2)
            {
                    return;
            }
            
            val_11.RemoveAt(index:  0);
            if((fnodes + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = this;
        }
        private bool Search(SLC.MatchyPics.MPINode currentNode)
        {
            var val_5;
            var val_6;
            var val_7;
            System.Comparison<SLC.MatchyPics.MPINode> val_9;
            var val_10;
            mem2[0] = 1;
            System.Collections.Generic.List<SLC.MatchyPics.MPINode> val_1 = this.GetAdjacentValidNodes(fromNode:  currentNode);
            val_6 = this;
            val_7 = null;
            val_7 = null;
            val_9 = MPIPathFinding.<>c.<>9__21_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Comparison<WordForest.NewsArticle>(object:  MPIPathFinding.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(789786400));
                MPIPathFinding.<>c.<>9__21_0 = val_9;
            }
            
            if(val_6 != 0)
            {
                    this.Sort(comparison:  7933952);
            }
            else
            {
                    val_6 = 0;
                0.Sort(comparison:  7933952);
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            label_16:
            if(MoveNext() == false)
            {
                goto label_9;
            }
            
            val_6 = val_5;
            val_9 = this.endNode;
            if((val_5 + 8) != this.endNode.x)
            {
                goto label_12;
            }
            
            val_9 = this.endNode;
            if((val_5 + 12) == this.endNode.y)
            {
                goto label_14;
            }
            
            label_12:
            if(this == 0)
            {
                goto label_16;
            }
            
            label_14:
            Dispose();
            val_10 = 1;
            return (bool)val_10;
            label_9:
            Dispose();
            val_10 = 0;
            mem2[0] = val_10;
            return (bool)val_10;
        }
        private System.Collections.Generic.List<SLC.MatchyPics.MPINode> GetAdjacentValidNodes(SLC.MatchyPics.MPINode fromNode)
        {
            SLC.MatchyPics.MPINode val_5;
            System.Collections.Generic.List<SLC.MatchyPics.MPINode> val_1 = this.GetNeighbors(node:  fromNode);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_3 = GetEnumerator();
            label_15:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if((val_5 + 16) != 0)
            {
                    val_5 + 16 = this.endNode;
            }
            
            if((val_5 != (val_5 + 16)) || ((val_5 + 20) == 1))
            {
                goto label_15;
            }
            
            if((val_5 + 20) != 0)
            {
                goto label_6;
            }
            
            float val_6 = SLC.MatchyPics.MPINode.Heuristic(a:  val_5, b:  fromNode);
            if(fromNode > 0)
            {
                goto label_15;
            }
            
            mem2[0] = fromNode;
            val_5.UpdateV();
            if(fromNode > 0)
            {
                goto label_15;
            }
            
            mem2[0] = S18 + val_5;
            Add(item:  val_5);
            goto label_15;
            label_6:
            mem2[0] = fromNode;
            val_5.UpdateV();
            if((val_5 + 20) > 0)
            {
                goto label_15;
            }
            
            float val_8 = SLC.MatchyPics.MPINode.Heuristic(a:  val_5, b:  this.endNode);
            mem2[0] = val_5;
            float val_9 = SLC.MatchyPics.MPINode.HCost(a:  val_5, b:  this.endNode);
            mem2[0] = val_5;
            float val_10 = SLC.MatchyPics.MPINode.Heuristic(a:  val_5, b:  fromNode);
            float val_11 = val_5;
            mem2[0] = 0;
            val_11 = S18 + val_11;
            mem2[0] = val_11;
            Add(item:  val_5);
            goto label_15;
            label_2:
            Dispose();
        }
        private System.Collections.Generic.List<SLC.MatchyPics.MPINode> GetNeighbors(SLC.MatchyPics.MPINode node)
        {
            var val_4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(node != 0)
            {
                
            }
            else
            {
                    val_4 = 0;
            }
            
            if(node < 0)
            {
                goto label_26;
            }
            
            if((this.<Width>k__BackingField) > (-1))
            {
                    this.<Width>k__BackingField = this.<Height>k__BackingField;
            }
            
            if((this.<Width>k__BackingField) > node)
            {
                goto label_4;
            }
            
            label_26:
            if(node < 0)
            {
                goto label_31;
            }
            
            if((this.<Width>k__BackingField) > (val_4 + 1))
            {
                    this.<Width>k__BackingField = this.<Height>k__BackingField;
            }
            
            if((this.<Width>k__BackingField) > node)
            {
                goto label_6;
            }
            
            label_31:
            if(val_4 < 0)
            {
                    return;
            }
            
            SLC.MatchyPics.MPINode val_3 = node - 1;
            if(val_3 < 0)
            {
                goto label_16;
            }
            
            if((this.<Width>k__BackingField) > 0)
            {
                    public System.Void System.Collections.Generic.List<SLC.MatchyPics.MPINode>::.ctor() = this.<Height>k__BackingField;
            }
            
            if((public System.Void System.Collections.Generic.List<SLC.MatchyPics.MPINode>::.ctor()) > val_3)
            {
                goto label_9;
            }
            
            label_16:
            if((node + 1) < 0)
            {
                    return;
            }
            
            if((this.<Width>k__BackingField) > 0)
            {
                    this.<Width>k__BackingField = this.<Height>k__BackingField;
                goto label_11;
            }
            
            return;
            label_9:
            Add(item:  this.nodes[this.<Width>k__BackingField]);
            goto label_16;
            label_11:
            Add(item:  this.nodes[this.<Width>k__BackingField]);
            return;
            label_4:
            Add(item:  this.nodes[this.<Width>k__BackingField]);
            goto label_26;
            label_6:
            Add(item:  this.nodes[this.<Width>k__BackingField]);
            goto label_31;
        }
        private void Clear()
        {
            int val_1 = this.<Height>k__BackingField;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_2 = 0;
                do
            {
                this.nodes[this.<Width>k__BackingField] = (this.nodes[this.<Width>k__BackingField]) + 28;
                mem2[0] = 0;
                mem2[0] = 2;
                val_2 = val_2 + 1;
            }
            while(val_2 < (this.<Width>k__BackingField));
            
                val_1 = this.<Height>k__BackingField;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
        
        }
        private bool InBounds(int x, int y)
        {
            if(x < 0)
            {
                    return false;
            }
            
            if((this.<Width>k__BackingField) <= x)
            {
                    return false;
            }
            
            if((this.<Height>k__BackingField) > y)
            {
                    0 = 1;
            }
            
            return true;
        }
        public MPIPathFinding()
        {
        
        }
    
    }

}
