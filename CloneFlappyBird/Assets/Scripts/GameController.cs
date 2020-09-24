using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //pegando camera
    private Vector3 camPos;
    //pegando os som
    [SerializeField] private AudioClip levelUP;


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
    [SerializeField] private float timerMin = 1;
    [SerializeField] private float timerMax = 3f;

    //variavel pontos canvas 
    [SerializeField] private Text pontosTexto;
    //variavel level canvas
    [SerializeField] private Text levelTexto;

    //level do player
    private int level = 1;
    [SerializeField] private float proximoLevel = 10f;
    // Start is called before the first frame update
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriaObstaculo();
        GanhaLevel();

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
            timer = Random.Range(timerMin / level, timerMax);
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
    private void GanhaLevel() {
        if (pontos > proximoLevel) {
            //aumentando o level
            level++;
            proximoLevel *= 2;
            if (level != 1)
            {
                AudioSource.PlayClipAtPoint(levelUP, camPos);
            }
            
        }
        levelTexto.text = level.ToString();
        //aumentando o valor do proximo level

    }
    public int retornaLevel() {
        return level;
    }
}
