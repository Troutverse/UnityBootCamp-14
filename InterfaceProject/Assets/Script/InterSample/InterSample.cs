using UnityEngine;

// Interface 
// 기능에 대한 설계 : 다중 상속이 가능 (충돌 문제 없음) => 구현 주체는 결국 인터페이스를 구현할 "클래스" 자신
// 결합도가 낮아서, 유연성이 높은 코드를 짜기 수월하다
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
