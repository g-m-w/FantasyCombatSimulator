using FantasyCombatSimulator.Equipment.Armour.Heavy;
using FantasyCombatSimulator.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatSimulator.Actors.Melee
{
  public class Paladin
  {
    private int _abilityPoints;
    private int _healthPoints;
    private int _level;

    private string _faction;
    private string _name;

    private Chainmail _armour;
    private Mace _weapon;

    public Paladin()
    {

    }

    public void HolyBlow()
    {
      throw new NotImplementedException();
    }

    public void PurifySoul()
    {
      throw new NotImplementedException();
    }

    public void RightousZeal()
    {
      throw new NotImplementedException();
    }
  }
}
