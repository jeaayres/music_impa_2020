using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{

    void Update()
    {
        if (this.CompareTag("good"))
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
        else
        {
            transform.Rotate(new Vector3(Random.Range(-15.0f, 45.0f), 0, 0) * Time.deltaTime);
        }
    }
}