using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonManager : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSure = 1f;
    float zamanSayacı = 0f;
    GameController gmController;
    // Start is called before the first frame update
    void Start()
    {
        gmController = this.gameObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayacı -= Time.deltaTime;
        int katsayi = (int)(gmController.zamanSayaci / 10) - 6;
        katsayi *= -1;

        if (zamanSayacı < 0 && gmController.zamanSayaci> 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.75f, 2.75f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*katsayi, 80f*katsayi), 0));
            zamanSayacı = balonOlusturmaSure;
        }
    }
}
