using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;
    public int collectibleCount;
    public int sceneToLoad;

    private int collectibleAmount;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        collectibleAmount = GameObject.FindGameObjectsWithTag("Fruit").Length;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && enemyCount == 0 && collectibleCount == collectibleAmount)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.Log("Enemies alive: " + enemyCount + "| Collectibles: " + collectibleCount);
            Debug.Log("You did not kill all the enemies or collect everything");
        }
    }
}
