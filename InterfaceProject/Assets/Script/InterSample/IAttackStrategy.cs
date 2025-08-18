using System.Threading.Tasks;
using UnityEngine;
public interface IAttackStrategy
{
    void Attack(GameObject attacker, GameObject target);

    Task GetDamage(GameObject target);
}