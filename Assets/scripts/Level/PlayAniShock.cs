using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayAniShock : MonoBehaviour
{
    public Animator play;
   
    public Drag drag;
    public bool playAni;
    public GameObject next;
    public GameObject hide;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(drag.isFinished)
        {
            StartCoroutine(PlayAnimation());
          
        }
    }

    IEnumerator PlayAnimation()
    {
        
        play.SetTrigger("shock");
        hide.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
       
       
       
       
        
      

    }

}
