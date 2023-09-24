using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesText : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateLives(int lives)
    {
        livesText.text = "" + lives;
    }
}
