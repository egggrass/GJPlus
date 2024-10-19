using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCamera : MonoBehaviour
{
    public Drag drag;
    public GameObject figure1;
    public GameObject figure2;
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PassLevel();
    }

    public void PassLevel()
    {
        if (drag.isFinished)
        {
            figure1.SetActive(false);
            figure2.SetActive(true);
            cat.SetActive(false);
        }
    }
}
