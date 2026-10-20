using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public int points = 100;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tomate"))
        {
            FindAnyObjectByType<Compteur>().AddPoints(points);
            //Destroy(gameObject);
        }
        if (other.CompareTag("shield"))
        {
            FindAnyObjectByType<Compteur>().AddPoints(points);
            Destroy(gameObject);
        }
    }
}
