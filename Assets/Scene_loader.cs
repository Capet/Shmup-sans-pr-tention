using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    [SerializeField] GameObject EcranChargement;
    [SerializeField] string SceneACharger;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void CallChargement()
    {
        StartCoroutine(Chargement());
    }

    IEnumerator Chargement()
    {
        var EcranChargementInstancie = Instantiate(EcranChargement);
        DontDestroyOnLoad(EcranChargementInstancie);
        var EcranChargementAnimator = EcranChargementInstancie.GetComponent<Animator>();
        var EtatDeChargement = SceneManager.LoadSceneAsync(SceneACharger);
        var DureeAnimation = EcranChargementAnimator.GetCurrentAnimatorStateInfo(0).length;
        EtatDeChargement.allowSceneActivation = false;
        while (!EtatDeChargement.isDone)
        {
            if (EtatDeChargement.progress >= 0.9f)
            {
                EcranChargementAnimator.SetTrigger("CheckChargement");
                EtatDeChargement.allowSceneActivation = true;
            }
            yield return new WaitForSeconds(DureeAnimation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
