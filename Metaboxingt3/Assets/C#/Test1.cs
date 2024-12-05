using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test.Instance.GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        // �����¼�
        Test.Instance.OnScoreChanged += UpdateScoreDisplay;
    }

    private void OnDisable()
    {
        // ȡ�������¼�
        Test.Instance.OnScoreChanged -= UpdateScoreDisplay;
    }

    // �����������仯ʱ��������ʾ
    private void UpdateScoreDisplay(int newScore)
    {
        Debug.Log("New Score: " + newScore);
    }
}