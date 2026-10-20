using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Compteur : MonoBehaviour
{
    public static int score;
    [SerializeField] public TextMeshProUGUI score_nb;
    //[SerializeField] public Text score_nb;
    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }
    void Update()
    {

    }
    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreUI();
    }
    void UpdateScoreUI()
    {
        score_nb.text = score.ToString();
    }
}
