using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene1 : MonoBehaviour
{
    // 「ステージ1」に移動させる関数
    public void OnClickStage1Button()
    {
        // ステージ1に移動
        SceneManager.LoadScene("GameScene1");
    }
}
