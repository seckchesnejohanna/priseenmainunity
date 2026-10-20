using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 5.0f;

    void Start(){
    }

    void Update(){
        transform.Rotate(0,speed,0,Space.Self);
    }
}
