using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletCounter2 : MonoBehaviour
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
        BulletCounter_Text.text = GameManager2.Instance.GetBulletcount().ToString();
        BulletCounter_Text.color = Color.white;
        if(GameManager2.Instance.GetBulletcount() < 3)
        {
            BulletCounter_Text.color = Color.yellow;
        }

        if(GameManager2.Instance.GetBulletcount() < 1)
        {
            BulletCounter_Text.color = Color.red;
        }

        if(GameManager2.Instance.GetBulletcount() == 0)
        {
            BulletCounter_Text.text = "Reload..";
        }

        return;
    }
}
