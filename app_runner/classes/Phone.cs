using System;

class Phone
{
    private string[] Apps = new string[100];

    public string AppsString
    {
        get
        {
            string stringApps = "";
            for (int i = 0; i < this.AppCount; i++)
            {
                if (AppCount != i + 1)
                {
                    stringApps += this.Apps[i] + ", ";
                }
                else
                {
                    stringApps += this.Apps[i] + ".";
                }
            }
            return stringApps;
        }
    }

    public string Owner { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public int Battery { get; set; }
    public int AppCount { get; set; }

    public Phone(string owner, int year, double price, int battery)
    {
        Owner = owner;
        Year = year;
        Price = price;
        Battery = battery;
        AppCount = 0;
    }

    public Phone(Phone p)
    {
        Owner = p.Owner;
        Year = p.Year;
        Price = p.Price;
        Battery = p.Battery;
        Apps = p.Apps;
        AppCount = p.AppCount;
    }

    public override string ToString()
    {
        return "The owner is " + Owner + ", the phone is from " + Year + " and it costs " + Price +
               "\nwith " + Battery + " percentage with " + AppCount + " apps which are: " + AppsString;
    }

    public void AddApp(string app)
    {
        if (AppCount < Apps.Length)
        {
            Apps[AppCount] = app;
            if (AppCount < 99)
            {
                AppCount++;
            }
        }
    }

    public void RemoveApp()
    {
        if (AppCount > 0)
        {
            Apps[AppCount] = null;
            AppCount--;
        }
        else
        {
            Console.WriteLine("There are no apps to remove.");
        }
    }
}

enum AppNames
{
    Google,
    Explorer,
    TikTok
}

class PhonePresenter
{
    public static void presenter()
    {
        Phone[] phones = new Phone[3];
        phones[0] = new Phone("Omer", 2018, 2500, 20);
        phones[1] = new Phone("Dani", 2006, 5080, 90);
        phones[2] = new Phone("Ban", 2021, 8700, 80);

        foreach (Phone phone in phones)
        {
            Console.WriteLine(phone);
        }

        for (int i = 0; i < Enum.GetNames(typeof(AppNames)).Length; i++)
        {
            if (i < 4)
            {
                phones[0].AddApp(((AppNames)i).ToString());
            }
            else if (i >= 4 && i <= 7)
            {
                phones[1].AddApp(((AppNames)i).ToString());
            }
            else
            {
                phones[2].AddApp(((AppNames)i).ToString());
            }
        }

        foreach (Phone phone in phones)
        {
            Console.WriteLine(phone);
        }
    }
}
