using UnityEngine;
using System.Collections;


public abstract class BoxEvents
{
    public abstract float GetForce();
}


public class Move : BoxEvents
{
    public override float GetForce()
    {
        return 30f;
    }
}
