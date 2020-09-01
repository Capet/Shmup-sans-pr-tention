using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_comportement : MonoBehaviour
{
    public Vector2 Direction;
    [SerializeField] float Vitesse;
    public Rigidbody2D myRigidBody;
    public Transform myTransform;


    // Start is called before the first frame update
    void Start()
    {
        //Direction = new Vector2(1, 0);
        myRigidBody = GetComponent<Rigidbody2D>();
        myRigidBody.AddForce(myTransform.right * Vitesse, ForceMode2D.Impulse);
        //transform.position = Direction;
    }

    void OnCollisionEnter2D()
    {
        myRigidBody.gravityScale = 1;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
