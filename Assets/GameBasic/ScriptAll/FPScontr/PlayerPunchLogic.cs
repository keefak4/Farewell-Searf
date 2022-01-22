using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunchLogic : MonoBehaviour
{
    [SerializeField] private GameObject leftPunch;
    //[SerializeField] private GameObject rightPunch;
    [SerializeField] private float speedPunch;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) LeftPunchLogic();
    }
   private IEnumerator LeftPunchLogic()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));
        yield return StartCoroutine(PlayerPunchAttackCorLogic.UnitsAttack(leftPunch.transform,new Vector3(5,5,5)));

    }
}
