using UnityEngine;
using System.Collections;

public class RotateDuringKeyPressed : MonoBehaviour
{   
    public float speed = 5.0f;
    public string Touche = "r";

    void Start(){
    }

    public void Update(){
        if (Input.GetKey(Touche))
        {
            transform.Rotate(0,speed,0,Space.Self);
        }
    }
}
