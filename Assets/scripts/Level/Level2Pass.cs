using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Pass : MonoBehaviour
{

    

    public Drag drag;
    
    public GameObject shock;
    public string sceneFrom;
    public string sceneTo;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (drag.isFinished)
        {
            shock.SetActive(true);


            TransitionManager.Instance.Transition(sceneFrom, sceneTo);

        }
    }
}
