namespace _060223_Homework3
{
  class StartUp
  {
    static void Main(string[] args)
    {
      string[] numbers = Console.ReadLine().Split();
      string[] sites = Console.ReadLine().Split();

      Smartphone smartphone = new Smartphone();
      StationaryPhone stationaryPhone = new StationaryPhone();
      Browser browser = new Browser();

      foreach (string number in numbers)
      {
        if (IsValidNumber(number))
        {
          if (number.Length == 10)
          {
            smartphone.Call(number);
          }
          else
          {
            stationaryPhone.Call(number);
          }
        }
      }

      foreach (string site in sites)
      {
        if (IsValidSite(site))
        {
          browser.Browse(site);
        }
      }
    }

    static bool IsValidNumber(string number)
    {
      if (!IsDigitsOnly(number))
      {
        Console.WriteLine("Invalid number!");
        return false;
      }

      if (number.Length != 10 && number.Length != 7)
      {
        Console.WriteLine("Invalid number!");
        return false;
      }

      return true;
    }

    static bool IsValidSite(string site)
    {
      foreach (char c in site)
      {
        //check if it have a digit
        if (char.IsDigit(c))
        {
          Console.WriteLine("Invalid URL!");
          return false;
        }
        //check else if it have a dot
        else if (!site.Contains("."))
        {
          Console.WriteLine("Invalid URL!");
          return false;
        }
      }

      return true;
    }

    static bool IsDigitsOnly(string str)
    {
      foreach (char c in str)
      {
        if (!char.IsDigit(c))
        {
          return false;
        }
      }

      return true;
    }

  }
}