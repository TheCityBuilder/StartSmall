using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    public float speed = 5f;
    void Start()
    {

    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, 0f));
    }
}
