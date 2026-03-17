using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class PiperSpawner : MonoBehaviour
{

    [SerializeField] private GameObject piperPrefab;

    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float minPositionY;
    [SerializeField] private float maxPositionY;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }
    private IEnumerator SpawnPipe()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            float randomY = Random.Range(minPositionY, maxPositionY);
            Vector2 spawnPosition = new Vector2 (transform.position.x, randomY);
            GameObject spawnedPipe = Instantiate(piperPrefab, spawnPosition, Quaternion.identity);
            Destroy(spawnedPipe, 3f);
        }
    }

}
