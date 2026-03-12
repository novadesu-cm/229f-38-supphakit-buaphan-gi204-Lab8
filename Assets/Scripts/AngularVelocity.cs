using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    public float AngularVelocitySpeed;
    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, AngularVelocitySpeed, 0);
        }
    }


    
    void Update()
    {
        
    }
}
