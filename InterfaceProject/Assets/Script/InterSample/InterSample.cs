using UnityEngine;

// Interface 
// ��ɿ� ���� ���� : ���� ����� ���� (�浹 ���� ����) => ���� ��ü�� �ᱹ �������̽��� ������ "Ŭ����" �ڽ�
// ���յ��� ���Ƽ�, �������� ���� �ڵ带 ¥�� �����ϴ�
public interface IThrowable
{

}
public interface IWeapon
{

}
public interface ICountable
{

}
public interface IPotion
{

}
public interface IUseable
{

}
public class Item
{

}
public class Sword : Item, IWeapon
{
}
public class Jabelin : Item, IWeapon, ICountable, IThrowable
{
}
public class MaxPotion : Item, IPotion, ICountable, IUseable
{
}
public class FirePotion : Item, IPotion, ICountable, IThrowable
{
}

public class InterSample : MonoBehaviour
{
}
