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
    // Start is called before the first frame update
   

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Deactivate GameObject "C" when colliding with anything

        drag.isFinished = true;
        ball.SetActive(false);
        TransitionManager.Instance.Transition(scenceFrom,scenceTo);
        
    }


}