using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //variavel dos pontos
    private float pontos = 0;
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    //posicao obstaculo
    [SerializeField] private Vector3 posicao;
    //posicao minima e maxima
    [SerializeField] private float posMin = -0.4f;
    [SerializeField] private float posMax = 2.3f;

    //timer max e min
    [SerializeField] private float timerMin = 0.4f;
    [SerializeField] private float timerMax = 3f;

    //variavel pontos canvas
    [SerializeField] private Text pontosTexto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriaObstaculo();

    }

    private void Pontos()
    {
        pontos += Time.deltaTime;
        pontosTexto.text = Mathf.Round(pontos).ToString();
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            posicao.y = Random.Range(posMin, posMax);
            timer = Random.Range(timerMin, timerMax);
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
