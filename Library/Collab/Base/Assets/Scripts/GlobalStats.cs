using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStats : MonoBehaviour {

	/*
	Class that holds global variables for gameplay
	Used to reduce calculation costs and make
	easy access for stats
	 */
	public static int bulletDamage;
	public static float bulletSpeed;
	public static float attackRate;
	public static int maxHealth;
	public static float rushEnemySpeed;
	public static int rushEnemyDamage;
	public static int enemyHealth;
	public static float enemySpawnRate;
	public static float enemySpawnX;
	public static float enemySpawnY;
	public static float enemySpawnZ;
	public static float shieldEnemyBlockRate;

	void Awake()
	{
		bulletDamage = 1;
		bulletSpeed = .1f;
		attackRate = 1f;
		maxHealth = 100;

		rushEnemySpeed = .1f;
		rushEnemyDamage = 1;
		enemyHealth = 1;
		enemySpawnRate = 3f;

		enemySpawnX = .5f;
		enemySpawnY = .5f;
		enemySpawnZ = .5f;

		shieldEnemyBlockRate = 1f;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
