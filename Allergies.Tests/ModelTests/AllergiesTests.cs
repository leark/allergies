using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergyTests
  {
    [TestMethod]
    public void Allergy_createAllergyObjWithScoreOne_One()
    {
      //arrange
      // any necessary logic to prep for test; instantiating new classes, etc.
      Allergy newscore = new Allergy(1);

      //act
      
      //assert
      
      Assert.AreEqual(1, newscore.Score);
    }
  }
}