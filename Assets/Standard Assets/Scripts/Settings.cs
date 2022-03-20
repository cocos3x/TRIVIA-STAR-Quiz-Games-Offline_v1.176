using UnityEngine;
[Serializable]
public struct MeshGenerator.Settings
{
    // Fields
    public bool useClipping;
    public float zSpacing;
    public bool pmaVertexColors;
    public bool tintBlack;
    public bool calculateTangents;
    public bool addNormals;
    public bool immutableTriangles;
    
    // Properties
    public static Spine.Unity.MeshGenerator.Settings Default { get; }
    
    // Methods
    public static Spine.Unity.MeshGenerator.Settings get_Default()
    {
        mem[3] = 0;
        mem[1] = 0;
        mem2[0] = 1;
        mem[4] = 0;
        mem[8] = 1;
        mem[9] = 0;
        mem[15] = 0;
        mem[13] = 0;
        return new MeshGenerator.Settings() {useClipping = false, zSpacing = 0f, pmaVertexColors = true, tintBlack = false, calculateTangents = false, addNormals = false, immutableTriangles = false};
    }

}
