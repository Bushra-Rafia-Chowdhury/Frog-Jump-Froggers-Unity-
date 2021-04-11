using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = CurrentScore.ToString(); //Converting a num to a str
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
