using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트
{
    class Character
    {
        public string name { get; private set; }
        public int hp { get; private set; }

        public event EventHandler onDamaged;

        public Character(string name, int health)
        {
            this.name = name;
            hp = health;
        }

        public void TakeDamage(int amount)
        {
            hp -= amount;
            Console.WriteLine($"{name}이 {amount} 만큼의 데미지를 입었습니다. 남은 체력 {hp}");

            onDamaged?.Invoke(this, EventArgs.Empty);
        }
    }
    class Program
    {
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            Character character = (Character)sender;

            Console.WriteLine($"이벤트 알림: {character.name}이 데미지를 입었습니다. 현재 체력: {character.hp}");
        }
        static void Main(string[] args)
        {
            Character hero = new Character("hero", 100);

            hero.onDamaged += Hero_OnDamaged;

            hero.TakeDamage(30);

            hero.onDamaged -= Hero_OnDamaged;

            hero.TakeDamage(30);
        }
    }
}
