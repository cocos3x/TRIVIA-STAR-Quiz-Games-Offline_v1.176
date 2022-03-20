using UnityEngine;
public class RawImageSkew : RawImage
{
    // Fields
    public UnityEngine.Vector2 skewAmount;
    
    // Methods
    protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
    {
        UnityEngine.Color val_1 = color;
        UnityEngine.Color32 val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        vh.Clear();
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_1.r, y:  val_1.g);
        float val_4 = xMax;
        float val_5 = yMax;
        uint val_23 = 2289696504;
        UnityEngine.Vector2 val_6 = 2289696504 + this.skewAmount;
        val_23 = val_23 + val_1.b;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_23, y:  val_1.g);
        vh.AddVert(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, color:  new UnityEngine.Color32() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, uv0:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_23, y:  val_1.g);
        float val_9 = xMax;
        float val_10 = yMin;
        uint val_24 = 2289696504;
        UnityEngine.Vector2 val_11 = 2289696504 - this.skewAmount;
        val_24 = val_24 + val_1.b;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_24, y:  val_1.g);
        vh.AddVert(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, color:  new UnityEngine.Color32() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, uv0:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_24, y:  val_1.g);
        float val_14 = xMin;
        float val_15 = yMin;
        uint val_25 = 2289696504;
        UnityEngine.Vector2 val_16 = 2289696504 - this.skewAmount;
        val_25 = val_25 - val_1.b;
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_25, y:  val_1.g);
        vh.AddVert(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, color:  new UnityEngine.Color32() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, uv0:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_25, y:  val_1.g);
        float val_19 = xMin;
        float val_20 = yMax;
        uint val_26 = 2289696504;
        UnityEngine.Vector2 val_21 = 2289696504 + this.skewAmount;
        val_26 = val_26 - val_1.b;
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_26, y:  val_1.g);
        vh.AddVert(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, color:  new UnityEngine.Color32() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, uv0:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        if(vh != 0)
        {
                vh.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
        }
        else
        {
                0.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
        }
        
        vh.AddTriangle(idx0:  2, idx1:  3, idx2:  0);
    }
    public RawImageSkew()
    {
    
    }

}
