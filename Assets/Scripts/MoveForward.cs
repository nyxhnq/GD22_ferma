using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float speed = 30f;
    [SerializeField] float MinSpeed = 5f;
    [SerializeField] float MaxSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(MinSpeed, MaxSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
