using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level1 : MonoBehaviour
{

    public float rotateSpeed = 30f;
    public float movespeed = 5;
    public bool rotationFinished;
    public bool positionFinished;
    public float duration = 0.5f;
    public float targetRotationx;
    public float targetRotationy;
    public float targetPositionx1;
    public float targetPositionx2;
    public float targetPositiony1;
    public float targetPositiony2;
    public string sceneFrom;
    public string sceneTo;
    public GameObject Piece;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckPosition();
        CheckRotation();
        
        if (positionFinished && rotationFinished)
        {
            {
                Piece.gameObject.SetActive(true);
                
                StartCoroutine(EnterNextLevel());
            }
        }

        

        if(!positionFinished ||!rotationFinished )
        {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * movespeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * movespeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, 0,15);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 0,-15);
        }
        }
    }

    public void CheckRotation()
    {
        float zRotation = transform.eulerAngles.z;

        if (zRotation > 180)
        {
            zRotation -= 360;
        }

        if (Mathf.Abs((zRotation - 30) % 60) < 0.1f)
            rotationFinished = true;


        else rotationFinished = false;

    }
    public void CheckPosition()
    {
        float playerX = transform.position.x;
        float playerY = transform.position.y;

        if (
            playerX >= targetPositionx1 && playerX <= targetPositionx2
         && playerY <= targetPositiony1 && playerY >= targetPositiony2
          )
            positionFinished = true;

        else positionFinished = false;
    }


    IEnumerator EnterNextLevel()
    {

        Glitch.Instance.ShowGlitch();
        yield return new WaitForSeconds(duration);
        
       
        TransitionManager.Instance.Transition(sceneFrom, sceneTo);
        
    }

}
    
