using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float speed = 5f;
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
