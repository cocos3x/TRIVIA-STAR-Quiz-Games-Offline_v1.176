using UnityEngine;
public class ExporterRuntimeS : ScriptableObject
{
    // Fields
    private static int vertexOffset;
    private static int normalOffset;
    private static int uvOffset;
    
    // Methods
    private static string MeshToString(UnityEngine.MeshFilter mf, System.Collections.Generic.Dictionary<string, OMATRuntime> materialList)
    {
        int val_14;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        float val_57;
        UnityEngine.MeshFilter val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_63;
        var val_64;
        if(mf != 0)
        {
                UnityEngine.Mesh val_1 = mf.sharedMesh;
        }
        else
        {
                UnityEngine.Mesh val_2 = 0.sharedMesh;
        }
        
        object val_3 = mf.GetComponent<System.Object>();
        UnityEngine.Material[] val_4 = mf.sharedMaterials;
        System.Text.StringBuilder val_5 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_6 = Append(value:  1791515696);
        string val_7 = mf.name;
        System.Text.StringBuilder val_8 = Append(value:  mf);
        System.Text.StringBuilder val_9 = Append(value:  1269544832);
        val_49 = 0;
        if(val_49 == 0)
        {
                val_49 = 0;
        }
        
        UnityEngine.Vector3[] val_10 = val_49.vertices;
        val_50 = val_49;
        var val_11 = val_49 + 16;
        val_51 = 0;
        goto label_9;
        label_15:
        UnityEngine.Transform val_12 = mf.transform;
        UnityEngine.Vector3 val_13 = TransformPoint(position:  new UnityEngine.Vector3() {x = mf, y = mem[(val_49 + 16) + (0)], z = mem[(val_49 + 16) + (4)]});
        string val_17 = System.String.Format(format:  1791515776, arg0:  15282176, arg1:  15282176, arg2:  15282176);
        System.Text.StringBuilder val_18 = Append(value:  1791515776);
        val_11 = val_11 + 12;
        val_50 = val_49;
        val_51 = 1;
        label_9:
        if(val_51 < 0)
        {
            goto label_15;
        }
        
        System.Text.StringBuilder val_19 = Append(value:  1269544832);
        val_52 = 0;
        if(val_52 == 0)
        {
                val_52 = 0;
        }
        
        UnityEngine.Vector3[] val_20 = val_52.normals;
        val_53 = val_52;
        var val_21 = val_52 + 16;
        val_54 = 0;
        goto label_18;
        label_24:
        UnityEngine.Transform val_22 = mf.transform;
        UnityEngine.Vector3 val_23 = TransformDirection(direction:  new UnityEngine.Vector3() {x = mf, y = mem[(val_52 + 16) + (0)], z = mem[(val_52 + 16) + (4)]});
        string val_24 = System.String.Format(format:  1791515888, arg0:  15282176, arg1:  15282176, arg2:  15282176);
        System.Text.StringBuilder val_25 = Append(value:  1791515888);
        val_21 = val_21 + 12;
        val_53 = val_52;
        val_54 = 1;
        label_18:
        if(val_54 < 0)
        {
            goto label_24;
        }
        
        val_55 = 0;
        System.Text.StringBuilder val_26 = Append(value:  1269544832);
        val_56 = 0;
        if(val_56 == 0)
        {
                val_56 = 0;
        }
        
        UnityEngine.Vector2[] val_27 = val_56.uv;
        val_57 = val_56 + 16;
        goto label_27;
        label_33:
        UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.212369E+26f, y = val_57});
        string val_29 = System.String.Format(format:  1791516000, arg0:  15282176, arg1:  15282176);
        System.Text.StringBuilder val_30 = Append(value:  1791516000);
        val_57 = val_57 + 8;
        val_55 = 1;
        label_27:
        if(val_55 < 0)
        {
            goto label_33;
        }
        
        label_61:
        if(0 >= 0.subMeshCount)
        {
            goto label_35;
        }
        
        if(val_5 != 0)
        {
                System.Text.StringBuilder val_32 = Append(value:  1269544832);
        }
        else
        {
                System.Text.StringBuilder val_33 = Append(value:  1269544832);
        }
        
        System.Text.StringBuilder val_34 = Append(value:  1791516096);
        val_58 = mf;
        if(val_58 == 0)
        {
                val_58 = mf;
        }
        
        if((mf + 12) <= 0)
        {
                val_58 = mf;
        }
        
        UnityEngine.MeshFilter val_35 = val_58 + 0;
        string val_36 = (mf + 0) + 16.name;
        System.Text.StringBuilder val_37 = Append(value:  (mf + 0) + 16);
        System.Text.StringBuilder val_38 = Append(value:  1269544832);
        System.Text.StringBuilder val_39 = Append(value:  1791516192);
        string val_40 = (mf + 0) + 16.name;
        System.Text.StringBuilder val_41 = Append(value:  (mf + 0) + 16);
        System.Text.StringBuilder val_42 = Append(value:  1269544832);
        string val_43 = (mf + 0) + 16.name;
        materialList.Add(key:  (mf + 0) + 16, value:  new OMATRuntime() {name = (mf + 0) + 16, cls = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}});
        val_59 = 0;
        if(val_59 == 0)
        {
                val_59 = 0;
        }
        
        val_60 = 0;
        System.Int32[] val_44 = val_59.GetTriangles(submesh:  0);
        goto label_52;
        label_60:
        val_61 = null;
        val_61 = null;
        int val_45 = 2621443 + ExporterRuntimeS.vertexOffset;
        val_45 = val_45 + 1;
        val_14 = val_45;
        var val_52 = 1;
        int val_51 = 1;
        val_51 = val_51 + ExporterRuntimeS.normalOffset;
        val_51 = val_51 + 1;
        val_52 = val_52 + 1;
        int val_53 = 0;
        val_53 = val_53 + ExporterRuntimeS.uvOffset;
        val_53 = val_53 + 1;
        string val_46 = System.String.Format(format:  1791517312, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        System.Text.StringBuilder val_47 = Append(value:  1791517312);
        val_60 = val_52 + 1;
        label_52:
        if(val_60 < 0)
        {
            goto label_60;
        }
        
        goto label_61;
        label_35:
        val_63 = null;
        val_63 = null;
        val_64 = 0;
        if(val_64 == 0)
        {
                val_64 = 0;
        }
        
        UnityEngine.Vector3[] val_48 = val_64.vertices;
        int val_54 = 0;
        val_54 = val_54 + ExporterRuntimeS.vertexOffset;
        ExporterRuntimeS.vertexOffset = val_54;
        if(val_64 == 0)
        {
                val_64 = 0;
        }
        
        UnityEngine.Vector3[] val_49 = val_64.normals;
        int val_55 = 0;
        val_55 = val_55 + ExporterRuntimeS.normalOffset;
        ExporterRuntimeS.normalOffset = val_55;
        if(val_64 == 0)
        {
                val_64 = 0;
        }
        
        UnityEngine.Vector2[] val_50 = val_64.uv;
        int val_56 = 0;
        val_56 = val_56 + ExporterRuntimeS.uvOffset;
        ExporterRuntimeS.uvOffset = val_56;
        if(val_5 != 0)
        {
                return;
        }
    
    }
    private static void Clear()
    {
        null = null;
        ExporterRuntimeS.vertexOffset = 0;
        ExporterRuntimeS.normalOffset = 0;
        ExporterRuntimeS.uvOffset = 0;
    }
    private static System.Collections.Generic.Dictionary<string, OMATRuntime> PrepareFileWrite()
    {
        ExporterRuntimeS.Clear();
        System.Collections.Generic.Dictionary<System.String, OMATRuntime> val_1 = new System.Collections.Generic.Dictionary<System.String, OMATRuntime>();
    }
    private static void MaterialsToFile(System.Collections.Generic.Dictionary<string, OMATRuntime> materialList, string folder, string filename)
    {
        string val_6;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        string val_1 = folder + 1115175264 + filename + 1791874976;
        System.IO.StreamWriter val_2 = new System.IO.StreamWriter(path:  folder);
        Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        int val_7 = val_6.LastIndexOf(value:  '/');
        val_15 = val_6;
        if(val_7 >= 0)
        {
                string val_9 = val_6.Substring(startIndex:  val_7 + 1);
            string val_10 = val_6.Trim();
            val_15 = val_6;
        }
        
        string val_11 = folder + 1115175264 + val_15;
        if((System.IO.File.Exists(path:  folder)) == true)
        {
            goto label_8;
        }
        
        System.IO.File.Copy(sourceFileName:  val_6, destFileName:  folder);
        goto label_8;
        label_2:
        val_16 = 0;
        Dispose();
        if(val_2 == 0)
        {
            goto label_10;
        }
        
        System.IO.StreamWriter val_14 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_11;
        }
        
        val_14 = 0;
        label_13:
        val_16 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_12;
        }
        
        val_14 = val_14 + 1;
        val_16 = (uint)val_14 & 65535;
        if(val_16 < (mem[null + 178]))
        {
            goto label_13;
        }
        
        label_11:
        val_17 = val_2;
        goto label_14;
        label_12:
        var val_13 = (mem[null + 88]) + 0;
        val_14 = val_14 + (((mem[null + 88] + 0) + 4) << 3);
        label_14:
        label_10:
        if(0 == 0)
        {
                return;
        }
    
    }
    private static void MeshesToFile(UnityEngine.MeshFilter[] mf, string folder, string filename)
    {
        var val_7;
        var val_8;
        System.Collections.Generic.Dictionary<System.String, OMATRuntime> val_1 = ExporterRuntimeS.PrepareFileWrite();
        string val_2 = folder + 1115175264 + filename + 1792048368;
        System.IO.StreamWriter val_3 = new System.IO.StreamWriter(path:  folder);
        string val_4 = 1792048528 + filename + 1792048448;
        val_7 = 0;
        goto label_4;
        label_9:
        string val_5 = ExporterRuntimeS.MeshToString(mf:  -2028617200, materialList:  258732032);
        val_7 = 1;
        label_4:
        if(val_7 < val_3)
        {
            goto label_9;
        }
        
        if((mem[null + 178]) == 0)
        {
            goto label_10;
        }
        
        var val_7 = 0;
        label_12:
        if((mem[null + 88] + 0) == null)
        {
            goto label_11;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < (mem[null + 178]))
        {
            goto label_12;
        }
        
        label_10:
        val_8 = val_3;
        goto label_13;
        label_11:
        var val_6 = (mem[null + 88]) + 0;
        var val_8 = (mem[null + 88] + 0) + 4;
        val_8 = null + (val_8 << 3);
        label_13:
        ExporterRuntimeS.MaterialsToFile(materialList:  258732032, folder:  folder, filename:  filename);
    }
    public static void ExportGOToOBJ(UnityEngine.Transform[] selection, string mainPath, string filename)
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_14 = selection;
        val_15 = 0;
        string val_1 = mainPath + 1115175264 + filename + 1115175264;
        System.IO.DirectoryInfo val_2 = System.IO.Directory.CreateDirectory(path:  mainPath);
        System.Collections.ArrayList val_3 = new System.Collections.ArrayList();
        val_16 = 0;
        goto label_1;
        label_12:
        UnityEngine.Transform val_14 = val_14[val_15];
        val_17 = val_14;
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(152981504)});
        val_18 = 0;
        UnityEngine.Component[] val_5 = val_14.GetComponentsInChildren(t:  152981504);
        val_14 = val_14 + 16;
        goto label_6;
        label_10:
        val_18 = 1;
        label_6:
        if(val_18 < val_3)
        {
            goto label_10;
        }
        
        val_15 = 1;
        val_14 = val_17;
        val_16 = val_16 + val_18;
        label_1:
        if(val_15 < val_3)
        {
            goto label_12;
        }
        
        if(val_16 >= 1)
        {
                val_17 = null;
            if(val_3 >= 1)
        {
                var val_15 = 0;
            do
        {
            val_18 = 0;
            if(val_3 != 0)
        {
                if(null != null)
        {
            
        }
        
            if(null != null)
        {
            
        }
        else
        {
                val_18 = val_3;
        }
        
        }
        
            UnityEngine.MeshFilter[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_18;
            val_15 = val_15 + 1;
        }
        while(val_15 < val_3);
        
        }
        
            val_15 = filename;
            if((val_15.Equals(value:  1098586544)) != false)
        {
                UnityEngine.Transform val_16 = val_14[0];
            UnityEngine.GameObject val_7 = val_16.gameObject;
            string val_8 = val_16.name;
            val_15 = val_16;
        }
        
            int val_9 = val_15.LastIndexOf(value:  '/');
            if(val_9 >= 0)
        {
                string val_11 = val_15.Substring(startIndex:  val_9 + 1);
            string val_12 = val_15.Trim();
            val_15 = val_15;
        }
        
            ExporterRuntimeS.MeshesToFile(mf:  -2028617200, folder:  mainPath, filename:  val_15);
            string val_13 = 1792258928 + mainPath + 1115175264 + val_15;
            val_19 = "Exported: ";
        }
        else
        {
                val_19 = "Error exporting. Make sure you selected the object.";
        }
        
        UnityEngine.Debug.Log(message:  1792259024);
    }
    public ExporterRuntimeS()
    {
    
    }
    private static ExporterRuntimeS()
    {
    
    }

}
