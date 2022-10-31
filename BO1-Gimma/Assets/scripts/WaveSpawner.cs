using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public float countdown = 2f;
    private int WaveIndex = 1;
    public float TimeInterval = 5f;
    public Text waveCountdownText;
   
    private void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(WaveSpawn());
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }
    void SpawnWave ()
    {
        WaveIndex++;
        for (int i = 0; i < WaveIndex; i++)
        {
            SpawnEnemy();
        }

        WaveIndex++;
    }

    IEnumerator WaveSpawn()
    {
        WaveIndex++;
        for (int i = 0; i < WaveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
