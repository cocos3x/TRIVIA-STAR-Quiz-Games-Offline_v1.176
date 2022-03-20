using UnityEngine;
public static class NGUIMath
{
    // Methods
    public static float Lerp(float from, float to, float factor)
    {
        float val_1 = 1f;
        val_1 = val_1 - R2;
        val_1 = val_1 * 0;
        return (float)val_1;
    }
    public static int ClampIndex(int val, int max)
    {
        if(val < 0)
        {
                val = 0;
            return val;
        }
        
        if(val >= max)
        {
                val = max - 1;
        }
        
        return val;
    }
    public static int RepeatIndex(int val, int max)
    {
        if(max < 1)
        {
                val = 0;
            return (int)val;
        }
        
        do
        {
            val = val + max;
        }
        while(((0 - max) + val) < 0);
        
        do
        {
            val = val - max;
        }
        while(val >= max);
        
        return (int)val;
    }
    public static float WrapAngle(float angle)
    {
        uint val_1 = 0;
        if()
        {
                do
        {
            val_1 = val_1 + (-360f);
        }
        while();
        
        }
        
        if(>=0)
        {
                return (float)val_1;
        }
        
        do
        {
            val_1 = val_1 + 360f;
        }
        while(<0);
        
        return (float)val_1;
    }
    public static float Wrap01(float val)
    {
        float val_2 = (float)UnityEngine.Mathf.FloorToInt(f:  val);
        val_2 = 0 - val_2;
        return (float)val_2;
    }
    public static int HexToDecimal(char ch)
    {
        ch = ch - 48;
        if(((uint)ch & 65535) > 54)
        {
                ch = 15;
            return (int)ch;
        }
        
        return 15;
    }
    public static char DecimalToHexChar(int num)
    {
        int val_1 = 70;
        if(num > 15)
        {
                return (char)(uint)val_1 & 65535;
        }
        
        if(num > 9)
        {
                val_1 = num + 55;
        }
        
        if(num <= 9)
        {
                val_1 = num + 48;
        }
        
        return (char)(uint)val_1 & 65535;
    }
    public static string DecimalToHex(int num)
    {
        string val_2 = num & (~4278190080).ToString(format:  1801259872);
    }
    public static int ColorToInt(UnityEngine.Color c)
    {
        float val_7 = c.g;
        val_7 = val_7 * 255f;
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_7);
        float val_8 = c.b;
        val_3 = val_3 << 16;
        float val_9 = c.a;
        int val_4 = val_3 | ((UnityEngine.Mathf.RoundToInt(f:  c.r * 255f)) << 24);
        val_8 = val_8 * 255f;
        val_9 = val_9 * 255f;
        val_4 = val_4 | ((UnityEngine.Mathf.RoundToInt(f:  val_8)) << 8);
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_8);
        val_6 = val_4 | val_6;
        return (int)val_6;
    }
    public static UnityEngine.Color IntToColor(int val)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        float val_3 = (float)(uint)(R1 >> 16) & 255;
        float val_4 = (float)R1 >> 24;
        float val_5 = (float)(uint)(R1 >> 8) & 255;
        float val_6 = (float)(int)R1 & 255;
        val_3 = val_3 * 0.003921569f;
        val_4 = val_4 * 0.003921569f;
        val_5 = val_5 * 0.003921569f;
        val_6 = val_6 * 0.003921569f;
        mem2[0] = val_4;
        mem2[0] = val_3;
        mem2[0] = val_5;
        mem2[0] = val_6;
        return new UnityEngine.Color() {r = val_3, g = val_1.g, b = val_4, a = val_1.a};
    }
    public static string IntToBinary(int val, int bits)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = bits;
        val_6 = "";
        if(val_5 < 1)
        {
                return;
        }
        
        do
        {
            if((val_5 <= 24) && ((16843008 & (1 << val_5)) == 0))
        {
                string val_1 = 1098586544 + 1297836560;
            val_7 = val_6;
        }
        
            val_5 = val_5 - 1;
            if((val & (1 << (val_5 & 31))) != 0)
        {
                49 = 48;
        }
        
            string val_3 = 48.ToString();
            string val_4 = 1098586544 + 1801607914;
            val_8 = val_7;
        }
        while(val_5 > 1);
    
    }
    public static UnityEngine.Color HexToColor(uint val)
    {
        UnityEngine.Color val_1 = NGUIMath.IntToColor(val:  val);
        return new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public static UnityEngine.Rect ConvertToTexCoords(UnityEngine.Rect rect, int width, int height)
    {
        var val_1;
        int val_6;
        float val_7;
        val_6 = height;
        val_7 = val_6;
        if(val_6 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_7};
        }
        
        val_7 = val_1;
        if(val_1 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_7};
        }
        
        float val_2 = rect.m_YMin.xMin;
        uint val_6 = 1801831912;
        val_6;
        val_6 = val_6 / (float)val_7;
        xMin = val_6;
        float val_3 = rect.m_YMin.xMax;
        uint val_7 = 1801831912;
        val_7 = val_7 / (float)val_7;
        xMax = val_7;
        float val_4 = rect.m_YMin.yMax;
        uint val_8 = 1801831912;
        val_8 = val_8 / (float)val_7;
        val_8 = 1f - val_8;
        yMin = val_8;
        float val_5 = rect.m_YMin.yMin;
        uint val_9 = 1801831912;
        val_9 = val_9 / (float)val_7;
        val_7 = 1f - val_9;
        yMax = val_7;
        return new UnityEngine.Rect() {m_XMin = val_7};
    }
    public static UnityEngine.Rect ConvertToPixels(UnityEngine.Rect rect, int width, int height, bool round)
    {
        var val_1;
        var val_13;
        float val_15;
        float val_16;
        float val_2 = rect.m_YMin.xMin;
        if(val_1 != 0)
        {
                int val_13 = height;
            val_13 = 1801943904 * val_13;
            val_13;
            xMin = (float)UnityEngine.Mathf.RoundToInt(f:  val_13);
            float val_4 = rect.m_YMin.xMax;
            uint val_14 = 1801943904;
            val_14 = val_14 * val_13;
            xMax = (float)UnityEngine.Mathf.RoundToInt(f:  val_14);
            float val_6 = rect.m_YMin.yMax;
            uint val_15 = 1801943904;
            val_15 = round;
            val_15 = 1f - val_15;
            val_15 = val_15 * (float)val_15;
            yMin = (float)UnityEngine.Mathf.RoundToInt(f:  val_15);
            float val_8 = rect.m_YMin.yMin;
            uint val_16 = 1801943904;
            val_16 = 1f - val_16;
            val_16 = val_16 * (float)val_15;
            val_16 = (float)UnityEngine.Mathf.RoundToInt(f:  val_16);
        }
        else
        {
                int val_17 = height;
            val_13;
            val_17 = 1801943904 * val_17;
            xMin = val_17;
            float val_10 = rect.m_YMin.xMax;
            uint val_18 = 1801943904;
            val_18 = val_18 * val_17;
            xMax = val_18;
            float val_11 = rect.m_YMin.yMax;
            uint val_19 = 1801943904;
            val_15 = round;
            val_19 = 1f - val_19;
            val_19 = val_19 * val_15;
            yMin = val_19;
            float val_12 = rect.m_YMin.yMin;
            uint val_20 = 1801943904;
            val_20 = 1f - val_20;
            val_16 = val_20 * val_15;
        }
        
        yMax = val_16;
        return new UnityEngine.Rect() {m_XMin = val_16, m_Width = val_15};
    }
    public static UnityEngine.Rect MakePixelPerfect(UnityEngine.Rect rect)
    {
        rect.m_YMin.xMin = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.xMin);
        rect.m_YMin.yMin = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.yMin);
        rect.m_YMin.xMax = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.xMax);
        rect.m_YMin.yMax = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.yMax);
        return new UnityEngine.Rect() {m_XMin = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.yMax)};
    }
    public static UnityEngine.Rect MakePixelPerfect(UnityEngine.Rect rect, int width, int height)
    {
        bool val_1;
        UnityEngine.Rect val_2 = NGUIMath.ConvertToPixels(rect:  new UnityEngine.Rect() {m_XMin = 2.839765E+26f, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height}, width:  width, height:  height, round:  val_1);
        rect.m_YMin.xMin = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.xMin);
        rect.m_YMin.yMin = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.yMin);
        rect.m_YMin.xMax = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.xMax);
        rect.m_YMin.yMax = (float)UnityEngine.Mathf.RoundToInt(f:  rect.m_YMin.yMax);
        UnityEngine.Rect val_11 = NGUIMath.ConvertToTexCoords(rect:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height}, width:  width, height:  height);
        return new UnityEngine.Rect() {m_XMin = val_11.m_XMin, m_YMin = val_11.m_YMin, m_Width = val_11.m_Width, m_Height = val_11.m_Height};
    }
    public static UnityEngine.Vector3 ApplyHalfPixelOffset(UnityEngine.Vector3 pos)
    {
        float val_2;
        float val_3;
        val_2 = pos.z;
        val_3 = pos.y;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        mem2[0] = val_3;
        mem2[0] = val_2;
        mem2[0] = R3;
        return new UnityEngine.Vector3() {x = 0.5f, z = -0.5f};
    }
    public static UnityEngine.Vector3 ApplyHalfPixelOffset(UnityEngine.Vector3 pos, UnityEngine.Vector3 scale)
    {
        float val_8;
        float val_9;
        val_8 = pos.z;
        val_9 = pos.y;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if((0 <= 10) && ((1156 & 1) == 0))
        {
                float val_3 = scale.y * 0.5f;
            if((UnityEngine.Mathf.RoundToInt(f:  null)) == ((UnityEngine.Mathf.RoundToInt(f:  val_3)) << 1))
        {
                val_3 = -0.5f;
        }
        
            float val_6 = scale.z * 0.5f;
            if((UnityEngine.Mathf.RoundToInt(f:  val_3 = val_9 + val_3)) == ((UnityEngine.Mathf.RoundToInt(f:  val_6)) << 1))
        {
                val_6 = val_8;
            val_6 = val_6 + 0.5f;
            val_8 = val_6;
        }
        
        }
        
        mem2[0] = val_9;
        return new UnityEngine.Vector3() {x = val_6, z = val_9};
    }
    public static UnityEngine.Vector2 ConstrainRect(UnityEngine.Vector2 minRect, UnityEngine.Vector2 maxRect, UnityEngine.Vector2 minArea, UnityEngine.Vector2 maxArea)
    {
        var val_2;
        var val_3;
        float val_8;
        var val_9;
        var val_10;
        var val_11;
        float val_12;
        val_8 = minArea.y;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_12 = val_8;
        var val_8 = val_9;
        var val_10 = val_10;
        var val_9 = SB;
        float val_4 = val_8 - val_12;
        float val_6 = val_9 - val_10;
        val_4 = (maxRect.y - minRect.y) - val_4;
        val_8 = val_4 + val_8;
        val_12 = val_12 - val_4;
        val_9 = val_8;
        val_8 = val_12;
        val_6 = (minArea.x - maxRect.x) - val_6;
        val_9 = val_6 + val_9;
        val_10 = val_10 - val_6;
        val_11 = val_9;
        val_10 = val_10;
        if(UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished < 0)
        {
                minRect.y = val_8 - minRect.y;
            val_8 = val_3;
            minRect.y = minRect.y + val_8;
            val_3 = minRect.y;
        }
        
        if(UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished > 0)
        {
                maxRect.y = maxRect.y - val_9;
            val_9 = val_3;
            maxRect.y = val_9 - maxRect.y;
            val_3 = maxRect.y;
        }
        
        if(UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished < 0)
        {
                maxRect.x = val_10 - maxRect.x;
            val_10 = val_2;
            maxRect.x = maxRect.x + val_10;
            val_2 = maxRect.x;
        }
        
        if(UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished > 0)
        {
                minArea.x = minArea.x - val_11;
            val_11 = val_2;
            minArea.x = val_11 - minArea.x;
            val_2 = minArea.x;
        }
        
        return new UnityEngine.Vector2() {x = minArea.x, y = val_12};
    }
    public static UnityEngine.Vector3 SpringDampen(ref UnityEngine.Vector3 velocity, float strength, float deltaTime)
    {
        float val_4;
        var val_5;
        float val_7 = 1000f;
        val_7 = R3 * val_7;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_7);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 2.924646E+26f, y = velocity.y, z = R7}, d:  0f);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 2.924644E+26f, y = velocity.y}, d:  val_2.x);
        mem[1152921510704490424] = val_5;
        velocity.y = val_4;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = velocity.x}, d:  val_3.x);
        return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public static UnityEngine.Vector2 SpringDampen(ref UnityEngine.Vector2 velocity, float strength, float deltaTime)
    {
        float val_6;
        float val_9 = 1000f;
        val_9 = R3 * val_9;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_9);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 2.949035E+26f, y = velocity.y}, d:  0f);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 2.949034E+26f, y = velocity.y}, d:  val_2.x);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 2.957161E+26f, y = val_6}, d:  val_3.x);
        return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
    }
    public static float SpringLerp(float strength, float deltaTime)
    {
        float val_3;
        float val_4;
        val_3 = R1 * 1000f;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_3);
        if(val_1 >= 1)
        {
                uint val_3 = 0;
            var val_4 = val_1;
            val_3 = val_3 * 0.001f;
            float val_2 = UnityEngine.Mathf.Lerp(a:  val_3, b:  deltaTime, t:  0.001f);
            val_4 = 0;
            val_4 = val_4 - 1;
            return val_3;
        }
        
        val_4 = 0f;
        return val_3;
    }
    public static float SpringLerp(float from, float to, float strength, float deltaTime)
    {
        var val_3;
        float val_4;
        var val_5;
        float val_6;
        val_3 = 0;
        val_4 = R2;
        val_5 = 35653764;
        val_6 = R3 * 1000f;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_6);
        if(val_1 < 1)
        {
                return (float)val_6;
        }
        
        float val_3 = val_4;
        val_3 = val_3 * 0.001f;
        val_4 = val_3;
        float val_2 = UnityEngine.Mathf.Lerp(a:  val_3, b:  to, t:  0.001f);
        val_5 = val_1 - 1;
        val_3 = val_3;
        val_6 = 0;
        return (float)val_6;
    }
    public static UnityEngine.Vector2 SpringLerp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float strength, float deltaTime)
    {
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = from.x, y = from.y}, b:  new UnityEngine.Vector2() {x = to.x, y = to.y}, t:  NGUIMath.SpringLerp(strength:  strength, deltaTime:  deltaTime));
        return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public static UnityEngine.Vector3 SpringLerp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float strength, float deltaTime)
    {
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, b:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z}, t:  NGUIMath.SpringLerp(strength:  strength, deltaTime:  deltaTime));
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static UnityEngine.Quaternion SpringLerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, float strength, float deltaTime)
    {
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w}, b:  new UnityEngine.Quaternion() {x = to.x, y = to.y, z = to.z, w = to.w}, t:  NGUIMath.SpringLerp(strength:  strength, deltaTime:  deltaTime));
        return new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
    }
    public static float RotateTowards(float from, float to, float maxAngle)
    {
        var val_2;
        var val_2 = R1;
        val_2 = val_2 - 0;
        val_2 = val_2 + (-360f);
        val_2 = val_2 + 360f;
        float val_1 = UnityEngine.Mathf.Sign(f:  System.Math.Abs(val_2));
        var val_4 = val_2;
        val_2 = val_4 * R2;
        val_4 = val_2 + 0;
        return (float)val_4;
    }
    private static float DistancePointToLineSegment(UnityEngine.Vector2 point, UnityEngine.Vector2 a, UnityEngine.Vector2 b)
    {
        float val_8;
        float val_22;
        float val_23;
        var val_24;
        val_22 = b.y;
        val_23 = b.x;
        val_23 = val_23;
        val_22 = b.y;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 3.09544E+26f, y = val_23}, b:  new UnityEngine.Vector2() {x = val_22, y = a.x});
        float val_2 = 0.sqrMagnitude;
        val_24 = null;
        uint val_22 = 1803552320;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 3.095437E+26f, y = point.x}, b:  new UnityEngine.Vector2() {x = point.y, y = a.x});
        return (float)val_8.magnitude;
    }
    public static float DistanceToRectangle(UnityEngine.Vector2[] screenPoints, UnityEngine.Vector2 mousePos)
    {
        float val_3;
        float val_4;
        float val_6;
        float val_7;
        var val_12;
        var val_15;
        var val_16;
        float val_17;
        float val_19;
        float val_20;
        val_15 = 0;
        do
        {
            val_17 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 3.15036E+26f, y = screenPoints[0]});
            var val_2 = 4 & 3;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 3.150356E+26f, y = screenPoints[val_2 << 3]});
            var val_20 = val_6;
            if(1803701180 <= val_2)
        {
                0 = 1;
        }
        
            if(1803701180 > val_2)
        {
                0 = 1;
        }
        
            if(1 == 1)
        {
                var val_21 = val_7;
            val_20 = val_20 - val_4;
            val_21 = val_21 - val_3;
            val_21 = (mousePos.y - val_4) * val_21;
            val_20 = val_21 / val_20;
            val_20 = val_3 + val_20;
            if(1 > 1)
        {
                val_15 = val_15 ^ 1;
        }
        
        }
        
            val_19 = val_17;
        }
        while((val_17 + 1) != 5);
        
        if((val_15 & 1) == 0)
        {
                val_20 = 0f;
            return (float)mousePos.x;
        }
        
        val_16 = 0;
        do
        {
            var val_10 = 0 + 1;
            val_10 = val_10 & 3;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 3.15036E+26f, y = 8.927367E-20f});
            val_15 = val_12;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 3.150356E+26f, y = screenPoints[val_10 << 3]});
            val_19 = val_7;
            val_17 = val_6;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 3.150353E+26f, y = val_3, z = val_4});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 3.15035E+26f, y = val_19, z = val_17});
            float val_17 = NGUIMath.DistancePointToLineSegment(point:  new UnityEngine.Vector2() {x = mousePos.x, y = mousePos.y}, a:  new UnityEngine.Vector2(), b:  new UnityEngine.Vector2());
            if(val_4 < 0)
        {
                -1f = mousePos.x;
        }
        
            if(val_4 < 0)
        {
                val_20 = mousePos.x;
        }
        
        }
        while(val_10 != 4);
        
        return (float)mousePos.x;
    }
    public static float DistanceToRectangle(UnityEngine.Vector3[] worldPoints, UnityEngine.Vector2 mousePos, UnityEngine.Camera cam)
    {
        var val_3;
        UnityEngine.Camera val_6;
        var val_6 = 0;
        do
        {
            val_6 = cam;
            if(val_6 == 0)
        {
                val_6 = cam;
        }
        
            UnityEngine.Vector3 val_1 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_6, y = mem[worldPoints[0x10] + (0)], z = mem[worldPoints[0x10] + (4)]});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 3.220391E+26f});
            val_6 = val_6 + 1;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_3;
        }
        while(val_6 != 4);
        
        return (float)NGUIMath.DistanceToRectangle(screenPoints:  533908128, mousePos:  new UnityEngine.Vector2() {x = mousePos.x, y = mousePos.y});
    }

}
