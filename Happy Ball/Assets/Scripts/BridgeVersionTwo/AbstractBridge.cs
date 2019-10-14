using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractBridge : IAbstractBridge
{
    public IBridge bridge;

    public AbstractBridge ( IBridge bridge )
    {
        this.bridge = bridge;
    }

    public void CallMethod1 ( )
    {
        this.bridge.Update ( );
    }

    public void CallMethod2 ( Collider2D collision )
    {
        this.bridge.OnTriggerEnter2D (  collision );
    }

    public void CallMethod3 ( Collider2D collision )
    {
        this.bridge.OnTriggerExit2D ( collision );
    }

    public void CallMethod4 ( )
    {
        this.bridge.Start ( );
    }

    public void CallMethod5 ( int damage )
    {
        this.bridge.TakeDamage ( damage );
    }

}
