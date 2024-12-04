using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject projectile;
    public Vector3 offset;
    public TextMeshProUGUI ammoText;

    public int throwableCounter;
    // Start is called before the first frame update
    void Start()
    {
        ammoText.text = throwableCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(projectile, throwablePosition, transform.rotation);
            throwableCounter--;
            ammoText.text = throwableCounter.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ThrowingObject"))
        {
            throwableCounter++;
            Destroy(other.gameObject);
            ammoText.text = throwableCounter.ToString();
        }
    }
}
