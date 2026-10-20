using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{
    public Renderer rend;
    Color og = Color.red;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.green;
    }

    void OnMouseExit()
    {
        rend.material.color = og;
    }
}
