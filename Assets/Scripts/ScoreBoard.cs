using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        Pickup.GetPickup += GetPoints;
    }

    private void GetPoints()
    {
        score += 50;
        textField.text = "score: " + score;
    }

    void Update()
    {
        
    }
}
