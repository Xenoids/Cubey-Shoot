using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMultiplayer2 : MonoBehaviour
{

    private int Enemycurrent;
    // Start is called before the first frame update
    void Start()
    {
        Enemycurrent = GameManager2.Instance.GetEnemycount();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.GetHPcount() == 0)
        {
            Enemycurrent = 0;
            GameManager2.Instance.SetEnemyCount(Enemycurrent);
            GameManager2.Instance.GameWin = true;
            GameManager.Instance.GameLose = true;
            return;
        }

        return;
    }

}
