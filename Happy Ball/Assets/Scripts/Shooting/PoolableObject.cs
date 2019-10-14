using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Poolable object used in regular object pool.
/// </summary>
public class PoolableObject : MonoBehaviour
{
    // Pool to return object
    public ObjectPool origin;

    /// <summary>
    /// Prepares instance to use.
    /// </summary>
    public virtual void PrepareToUse()
    {
        // prepare object for use
        // you can add additional code here if you want to.
    }

    /// <summary>
    /// Returns instance to pool.
    /// </summary>
    public virtual void ReturnToPool()
    {
        // prepare object for return.
        // you can add additional code here if you want to.

        origin.ReturnToPool(this);
    }
}
