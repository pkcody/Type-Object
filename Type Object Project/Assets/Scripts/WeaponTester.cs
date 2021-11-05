using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponTester : MonoBehaviour
{
    [SerializeField]
    private Weapon currentWeapon;

    [SerializeField]
    private Target target;

    private void Awake()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            currentWeapon.Attack(target);
        }
    }
}
