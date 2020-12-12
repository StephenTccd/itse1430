/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 5
 */
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Web.Models
{
    public class CharacterModel
    {
        public CharacterModel () 
        { }

        public CharacterModel (Character character)
        {
            Name = character.Name;
            Profession = character.Profession;
            Race = character.Race;
            Strength = character.Strength;
            Intelligence = character.Intelligence;
            Agility = character.Agility;
            Constitution = character.Constitution;
            Charisma = character.Charisma;
            Description = character.Description;
        }

        public Character ToCharacter ()
        {
            return new Character() 
            {
             Name = Name,
             Profession = Profession,
             Race = Race,
             Strength = Strength,
             Intelligence = Intelligence,
             Agility = Agility,
             Constitution = Constitution,
             Charisma = Charisma,
             Description = Description,
            };
        }

        [Required(AllowEmptyStrings =  false)]
        [StringLength(Character.MaximumNameLength)]
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Race { get; set; }
        
        [Range(0, 100)]
        public int Strength { get; set; } = 50;
        
        [Range(0, 100)]
        public int Intelligence { get; set; } = 50;
        
        [Range(0, 100)]
        public int Agility { get; set; } = 50;

        [Range(0, 100)]
        public int Constitution { get; set; } = 50;

        [Range(0, 100)]
        public int Charisma { get; set; } = 50;
        
        [StringLength(Character.MaximumNameLength)]
        public string Description { get; set; }
    }
}
