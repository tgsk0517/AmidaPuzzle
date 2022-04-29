using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuScene : MonoBehaviour
{
    public void OnClickBackMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
