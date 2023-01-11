using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletCounter : MonoBehaviour
{

    private TMP_Text BulletCounter_Text;
    // Start is called before the first frame update
    void Start()
    {
        BulletCounter_Text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletCounter_Text.text = GameManager.Instance.GetBulletcount().ToString();
        BulletCounter_Text.color = Color.white;
        if(GameManager.Instance.GetBulletcount() < 3)
        {
            BulletCounter_Text.color = Color.yellow;
        }

        if(GameManager.Instance.GetBulletcount() < 1)
        {
            BulletCounter_Text.color = Color.red;
        }

        if(GameManager.Instance.GetBulletcount() == 0)
        {
            BulletCounter_Text.text = "Reload..";
        }

        return;
    }
}
