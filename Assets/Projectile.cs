using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 15f;
    public Throwable direction;

    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Invoke("DestroyThrowable", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
        {
            transform.position += direction.offset * Time.deltaTime * projectileSpeed;
        }
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
        Debug.Log("I was called!");
    }
}
