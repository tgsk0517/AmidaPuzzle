using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRuleButton : MonoBehaviour
{
    public void OnClickRuleButton()
    {
        SceneManager.LoadScene("RuleScene");
    }
}
