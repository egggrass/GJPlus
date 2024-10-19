using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Collider : MonoBehaviour
{
    public GameObject cutpiece;
    public bool cutFinished = false;
    public string scenceFrom;
    public string scenceTo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Deactivate GameObject "C" when colliding with anything
        
            cutpiece.SetActive(false);
        cutFinished = true;

        TransitionManager.Instance.Transition(scenceFrom,scenceTo);
        
    }


}