using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : Singleton<Test>
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameStart");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            TriggerScoreChanged(score); // 触发事件，传递新分数
        }
    }

    public void  GameStart()
        {
        Debug.Log("Im here");
        }

    public  event Action<int> OnScoreChanged;

    public void TriggerScoreChanged(int score)
    {
        if (OnScoreChanged == null) 
            Debug.LogError("当前事件未订阅");
        else
            Debug.Log(score);
    }
}
