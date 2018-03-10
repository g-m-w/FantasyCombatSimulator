using FantasyCombatSimulator.Equipment.Armour.Medium;
using FantasyCombatSimulator.Equipment.Weapons.Edged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatSimulator.Actors.Spellcaster
{
  public class Necromancer
  {
    private int _abilityPoints;
    private int _healthPoints;
    private int _level;

    private string _faction;
    private string _name;

    private StuddedLeatherVest _armour;
    private Sword _weapon;

    public Necromancer()
    {

    }

    public void BloodRage()
    {
      throw new NotImplementedException();
    }

    public void VampireTouch()
    {
      throw new NotImplementedException();
    }

    public void BoneArmour()
    {
      throw new NotImplementedException();
    }
  }
}
