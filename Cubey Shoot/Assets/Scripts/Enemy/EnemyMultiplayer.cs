using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMultiplayer : MonoBehaviour
{

    private int Enemycurrent;
    // Start is called before the first frame update
    void Start()
    {
        Enemycurrent = GameManager.Instance.GetEnemycount();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager2.Instance.GetHPcount() == 0)
        {
            Enemycurrent = 0;
            GameManager.Instance.SetEnemyCount(Enemycurrent);
            GameManager.Instance.GameWin = true;
            GameManager2.Instance.GameLose = true;
            return;
        }

        return;
    }

}
