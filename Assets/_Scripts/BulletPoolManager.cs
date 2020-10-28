using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://learn.unity.com/tutorial/introduction-to-object-pooling-2019-3#5ea6e6e0edbc2a001f584398

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    //TODO: create a structure to contain a collection of bullets
    private List<GameObject> bulletPool = new List<GameObject>();
    public int maxBullets = 20;

    // Start is called before the first frame update
    void Start()
    {
        buildBulletPool();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        for(int i = 0; i < maxBullets; i++)
        {
            if(!bulletPool[i].activeInHierarchy)
            {
                return bulletPool[i];
            }
        }
        return null;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
    }

    public int poolSize()
    {
        return bulletPool.Count;
    }

    public bool isEmpty()
    {
        if (bulletPool.Count == 0)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    private void buildBulletPool()
    {
        // TODO: add a series of bullets to the Bullet Pool

        for (int i = 0; i < maxBullets; i++)
        {
            bulletPool.Add(Instantiate(bullet));
        }
    }
}
