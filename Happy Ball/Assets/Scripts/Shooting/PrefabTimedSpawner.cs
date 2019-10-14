using UnityEngine;

/// <summary>
/// Prefab spawner.
/// Component uses object pool to get prefab instance every few moments.
/// </summary>
public class PrefabTimedSpawner : MonoBehaviour
{
    public FixedJoystick JoystickDirection;
    // Spawn rate
    [SerializeField]
    private float spawnRatePerMinute = 30;
    // Current spawn count
    private int currentCount = 0;
    private float nextFire = 0.0f;
    public float fireRate = 0.001f;

    // Reference to used object pool
    [SerializeField]
    private TimedObjectObjectPool objectPool;

    /// <summary>
    /// Unity's method called every frame
    /// </summary>
    private void Update ( )
    {
        if (JoystickDirection.Direction!=Vector2.zero && Time.time > nextFire)
        {
            //var targetCount = Time.time * (spawnRatePerMinute / 60);
            nextFire = Time.time + fireRate;
           // while (targetCount > currentCount)
           // {
                // Setup prefab instace to shoot!
                var inst = objectPool.GetPrefabInstance ( );
                inst.transform.position = transform.position;


                inst.transform.up = JoystickDirection.Direction;


                inst.Rigidbody.AddForce ( inst.transform.rotation * (Vector2.up * 10), ForceMode2D.Impulse );

                currentCount++;
           // }
        }


    }
}
