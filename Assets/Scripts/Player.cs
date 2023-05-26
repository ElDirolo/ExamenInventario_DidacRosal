using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * horizontal * 5 * Time.deltaTime;
    }
}
