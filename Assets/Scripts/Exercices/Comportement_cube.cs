using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportement_cube : MonoBehaviour
{
    [SerializeField] private Vector3 VitesseRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(VitesseRotation*Time.deltaTime, Space.Self);
    }
}
