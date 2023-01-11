using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{

    [Header("Bullets")]

    #region Bullets
    [SerializeField]
    private Transform bulletspawn;
    public GameObject bulletprefabs;

    [SerializeField]
    private int bulletcurrent;

    

    [SerializeField]
    private float bulletspeed = 10f;

    public bool isAvailable = true;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        bulletspawn = GetComponentInChildren<Transform>().GetChild(0);
        bulletcurrent = GameManager2.Instance.GetBulletcount();
    }

    // Update is called once per frame
    void Update()
    {
        if(isAvailable && !GameManager2.Instance.GameWin && !GameManager2.Instance.GameLose)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
            GameObject Bullet = Instantiate(bulletprefabs,bulletspawn.position, bulletspawn.rotation);
            Bullet.GetComponent<Rigidbody>().velocity = bulletspawn.forward * bulletspeed;
            bulletcurrent--;
            GameManager2.Instance.SetBulletCount(bulletcurrent);
            // Debug.Log(bulletcurrent);
            if(bulletcurrent == 0)
            StartCoroutine(fillbullet());
            }
           
        }

        if(!isAvailable)
        {
           return;
        }

        // return;
    }

    public IEnumerator fillbullet()
    {
        isAvailable = false;
        yield return new WaitForSeconds(1.5f);
        bulletcurrent = 5;
        GameManager2.Instance.SetBulletCount(5);
        isAvailable = true;
    }

}
