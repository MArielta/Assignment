using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.UpArrow))
     {
transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
    

if (Input.GetKey(KeyCode.DownArrow))

          {
transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
          }
          {
            if (Input.GetKey(KeyCode.RightArrow)){
transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            }
            {
              if (Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            
              }
            }
            if (Input.GetKey(KeyCode.Space)){
transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
          }
    }
}

    

    

