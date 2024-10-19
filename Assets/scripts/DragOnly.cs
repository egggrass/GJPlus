using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class DragOnly : MonoBehaviour
{
    public GameObject objectDrag;
    public GameObject objectDragTo;
  
    public float dropDistance;
    


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
        
           

            objectDrag.transform.position = Input.mousePosition;




    }

}

   

