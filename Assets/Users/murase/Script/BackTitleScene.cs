using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitleScene : MonoBehaviour
{
    public void OnClickBackTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
