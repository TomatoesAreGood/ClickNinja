using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayStats : MonoBehaviour
{   
    [SerializeField] public TimeText timeText;
    [SerializeField] public ScoreText scoreText;

    void Start()
    {
      scoreText.UpdateScore(GameManager.score);
      timeText.UpdateTime(GameManager.time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
