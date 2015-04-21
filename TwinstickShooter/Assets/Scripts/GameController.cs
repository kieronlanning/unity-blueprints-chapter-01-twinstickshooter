using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public Transform enemy;

    // We want to delay our code at certain times.
    public float timeBeforeSpawning = 1.5f;
    public float timeBetweenEnemies = .25f;
    public float timeBeforeWaves = 2.0f;

    public int enemiesPerWave = 10;

    int currentNumberOfEnemies = 0;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(SpawnEnemies());
	}

    // Coroutine to span enemies.
    IEnumerator SpawnEnemies()
    {
        // Give the player time before we start the game.
        yield return new WaitForSeconds(timeBeforeSpawning);

        // After timeBeforeSpawning has elapsed, we will enter this loop.
        while (true)
        {
            // Don't spawn anything new until all the previous wave's enemies are dead.
            if (currentNumberOfEnemies == 0)
            {
                float randDirection;
                float randDistance;

                // Spawn 10 enemies in a random position.

            }
        }
    }

    // Update is called once per frame
	void Update () {
	
	}
}
