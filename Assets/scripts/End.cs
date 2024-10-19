using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    public Drag drag;

    public string sceneFrom;
    public string sceneTo;

    private void Update()
    {
        if (drag.isFinished)
        {
            TransitionManager.Instance.Transition(sceneFrom, sceneTo);
        }
    }
}
