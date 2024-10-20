using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Collider : MonoBehaviour
{
    
    public Drag drag;
   
    public string scenceFrom;
    public string scenceTo;
    public GameObject ball;
    public GameObject ballin;
    



    void OnTriggerEnter2D(Collider2D collider)
    {
      

        drag.isFinished = true;
        ball.SetActive(false);
        ballin.SetActive(true);
        TransitionManager.Instance.Transition(scenceFrom,scenceTo);
       

    }


}