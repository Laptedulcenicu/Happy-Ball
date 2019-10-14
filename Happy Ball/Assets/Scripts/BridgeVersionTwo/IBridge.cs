using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public interface IBridge
    {
        void Start ( );
        void Update ( );
        void OnTriggerEnter2D ( Collider2D collision );
        void OnTriggerExit2D ( Collider2D collision );
        void TakeDamage ( int damage );
}

