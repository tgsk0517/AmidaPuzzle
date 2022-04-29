using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuScene : MonoBehaviour
{
    // 「X」を押したときメニューに戻る関数
    public void OnClickBackMenuButton()
    {
        // メニュー画面に戻る
        SceneManager.LoadScene("MenuScene");
    }
}
