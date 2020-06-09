using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportement_cube_inputs : MonoBehaviour
{
    [SerializeField] float Vitesse;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        var VitesseHorizontale = Input.GetAxis("Horizontal");
        var VitesseVerticale = Input.GetAxis("Vertical");
        //var Rotation = Input.GetAxis("Rotate");
        var Direction = new Vector3(VitesseHorizontale, VitesseVerticale, 0);
        transform.position += Direction.normalized * Vitesse * Time.deltaTime;
    }
}
