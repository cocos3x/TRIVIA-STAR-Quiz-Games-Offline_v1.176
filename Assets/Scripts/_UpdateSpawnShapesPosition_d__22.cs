using UnityEngine;
private sealed class BlockShapeSpawner.<UpdateSpawnShapesPosition>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BlockPuzzleMagic.BlockShapeSpawner <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BlockShapeSpawner.<UpdateSpawnShapesPosition>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        var val_7;
        var val_8;
        float val_9;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = val_1;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_7 = 4;
        val_9 = 1152921504765685760;
        goto label_4;
        label_34:
        if(((this.<>4__this.spawnedShapes[0]) != 0) && ((this.<>4__this.ShapeContainers[0]) != 0))
        {
                BlockPuzzleMagic.ShapeInfo val_9 = this.<>4__this.spawnedShapes[0];
            UnityEngine.Transform val_10 = this.<>4__this.ShapeContainers[0];
            UnityEngine.Vector3 val_4 = position;
            BlockPuzzleMagic.ShapeInfo val_11 = this.<>4__this.spawnedShapes[0];
            if((this.<>4__this.spawnedShapes[0].isDragged) != true)
        {
                BlockPuzzleMagic.ShapeInfo val_12 = this.<>4__this.spawnedShapes[0];
            UnityEngine.Transform val_5 = val_12.transform;
            val_12.position = new UnityEngine.Vector3() {x = this.<>4__this.spawnedShapes[0].neutralWorldPosition, y = 1808108f, z = this.<>4__this.spawnedShapes[0]};
            val_8 = ;
            val_9 = 1152921504765685760;
        }
        
        }
        
        val_7 = 5;
        label_4:
        if((val_7 - 4) < val_12)
        {
            goto label_34;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
