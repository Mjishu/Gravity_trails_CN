using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public TextMeshProUGUI collectibleText;
    private Teleport teleport;

    private int collectibleAmount;

    // Start is called before the first frame update
    void Start()
    {
        collectibleText.text = collectibleAmount.ToString();
        teleport = GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
            collectibleAmount++;
            teleport.collectibleCount++;
            collectibleText.text = collectibleAmount.ToString();
        }
    }
}
