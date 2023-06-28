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
    public Text theScoreboard;
    public Text finalScore;
    public Text highScoreOnMainMenu;

    public GameObject gameOverScreen;
    public GameObject gameScreen;

    public int NumberThatWillDecideTheEquation;
    public string theEquationSymbol;

    // Start is called before the first frame update
    void Start()
    {
        theScore = 0;
        UpdateEquation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEquation () {
        if (difficulty == 0) {
            NumberThatWillDecideTheEquation = 0;
        } else if (difficulty == 1) {
            NumberThatWillDecideTheEquation = UnityEngine.Random.Range(0, 2);
        } else if (difficulty == 2) {
            NumberThatWillDecideTheEquation = UnityEngine.Random.Range(0, 3);
        }

        if (NumberThatWillDecideTheEquation == 0) {
            theEquationSymbol = "+";
        } else if (NumberThatWillDecideTheEquation == 1) {
            theEquationSymbol = "-";    
        } else if (NumberThatWillDecideTheEquation == 2) {
            theEquationSymbol = "x";
        }

        number1 = UnityEngine.Random.Range(0, 10);
        number2 = UnityEngine.Random.Range(0, 10);

        theTextOfTheEquation.text = Convert.ToString(number1) + " " + theEquationSymbol + " " + Convert.ToString(number2) + " = ";
    }

    public void theEventThatHappensAfterTheAnswerHasBeenSubmitted() {
        if (NumberThatWillDecideTheEquation == 0) {
            if (Int32.Parse(answerInput.text) == number1 + number2) {
                theScore++;
                theScoreboard.text = "Score: " + (int)theScore;
                answerInput.text = "";
                UpdateEquation();
            } else {
                lostTheGame();
            }
        } else if (NumberThatWillDecideTheEquation == 1) {
            if (Int32.Parse(answerInput.text) == number1 - number2) {
                theScore++;
                theScoreboard.text = "Score: " + (int)theScore;
                answerInput.text = "";
                UpdateEquation();
            } else {
                lostTheGame();
            }
        } else if (NumberThatWillDecideTheEquation == 2) {
            if (Int32.Parse(answerInput.text) == number1 * number2) {
                theScore++;
                theScoreboard.text = "Score: " + (int)theScore;
                answerInput.text = "";
                UpdateEquation();
            } else {
                lostTheGame();
            }
        }
    }

    public void lostTheGame () {
        answerInput.text = "";
        gameOverScreen.gameObject.SetActive(true);
        gameScreen.gameObject.SetActive(false);
        finalScore.text = "Final Score: " + theScore;

        if (highScore < theScore) {
            highScore = theScore;
        }

        theScore = 0;
        theScoreboard.text = "Score: " + (int)theScore;
    }

    public void setScoreToZero () {
        theScore = 0;
        theScoreboard.text = "Score: " + (int)theScore;
    }

    public void setNewHighScore () {
        highScoreOnMainMenu.text = "High Score This Session: " + highScore;
    }

    public void setGameToEasy () {
        difficulty = 0;
    }

    public void setGameToNormal () {
        difficulty = 1;
    }

    public void setGameToHard () {
        difficulty = 2;
    }
}
