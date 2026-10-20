using Unity.VisualScripting;
using UnityEngine;

// Instantiate a rigidbody then set the velocity

public class Kill : MonoBehaviour
{
    // Assign a Rigidbody component in the inspector to instantiate

    public Rigidbody projectile;
    public float speed = 10f;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.linearVelocity = transform.TransformDirection(Vector3.forward * speed);

            //Destroy(clone, 4);

        }
    }
}

