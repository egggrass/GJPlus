using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class PlayAni : MonoBehaviour
{
    public Animator play;
   
    public Drag drag;
    public bool playAni;
    public string sceneFrom;
    public string sceneTo;
   

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
           
            play.SetTrigger("move");
           

            TransitionManager.Instance.Transition(sceneFrom, sceneTo);

        }
    }


}
