namespace Rpg_Game
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lancou Magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lancou Magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lancou Magia com forca fraca com bonus de " + Bonus;
            }

            
        }
    }
}