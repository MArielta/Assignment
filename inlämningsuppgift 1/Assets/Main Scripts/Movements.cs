using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {

        float totalSpeed = moveSpeed * Time.deltaTime;

        transform.position +=(Vector3.right + Vector3.forward) * totalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
