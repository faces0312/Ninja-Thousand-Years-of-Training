using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Manager : MonoBehaviour
{
    public void Game_Start()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
