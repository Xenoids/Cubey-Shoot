using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{

    private HealthBar healthBar;

    private float Player1HP;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<HealthBar>();
        Player1HP = GameManager.Instance.GetHPcount();
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
            GameManager2.Instance.setHPcount(healthBar.Health);
            if(healthBar.Health == 0)
            GameManager2.Instance.GameLose = true;
        }

         if(other.collider.CompareTag("WallInv"))
        {
            Destroy(this.gameObject);
        }

        if(other.collider.CompareTag("Player"))
        {
            Player1HP = GameManager.Instance.GetHPcount();
            Player1HP--;
            GameManager.Instance.setHPcount(Player1HP);
            Destroy(this.gameObject);
        }

    }
}
