using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int moedasNaFase;
    public AudioSource somDaMoeda;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DescontarMoedas()
    {
        moedasNaFase -= 1;
        somDaMoeda.Play();
    }
}
