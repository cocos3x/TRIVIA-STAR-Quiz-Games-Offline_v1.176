using UnityEngine;
public class Math3D
{
    // Fields
    private static UnityEngine.Transform tempChild;
    private static UnityEngine.Transform tempParent;
    private static UnityEngine.Vector3[] positionRegister;
    private static float[] posTimeRegister;
    private static int positionSamplesTaken;
    private static UnityEngine.Quaternion[] rotationRegister;
    private static float[] rotTimeRegister;
    
    // Methods
    public static void Init()
    {
        var val_9;
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  -2130397440);
        UnityEngine.Transform val_2 = transform;
        val_9 = null;
        val_9 = null;
        Math3D.tempChild = null;
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  -2130397328);
        UnityEngine.Transform val_4 = transform;
        Math3D.tempParent = null;
        UnityEngine.GameObject val_5 = gameObject;
        hideFlags = 61;
        UnityEngine.GameObject val_6 = gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  157720576);
        UnityEngine.GameObject val_7 = gameObject;
        hideFlags = 61;
        UnityEngine.GameObject val_8 = gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  157720576);
        parent = 157720576;
    }
    public static UnityEngine.Vector3 AddVectorLength(UnityEngine.Vector3 vector, float size)
    {
        var val_1;
        float val_2 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = vector.y, y = vector.z, z = R3});
        float val_5 = vector.y;
        val_5 = (val_5 + val_1) / val_5;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, d:  val_5);
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static UnityEngine.Vector3 SetVectorLength(UnityEngine.Vector3 vector, float size)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = -2.503778E-38f, y = vector.y, z = vector.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = vector.x}, d:  val_2.x);
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static UnityEngine.Quaternion SubtractRotation(UnityEngine.Quaternion B, UnityEngine.Quaternion A)
    {
        float val_2;
        float val_4 = val_4;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = -2.535165E-38f, y = A.y, z = val_4, w = A.w});
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = B.x}, rhs:  new UnityEngine.Quaternion() {x = val_2, y = B.y, z = B.z, w = B.w});
        return new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    public static bool PlanePlaneIntersection(out UnityEngine.Vector3 linePoint, out UnityEngine.Vector3 lineVec, UnityEngine.Vector3 plane1Normal, UnityEngine.Vector3 plane1Position, UnityEngine.Vector3 plane2Normal, UnityEngine.Vector3 plane2Position)
    {
        float val_2;
        float val_3;
        float val_5;
        float val_7;
        var val_8;
        float val_10;
        float val_11;
        float val_12;
        float val_15;
        var val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        val_19 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        mem[1152921511066913224] = val_2;
        linePoint.x = val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        mem[1152921511066917368] = val_3;
        linePoint.y = val_5;
        val_20 = linePoint.z;
        val_21 = lineVec.x;
        val_22 = lineVec.y;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.573513E-38f, y = val_20, z = val_21}, rhs:  new UnityEngine.Vector3() {x = -2.590514E-38f, y = plane1Normal.z, z = plane1Position.x});
        linePoint.y = val_7;
        mem[1152921511066917368] = val_8;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.573509E-38f, y = plane1Normal.z, z = plane1Position.x}, rhs:  new UnityEngine.Vector3() {x = plane1Position.y, y = linePoint.y});
        float val_13 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = -2.590514E-38f}, rhs:  new UnityEngine.Vector3() {x = val_10, y = val_12, z = val_11});
        float val_19 = System.Math.Abs(val_20);
        val_23 = plane1Normal.y;
        val_20 = plane1Normal.x;
        val_25 = lineVec.z;
        val_23 = plane1Normal.y;
        val_25 = val_25;
        val_24 = plane1Position.z;
        val_21 = val_21;
        val_22 = val_24;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.573519E-38f, y = -2.591676E-38f, z = val_20}, b:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = plane2Normal.x});
        float val_16 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint.z, y = lineVec.x, z = -2.590514E-38f}, rhs:  new UnityEngine.Vector3() {x = val_3, y = val_15, z = val_2});
        float val_20 = linePoint.z;
        val_20 = val_20 / val_20;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(d:  val_20, a:  new UnityEngine.Vector3() {x = -2.573517E-38f, y = val_20, z = val_10});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.573513E-38f, y = val_22, z = plane2Normal.x}, b:  new UnityEngine.Vector3() {x = val_21});
        val_19 = 1;
        mem[1152921511066913224] = val_8;
        linePoint.x = val_7;
        return (bool)val_19;
    }
    public static bool LinePlaneIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint)
    {
        float val_2;
        var val_3;
        float val_10;
        var val_11;
        var val_12;
        float val_13;
        float val_14;
        val_12 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        mem[1152921511067062472] = val_3;
        intersection.x = val_2;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.615345E-38f, y = planeNormal.y, z = planeNormal.z}, b:  new UnityEngine.Vector3() {x = planePoint.x, y = intersection.y, z = intersection.z});
        float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = lineVec.y, y = lineVec.z, z = planeNormal.x});
        val_13 = linePoint.z;
        val_14 = lineVec.x;
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint.y, y = val_13, z = val_14}, rhs:  new UnityEngine.Vector3() {x = lineVec.y, y = lineVec.z, z = planeNormal.x});
        float val_7 = R0 / linePoint.y;
        UnityEngine.Vector3 val_8 = Math3D.SetVectorLength(vector:  new UnityEngine.Vector3() {x = -2.61535E-38f, y = linePoint.y, z = val_13}, size:  linePoint.y);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.615345E-38f, y = -2.628854E-38f, z = -2.630011E-38f}, b:  new UnityEngine.Vector3() {x = linePoint.x});
        val_12 = 1;
        mem[1152921511067062472] = val_11;
        intersection.x = val_10;
        return (bool)val_12;
    }
    public static bool LineLineIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
    {
        float val_2;
        var val_3;
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_11;
        float val_12;
        float val_13;
        float val_19 = 0f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        mem2[0] = val_3;
        mem2[0] = val_2;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.653671E-38f, y = lineVec1.y, z = lineVec1.z}, b:  new UnityEngine.Vector3() {x = linePoint2.x, y = intersection.y, z = intersection.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.653667E-38f, y = linePoint1.y, z = linePoint1.z}, rhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = linePoint2.y, z = linePoint2.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.653664E-38f, y = val_6, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_2, y = linePoint2.y, z = linePoint2.z});
        float val_14 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_2}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_19, z = val_8});
        val_19 = 0;
        float val_15 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_19, z = val_8});
        float val_19 = val_11;
        float val_16 = val_9.sqrMagnitude;
        val_19 = val_19 / 2165340896;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.653674E-38f, y = linePoint1.y, z = linePoint1.z}, d:  1f);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.653671E-38f, y = -2.667184E-38f, z = -2.668341E-38f}, b:  new UnityEngine.Vector3() {x = linePoint1.x});
        val_19 = 1;
        mem2[0] = val_2;
        mem2[0] = val_6;
        return (bool)val_19;
    }
    public static bool LineLineIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Ray ray1, UnityEngine.Ray ray2)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        UnityEngine.Vector3 val_1 = origin;
        UnityEngine.Vector3 val_2 = direction;
        UnityEngine.Vector3 val_3 = origin;
        UnityEngine.Vector3 val_4 = direction;
        return (bool)Math3D.LineLineIntersection(intersection: out  new UnityEngine.Vector3() {x = -2.704358E-38f}, linePoint1:  new UnityEngine.Vector3() {y = val_9, z = val_10}, lineVec1:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_8}, linePoint2:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_13}, lineVec2:  new UnityEngine.Vector3() {x = val_7});
    }
    public static bool ClosestPointsOnTwoLines(out UnityEngine.Vector3 closestPointLine1, out UnityEngine.Vector3 closestPointLine2, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
    {
        float val_2;
        float val_3;
        float val_5;
        var val_6;
        float val_12;
        var val_19;
        float val_20;
        float val_23;
        var val_24;
        float val_25;
        var val_26;
        float val_27;
        float val_28;
        float val_29;
        val_25 = linePoint2.y;
        val_26 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        mem[1152921511067485256] = val_2;
        closestPointLine1.x = val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        mem[1152921511067489400] = val_6;
        closestPointLine1.y = val_5;
        float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = -2.751993E-38f, y = linePoint1.x, z = linePoint1.y}, rhs:  new UnityEngine.Vector3() {x = -2.751993E-38f, y = linePoint1.x, z = linePoint1.y});
        val_27 = lineVec1.z;
        val_28 = closestPointLine2.z;
        float val_8 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = -2.751993E-38f, y = linePoint1.x, z = linePoint1.y}, rhs:  new UnityEngine.Vector3() {x = val_27, y = linePoint2.x, z = val_25});
        val_29 = closestPointLine2.z;
        float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_27, y = linePoint2.x, z = val_25}, rhs:  new UnityEngine.Vector3() {x = val_27, y = linePoint2.x, z = val_25});
        float val_10 = 2165691696 * val_27;
        val_25 = closestPointLine1.z;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.733839E-38f, y = val_25, z = closestPointLine2.x}, b:  new UnityEngine.Vector3() {x = -2.750832E-38f, y = linePoint1.z, z = lineVec1.x});
        val_28 = val_3;
        val_29 = linePoint1.x;
        val_27 = linePoint1.y;
        float val_13 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = -2.751993E-38f, y = val_29, z = val_27}, rhs:  new UnityEngine.Vector3() {x = val_28, y = val_12, z = val_2});
        float val_14 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.z, y = linePoint2.x, z = linePoint2.y}, rhs:  new UnityEngine.Vector3() {x = val_28, y = val_12, z = val_2});
        float val_15 = 2165691696 * lineVec1.z;
        val_15 = val_15 / val_10;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.733835E-38f, y = -2.751993E-38f, z = val_29}, d:  val_15);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.73383E-38f, y = val_25, z = closestPointLine2.x}, b:  new UnityEngine.Vector3() {x = -2.750832E-38f});
        float val_18 = 2165691696 * lineVec1.z;
        mem[1152921511067485256] = val_19;
        closestPointLine1.x = val_20;
        val_18 = val_18 / val_10;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.733827E-38f, y = lineVec1.z, z = linePoint2.x}, d:  val_18);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.733823E-38f, y = linePoint1.z, z = lineVec1.x}, b:  new UnityEngine.Vector3() {x = lineVec1.y});
        val_26 = 1;
        mem[1152921511067489400] = val_24;
        closestPointLine1.y = val_23;
        return (bool)val_26;
    }
    public static UnityEngine.Vector3 ProjectPointOnLine(UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 point)
    {
        float val_1;
        float val_6;
        float val_7;
        float val_8;
        val_6 = point.y;
        val_7 = val_7;
        val_8 = val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.772199E-38f, y = val_6, z = val_7}, b:  new UnityEngine.Vector3() {x = val_8, y = linePoint.y, z = linePoint.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.772195E-38f, y = lineVec.y, z = lineVec.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = lineVec.y, y = lineVec.z, z = point.x}));
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z}, b:  new UnityEngine.Vector3() {x = lineVec.x});
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static UnityEngine.Vector3 ProjectPointOnLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
    {
        float val_7;
        float val_8;
        float val_9;
        float val_12 = point.x;
        val_12 = val_12;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.803583E-38f, y = linePoint2.y, z = linePoint2.z}, b:  new UnityEngine.Vector3() {x = val_12, y = linePoint1.y, z = linePoint1.z});
        UnityEngine.Vector3 val_4 = normalized;
        UnityEngine.Vector3 val_6 = Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = -2.803577E-38f, y = linePoint1.y, z = linePoint1.z}, lineVec:  new UnityEngine.Vector3() {x = linePoint2.x}, point:  new UnityEngine.Vector3() {y = point.y, z = point.z});
        int val_10 = Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = linePoint1.y, y = linePoint1.z, z = linePoint2.x}, linePoint2:  new UnityEngine.Vector3() {x = linePoint2.y, y = linePoint2.z, z = val_12}, point:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
        if(val_10 == 2)
        {
            goto label_5;
        }
        
        if(val_10 == 1)
        {
            goto label_6;
        }
        
        if(val_10 != 0)
        {
            goto label_7;
        }
        
        mem2[0] = val_7;
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        label_5:
        mem2[0] = linePoint2.y;
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        label_6:
        mem2[0] = linePoint1.y;
        mem2[0] = linePoint1.z;
        mem2[0] = linePoint2.x;
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        label_7:
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public static UnityEngine.Vector3 ProjectPointOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
    {
        float val_1;
        planePoint.y = planePoint.y;
        float val_5 = planeNormal.y;
        val_5 = val_5 ^ 2147483648;
        UnityEngine.Vector3 val_3 = Math3D.SetVectorLength(vector:  new UnityEngine.Vector3() {x = -2.834977E-38f, y = planeNormal.y, z = planeNormal.z}, size:  Math3D.SignedDistancePlanePoint(planeNormal:  new UnityEngine.Vector3() {x = val_5, y = planeNormal.z, z = planePoint.x}, planePoint:  new UnityEngine.Vector3() {x = planePoint.y, y = planePoint.z, z = point.x}, point:  new UnityEngine.Vector3() {x = point.y, y = point.z, z = val_1}));
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = planeNormal.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = val_1});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static UnityEngine.Vector3 ProjectVectorOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 vector)
    {
        float val_1;
        float val_5 = vector.z;
        val_5 = val_5;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.y, y = val_5, z = val_1}, rhs:  new UnityEngine.Vector3() {x = planeNormal.y, y = planeNormal.z, z = vector.x}), a:  new UnityEngine.Vector3() {x = -2.866366E-38f, y = vector.y, z = planeNormal.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = planeNormal.x, y = vector.y, z = val_5}, b:  new UnityEngine.Vector3() {x = val_1});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static float SignedDistancePlanePoint(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_6;
        float val_7;
        float val_8;
        val_6 = point.x;
        val_7 = val_7;
        val_8 = point.z;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.897755E-38f, y = val_6, z = val_7}, b:  new UnityEngine.Vector3() {x = val_8, y = planePoint.x, z = planePoint.y});
        return (float)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, rhs:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_2});
    }
    public static float SignedDotProduct(UnityEngine.Vector3 vectorA, UnityEngine.Vector3 vectorB, UnityEngine.Vector3 normal)
    {
        float val_3 = normal.z;
        val_3 = val_3;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.929144E-38f, y = normal.x, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = val_3, y = vectorA.x, z = vectorA.y});
        return (float)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = vectorB.x, y = vectorB.y, z = vectorB.z});
    }
    public static float SignedVectorAngle(UnityEngine.Vector3 referenceVector, UnityEngine.Vector3 otherVector, UnityEngine.Vector3 normal)
    {
        float val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -2.960532E-38f, y = normal.x, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = normal.z, y = referenceVector.x, z = referenceVector.y});
        float val_5 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = referenceVector.x, y = referenceVector.y, z = referenceVector.z}, to:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z});
        float val_7 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, rhs:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z}));
        var val_8 = val_2;
        val_8 = referenceVector.x * val_8;
        return (float)val_8;
    }
    public static float AngleVectorPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 normal)
    {
        float val_1 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
        val_1 = 1.570796f - val_1;
        return (float)val_1;
    }
    public static float DotProductAngle(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2)
    {
        float val_1 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vec1.x, y = vec1.y, z = vec1.z}, rhs:  new UnityEngine.Vector3() {x = vec2.x, y = vec2.y, z = vec2.z});
        return -1f;
    }
    public static void PlaneFrom3Points(out UnityEngine.Vector3 planeNormal, out UnityEngine.Vector3 planePoint, UnityEngine.Vector3 pointA, UnityEngine.Vector3 pointB, UnityEngine.Vector3 pointC)
    {
        var val_2;
        float val_3;
        var val_5;
        float val_6;
        float val_8;
        float val_9;
        float val_10;
        float val_12;
        float val_13;
        var val_17;
        float val_18;
        float val_21;
        float val_22;
        float val_23;
        float val_26;
        float val_27;
        float val_28;
        float val_30;
        float val_31;
        float val_32;
        float val_34;
        float val_35;
        float val_36;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        mem[1152921511068654888] = val_2;
        planeNormal.x = val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        mem[1152921511068659016] = val_5;
        planeNormal.y = val_6;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.061628E-38f, y = -3.079772E-38f, z = pointA.x}, b:  new UnityEngine.Vector3() {x = pointA.y, y = -3.076301E-38f, z = -3.077458E-38f});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.061624E-38f, y = pointA.z, z = pointB.x}, b:  new UnityEngine.Vector3() {x = pointB.y, y = -3.076301E-38f, z = -3.077458E-38f});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -3.061621E-38f, y = val_8, z = val_9}, rhs:  new UnityEngine.Vector3() {x = val_10, y = val_13, z = val_12});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = -3.061617E-38f});
        mem[1152921511068654888] = val_17;
        planeNormal.x = val_18;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.061614E-38f, y = val_8, z = val_9}, d:  val_16.x);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.061611E-38f, y = -3.076301E-38f, z = -3.077458E-38f}, b:  new UnityEngine.Vector3() {x = -3.078615E-38f});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.061607E-38f, y = val_13, z = val_12}, d:  val_20.x);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.061604E-38f, y = -3.076301E-38f, z = -3.077458E-38f}, b:  new UnityEngine.Vector3() {x = -3.078615E-38f});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.061601E-38f, y = pointA.z, z = pointB.x}, b:  new UnityEngine.Vector3() {x = pointB.y, y = val_21, z = val_22});
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.061597E-38f, y = -3.079772E-38f, z = pointA.x}, b:  new UnityEngine.Vector3() {x = pointA.y, y = val_26, z = val_27});
        bool val_37 = Math3D.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3() {x = -3.075144E-38f, y = -3.06164E-38f, z = val_21}, closestPointLine2: out  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_30}, linePoint1:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_26}, lineVec1:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_34}, linePoint2:  new UnityEngine.Vector3() {x = val_35, y = val_36}, lineVec2:  new UnityEngine.Vector3() {x = val_32, y = val_31, z = val_30});
    }
    public static UnityEngine.Vector3 GetForwardVector(UnityEngine.Quaternion q)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1});
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static UnityEngine.Vector3 GetUpVector(UnityEngine.Quaternion q)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1});
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static UnityEngine.Vector3 GetRightVector(UnityEngine.Quaternion q)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1});
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static UnityEngine.Quaternion QuaternionFromMatrix(UnityEngine.Matrix4x4 m)
    {
        float val_8;
        float val_9;
        UnityEngine.Vector4 val_2 = GetColumn(index:  -2127698016);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = -3.194119E-38f});
        UnityEngine.Vector4 val_5 = GetColumn(index:  -2127698016);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = -3.194111E-38f});
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = m.m00}, upwards:  new UnityEngine.Vector3() {y = val_9, z = val_8});
        return new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    public static UnityEngine.Vector3 PositionFromMatrix(UnityEngine.Matrix4x4 m)
    {
        UnityEngine.Vector4 val_2 = GetColumn(index:  -2127586016);
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        m.m00 = new UnityEngine.Vector3(x:  val_2.x, y:  val_2.y, z:  val_2.z);
        return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static void LookRotationExtended(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 customForward, UnityEngine.Vector3 customUp)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        float val_10;
        float val_11 = alignWithNormal.z;
        val_11 = val_11;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = -3.258069E-38f, y = alignWithVector.x, z = alignWithVector.y}, upwards:  new UnityEngine.Vector3() {x = alignWithVector.z, y = alignWithNormal.x, z = alignWithNormal.y});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = -3.258065E-38f, y = customForward.x, z = customForward.y}, upwards:  new UnityEngine.Vector3() {x = customForward.z, y = customUp.x, z = customUp.y});
        UnityEngine.Transform val_7 = gameObjectInOut.transform;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = -3.25806E-38f, y = R5, z = R6, w = R7});
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = -3.258056E-38f, y = val_2, z = val_3, w = val_4}, rhs:  new UnityEngine.Quaternion() {x = val_5});
        gameObjectInOut.rotation = new UnityEngine.Quaternion() {w = val_10};
    }
    public static void TransformWithParent(out UnityEngine.Quaternion childRotation, out UnityEngine.Vector3 childPosition, UnityEngine.Quaternion parentRotation, UnityEngine.Vector3 parentPosition, UnityEngine.Quaternion startParentRotation, UnityEngine.Vector3 startParentPosition, UnityEngine.Quaternion startChildRotation, UnityEngine.Vector3 startChildPosition)
    {
        float val_3;
        var val_4;
        float val_9;
        var val_10;
        var val_11;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        mem[1152921511069505672] = val_4;
        childRotation.y = val_3;
        val_11 = null;
        val_11 = null;
        Math3D.tempParent.rotation = new UnityEngine.Quaternion() {x = parentRotation.z, y = parentRotation.w, z = parentPosition.x, w = parentPosition.y};
        Math3D.tempParent.position = new UnityEngine.Vector3() {x = parentPosition.z, y = startParentRotation.x, z = startParentRotation.y};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        Math3D.tempParent.localScale = new UnityEngine.Vector3();
        Math3D.tempChild.rotation = new UnityEngine.Quaternion() {x = startParentRotation.z, y = startParentRotation.w, z = startParentPosition.x, w = startParentPosition.y};
        Math3D.tempChild.position = new UnityEngine.Vector3() {x = startParentPosition.z, y = startChildRotation.x, z = startChildRotation.y};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        Math3D.tempChild.localScale = new UnityEngine.Vector3();
        Math3D.tempParent.rotation = new UnityEngine.Quaternion() {x = childRotation.z, y = childRotation.w, z = -3.315979E-38f, w = childPosition.y};
        Math3D.tempParent.position = new UnityEngine.Vector3() {x = -3.318347E-38f, y = parentRotation.x, z = parentRotation.y};
        UnityEngine.Quaternion val_7 = rotation;
        UnityEngine.Vector3 val_8 = position;
        mem[1152921511069505672] = val_10;
        childRotation.y = val_9;
    }
    public static void PreciseAlign(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 alignWithPosition, UnityEngine.Vector3 triangleForward, UnityEngine.Vector3 triangleNormal, UnityEngine.Vector3 trianglePosition)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        val_9 = alignWithVector.z;
        val_9 = val_9;
        val_10 = triangleNormal.z;
        val_11 = triangleNormal.y;
        val_12 = triangleNormal.x;
        val_13 = triangleForward.z;
        val_14 = alignWithNormal.z;
        val_14 = val_14;
        val_9 = val_9;
        val_10 = triangleNormal.z;
        val_13 = triangleForward.z;
        val_12 = triangleNormal.x;
        val_11 = triangleNormal.y;
        Math3D.LookRotationExtended(gameObjectInOut: ref  UnityEngine.GameObject val_1 = -2127134400, alignWithVector:  new UnityEngine.Vector3() {x = alignWithVector.x, y = alignWithVector.y, z = val_9}, alignWithNormal:  new UnityEngine.Vector3() {x = alignWithNormal.x, y = alignWithNormal.y, z = val_14}, customForward:  new UnityEngine.Vector3() {x = triangleForward.x, y = triangleForward.y, z = val_13}, customUp:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_10});
        UnityEngine.Transform val_2 = gameObjectInOut.transform;
        UnityEngine.Vector3 val_3 = TransformPoint(position:  new UnityEngine.Vector3() {x = gameObjectInOut, y = trianglePosition.x, z = trianglePosition.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.339737E-38f, y = alignWithPosition.x, z = alignWithPosition.y}, b:  new UnityEngine.Vector3() {x = alignWithPosition.z});
        UnityEngine.Transform val_8 = gameObjectInOut.transform;
        gameObjectInOut.Translate(translation:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, relativeTo:  0);
    }
    public static void VectorsToTransform(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 positionVector, UnityEngine.Vector3 directionVector, UnityEngine.Vector3 normalVector)
    {
        float val_4;
        UnityEngine.Transform val_1 = gameObjectInOut.transform;
        gameObjectInOut.position = new UnityEngine.Vector3() {x = positionVector.x, y = positionVector.y, z = positionVector.z};
        UnityEngine.Transform val_2 = gameObjectInOut.transform;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = -3.373438E-38f, y = directionVector.x, z = directionVector.y}, upwards:  new UnityEngine.Vector3() {x = directionVector.z, y = normalVector.x, z = normalVector.y});
        gameObjectInOut.rotation = new UnityEngine.Quaternion() {w = val_4};
    }
    public static int PointOnWhichSideOfLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
    {
        float val_2;
        float val_3;
        float val_5;
        float val_6;
        var val_10;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.40596E-38f, y = linePoint2.x, z = linePoint2.y}, b:  new UnityEngine.Vector3() {x = linePoint2.z, y = linePoint1.x, z = linePoint1.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.405956E-38f, y = point.x, z = point.y}, b:  new UnityEngine.Vector3() {x = point.z, y = linePoint1.x, z = linePoint1.y});
        float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5, y = 0f, z = val_6}, rhs:  new UnityEngine.Vector3() {x = val_2, y = 0f, z = val_3});
        val_10 = 1;
        float val_8 = val_5.magnitude;
        float val_9 = val_6.magnitude;
        if(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    public static float MouseDistanceToLine(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2)
    {
        float val_3;
        float val_4;
        float val_7;
        float val_8;
        float val_9;
        float val_17;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = linePoint1.x, z = linePoint1.y});
        UnityEngine.Vector3 val_10 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = linePoint2.x, z = linePoint2.y});
        UnityEngine.Vector3 val_11 = Math3D.ProjectPointOnLineSegment(linePoint1:  new UnityEngine.Vector3() {x = -3.437343E-38f, y = val_7, z = val_8}, linePoint2:  new UnityEngine.Vector3() {x = val_9}, point:  new UnityEngine.Vector3() {y = val_3, z = val_4});
        UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_11.x, y:  val_11.y, z:  val_11.z);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.437338E-38f, y = val_14.x, z = val_14.y}, b:  new UnityEngine.Vector3() {x = val_14.z, y = val_3, z = val_4});
        return (float)val_17.magnitude;
    }
    public static float MouseDistanceToCircle(UnityEngine.Vector3 point, float radius)
    {
        float val_3;
        float val_4;
        float val_12;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = point.x, z = point.y});
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y, z:  val_6.z);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.468732E-38f, y = val_9.x, z = val_9.y}, b:  new UnityEngine.Vector3() {x = val_9.z, y = val_4, z = val_3});
        float val_13 = val_12.magnitude;
        uint val_14 = 2168249144;
        val_14 = val_14 - R3;
        return (float)val_14;
    }
    public static bool IsLineInRectangle(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectD)
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        val_7 = linePoint1.z;
        val_8 = rectD.z;
        val_9 = rectD.y;
        val_10 = rectC.z;
        val_11 = rectA.z;
        val_12 = rectA.y;
        val_13 = rectA.x;
        val_13 = val_13;
        val_9 = val_9;
        val_10 = rectC.z;
        val_12 = rectA.y;
        val_11 = rectA.z;
        val_8 = rectD.z;
        if((Math3D.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7}, rectA:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, rectC:  new UnityEngine.Vector3() {x = rectC.x, y = rectC.y, z = val_10}, rectB:  new UnityEngine.Vector3() {x = rectB.x, y = rectB.y, z = rectB.z}, rectD:  new UnityEngine.Vector3() {x = rectD.x, y = val_9, z = val_8})) == true)
        {
                return true;
        }
        
        val_14 = linePoint2.y;
        val_14 = val_14;
        val_7 = val_14;
        if((Math3D.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_14, z = linePoint2.z}, rectA:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, rectC:  new UnityEngine.Vector3() {x = rectC.x, y = rectC.y, z = val_10}, rectB:  new UnityEngine.Vector3() {x = rectB.x, y = rectB.y, z = rectB.z}, rectD:  new UnityEngine.Vector3() {x = rectD.x, y = rectD.y, z = rectD.z})) != false)
        {
                return true;
        }
        
        float val_8 = rectD.z;
        bool val_7 = Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_7, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, pointB2:  new UnityEngine.Vector3() {x = rectB.x, y = rectB.y, z = rectB.z});
        val_7 = val_7 | (Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_7, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = rectB.x, y = rectB.y, z = rectB.z}, pointB2:  new UnityEngine.Vector3() {x = rectC.x, y = rectC.y, z = val_10}));
        val_8 = val_7 | (Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_7, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = rectC.x, y = rectC.y, z = val_10}, pointB2:  new UnityEngine.Vector3() {x = rectD.x, y = rectD.y, z = val_8}));
        bool val_6 = Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = rectD.x, y = rectD.y, z = val_8}, pointB2:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
        val_6 = val_8 | val_6;
        return (bool)val_6;
    }
    public static bool IsPointInRectangle(UnityEngine.Vector3 point, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectD)
    {
        float val_3;
        float val_7;
        float val_13;
        float val_14;
        float val_16;
        float val_17;
        float val_22;
        float val_27;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.531505E-38f, y = rectC.x, z = rectC.y}, b:  new UnityEngine.Vector3() {x = rectC.z, y = rectA.x, z = rectA.y});
        float val_4 = val_3.magnitude;
        float val_5 = 2168473136 * (-0.5f);
        UnityEngine.Vector3 val_6 = Math3D.AddVectorLength(vector:  new UnityEngine.Vector3() {x = -3.531501E-38f, y = val_3, z = 0f}, size:  -0.5f);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.531497E-38f, y = rectA.x, z = rectA.y}, b:  new UnityEngine.Vector3() {x = rectA.z, y = val_7, z = 0f});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.531501E-38f, y = rectB.x, z = rectB.y}, b:  new UnityEngine.Vector3() {x = rectB.z, y = rectA.x, z = rectA.y});
        float val_11 = val_7.magnitude;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.531496E-38f, y = rectD.x, z = rectD.y}, b:  new UnityEngine.Vector3() {x = rectD.z, y = rectA.x, z = rectA.y});
        float val_15 = val_14.magnitude;
        UnityEngine.Vector3 val_18 = normalized;
        UnityEngine.Vector3 val_19 = Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = -3.53149E-38f, y = val_16, z = val_13}, lineVec:  new UnityEngine.Vector3() {x = val_17}, point:  new UnityEngine.Vector3() {y = point.x, z = point.y});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.531485E-38f}, b:  new UnityEngine.Vector3() {y = point.x, z = point.y});
        float val_23 = val_22.magnitude;
        UnityEngine.Vector3 val_24 = normalized;
        UnityEngine.Vector3 val_25 = Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = -3.531478E-38f, y = val_16, z = val_13}, lineVec:  new UnityEngine.Vector3() {x = val_17}, point:  new UnityEngine.Vector3() {y = point.x, z = point.y});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.531474E-38f}, b:  new UnityEngine.Vector3() {y = point.x, z = point.y});
        float val_29 = val_14 * 0.5f;
        float val_30 = 2168473120 * 0.5f;
        float val_31 = val_27.magnitude;
        if(Math3D.__il2cppRuntimeField_cctor_finished <= 0)
        {
                0 = 1;
        }
        
        if(Math3D.__il2cppRuntimeField_cctor_finished <= 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool AreLineSegmentsCrossing(UnityEngine.Vector3 pointA1, UnityEngine.Vector3 pointA2, UnityEngine.Vector3 pointB1, UnityEngine.Vector3 pointB2)
    {
        float val_9;
        float val_10;
        float val_11;
        float val_15;
        float val_16;
        float val_18;
        var val_19;
        val_15 = pointA2.z;
        val_16 = pointA2.y;
        val_16 = pointA2.y;
        val_15 = pointA2.z;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.562899E-38f, y = pointA2.x, z = val_16}, b:  new UnityEngine.Vector3() {x = val_15, y = pointA1.x, z = pointA1.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.562894E-38f, y = pointB2.x, z = pointB2.y}, b:  new UnityEngine.Vector3() {x = pointB2.z, y = pointB1.x, z = pointB1.y});
        UnityEngine.Vector3 val_7 = normalized;
        UnityEngine.Vector3 val_8 = normalized;
        val_18 = val_9;
        val_19 = 0;
        if((Math3D.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3() {x = -3.562917E-38f, y = -3.562912E-38f, z = pointA1.x}, closestPointLine2: out  new UnityEngine.Vector3() {x = pointA1.y, y = pointA1.z}, linePoint1:  new UnityEngine.Vector3() {z = pointB1.x}, lineVec1:  new UnityEngine.Vector3() {x = pointB1.y, y = pointB1.z, z = val_11}, linePoint2:  new UnityEngine.Vector3() {x = val_18, y = val_10}, lineVec2:  new UnityEngine.Vector3() {x = pointA2.x})) == false)
        {
                return (bool)val_19;
        }
        
        int val_14 = Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = pointB1.x, y = pointB1.y, z = pointB1.z}, linePoint2:  new UnityEngine.Vector3() {x = pointB2.x, y = pointB2.y, z = pointB2.z}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_14 = (Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = pointA1.x, y = pointA1.y, z = pointA1.z}, linePoint2:  new UnityEngine.Vector3() {x = pointA2.x, y = pointA2.y, z = pointA2.z}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_18})) | val_14;
        val_19 = val_14 >> 5;
        return (bool)val_19;
    }
    public static bool LinearAcceleration(out UnityEngine.Vector3 vector, UnityEngine.Vector3 position, int samples)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_6;
        var val_7;
        float val_26;
        float val_29;
        var val_30;
        var val_31;
        var val_32;
        float val_34;
        System.Single[] val_37;
        UnityEngine.Vector3[] val_38;
        float val_39;
        var val_40;
        var val_41;
        var val_43;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        if(position.y <= (4.203895E-45f))
        {
                position.y = 3;
        }
        
        mem[1152921511070567688] = val_7;
        vector.x = val_6;
        val_29 = 1152921504883363840;
        val_30 = null;
        val_30 = null;
        if(Math3D.positionRegister == null)
        {
                val_31 = null;
            val_31 = null;
            Math3D.positionRegister = null;
            val_30 = null;
            Math3D.posTimeRegister = null;
        }
        
        val_32 = 0;
        if(Math3D.positionRegister == null)
        {
                val_30 = null;
        }
        
        val_37 = position.y;
        val_30 = null;
        val_38 = Math3D.positionRegister;
        mem2[0] = vector.y;
        mem2[0] = vector.z;
        Length = position.x;
        if(Math3D.posTimeRegister != null)
        {
                float val_13 = UnityEngine.Time.time;
            val_39 = 0;
        }
        else
        {
                float val_14 = UnityEngine.Time.time;
            val_39 = 0;
        }
        
        mem2[0] = val_39;
        val_40 = null;
        int val_32 = Math3D.positionSamplesTaken;
        val_32 = val_32 + 1;
        Math3D.positionSamplesTaken = val_32;
        if(Math3D.positionSamplesTaken < 3)
        {
                return (bool);
        }
        
        val_41 = 0;
        val_38 = 1152921504883363840;
        if(Math3D.positionRegister == null)
        {
                val_40 = null;
        }
        
        val_40 = null;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.597719E-38f, y = val_26, z = val_6}, d:  (float)(UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2));
        val_29 = val_3;
        val_34 = val_2;
        val_37 = Math3D.posTimeRegister;
        System.Single[].__il2cppRuntimeField_byval_arg = (mem[(Math3D.posTimeRegister + ((System.Single[].__il2cppRuntimeField_namespaze - 1)) << 2) + 16]) - System.Single[].__il2cppRuntimeField_byval_arg;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.597716E-38f, y = val_29, z = val_4}, d:  System.Single[].__il2cppRuntimeField_byval_arg);
        mem[1152921511070567688] = val_7;
        val_43 = 1;
        vector.x = val_6;
        return (bool);
    }
    public static float LinearFunction2DBasic(float x, float Qx, float Qy)
    {
        var val_1 = R1;
        val_1 = R2 / val_1;
        val_1 = val_1 * 0;
        return (float)val_1;
    }
    public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
    {
        var val_1;
        var val_2 = val_1;
        var val_4 = R1;
        var val_3 = R3;
        val_2 = val_2 - R2;
        val_3 = val_3 - val_4;
        val_2 = val_2 / val_3;
        val_4 = 0 - val_4;
        return (float)val_2;
    }
    public static float DistanceFromPoint2Ray(UnityEngine.Vector3 point, UnityEngine.Ray ray)
    {
        float val_4;
        float val_5;
        float val_9;
        UnityEngine.Vector3 val_1 = direction;
        UnityEngine.Vector3 val_2 = origin;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.69529E-38f, y = point.x, z = point.y}, b:  new UnityEngine.Vector3() {x = point.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = -3.695287E-38f}, rhs:  new UnityEngine.Vector3() {y = val_5, z = val_4});
        return (float)val_9.magnitude;
    }
    public static float DistanceFromPoint2Ray(UnityEngine.Vector3 point, UnityEngine.Vector3 startingPoint, UnityEngine.Vector3 rayDirection)
    {
        rayDirection.x.Normalize();
        UnityEngine.Ray val_1 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = startingPoint.x, y = startingPoint.y, z = startingPoint.z}, direction:  new UnityEngine.Vector3() {x = rayDirection.x, y = rayDirection.y, z = rayDirection.z});
        return (float)Math3D.DistanceFromPoint2Ray(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_1.m_Origin.x, y = val_1.m_Origin.y, z = val_1.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_1.m_Direction.x, y = val_1.m_Direction.y, z = val_1.m_Origin.x}});
    }
    public Math3D()
    {
    
    }
    private static Math3D()
    {
    
    }

}
