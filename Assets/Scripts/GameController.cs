using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{


    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

    [SerializeField] private Text outcome;
    [SerializeField] private PlayableDirector masterTimelinePlayableDirector;
    [SerializeField] private GameObject playerShip;



    private bool gameOver = false;
    private int score;
    private int enemiesLeft = 0;
    private SceneLoader sceneLoader;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        enemiesLeft = GameObject.FindObjectsOfType<Enemy>().Length;
        restartText.text = "";
        gameOverText.text = "";
        outcome.text = "";
        score = 0;
        UpdateScore();
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                sceneLoader.LoadFirstScene();
            }
        }
    }


    public void DecreaseEnemyCount()
    {
        enemiesLeft--;
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverText.text = "Game Over!";

        if (enemiesLeft > 0)
        {
            outcome.text = "You Lose";
        }
        else
        {
            outcome.text = "You Win";
        }

        restartText.text = "Press 'R' for Restart";

        masterTimelinePlayableDirector.Stop();
        playerShip.SetActive(false);
    }
}



