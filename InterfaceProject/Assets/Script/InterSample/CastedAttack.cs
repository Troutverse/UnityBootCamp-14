using System.Threading.Tasks;
using UnityEngine;
[CreateAssetMenu(menuName="Attack Strategy/Cast")]
public class CastedAttack : ScriptableObject, IAttackStrategy
{
    public GameObject FireBall_Prefab;

    public void Attack(GameObject attacker, GameObject target)
    {
        var FireBall = FireBall_Prefab.GetComponent<Transform>();
        GetDamage(target);
        Debug.Log("[CastedAttack] Sucess");
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
