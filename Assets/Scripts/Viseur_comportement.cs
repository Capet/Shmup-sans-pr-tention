using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viseur_comportement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SourisToViseur(Vector2 Regard)
    {
        var Regard3 = new Vector3 (Regard.x, Regard.y, 10);
        transform.position = Camera.main.ScreenToWorldPoint(Regard3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
