using UnityEngine;

namespace TMPro.Examples
{
    public class CurveText : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        public UnityEngine.AnimationCurve VertexCurve;
        public float CurveScale;
        
        // Properties
        private TMPro.TMP_Text TextComponent { get; }
        
        // Methods
        private TMPro.TMP_Text get_TextComponent()
        {
            if(this.m_TextComponent != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            object val_3 = this.GetComponent<System.Object>();
            this.m_TextComponent = this;
        }
        private void Update()
        {
            TMPro.TMP_Text val_1 = this.TextComponent;
            if((UnityEngine.Object.op_Implicit(exists:  498310176)) == false)
            {
                    return;
            }
            
            TMPro.TMP_Text val_3 = this.TextComponent;
            if((UnityEngine.Object.op_Implicit(exists:  498310176)) == false)
            {
                    return;
            }
            
            this.DoWarpText();
        }
        private void DoWarpText()
        {
            var val_6;
            var val_10;
            this.VertexCurve.preWrapMode = 1;
            this.VertexCurve.postWrapMode = 1;
            TMPro.TMP_Text val_1 = this.TextComponent;
            TMPro.TMP_Text val_2 = this.TextComponent;
            if((R8 + 12) != 0)
            {
                    TMPro.TMP_Text val_3 = this.TextComponent;
                UnityEngine.Bounds val_4 = bounds;
                UnityEngine.Vector3 val_5 = min;
                TMPro.TMP_Text val_7 = this.TextComponent;
                UnityEngine.Bounds val_8 = bounds;
                UnityEngine.Vector3 val_9 = max;
                if((R8 + 12) >= 1)
            {
                    float val_11 = val_10 - val_6;
            }
            
            }
        
        }
        public CurveText()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_20 = val_1.m_WeightedMode;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_24 = val_1.m_InWeight;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_28 = val_1.m_Time;
            UnityEngine.Keyframe val_2 = new UnityEngine.Keyframe(time:  null, value:  null);
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_3C = val_2.m_WeightedMode;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_40 = val_2.m_Time;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_44 = val_2.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_58 = val_3.m_WeightedMode;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_5C = val_3.m_Time;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_60 = val_3.m_Time;
            this.VertexCurve = new UnityEngine.AnimationCurve(keys:  1544414176);
            this.CurveScale = 10f;
        }
    
    }

}
