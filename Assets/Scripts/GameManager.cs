using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject ball;

    public GameObject player1Paddle;
    public GameObject player2Paddle;

    public GameObject player1Goal;
    public GameObject player2Goal;

    public GameObject player1Text;
    public GameObject player2Text;

    public int player1Score;
    public int player2Score;

    public void Player1Scored() {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored() {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }
    public void ResetPosition() {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
    void Update() {
        if (player1Score >= 7) {
            SceneManager.LoadScene(2);
        }
        if (player2Score >= 7) {
            SceneManager.LoadScene(3);
        }
    }
}