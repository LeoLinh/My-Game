using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyShield : MonoBehaviour
{
    private bool isShieldActive = false;
    public GameObject Shield_Skill;
    public float shieldDuration = 3;

    // Hàm để kích hoạt màn chắn năng lượng.
    public void ActivateShield()
    {
        Debug.Log("Shiled actived");
        isShieldActive = true;
        Shield_Skill.SetActive(true);
        StartCoroutine(DeactivateShieldAfterDuration());
    }

    private IEnumerator DeactivateShieldAfterDuration()
    {
        yield return new WaitForSeconds(shieldDuration);
        isShieldActive = false;
        Shield_Skill.SetActive(false);
        Debug.Log("Shield deactivated");
    }

    // Hàm để tắt màn chắn năng lượng.
    public void DeactivateShield()
    {
        isShieldActive = false;
        Shield_Skill.SetActive(false);
        // Thực hiện các hành động liên quan đến ẩn màn chắn năng lượng ở đây.
    }
}
