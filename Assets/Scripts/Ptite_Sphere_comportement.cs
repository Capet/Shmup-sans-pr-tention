using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportement_Ptite_Sphere : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        //Direction = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)).normalized; //Normalise pour que la taille du vector soit tjs = à 1
        // il faudrait faire la même chose mais le vecteur irait du centre de la grosse sphère jusqu'à la position de la petite pour un effet d'explosion
        //Edit du 16 mai: fait
        //myRigidbody.AddForce(Direction * Ceufor * Time.fixedDeltaTime,ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
