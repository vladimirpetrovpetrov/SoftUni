using System;

List<Venue> venues = new List<Venue>();
List<Singer> singers = new List<Singer>(); 

while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    if (input[0] == "End")
    {
        break;
    }
    //"singer @venue ticketsPrice ticketsCount"
    var startsWithA = false;
    var indexOfA = 0;
    foreach (var item in input) //провери дали някоя от думата започва с @
    {
        if (item.StartsWith('@'))
        {
            startsWithA = true;
            indexOfA = input.IndexOf(item);
            break;
        }
    }
    if (!startsWithA)
    {
        continue;
    }
    bool lastIsDigitOne = true;
    bool lastIsDigitTwo = true;
    foreach (var item in input[^1]) //провери дали последната дума е само от цифри
    {
        if (!Char.IsDigit(item))
        {
            lastIsDigitOne= false;
            break;
        }
    }
    foreach (var item in input[^2])//провери дали предпоследната дума е само от цифри
    {
        if (!Char.IsDigit(item))
        {
            lastIsDigitTwo = false;
            break;
        }
    }
    if(!lastIsDigitOne || !lastIsDigitTwo)
    {
        continue;
    }
    var inputArray = input.ToArray();
    

    var lenghtValid = true;
    if(input.Count > 8 || input.Count < 4) //ако има под 4 елемента или над 8
    {
        lenghtValid= false;
    }
    if (!lenghtValid)
    {
        continue;
    }

    var venue = inputArray[indexOfA..^2];
    if(venue.Length > 3)
    {
        continue;
    }
    var ticketPrice = inputArray[^2];
    var ticketsCount = inputArray[^1];
    var singerName = inputArray[..indexOfA];
    if(singerName.Length == 0 || singerName.Length > 3)
    {
        continue;
    }

    var finalVenue = String.Join(" ", venue).ToString().TrimStart('@');
    int finalTicketPrice = Convert.ToInt32(ticketPrice);
    int finalTicketsCount = Convert.ToInt32(ticketsCount);
    var finalSingerName = String.Join(" ", singerName).ToString();
    ;
    bool singerExist = singers.Any(x=>x.Name == finalSingerName);
    if(!singerExist)
    {
        Singer s = new Singer(finalSingerName, finalVenue, finalTicketPrice * finalTicketsCount);
        singers.Add(s);
        bool venueExist = venues.Any(x=>x.VenueName == finalVenue);
        if (!venueExist)
        {
            venues.Add(new Venue(finalVenue, new List<Singer>()));
            venues.Find(x => x.VenueName == finalVenue).Singer.Add(s);
        }
        else
        {
            var v = venues.Find(x => x.VenueName == finalVenue);
            if(v.Singer.Any(x=>x.Name == s.Name))
            {
                
            }
            v.Singer.Add(s);
        }
    }
    else
    {
        var s = singers.Find(x => x.Name == finalSingerName);
        s.AddVenueOrMoney(finalVenue, finalTicketPrice * finalTicketsCount);
        venues.Add(new Venue(finalVenue, new List<Singer>()));
        venues.Find(x => x.VenueName == finalVenue).Singer.Add(s);
    }





}



public class Singer
{
    public Singer(string name,string venue, int money)
    {
        this.Name = name;
        if (!VenueMoney.ContainsKey(venue))
        {
            this.VenueMoney.Add(venue, money);
        }
        else
        {
            this.VenueMoney[venue] += money;
        }
        
    }

    public string Name { get; set; }
    public Dictionary<string,int> VenueMoney { get; set; } = new Dictionary<string,int>();
    public void AddVenueOrMoney(string venue, int money)
    {
        if (!VenueMoney.ContainsKey(venue))
        {
            this.VenueMoney.Add(venue, money);
        }
        else
        {
            this.VenueMoney[venue] += money;
        }
    }

}
public class Venue
{
    public Venue(string venueName, List<Singer> singer)
    {
        VenueName = venueName;
        this.Singer = singer;
    }

    public string VenueName { get; set; }
    public List<Singer> Singer { get; set; } = new List<Singer>();

}