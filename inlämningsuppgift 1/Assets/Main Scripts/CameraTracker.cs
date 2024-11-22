using UnityEngine;

public class CameraTracker : MonoBehaviour
{

   [SerializeField] private Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start() => offset = transform.position - player.position;
   

    // Update is called once per frame
    void Update() => transform.position = player.position + offset;
   
}
