using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Pass : MonoBehaviour
{

    

    public Drag drag;
    
    public GameObject shock;
    public string sceneFrom;
    public string sceneTo;
    public AudioClip scream;
    public Animator animator;
    public bool ispass;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update( )
    {
        if (drag.isFinished && !ispass)
        {
            shock.SetActive(true);
           
            StartCoroutine(CatShock());
            ispass = true;
            TransitionManager.Instance.Transition(sceneFrom, sceneTo);

        }
    }
    IEnumerator CatShock()
    {
        
        AudioManager.instance.AudioPlay(scream);

        animator.SetTrigger("catshock");
        yield return new WaitForSeconds(0.5f);
        AudioManager.instance.AudioPlay(scream);
        yield return new WaitForSeconds(3f);


    }
}
