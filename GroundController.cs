using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float degreesPerClick = 5.0f;

    void Start()
    {
        Debug.Log("BGM");
        bool result = GetComponent<ChuckMainInstance>().RunFile("bgm.ck");
        Debug.Log(result);
    }

    // FixedUpdate is called when phisics calculation is done
    void FixedUpdate()
    {
        float horizontalForce = -Input.GetAxis("Horizontal") * degreesPerClick;
        float verticalForce = Input.GetAxis("Vertical") * degreesPerClick;
        Vector3 force = new Vector3(verticalForce, 0.0f, horizontalForce);

        Quaternion rotationAngle = Quaternion.Euler(force);
        Quaternion rb = transform.rotation;
        Quaternion rotation = rb * rotationAngle;

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
    }
}

