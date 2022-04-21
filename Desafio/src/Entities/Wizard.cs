namespace Desafio.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int level, string HeroType) : base(Name, level, HeroType)
    {
      this.Name = Name;
      this.level = level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " Atacou com a sua Magia";
    }

    
    public virtual string Attack(int Bonus){
        if(Bonus > 6){
        return this.Name + " Lançou magia Forte com bonus de ataque de " + Bonus;
        }else{
      return this.Name + " Lançou magia fraca com bonus de ataque de " + Bonus;
        }

    }
  }
}