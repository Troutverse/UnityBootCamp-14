using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName="Attack Strategy/Range")]
public class RangedAttack : ScriptableObject, IAttackStrategy
{
    public void Attack(GameObject attacker, GameObject target)
    {
        if (Vector3.Distance(attacker.transform.position, target.transform.position) <= 15)
        {
            GetDamage(target);
            Debug.Log("[RangeAttack] Sucess" + target.name);
        }
        else
        {
            Debug.Log("[RangeAttack] Fail" + target.name);
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
