using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // 移動速度
    private Vector2 movementDirection;
    private float changeDirectionTime = 2f; // 方向転換の間隔
    private float timer;

    void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > changeDirectionTime)
        {
            ChangeDirection();
            timer = 0;
        }

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        float angle = Random.Range(0, 360);
        movementDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }
}
