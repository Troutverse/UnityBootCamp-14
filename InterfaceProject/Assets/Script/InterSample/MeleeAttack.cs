using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Attack Strategy/Melee")]
public class MeleeAttack : ScriptableObject, IAttackStrategy
{
    public void Attack(GameObject attacker, GameObject target)
    {
        if (Vector3.Distance(target.transform.position, attacker.transform.position) <= 5)
        {
            GetDamage(target);
            Debug.Log("[Melee Attack] Sucess " + target.name);
        }
        else
        {
            Debug.Log("[Melee Attack] Fail " + target.name);
        }
    }
    public async Task GetDamage(GameObject target)
    {
        var TargetRender = target.GetComponent<Renderer>();
        Color OriginTargetColor = TargetRender.material.color;
        TargetRender.material.color = Color.red;
        await Task.Delay(200);
        TargetRender.material.color = OriginTargetColor;
    }
}