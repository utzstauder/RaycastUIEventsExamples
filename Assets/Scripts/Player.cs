using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    float xInput;

    float currentSpeed;
    public float CurrentSpeed
    {
        private set
        {
            if (value != currentSpeed)
            {
                currentSpeed = value;
                OnCurrentSpeedChanged?.Invoke(currentSpeed);
            }
        }
        get { return currentSpeed; }
    }


    public static event System.Action<float> OnCurrentSpeedChanged;

    public float speed = 10f;

    // public SpeedUIController uiController;


    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        CurrentSpeed = xInput * speed;

        transform.position += Vector3.right * CurrentSpeed * Time.deltaTime;
    }
}
