﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for objects used in generic object pool
/// </summary>
public class GenericPoolableObject : MonoBehaviour, IPoolable
{
    // Pool to return object
    public IObjectPool Orgin { get; set; }

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

        Orgin.ReturnToPool(this);
    }
}