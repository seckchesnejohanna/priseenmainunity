using UnityEngine;

public class RotateOnOffKey : MonoBehaviour
{   
    public float speed = 5.0f;
    public string Touche = "r";
    private bool sw = false;

    void Start(){

    }

    public void Update(){
        if (Input.GetKeyDown(Touche)){
            sw = !sw;
        }

        if (sw)
        {
            transform.Rotate(0,speed,0,Space.Self);
        }
    }
}