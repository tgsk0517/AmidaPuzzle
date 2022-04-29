using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene1 : MonoBehaviour
{
    public void OnClickStage1Button()
    {
        SceneManager.LoadScene("GameScene1");
    }
}
