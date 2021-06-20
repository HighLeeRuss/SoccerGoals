using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public GameObject ball;
  public GameObject blue1;
  public GameObject blue2;
  public GameObject blue3;
  private Vector3 ballSpawn;
  private Quaternion blue1Spawn;
  private Quaternion blue2Spawn;
  private Quaternion blue3Spawn;
  private Vector3 blue1SpawnPos;
  private Vector3 blue2SpawnPos;
  private Vector3 blue3SpawnPos;

  private void Start()
  {
    ballSpawn = ball.transform.position;
    blue1Spawn = blue1.transform.rotation;
    blue2Spawn = blue2.transform.rotation;
    blue3Spawn = blue3.transform.rotation;
    blue1SpawnPos = blue1.transform.position;
    blue2SpawnPos = blue2.transform.position;
    blue3SpawnPos = blue3.transform.position;
  }

  private void OnEnable()
  {
    EventManager.ResetAcitvated += Reset;
  }

  private void OnDisable()
  {
    EventManager.ResetAcitvated -= Reset;
  }

  void Reset()
  {
    StartCoroutine(WaitForSec());
  }

  IEnumerator WaitForSec()
  {
    yield return new WaitForSeconds(5f);
    ball.transform.position = ballSpawn;
    blue1.transform.rotation = blue1Spawn;
    blue2.transform.rotation = blue2Spawn;
    blue3.transform.rotation = blue3Spawn;
    blue1.transform.position = blue1SpawnPos;
    blue2.transform.position = blue2SpawnPos;
    blue3.transform.position = blue3SpawnPos;
    Debug.Log("Shoot again");
  }
  
  
}
