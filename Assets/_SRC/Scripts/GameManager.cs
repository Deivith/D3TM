using com.odaclick.d3.core;
using com.odaclick.d3.lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject optionsPanel;
    public Text optionText;
    public Text nestCounter;
    public Text enemyCounter;
    public GameObject btnContinue;
    public GameObject btnRestart;

    private int nest;
    private int destroyed;
    
    public int enemyLimit = 10;
    private int spawnedEnemies = 0;

    private void Start()
    {
        Language.instance.OnChangeLanguage();
        nest = 4;
        UpdateNestUI();
        OnGameStart();

    }

    public void OnGameStart()
    {
        Time.timeScale = 0f;        
        optionsPanel.SetActive(true);
    }

    public void OnQuitClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Const.SCENES.MAIN);
    }

    public void OnRestartClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Gameplay");
    }

    public void Win()
    {
        Time.timeScale = 0f;
        optionText.text = "Enhorabuena!".ToUpper();
        optionsPanel.SetActive(true);
        btnContinue.SetActive(false);
    }

    public void GameOver()
    {

        Time.timeScale = 0f;
        optionText.text = "¿Quieres Volver a Intentarlo?".ToUpper();
        optionsPanel.SetActive(true);
        btnContinue.SetActive(false);
    }

    public void OnOptionsClicked()
    {
        Time.timeScale = 0f;
        optionText.text = "Juego en Pausa".ToUpper();
        optionsPanel.SetActive(true);
        
    }

    public void OnNestDestroyed()
    {
        destroyed++;
        UpdateNestUI();

        if (nest == destroyed)
        {
            Win();
        }

    }

    private void UpdateNestUI()
    {
        nestCounter.text = "NIDOS: " + destroyed + " / " + nest;
        enemyCounter.text = "ENEMIGOS: " + spawnedEnemies;
    }

    public void OnEnemySpawned()
    {
        spawnedEnemies++;
        UpdateNestUI();
    }
    public void OnEnemyDead()
    {
        spawnedEnemies--;
        UpdateNestUI();
    }

    public bool IsSpawnAllowed()
    {
        return enemyLimit == 0 || (enemyLimit > spawnedEnemies);
    }

}
