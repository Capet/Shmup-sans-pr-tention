using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ennemi_comportement : MonoBehaviour
{
    // Start is called before the first frame update
    float PointsDeVie;
    [SerializeField] float PVmax;
    [SerializeField] GameObject Explosion;
    public UnityEvent Death;
    void Start()
    {
        PointsDeVie = PVmax;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
            {
            PointsDeVie--;
            Debug.Log("pv" + PointsDeVie);
            GetComponent<SpriteRenderer>().material.color = Color.Lerp(Color.red, Color.white, PointsDeVie/PVmax);
            Debug.Log("Ratio" + PointsDeVie/PVmax);
            if (PointsDeVie <= 0)
                {
                 Die();
                }
            }
        //Pour que ça soit seulement les lasers qui lui fassent des dégâts
    }

    private void Die()
    {
        Destroy(gameObject);
        Explosion.SetActive(true);
        Death.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
