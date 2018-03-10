using FantasyCombatSimulator.Equipment.Armour.Heavy;
using FantasyCombatSimulator.Equipment.Weapons.Edged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatSimulator.Actors.Melee
{
  public class Warrior
  {
    private int _abilityPoints;
    private int _healthPoints;
    private int _level;

    private string _faction;
    private string _name;

    private Chainmail _armour;
    private Axe _weapon;

    public Warrior()
    {

    }

    public void Strike()
    {
      throw new NotImplementedException();
    }

    public void Execute()
    {
      throw new NotImplementedException();
    }

    public void Brace()
    {
      throw new NotImplementedException();
    }
  }
}
