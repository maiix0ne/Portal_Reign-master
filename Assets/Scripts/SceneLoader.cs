using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentSceneIndex = -1;


    private void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Start()
    {
        if (currentSceneIndex == 0)
        {
            Invoke("LoadFirstScene", 2f);
        }
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}