using UnityEngine;

namespace UnityEngine.UI
{
    public class Outline8 : Shadow
    {
        // Methods
        protected Outline8()
        {
        
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            byte val_16;
            var val_17;
            byte val_18;
            var val_19;
            byte val_20;
            var val_21;
            byte val_22;
            var val_23;
            byte val_24;
            var val_25;
            byte val_26;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<T> val_2 = UnityEngine.UI.ListPool<UnityEngine.UIVertex>.Get();
            val_12 = 0;
            vh.GetUIVertexStream(stream:  1182077152);
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_13 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
            }
            else
            {
                    val_13 = 12;
            }
            
            val_14 = public System.Int32 System.Collections.Generic.List<UnityEngine.UIVertex>::get_Capacity();
            if(Capacity < 0)
            {
                    val_14 = 0;
                val_12 = public System.Void System.Collections.Generic.List<UnityEngine.UIVertex>::set_Capacity(int value);
                Capacity = 0;
            }
            
            UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, start:  0, end:  0, x:  null, y:  null);
            UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_15 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_16 = val_5.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_16, g = val_5.g, b = val_5.b, a = val_5.a}, start:  0, end:  0, x:  null, y:  null);
            }
            else
            {
                    val_15 = 0;
                val_16 = val_5.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_16, g = val_5.g, b = val_5.b, a = val_5.a}, start:  0, end:  0, x:  null, y:  null);
            }
            
            UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_17 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_18 = val_6.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_18, g = val_6.g, b = val_6.b, a = val_6.a}, start:  0, end:  0, x:  -S0, y:  null);
            }
            else
            {
                    val_17 = 0;
                val_18 = val_6.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_18, g = val_6.g, b = val_6.b, a = val_6.a}, start:  0, end:  0, x:  -S0, y:  null);
            }
            
            UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_19 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_20 = val_7.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_20, g = val_7.g, b = val_7.b, a = val_7.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            else
            {
                    val_19 = 0;
                val_20 = val_7.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_20, g = val_7.g, b = val_7.b, a = val_7.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_21 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_22 = val_8.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_22, g = val_8.g, b = val_8.b, a = val_8.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            else
            {
                    val_21 = 0;
                val_22 = val_8.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_22, g = val_8.g, b = val_8.b, a = val_8.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            
            UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_23 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_24 = val_9.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_24, g = val_9.g, b = val_9.b, a = val_9.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            else
            {
                    val_23 = 0;
                val_24 = val_9.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_24, g = val_9.g, b = val_9.b, a = val_9.a}, start:  0, end:  0, x:  -(-S0), y:  null);
            }
            
            UnityEngine.Color32 val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            if((public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get()) != 0)
            {
                    val_25 = public static System.Collections.Generic.List<T> UnityEngine.UI.ListPool<UnityEngine.UIVertex>::Get();
                val_26 = val_10.r;
                this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_26, g = val_10.g, b = val_10.b, a = val_10.a}, start:  0, end:  0, x:  -(-(-S0)), y:  null);
            }
            else
            {
                    val_25 = 0;
                val_26 = val_10.r;
                this.ApplyShadowZeroAlloc(verts:  0, color:  new UnityEngine.Color32() {r = val_26, g = val_10.g, b = val_10.b, a = val_10.a}, start:  0, end:  0, x:  -(-(-S0)), y:  null);
            }
            
            UnityEngine.Color32 val_11 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            this.ApplyShadowZeroAlloc(verts:  1182077152, color:  new UnityEngine.Color32() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, start:  0, end:  0, x:  -(-(-(-S0))), y:  null);
            if(vh != 0)
            {
                    vh.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            vh.AddUIVertexTriangleStream(verts:  1182077152);
            UnityEngine.UI.ListPool<UnityEngine.UIVertex>.Release(toRelease:  1182077152);
        }
    
    }

}
