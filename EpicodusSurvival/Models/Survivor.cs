using System;

namespace EpicodusSurvival.Models
{
  public class Survivor
  {
    private string _name;
    private int _codingSkill;
    private int _caffeine;
    private int _sleep;
    private bool _dead;
    public bool decaffed;
    public static Survivor currentSurvivor;

    public Survivor(string name)
    {
      _name = name;
      _codingSkill =0;
      _caffeine= 10;
      _sleep = 10;
      _dead= false;
      decaffed = false;
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
      if(Survivor.currentSurvivor.decaffed == false)
      {
        this.SetSleep(this.GetSleep() - 1);
      }
      else
      {
      this.SetSleep(this.GetSleep() - 3);
      }
    }
    public void DecreaseCaffeine()
    {
      if(Survivor.currentSurvivor.decaffed == true)
      {
        this.SetCaffeine(this.GetCaffeine());
      }
      else
      {
        this.SetCaffeine(this.GetCaffeine() - 1);
      }
    }

    public static void TimeDecay(Survivor thisSurvivor)
    {
      thisSurvivor.DecreaseCodingSkill();
      thisSurvivor.DecreaseSleep();
      thisSurvivor.DecreaseCaffeine();
    }
  }
}
