using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Enemy
    {
        // type // name // value
       string name;
       public int weaponCount;
       public bool isAlive;
       public int currentState;
       // getter and setter
       public string Name
       {
           get
           {
               return name;
           }
           set
           {
               name = value;
           }
       }

        public Enemy()
        {
            name = "Enemy";
            weaponCount = 5;
            isAlive = true;
            currentState = 2;
        }
        public Enemy(string enemyName, int weapon, bool alive, int state)
        {
            name = enemyName;
            weaponCount = weapon;
            isAlive = alive;
            currentState = state;
        }
        public void enemyAttack()
        {
            Console.WriteLine("Attacking Player");
        }
    }
}
