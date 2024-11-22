using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    
    {

        other.transform.position = new Vector3(-3, 9, -4);
        
    
    }
}
