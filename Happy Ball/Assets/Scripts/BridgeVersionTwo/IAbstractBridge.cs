using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbstractBridge
{
    void CallMethod1 ( );
    void CallMethod2 ( Collider2D collision );
    void CallMethod3 ( Collider2D collision );
    void CallMethod4 ( );
    void CallMethod5 (int damage );
}
