using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda2D_Clone.Stats
{
    public class Being
    {
        float attackSpeed; //To decide order of attack upon intial encounter
        float attackPower; //Will decide amount of damage being done per attack
        float defense; //Determines effectiveness of enemy attacks
        float currentHealth; //Stores information on 
        float maxHealth;

    }

    public class Player : Being
    {
        //TODO 
    }

    public class NPC : Being
    {
        //TODO 
    }
}
