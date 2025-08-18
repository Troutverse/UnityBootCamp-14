using UnityEngine;

public class InterPlayer : MonoBehaviour
{
    // 인스펙터 내에서 접근 가능, 외부에서 접근 불가
    [SerializeField] private ScriptableObject attackObject;
    private IAttackStrategy strategy;
    private void Awake()
    {
        strategy = attackObject as IAttackStrategy;
        if (strategy == null) Debug.LogError("NO ATTACK FUNCTION");
    }
    public void AttackMelee(GameObject target, GameObject attacker)
    {
        strategy?.Attack(attacker, target);
        // Nullable<T> OR T? 는 Value에 대한 null 허용을 위한 도구
    }

    public void AttackRange(GameObject target, GameObject attacker)
    {
        strategy?.Attack(attacker, target);
    }

    public void AttackCast(GameObject target, GameObject attacker)
    {
        strategy?.Attack(attacker, target);
    }

    public void AttackMeleeBtClick(GameObject target)
    {
        AttackMelee(target, this.gameObject);
    }

    public void AttackRangeBtClick(GameObject target)
    {
        AttackRange(target, this.gameObject);
    }

    public void AttackCastBtClick(GameObject target)
    {
        AttackRange(target, this.gameObject);
    }
}