using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeQuiBouge : MonoBehaviour
{
    private Vector3 Direction;
    private bool depart;
    public int couleur = 0;
    [SerializeField] private MeshRenderer myRenderer;
    private Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
      Direction = transform.right;
        depart = false;
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    /* void Update()
     {
         if (Input.GetButton("Jump"))
         {
             depart = true;
         }

         if (depart)
         {
             transform.position += Direction * 7 * Time.deltaTime;
         }
     }
     */
    private void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            depart = true;
        }
        if (depart)
        {
            //3 façons de bouger un Rigidbody
            //myRigidbody.MovePosition(myRigidbody.position + Direction * 7 * Time.fixedDeltaTime);
            myRigidbody.velocity = Direction * 42 * Time.fixedDeltaTime;
            //myRigidbody.AddForce(Direction * 42 * Time.fixedDeltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Ligne01"))
        {
            myRenderer.material.color = Color.red;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //depart = false;
        if (collision.gameObject.CompareTag("Ligne02"))
        {
            myRenderer.material.color = Color.green;
        }
    }
    void OnBecameInvisible() => Destroy(gameObject);
}