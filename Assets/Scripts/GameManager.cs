using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Se genera un singleton 
    public static GameManager Instance;
    public enum GameState { Playing, Paused,GameOver};
    public GameState state;
    public int playScore = 0;
    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.Playing:
                // L�gica para reanudar el juego
                Time.timeScale = 1;
                break;
            case GameState.Paused:
                // L�gica para pausar el juego
                Time.timeScale = 0;
                break;
            case GameState.GameOver:
                // L�gica para finalizar el juego
                Time.timeScale = 0;
                Debug.Log("Juego terminado");
                break;
        }
    }
    // M�todo para actualizar la puntuaci�n del jugador
    public void AddScore(int points)
    {
        playScore += points;
        Debug.Log("Puntuaci�n actual: " + playScore);
    }


}
