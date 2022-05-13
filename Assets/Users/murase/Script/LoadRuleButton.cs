using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRuleButton : MonoBehaviour
{
    // 「遊び方」を押したときに画面を移動させる関数
    public void OnClickRuleButton()
    {
        // 遊び方画面に移動
        SceneManager.LoadScene("RuleScene");
    }
}
