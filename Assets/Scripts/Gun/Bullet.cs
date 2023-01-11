using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private HealthBar healthBar;

    private float Player2HP;
    
    // public bool isMultiplayer = false;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        // if(isMultiplayer)
        // {
        //   Player2HP = GameManager2.Instance.GetHPcount();
        // }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Enemy")){
            Destroy(this.gameObject);
        }

        if(other.collider.CompareTag("Wall")){
            Destroy(this.gameObject);
            healthBar.Health--;
            GameManager.Instance.setHPcount(healthBar.Health);
            if(healthBar.Health == 0)
            GameManager.Instance.GameLose = true;
        }

        if(other.collider.CompareTag("WallInv"))
        {
            Destroy(this.gameObject);
        }

        if(other.collider.CompareTag("Player2"))
        {
           Player2HP =  GameManager2.Instance.GetHPcount();
           Player2HP--;
           GameManager2.Instance.setHPcount(Player2HP);
           Destroy(this.gameObject);
        }

    }
}
