using System.Collections.Generic;
using System;
using System.Linq;

namespace Allergies
{
  public class Allergy
  {
    public int Score { get; set; }
    public Dictionary<int, string> Allergens;

    public Allergy(int score) 
    {
      Score = score;
      Allergens = new Dictionary<int, string>() {{1, "eggs"}, {2, "peanuts"}, {4, "shellfish"}, {8, "strawberries"}, {16, "tomatoes"}, {32, "chocolate"}, {64, "pollen"}, {128, "cats"}};
    }

    public List<string> CalculateAllergies() 
    {
      List<string> allergies = new List<string> {};
      int tempScore = Score;
      Dictionary<int, string>.KeyCollection keys = Allergens.Keys;

      while (tempScore > 0) {
        for (int i = keys.Count - 1; i >= 0; i--) {
          int allergenScore = keys.ElementAt(i);
          if (tempScore >= allergenScore) {
            allergies.Add(Allergens[allergenScore]);
            tempScore -= allergenScore;
          }
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