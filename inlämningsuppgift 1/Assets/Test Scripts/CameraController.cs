using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    public Transform target;


    private void FixedUpdate()

    {

        transform.LookAt(target);

       

    }

}
