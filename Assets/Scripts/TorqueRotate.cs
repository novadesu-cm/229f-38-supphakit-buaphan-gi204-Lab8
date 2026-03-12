using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float TorqueRotateSpeed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(0, 0, TorqueRotateSpeed));
        }

        
    }
}