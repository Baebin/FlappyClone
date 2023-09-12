using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * (Vector3.left * Time.deltaTime);
    }
}
