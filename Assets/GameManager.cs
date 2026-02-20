using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevel;
    public void CompleteLevel()
    {
        Debug.Log("LEVEL 1");
        completeLevel.SetActive(true);
    }
    public void EndGame ()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
