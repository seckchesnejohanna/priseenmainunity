using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    public float speed = 2.5f;

    void Start(){
    }

    public void Update(){
        //float ve = Input.GetAxis("Vertical");
        float ho = Input.GetAxis("Horizontal");

        //transform.Rotate(0,Time.deltaTime * ve,0,Space.World);
        transform.Translate(speed * Time.deltaTime * new Vector3(ho, /*ve*/0, 0));

        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            Camera.main.fieldOfView--;
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            Camera.main.fieldOfView++;
        }
    }
}
