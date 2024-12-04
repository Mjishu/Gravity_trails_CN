using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRb.gravityScale *= -1f;
            Vector3 newDirection = transform.localScale;
            newDirection.y *= -1;
            avatarRb.transform.localScale = newDirection;
        }
    }
}
