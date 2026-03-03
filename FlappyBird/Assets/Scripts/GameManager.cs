using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool isStarted = false;

    private void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && isStarted == false)
        {
            StartScreen.SetActive(false);
            isStarted = true;
            Time.timeScale = 1f;
        }
    }
}
