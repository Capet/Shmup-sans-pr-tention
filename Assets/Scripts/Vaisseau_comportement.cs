using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class Vaisseau_comportement : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] float SetDelay;
    float ShootDelay;
    [SerializeField] float Vitesse;
    [SerializeField] float VitesseRotation;
    private Controles Inputs;
    public Vector2 Direction;
    public Vector2 Regard;
    public Evenements_BougerSouris BougerSouris;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Inputs = new Controles();
        Inputs.Enable();
        Inputs.Vaisseau.Shoot.performed += Shoot;
        Inputs.Vaisseau.Deplacement.performed += Deplacement;
        Inputs.Vaisseau.Deplacement.canceled += DeplacementAnnule;
        Inputs.Vaisseau.Rotation.performed += Rotation;

    }

    // Update is called once per frame
    void Update()
    {
        var Direction3D = new Vector3(Direction.x,Direction.y,0);
        transform.position += Direction3D.normalized * Vitesse * Time.deltaTime;
        //convertir la position de la souris dans une position de notre monde 2D
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Regard);
        Vector2 direction = ((Vector2)mouseWorldPosition - (Vector2)transform.position).normalized;
        transform.right = direction;
        //var DirectionRotation = new Vector3(0, 0, Rotation);
        //transform.rotation *= Quaternion.Euler(DirectionRotation * Time.deltaTime * VitesseRotation);
        //Time.deltaTime pour que le perso ne bouge pas moins vite si ça se met à ramer car sa vitesse est en fontion du temps écoulé entre chaque frame
        ShootDelay += Time.deltaTime;

       /* if (Input.GetButton("Jump")&& ShootDelay>SetDelay)
        {
            Shoot();
        }*/
    }

    void Rotation(InputAction.CallbackContext CBC)
    {
        Regard = CBC.ReadValue<Vector2>();
        BougerSouris.Invoke(Regard);
    }


    void Deplacement (InputAction.CallbackContext CBC)
    {
        Direction = CBC.ReadValue<Vector2>();
    }

    void DeplacementAnnule(InputAction.CallbackContext CBC)
    {
        Direction = Vector2.zero;
    }

    void Shoot(InputAction.CallbackContext CBC)
    {
        ShootDelay = 0;
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
