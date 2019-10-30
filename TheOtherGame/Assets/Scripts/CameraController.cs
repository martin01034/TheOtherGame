using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform playerTransform;

    private Vector3 cameraOffset;

    [SerializeField]
    float speed = 15f;
    [Range(0.01f, 1f)]
    public float smoothFactor = 0.5f;


    void Start()
    {
        cameraOffset = this.transform.position - playerTransform.position;
    }

    private void Update()
    {
        HandleInput();
    }
    private void LateUpdate()
    {
        // Follow the player
        Vector3 newPos = playerTransform.position + cameraOffset;
        this.transform.position = Vector3.Slerp(this.transform.position, newPos, smoothFactor);
    }



    private void HandleInput()
    {
        Vector3 movement = new Vector3();
        // Rotate around the player
        if (Input.GetKey("q"))
        {
            
        }
        if (Input.GetKey("e"))
        {
            
           
        }


    }

}
