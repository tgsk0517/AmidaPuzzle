using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuScene : MonoBehaviour
{
    // 「Start」を押したときメニュー画面に移動する関数
    public void OnClickStartButton()
    {
        // メニュー画面に移動
        SceneManager.LoadScene("MenuScene");
    }
}
