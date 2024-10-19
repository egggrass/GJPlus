using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayAni : MonoBehaviour
{
    public Animator play;
   
    public Drag drag;
    public bool playAni;

    public GameObject obj;
   
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

        play.SetTrigger("move");
        yield return new WaitForSeconds(2f);
        Debug.Log("finished");
        obj.SetActive(false);

    }

}
