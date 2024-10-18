using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    public string sceneFrom;
    public string sceneTo; // 要加载的场景名称

    public void Teleport()
    {
       
        TransitionManager.Instance.Transition(sceneFrom, sceneTo);

    }

}
   
