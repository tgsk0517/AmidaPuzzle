using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene2 : MonoBehaviour
{
    // 「ステージ2」に移動する関数
    public void OnClickStage2Button()
    {
        // ステージ2に移動
        SceneManager.LoadScene("GameScene2");
    }
}
