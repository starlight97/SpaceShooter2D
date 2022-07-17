using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    private Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        textScore = transform.Find("TextScore").GetComponent<Text>();
        textScore.text = "Total Score\r\n" + InfoManager.instance.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
