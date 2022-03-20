using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPINode
    {
        // Fields
        public int x;
        public int y;
        public bool isATile;
        public SLC.MatchyPics.NodeState state;
        public bool path;
        private SLC.MatchyPics.MPINode _parent;
        private float <G>k__BackingField;
        private float <H>k__BackingField;
        private float <Hc>k__BackingField;
        private float <V>k__BackingField;
        
        // Properties
        public float G { get; set; }
        public float H { get; set; }
        public float Hc { get; set; }
        public float F { get; }
        public float V { get; set; }
        public UnityEngine.Vector2 Direction { get; }
        public SLC.MatchyPics.MPINode parent { get; set; }
        
        // Methods
        public float get_G()
        {
            return (float)S0;
        }
        public void set_G(float value)
        {
            this.<G>k__BackingField = ;
        }
        public float get_H()
        {
            return (float)S0;
        }
        public void set_H(float value)
        {
            this.<H>k__BackingField = ;
        }
        public float get_Hc()
        {
            return (float)S0;
        }
        public void set_Hc(float value)
        {
            this.<Hc>k__BackingField = ;
        }
        public float get_F()
        {
            float val_1 = this.<G>k__BackingField;
            val_1 = val_1 + (this.<H>k__BackingField);
            return (float)val_1;
        }
        public float get_V()
        {
            return (float)S0;
        }
        private void set_V(float value)
        {
            this.<V>k__BackingField = ;
        }
        public UnityEngine.Vector2 get_Direction()
        {
            if((R1 + 28) != 0)
            {
                    var val_3 = R1 + 28 + 8;
                var val_4 = R1 + 28 + 12;
                val_3 = (R1 + 8) - val_3;
                val_4 = (R1 + 12) - val_4;
                this = 0;
                mem[1152921513989224804] = 0;
                this = new UnityEngine.Vector2(x:  (float)val_3, y:  null);
                return new UnityEngine.Vector2() {x = (float)val_3};
            }
            
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public SLC.MatchyPics.MPINode get_parent()
        {
        
        }
        public void set_parent(SLC.MatchyPics.MPINode value)
        {
            this._parent = value;
            this.UpdateV();
        }
        public MPINode(int x, int y)
        {
            this.state = 2;
            this.x = x;
            this.y = y;
        }
        public static float HCost(SLC.MatchyPics.MPINode a, SLC.MatchyPics.MPINode b)
        {
            var val_3;
            if(b != 0)
            {
                
            }
            else
            {
                    var val_2 = 8;
                val_3 = 0;
            }
            
            var val_1 = R6 - val_3;
            val_1 = val_1 * val_1;
            val_2 = a - val_2;
            return (float)(float)val_2;
        }
        public static float HCost(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
        {
            var val_5 = a.m_X.x;
            int val_2 = b.m_X.x;
            val_2 = val_5 - val_2;
            val_5 = val_2 * val_2;
            int val_4 = b.m_X.y;
            val_4 = a.m_X.y - val_4;
            return (float)(float)val_4;
        }
        public static float Heuristic(SLC.MatchyPics.MPINode a, SLC.MatchyPics.MPINode b)
        {
            int val_2 = UnityEngine.Mathf.Abs(value:  35638271 - R7);
            val_2 = 0 - val_2;
            int val_3 = UnityEngine.Mathf.Abs(value:  val_2);
            val_3 = val_3 + val_2;
            return (float)(float)val_3;
        }
        public int CompareTo(SLC.MatchyPics.MPINode node)
        {
            float val_3 = this.<G>k__BackingField;
            val_3 = val_3 + (this.<H>k__BackingField);
            val_3 = val_3 + (this.<H>k__BackingField);
            if((val_3.CompareTo(value:  val_3)) != 0)
            {
                    return (int)this.<Hc>k__BackingField.CompareTo(value:  val_3);
            }
            
            return (int)this.<Hc>k__BackingField.CompareTo(value:  val_3);
        }
        public void Clear()
        {
            this.<V>k__BackingField = 0f;
            this.state = 2;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            float val_2 = this.<G>k__BackingField;
            val_2 = val_2 + (this.<H>k__BackingField);
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            string val_1 = System.String.Format(format:  793484576, args:  472754880);
        }
        private void UpdateV()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            if(this._parent == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = Direction;
            UnityEngine.Vector2 val_2 = Direction;
            float val_7 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_5, y = val_6}, rhs:  new UnityEngine.Vector2() {x = val_3, y = val_4});
            if(this._parent < 0)
            {
                    this._parent.<V>k__BackingField = (this._parent.<V>k__BackingField) + 1f;
            }
            
            this.<V>k__BackingField = this._parent.<V>k__BackingField;
        }
    
    }

}
