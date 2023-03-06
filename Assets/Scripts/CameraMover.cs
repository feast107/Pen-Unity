using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float mouseSensitivity = 500f;

    void Start()
    {
    }

    void Update()
    {
        // WASD movement
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(x, 0, z);

        // Mouse look
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //transform.localRotation = transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
        transform.Rotate(Vector3.left * mouseY);
        transform.Rotate(Vector3.up * mouseX,Space.World);
    }
}
