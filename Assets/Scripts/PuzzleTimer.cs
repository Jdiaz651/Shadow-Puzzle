using UnityEngine;
using TMPro;

public class PuzzleTimer : MonoBehaviour
{
    public TextMeshProUGUI titleText;    // Assign in Inspector
    public TextMeshProUGUI timerText;    // Assign in Inspector
    public QuaternionRotationMatcher matcher;      // Reference to your puzzle logic script

    private float timer = 0f;
    private bool puzzleSolved = false;

    void Start()
    {
        titleText.text = "Match the Shadows";
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (puzzleSolved)
            return;

        timer += Time.deltaTime;
        UpdateTimerDisplay();

        if (matcher.IsPuzzleSolved())
        {
            OnPuzzleSolved();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = $"Time: {minutes:00}:{seconds:00}";
    }

    void OnPuzzleSolved()
    {
        puzzleSolved = true;
        titleText.text = $"Puzzle Solved!";
        // You could also log time or trigger animations here
    }
}
