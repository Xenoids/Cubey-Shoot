using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Player")]

    [SerializeField]
    private float HP = 5f;

    [Header("Enemy")]

    [SerializeField]
    private int Enemycount = 3;

    [Header("Bullet")]

    [SerializeField]
    private int Bulletcount = 5;

    [Header("State")]

    // public bool GameEnded = false;
    public bool GameLose = false;
    public bool GameWin = false;

    private GameObject Lose_Panel;
    private GameObject Win_Panel;

    public int GetEnemycount()
    {
        return Enemycount;
    }

    public void SetEnemyCount(int value)
    {
        Enemycount = value;
        // Debug.Log(Enemycount);
    }

    public int GetBulletcount()
    {
        return Bulletcount;
    }

    public void SetBulletCount(int value)
    {
        Bulletcount = value;
    }

    public float GetHPcount()
    {
        return HP;
    }

    public void setHPcount(float value)
    {
        HP = value;
    }



    public static GameManager Instance;

    private void Awake() {
        if(!Instance)
        {
            Instance = this;
        }

        if(Instance)
        {
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Lose_Panel = GameObject.FindGameObjectWithTag("Lose");
        Win_Panel = GameObject.FindGameObjectWithTag("Win");
        Lose_Panel.SetActive(false);
        Win_Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameLose)
        {
            Lose_Panel.SetActive(true);
            StartCoroutine(delay());
            return;
        }

        if(GameWin)
        {
            Win_Panel.SetActive(true);
            StartCoroutine(delay());
            return;
        }

        return;
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale  = 0;
    }



}
