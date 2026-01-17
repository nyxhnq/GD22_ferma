
using UnityEngine;

public class DeleteCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        { 
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
