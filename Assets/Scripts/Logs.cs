using UnityEngine;

public class Logs : MonoBehaviour
{
    private int compteur = 0;

    void Start(){
        Debug.Log("Chachou");
    }

    void Update(){
        Debug.Log(compteur);
        compteur++;
    }
}