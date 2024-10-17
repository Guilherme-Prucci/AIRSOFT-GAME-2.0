using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Movimento : MonoBehaviour
{
    public Transform playerCamera;

    public float SensibilidadeMouseX = 100f;
    public float SensibilidadeMouseY = 100f;

    private float xRotation = 0f;
    private float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * SensibilidadeMouseY * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * SensibilidadeMouseX * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
