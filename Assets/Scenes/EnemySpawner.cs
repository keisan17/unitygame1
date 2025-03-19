using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 敵のプレハブ
    public int enemyCount = 5; // スポーンする敵の数
    public Vector2 spawnAreaMin; // スポーンエリアの最小座標
    public Vector2 spawnAreaMax; // スポーンエリアの最大座標

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector2 spawnPosition = new Vector2(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y)
            );

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
