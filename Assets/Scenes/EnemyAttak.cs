using UnityEngine;

//hoge

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("衝突判定が発生しました: " + other.gameObject.name); // 追加！

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("敵に当たった！ダメージ処理を実行"); // 追加！
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        currentHealth--;
        Debug.Log("ダメージを受けた！ 残りHP: " + currentHealth); // 追加！

        if (currentHealth <= 0)
        {
            Debug.Log("HPが0以下になりました！ プレイヤーを消去"); // 追加！
            Destroy(gameObject); // プレイヤーを消す
        }
    }
}
