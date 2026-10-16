using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCount : MonoBehaviour
{
    public TMP_Text currentScore;
    int score = 0;
    int maxScore = 3;

    void Start()
    {
   
    }

    void AddScore(int amount)
    {
        if (score <= maxScore)
        {
            score += amount;
        }

        if (score >= maxScore)
        {

            Debug.Log("All keys gained");
        }

        currentScore.text = score.ToString();

    }

    void OnTriggerEnter(Collider other)
    {
        if (GetComponent<KeyPickUp>())
        {
            AddScore(1);
      
        }
    }
}

// Note: Attach this script to the Paper ball prefab/GameObject! Make sure to select "Current Score" TMP for the counter
