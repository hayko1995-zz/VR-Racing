using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SterringWheel : MonoBehaviour
{

    public Transform frontLeftWheelWrapper;
    public float maxWheelTurnAngle = 540f;
    private float steerAngle = 0f;
    private float rotation = 0f;
    public float rotationSpeed = 10f;
    private bool left = false;
    private bool right = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (steerAngle > 0)
        {

            if (rotation <= 160f)
            {
                rotation += Time.deltaTime * rotationSpeed;
            }
            frontLeftWheelWrapper.localRotation = Quaternion.Euler(0, 0, -rotation);


        }
        if (steerAngle < 0)
        {

            if (rotation >= -160f)
            {
                rotation -= Time.deltaTime * rotationSpeed;

                frontLeftWheelWrapper.localRotation = Quaternion.Euler(0, 0, -rotation);
            }
        }

        if (steerAngle == 0)
        {


            rotation = Time.deltaTime * rotationSpeed;
            frontLeftWheelWrapper.localRotation = Quaternion.Euler(0, 0, 0);

        }

    }

    void FixedUpdate()
    {

        steerAngle = maxWheelTurnAngle * SimpleInput.GetAxis("Horizontal");
    }


    //  private float x;
    // private float z;
    // private bool rotateX;
    // private float rotationSpeed;

    // void Start()
    // {
    //     x = 0.0f;
    //     z = 0.0f;
    //     rotateX = true;
    //     rotationSpeed = 75.0f;
    // }

    // void FixedUpdate()
    // {
    //     if (rotateX == true)
    //     {
    //         x += Time.deltaTime * rotationSpeed;

    //         if (x > 360.0f)
    //         {
    //             x = 0.0f;
    //             rotateX = false;
    //         }
    //     }
    //     else
    //     {
    //         z += Time.deltaTime * rotationSpeed;

    //         if (z > 360.0f)
    //         {
    //             z = 0.0f;
    //             rotateX = true;
    //         }
    //     }

    //     transform.localRotation = Quaternion.Euler(x, 0, z);
    // }
}
