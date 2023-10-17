using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    public int counter = 0;

    public Text counterText;

    void Start()
    {
        UpdateCounterText();
    }

    void UpdateCounterText()
    {
        counterText.text = "Счёт: " + counter.ToString();
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        counter++;
        UpdateCounterText();
        print(counter);
        
    }

}
