namespace _020223_Homework3
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      // Create a new instance of the Hero class
      Hero hero = new Hero("Pesho", 10);
      // Create a new instance of the Elf class
      Elf elf = new Elf("Gosho", 10);
      // Create a new instance of the MuseElf class
      MuseElf museElf = new MuseElf("Ivan", 10);
      // Create a new instance of the Wizard class
      Wizard wizard = new Wizard("Stamat", 10);
      // Create a new instance of the DarkWizard class
      DarkWizard darkWizard = new DarkWizard("Balmain", 10);
      // Create a new instance of the SoulMaster class
      SoulMaster soulMaster = new SoulMaster("Siro", 10);
      // Create a new instance of the Knight class
      Knight knight = new Knight("Kay", 10);
      // Create a new instance of the DarkKnight class
      DarkKnight darkKnight = new DarkKnight("Dxy", 10);
      // Create a new instance of the BladeKnight class
      BladeKnight bladeKnight = new BladeKnight("Bray", 10);

      // Print the username and level of the hero
      System.Console.WriteLine(hero);
      // Print the username and level of the elf
      System.Console.WriteLine(elf);
      // Print the username and level of the museElf
      System.Console.WriteLine(museElf);
      // Print the username and level of the wizard
      System.Console.WriteLine(wizard);
      // Print the username and level of the darkWizard
      System.Console.WriteLine(darkWizard);
      // Print the username and level of the soulMaster
      System.Console.WriteLine(soulMaster);
      // Print the username and level of the knight
      System.Console.WriteLine(knight);
      // Print the username and level of the darkKnight
      System.Console.WriteLine(darkKnight);
      // Print the username and level of the bladeKnight
      System.Console.WriteLine(bladeKnight);
    }
  }
}