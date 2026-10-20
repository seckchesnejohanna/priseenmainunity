using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    //public float createPos=2.0f;
    public Renderer rend;

    void Start()
    {
        rend = prefab.GetComponent<Renderer>();
    }

    public void Update(){
        if (Input.GetMouseButton(1))
        {
            //Instantiate(prefab, parent);
            Instantiate(prefab, parent, true);
            rend.material.color = Color.blue;
            
        }
    }
}
