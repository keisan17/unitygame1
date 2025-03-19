using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // キャラクターの移動速度
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2Dを取得
    }

    void Update()
    {
        // WASDキーの入力を取得
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Rigidbody2Dを使用して移動
        rb.linearVelocity = movement.normalized * speed;
    }
}
