using System.Collections.Generic;

namespace Allergies
{
  public class Allergy
  {
    public int Score { get; set; }
    public Dictionary<int, string> Allergens;

    public Allergy(int score) 
    {
      Score = score;
      Allergens = new Dictionary<int, string>() {{1, "eggs"}, {2, "peanuts"}};
    }

    public List<string> CalculateAllergies() 
    {
      List<string> allergies = new List<string> {};
      int tempScore = Score;
      while (tempScore > 0) {
        if (tempScore >= 128)
        {
          allergies.Add("cats");
          tempScore -= 128;
        }
        else if (tempScore >= 64)
        {
          allergies.Add("pollen");
          tempScore -= 64;
        }
        else if (tempScore >= 32)
        {
          allergies.Add("chocolate");
          tempScore -= 32;
        }
        else if (tempScore >= 16)
        {
          allergies.Add("tomatoes");
          tempScore -= 16;
        }
        else if (tempScore >= 8)
        {
          allergies.Add("strawberries");
          tempScore -= 8;
        }
        else if (tempScore >= 4)
        {
          allergies.Add("shellfish");
          tempScore -= 4;
        }
        else if (tempScore >= 2)
        {
          allergies.Add("peanuts");
          tempScore -= 2;
        }
        else if (tempScore >= 1)
        {
          allergies.Add("eggs");
          tempScore -= 1;
        }
      }      
      return allergies;
    }
  }
}



/*
create a dictionary for allergy scores
create a constructor for our allergy class to get score

*/
/*

135 -> gonna have cats so subtract 128 for cats
7 -> def have shellfish subtract 4
3 -> subtract peanuts
1 -> eggs

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