using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportement_spawneur : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Vector3 positionMin = cam.ScreenToWorldPoint(new Vector3(0, 0, 10));
            Vector3 positionMax = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, 10));
            Vector2 position = new Vector2(Random.Range(positionMin.x, positionMax.x), Random.Range(positionMin.y, positionMax.y));
            //Vector2 position = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube),position,Quaternion.identity);
        }
    }
}
