using System;
using System.Collections.Generic;

namespace EpicodusSurvival.Models
{
  public class Survivor
  {
    private string _name;
    private int _codingSkill;
    private int _caffeine;
    private int _sleep;
    private bool _dead;
    public static Survivor currentSurvivor;

    public Survivor(string name)
    {
      _name = name;
      _codingSkill =0;
      _caffeine= 100;
      _sleep = 100;
      _dead= false;
    }

    public void SetCodingSkill(int newCodingSkill)
    {
      _codingSkill= newCodingSkill;
    }

    public int GetCodingSkill()
    {
      return _codingSkill;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetCaffeine(int newCaffeine)
    {
      _caffeine = newCaffeine;
    }

    public int GetCaffeine()
    {
      return _caffeine ;
    }

    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }

    public int GetSleep()
    {
      return _sleep ;
    }

    public void SetDead(bool newDead)
    {
      _dead = newDead;
    }

    public bool GetDead()
    {
      return _dead ;
    }

    public void IncreaseCodingSkill()
    {
      this.SetCodingSkill(this.GetCodingSkill() + 1);
    }
    public void IncreaseSleep()
    {
      this.SetSleep(this.GetSleep() + 1);
    }
    public void IncreaseCaffeine()
    {
      this.SetCaffeine(this.GetCaffeine() + 1);
    }

    public void DecreaseCodingSkill()
    {
      this.SetCodingSkill(this.GetCodingSkill() - 1);
    }
    public void DecreaseSleep()
    {
      this.SetSleep(this.GetSleep() - 1);
    }
    public void DecreaseCaffeine()
    {
      this.SetCaffeine(this.GetCaffeine() - 1);
    }

    public static void TimeElapse(Survivor thisSurvivor)
    {
      thisSurvivor.DecreaseCodingSkill();
      thisSurvivor.DecreaseSleep();
      thisSurvivor.DecreaseCaffeine();
    }


  }
}
