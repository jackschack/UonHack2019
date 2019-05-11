using UnityEngine;
using System.Collections;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class ScoreSystem : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI scoreText;
    private int score = 0;
    void Awake()
    {
        // Get a reference to an existing TextMeshPro component.
        scoreText = GetComponent<TextMeshProUGUI>();
        // Set the point size
        scoreText.fontSize = 24;
        // Set the text
        scoreText.text = score.ToString();
    }
}