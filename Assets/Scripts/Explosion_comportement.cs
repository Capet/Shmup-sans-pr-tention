using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_comportement : MonoBehaviour
{
    [SerializeField] float Ceufor;
    // Start is called before the first frame update
    void Start()
    {
        var Rigidbodies_Enfants = GetComponentsInChildren<Rigidbody2D>(); // L'arrivée
        foreach (var RigidBody_Enfant in Rigidbodies_Enfants)
        {
            var Trajectoire = RigidBody_Enfant.position - (Vector2)transform.position;
            RigidBody_Enfant.AddForce(Trajectoire * Ceufor, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
