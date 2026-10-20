using UnityEngine;

public class ManipulationMouse : MonoBehaviour
{
    public float speed = 5f;
    //public Rigidbody rigidbody;

    public void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            //transform.position = mousePos;
            //transform.position = transform.position + new Vector3(mousePos.x,mousePos.y,0) * speed * Time.deltaTime;
            //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,-Camera.main.transform.position.z));
            //rigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,-Camera.main.transform.position.z));
            //desactiver sa physique d'abord à voir 
        }

    }
}
