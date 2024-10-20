using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    public Drag drag;

    public GameObject bigcat;
    public GameObject smallcat;
    public AudioClip ring;

    private void Update()
    {
        if (drag.isFinished)
        {
            bigcat.SetActive(true);
            smallcat.SetActive(false);
            AudioManager.instance.AudioPlay(ring);
        }
    }
}
