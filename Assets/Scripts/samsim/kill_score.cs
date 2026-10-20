using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class kill_score : MonoBehaviour
{
    private int score;
    [SerializeField] private TextMeshProUGUI score_nb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cible"))
        {
            score += 100;
            score_nb.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
}
