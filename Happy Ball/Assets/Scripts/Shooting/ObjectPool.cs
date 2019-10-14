using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Basic object pool implementation
/// </summary>
public class ObjectPool : MonoBehaviour
{
    // Reference to prefab.
    [SerializeField]
    private PoolableObject prefab;

    // References to reusable instances
    private Stack<PoolableObject> reusableInstances = new Stack<PoolableObject>();

    /// <summary>
    /// Returns instance of prefab.
    /// </summary>
    /// <returns>Instance of prefab.</returns>
    public PoolableObject GetPrefabInstance()
    {
        PoolableObject inst;
        if (reusableInstances.Count > 0)
        {
            inst = reusableInstances.Pop();
            inst.transform.SetParent(null);
            inst.gameObject.SetActive(true);
        }
        else
        {
            inst = Instantiate(prefab);
        }

        return inst;
    }

    public void ReturnToPool(PoolableObject instance)
    {
        instance.gameObject.SetActive(false);

        instance.transform.SetParent(transform);

        instance.transform.localPosition = Vector3.zero;
        instance.transform.localScale = Vector3.one;
        instance.transform.localEulerAngles = Vector3.one;

        reusableInstances.Push(instance);
    }
}
