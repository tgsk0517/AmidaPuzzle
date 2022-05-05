using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene3 : MonoBehaviour
{
    // 「stage3」に移動する関数
    public void OnClickStage3Button()
    {
        // stage3に移動
        SceneManager.LoadScene("GameScene3");
    }
}
