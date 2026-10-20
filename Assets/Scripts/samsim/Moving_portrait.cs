using UnityEngine;
using UnityEngine.UIElements;

public class Moving_portrait : MonoBehaviour
{
    public float speed = 0.5f;
    private bool interL = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 0)
        {
            interL = !interL;
        }

        if(transform.position.z <= -20)
        {
            interL = !interL;
        }

        if (interL)
        {
            transform.Translate(speed * Time.deltaTime * new Vector3(1, 0, 0));
        }
        else if (!interL)
        {
            transform.Translate(speed * Time.deltaTime * new Vector3(-1, 0, 0));
        }

    }
}
