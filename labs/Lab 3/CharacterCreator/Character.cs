/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 3
 */
using System;

namespace CharacterCreator
{
    public class Character
    {

        public const int MaximumNameLength = 50;
        public readonly int MaximumDescriptionLength = 200;
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";
        public int Id { get; set; }
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }
        private string _profession = "";
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        private string _race;
        public int Strength { get; set; } = 50;
        public int Intelligence { get; set; } = 50;
        public int Agility { get; set; } = 50;
        public int Constitution { get; set; } = 50;
        public int Charisma { get; set; } = 50;
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;
  
        public string Validate()
        {
            if (String.IsNullOrEmpty(Name))
                return "Name is required";
            
            if (Profession == null) 
                return "Profession is required";

            if (Race == null)
                return "Race is required";

            if (Strength < 0)
                return "Strength must be greater than or equal to 0";
            
            if (Strength > 100)
                return "Strength must be less than or equal to 100";

            if (Intelligence < 0)
                return "Intelligence must be greater than or equal to 0";

            if (Intelligence > 100)
                return "Intelligence must be less than or equal to 100";

            if (Agility < 0)
                return "Agility must be greater than or equal to 0";

            if (Agility > 100)
                return "Agility must be less than or equal to 100";

            if (Constitution < 0)
                return "Constitution must be greater than or equal to 0";

            if (Constitution > 100)
                return "Constitution must be less than or equal to 100";

            if (Charisma < 0)
                return "Charisma must be greater than or equal to 0";
            
            if (Charisma > 100)
                return "Charisma must be less than or equal to 100";

            return null;
        }
    }
}
