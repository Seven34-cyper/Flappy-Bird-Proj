using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject piperPrefab;

    [SerializeField] private float spaenRate = 1f;

    private void Start()
    {
        StartCoroutine(SpawnPipe()) ;
    }
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new  WaitForSeconds(spaenRate);
            Instantiate(piperPrefab,transform.position, Quaternion.identity);   
        }
    }

}