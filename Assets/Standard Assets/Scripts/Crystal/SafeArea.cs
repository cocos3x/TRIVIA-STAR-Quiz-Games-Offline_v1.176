using UnityEngine;

namespace Crystal
{
    public class SafeArea : MonoBehaviour
    {
        // Fields
        public static Crystal.SafeArea.SimDevice Sim;
        private UnityEngine.Rect[] NSA_iPhoneX;
        private UnityEngine.Rect[] NSA_iPhoneXsMax;
        private UnityEngine.RectTransform Panel;
        private UnityEngine.Rect LastSafeArea;
        private bool ConformX;
        private bool ConformY;
        
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.Panel = this;
            if(2049817232 == 0)
            {
                    string val_3 = this.name;
                string val_4 = 2049793056 + 2049817232;
                UnityEngine.Debug.LogError(message:  2049793056);
                UnityEngine.GameObject val_5 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  2049817232);
            }
            
            this.Refresh();
        }
        private void Update()
        {
            this.Refresh();
        }
        private void Refresh()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Rect val_1 = GetSafeArea();
            if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = val_2, m_YMin = val_3, m_Width = val_4, m_Height = val_5}, rhs:  new UnityEngine.Rect() {m_XMin = mem[this.LastSafeArea + (0)], m_YMin = mem[this.LastSafeArea + (4)], m_Width = mem[this.LastSafeArea + (8)], m_Height = mem[this.LastSafeArea + (12)]})) == false)
            {
                    return;
            }
            
            this.ApplySafeArea(r:  new UnityEngine.Rect() {m_XMin = val_2, m_YMin = val_3, m_Width = val_4, m_Height = val_5});
        }
        private UnityEngine.Rect GetSafeArea()
        {
            var val_21;
            float val_22;
            float val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_21 = R1;
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            if(UnityEngine.Application.isEditor == false)
            {
                    return new UnityEngine.Rect() {m_XMin = val_22, m_YMin = val_1.m_YMin, m_Width = val_23, m_Height = val_1.m_Height};
            }
            
            val_24 = null;
            val_24 = null;
            if(Crystal.SafeArea.Sim == 0)
            {
                    return new UnityEngine.Rect() {m_XMin = val_22, m_YMin = val_1.m_YMin, m_Width = val_23, m_Height = val_1.m_Height};
            }
            
            int val_3 = UnityEngine.Screen.width;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_1.m_YMin, width:  val_1.m_Width, height:  val_1.m_Height);
            val_25 = null;
            val_25 = null;
            if(Crystal.SafeArea.Sim == 2)
            {
                goto label_7;
            }
            
            if(Crystal.SafeArea.Sim != 1)
            {
                goto label_8;
            }
            
            val_26 = UnityEngine.Screen.height;
            val_27 = mem[R1 + 12];
            val_27 = R1 + 12;
            val_28 = UnityEngine.Screen.width;
            goto label_9;
            label_7:
            val_26 = UnityEngine.Screen.height;
            val_28 = UnityEngine.Screen.width;
            val_27 = mem[R1 + 16];
            val_27 = R1 + 16;
            label_9:
            if(val_26 > val_28)
            {
                    var val_10 = val_27 + 16;
            }
            else
            {
                    var val_11 = val_27 + 32;
            }
            
            label_8:
            float val_13 = val_5.m_XMin.x;
            float val_15 = val_5.m_XMin.y;
            float val_17 = val_5.m_XMin.width;
            val_21 = UnityEngine.Screen.height;
            float val_19 = val_5.m_XMin.height;
            float val_21 = (float)UnityEngine.Screen.width;
            float val_22 = (float)UnityEngine.Screen.height;
            float val_23 = (float)UnityEngine.Screen.width;
            val_21 = 2050141160 * val_21;
            val_22 = 2050141160 * val_22;
            val_23 = 2050141160 * val_23;
            val_23 = 2050141160;
            val_22 = val_23 * (float)val_21;
            UnityEngine.Rect val_20 = new UnityEngine.Rect(x:  val_22, y:  val_1.m_YMin, width:  val_23, height:  val_1.m_Height);
            return new UnityEngine.Rect() {m_XMin = val_22, m_YMin = val_1.m_YMin, m_Width = val_23, m_Height = val_1.m_Height};
        }
        private void ApplySafeArea(UnityEngine.Rect r)
        {
            var val_4;
            var val_5;
            float val_8;
            var val_10;
            var val_11;
            this.LastSafeArea = r;
            mem[1152921510952087724] = r.m_YMin;
            mem[1152921510952087728] = r.m_Width;
            mem[1152921510952087732] = r.m_Height;
            if(this.ConformX != true)
            {
                    r.m_XMin.x = null;
                r.m_XMin.width = (float)UnityEngine.Screen.width;
            }
            
            if(this.ConformY != true)
            {
                    r.m_XMin.y = (float)UnityEngine.Screen.width;
                r.m_XMin.height = (float)UnityEngine.Screen.height;
            }
            
            UnityEngine.Vector2 val_3 = position;
            UnityEngine.Vector2 val_6 = position;
            UnityEngine.Vector2 val_7 = size;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.343094E+35f}, b:  new UnityEngine.Vector2() {y = val_8});
            this.Panel.anchorMin = new UnityEngine.Vector2() {x = val_4 / (float)UnityEngine.Screen.width, y = val_5 / (float)UnityEngine.Screen.height};
            this.Panel.anchorMax = new UnityEngine.Vector2() {x = val_10 / (float)UnityEngine.Screen.width, y = val_11 / (float)UnityEngine.Screen.height};
        }
        public SafeArea()
        {
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.NSA_iPhoneX = null;
            UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.NSA_iPhoneXsMax = null;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.ConformX = true;
            this.ConformY = true;
        }
        private static SafeArea()
        {
        
        }
    
    }

}
