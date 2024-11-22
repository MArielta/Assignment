using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {

        other.transform.position = new Vector3(83, 8.61f, -4.57f);


    }
}