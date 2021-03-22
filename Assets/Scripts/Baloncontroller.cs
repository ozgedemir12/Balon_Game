using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloncontroller : MonoBehaviour
{
    public GameObject patlama;
    GameController gameControllerS;

    private void Start()
    {
        gameControllerS = GameObject.Find("GameObject").GetComponent<GameController>();
    }

    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.333f);
        gameControllerS.BalonEkle();
    }
}
