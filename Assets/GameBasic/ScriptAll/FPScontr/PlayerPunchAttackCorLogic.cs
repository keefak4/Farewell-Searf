using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunchAttackCorLogic : MonoBehaviour
{
   public static IEnumerator UnitsAttack(Transform obj,Vector3 target)
    {
        Vector3 startPosition = obj.position;
        float t = 0;
        const float animationsDiructions = 1.5f;
        while(t < 1)
        {
            obj.position = Vector3.Lerp(startPosition, target, t * t);
            t += Time.deltaTime / animationsDiructions;
            yield return null;
        }
    }
}
