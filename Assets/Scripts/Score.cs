using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public Text t;

    private float score = 0;
    public static double scoreTotal;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SetScore(1);
    }

    void Update()
    {
        scoreTotal = System.Math.Round(score * 120.5 - 120.5, 2);
    }

    public void AddScore(float amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    private void SetScore(float amount)
    {
        score = amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        t.text = "Score: " + System.Math.Round(score * 120.5 - 120.5, 2).ToString();
    }
}