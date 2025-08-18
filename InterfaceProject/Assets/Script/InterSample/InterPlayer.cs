using UnityEngine;

public class InterPlayer : MonoBehaviour
{
    // �ν����� ������ ���� ����, �ܺο��� ���� �Ұ�
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
        // Nullable<T> OR T? �� Value�� ���� null ����� ���� ����
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