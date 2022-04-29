using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitleScene : MonoBehaviour
{
    // タイトル画面に戻る関数
    public void OnClickBackTitleButton()
    {
        // タイトル画面に戻る処理
        SceneManager.LoadScene("TitleScene");
    }
}
