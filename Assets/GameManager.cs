using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int difficulty;

    public int number1;
    public int number2;

    public int theScore;
    public int highScore;

    public InputField answerInput;
    public Text theTextOfTheEquation;

    public int NumberThatWillDecideTheEquation;
    public string theEquationSymbol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEquation () {
        if (difficulty == 0) {
            NumberThatWillDecideTheEquation = 0;
        } else if (difficulty == 1) {
            NumberThatWillDecideTheEquation = UnityEngine.Random.Range(0, 1);
        } else if (difficulty == 2) {
            NumberThatWillDecideTheEquation = UnityEngine.Random.Range(0, 2);
        }

        if (NumberThatWillDecideTheEquation == 0) {
            theEquationSymbol = "+";
        } else if (NumberThatWillDecideTheEquation == 1) {
            theEquationSymbol = "-";    
        } else if (NumberThatWillDecideTheEquation == 2) {
            theEquationSymbol = "x";
        }

        number1 = UnityEngine.Random.Range(0, 9);
        number2 = UnityEngine.Random.Range(0, 9);

        theTextOfTheEquation.text = Convert.ToString(number1) + " " + theEquationSymbol + " " + Convert.ToString(number2) + " = ";
    }

    public void theEventThatHappensAfterTheAnswerHasBeenSubmitted() {
        if (NumberThatWillDecideTheEquation == 0) {
            if (Int32.Parse(answerInput.text) == number1 + number2) {
                
            }
        } else if (NumberThatWillDecideTheEquation == 1) {
            if (Int32.Parse(answerInput.text) == number1 - number2) {
                
            }
        } else if (NumberThatWillDecideTheEquation == 2) {
            if (Int32.Parse(answerInput.text) == number1 * number2) {
                
            }
        }
    }
}
