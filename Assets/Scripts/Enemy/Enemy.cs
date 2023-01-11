using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Renderer renderer;

    private int Enemycurrent;

    public bool ishit = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Bullet")){
            renderer.material.SetColor("_Color",Color.yellow);
            if(GameManager.Instance.GetEnemycount() > 0 && !ishit)
            {
                ReduceEnemy();
                ishit = true;
            }

            if(ishit)
            {
                return;
            }
            
        }
    }

    public void ReduceEnemy()
    {
       Enemycurrent =  GameManager.Instance.GetEnemycount();
       Enemycurrent--;
       GameManager.Instance.SetEnemyCount(Enemycurrent);
       if(GameManager.Instance.GetEnemycount() == 0)
       {
        GameManager.Instance.GameWin = true;
       }
    }
}
