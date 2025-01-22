using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float y;
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
        rotationSpeed = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime * rotationSpeed;
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
