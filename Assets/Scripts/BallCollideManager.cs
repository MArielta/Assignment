using UnityEngine;

public class PlayerCollideManager : MonoBehaviour

    {
private void OnCollisionEnter(Collision collision)        

    {
if (collision.gameObject.CompareTag("Obstacle"))

    {
Debug.Log("Game Over");


Destroy(gameObject);
}



}


}
