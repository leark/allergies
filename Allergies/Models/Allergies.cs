using System.Collections.Generic;

namespace Allergies
{
  public class Allergy
  {
    public int Score { get; set; }

    public Allergy(int score) 
    {
      Score = score;
    }

    public List<string> CalculateAllergies() 
    {
      List<string> allergies = new List<string> {""};
      
      return allergies;
    }
  }
}



/*
create a dictionary for allergy scores
create a constructor for our allergy class to get score

*/
/*

allergen     score
eggs         1
peanuts      2
shellfish    4
strawberries 8
tomatoes     16
chocolate    32
pollen       64
cats         128

*/