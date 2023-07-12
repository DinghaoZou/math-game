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

    public AudioSource youAreCorrect;
    public AudioSource youAreWrong;
    public AudioSource theMusicInMath;

    public int NumberThatWillDecideTheEquation;
    public string theEquationSymbol;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");
        setNewHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTheGame () {
        theScore = 0;
        UpdateEquation();
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
                youAreCorrect.Play();
                theScoreboard.text = "Score: " + (int)theScore;
                answerInput.text = "";
                UpdateEquation();
            } else {
                lostTheGame();
            }
        } else if (NumberThatWillDecideTheEquation == 1) {
            if (Int32.Parse(answerInput.text) == number1 - number2) {
                theScore++;
                youAreCorrect.Play();
                theScoreboard.text = "Score: " + (int)theScore;
                answerInput.text = "";
                UpdateEquation();
            } else {
                lostTheGame();
            }
        } else if (NumberThatWillDecideTheEquation == 2) {
            if (Int32.Parse(answerInput.text) == number1 * number2) {
                theScore++;
                youAreCorrect.Play();
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
        theMusicInMath.Stop();
        youAreWrong.Play();
        gameOverScreen.gameObject.SetActive(true);
        gameScreen.gameObject.SetActive(false);
        finalScore.text = "Final Score: " + theScore;

        if (highScore < theScore) {
            highScore = theScore;
        }

        theScore = 0;
        theScoreboard.text = "Score: " + (int)theScore;
        PlayerPrefs.SetInt("highscore", highScore);
        Debug.Log(PlayerPrefs.GetInt("highscore"));
    }

    public void setScoreToZero () {
        theScore = 0;
        theScoreboard.text = "Score: " + (int)theScore;
    }

    public void setNewHighScore () {
        highScoreOnMainMenu.text = "High Score: " + highScore;
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
