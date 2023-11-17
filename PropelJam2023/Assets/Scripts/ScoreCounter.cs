using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private int Count = 0;
    public TextMeshProUGUI CounterText;

    private void Start()
    {
        CounterText = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        DontDestroyOnLoad(gameObject);

        UpdateCounterText();
    }

    public void IncrementCounter()
    {
        Count++;
        UpdateCounterText();
        Debug.Log("Your score is " + Count);
    }

    private void UpdateCounterText()
    {
        if (CounterText != null)
        {
            CounterText.text = "SCORE: " + Count;
        }
        else
        {
            Debug.LogError("CounterText is not assigned!");
        }
    }

}


