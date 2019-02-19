using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gamehasended = false;

public void EndGame()
    {

        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Menu");
        GameVariables.count = 0;
    }
}
