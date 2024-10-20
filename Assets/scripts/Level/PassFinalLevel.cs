using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassFinalLevel : MonoBehaviour
{
    public Drag drag;
    public Drag drag2;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject objFinal;
    public AudioClip coffee;
    // Start is called before the first frame update

    public void Start()
    {
        AudioManager.instance.AudioPlay(coffee);
    }

    // Update is called once per frame
    void Update()
    {
        if(drag.isFinished || drag2.isFinished)
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            objFinal.SetActive(true);

          
        }


    }

    public void MusicStop()
    {
        AudioManager.instance.StopAudio();
    }
}
