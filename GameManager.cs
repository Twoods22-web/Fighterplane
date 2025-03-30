using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        // This will call CreateEnemyOne every 2 seconds starting after 1 second
        InvokeRepeating("CreateEnemyTwo", 3, 4); // This will call CreateEnemyTwo every 4 seconds starting after 1 second
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    //Made by Terrell Woods
    void CreateEnemyTwo()
    {
        // This function can be used to create another type of enemy
        Instantiate(enemyTwoPrefab, new Vector3(9f, Random.Range(-6.5f, 6.5f), 0), Quaternion.identity);
        // You can implement this function as needed for your game
    }
}
