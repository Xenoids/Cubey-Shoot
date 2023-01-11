using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public float Health;

    public float maxHealth = 5f;

    [SerializeField]
    private Image HPBar;

    // Start is called before the first frame update
    void Start()
    {
        HPBar = GetComponent<Image>();
        Health = GameManager.Instance.GetHPcount();
    }

    // Update is called once per frame
    void Update()
    {
        Health = GameManager.Instance.GetHPcount();
        HPBar.fillAmount = Health/maxHealth;
        if(Health == maxHealth)
        {
            HPBar.color = Color.green;
        }

        if(Health <= 3f)
        {
            HPBar.color = Color.yellow;
        }

        if(Health <= 1f)
        {
            HPBar.color = Color.red;
        }
        
        return;
    }


}
