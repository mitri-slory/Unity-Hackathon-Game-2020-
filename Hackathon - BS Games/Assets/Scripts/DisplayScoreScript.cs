using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScoreScript : MonoBehaviour
{
    public TextMeshProUGUI Score;

    void Start()
    {
        Score.text = Convert.ToString(GameManager.Instance.NumCubes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
