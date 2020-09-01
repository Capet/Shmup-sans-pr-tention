using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Fonction distincte pour détruire l'objet qui sera lancée par la fin de l'animation de chargement
    public void Destruction()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
