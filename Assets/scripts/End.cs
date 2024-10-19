using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    public Drag drag;

    public GameObject credits;

    private void Update()
    {
        if (drag.isFinished)
        {
            credits.SetActive(true);
        }
    }
}
