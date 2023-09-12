using UnityEngine;

public class ScoreUP : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Score.score++;
    }
}