using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
    }
    
    public void onHigher()
    {
        if (min >= max)
            min = max;
        else
            min = guess + 1;
        NextGuess();
    }

    public void onLower()
    {
        if (max <= min)
            max = min;
        else
            max = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
