using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.InputSystem;

public class MenuOpciones : MonoBehaviour
{
    float tiempoDePartida = 0.0f;
    float tiempoRestante = 420f;
    [SerializeField] TextMeshProUGUI tiempoPartida;
    bool partidaEnCurso;
    [SerializeField]
    GameObject Menu1;

    // Start is called before the first frame update
    void Start()
    {
        

     partidaEnCurso = true;

        Menu1.SetActive(true);
        Time.timeScale = 0f;


    }

    // Update is called once per frame
    void Update()
    {
        if (partidaEnCurso)
        {
            tiempoDePartida += Time.unscaledDeltaTime;
            tiempoRestante -= Time.unscaledDeltaTime;



        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            partidaEnCurso = !partidaEnCurso;
            Menu1.SetActive(!partidaEnCurso);




        }
        else
        {
            Menu1.SetActive (false);
        }


        tiemp();





    }
    void tiemp()
    {
        float minutos = Mathf.FloorToInt(tiempoRestante/60f);

        float segundos = Mathf.FloorToInt(tiempoRestante % 60f);

        tiempoPartida.text = string.Format("{0:00}:{1:00}", minutos, segundos);



    }


    public void PlayGame()
    {


        Menu1.SetActive(false);
        Time.timeScale = 0f;



    }





    public void ExitMenu()
    {
        Application.Quit();
    }









}
