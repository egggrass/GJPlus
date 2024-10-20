using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayAniShock : MonoBehaviour
{
    public Animator play;
   
    public Drag drag;
    public bool playAni;
    public GameObject next;
    public GameObject hide;
    public GameObject catwalk;
    public AudioClip city;
   

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.AudioPlay(city);
    }

    // Update is called once per frame
    void Update()
    {
        if(drag.isFinished)
        {
          PlayAnimation();
          
        }
    }

    public void PlayAnimation()
    {
        
        play.SetTrigger("shock");
        hide.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
       
       
        catwalk.SetActive(true);
        
        AudioManager.instance.StopAudio();



    }

}
