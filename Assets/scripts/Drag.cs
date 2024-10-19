using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public GameObject objectDrag;
    public GameObject objectDragTo;
  
    public float dropDistance;
    public AudioClip pass;


    public bool isFinished;
    Vector2 objectIntPos;
    public void Start()
    {
        objectIntPos = objectDrag.transform.position;
    }
    
    public void DragObject()
    {
        if(!isFinished)
        {
            objectDrag.transform.position = Input.mousePosition;
           
        }
    }

    public void DropObject()
    {
        float Distance = Vector3.Distance(objectDrag.transform.position, objectDragTo.transform.position);
        if( Distance < dropDistance )
        {
            isFinished = true;
            objectDrag.transform.position = objectDragTo.transform.position;
            AudioManager.instance.AudioPlay(pass);

        }
        else
        {
           

            objectDrag.transform.position = Input.mousePosition;




        }
    }

}

   

