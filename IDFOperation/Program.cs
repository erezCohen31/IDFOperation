using IDFOperation.HAMAS;
using IDFOperation.IDF;

public class program
{
    static void Main(string[] args)
    {
        Weapon ak = new Weapon("AK-47");
        Weapon m16 = new Weapon("M16");
        Weapon m4 = new Weapon("M4");
        List<Weapon> weapons1 = new List<Weapon>();
        List<Weapon> weapons2 = new List<Weapon>();
        List<Weapon> weapons3 = new List<Weapon>();
        weapons1.Add(ak);
        weapons1.Add(m16);
        weapons1.Add(m4);
        weapons2.Add(ak);
        weapons2.Add(m16);
        weapons3.Add(m4);
        Terrorist terrorist1 = new Terrorist("ali", 1, weapons1);
        Terrorist terrorist2 =new Terrorist("mouhamad",5, weapons2);
        Terrorist terrorist3 = new Terrorist("abu",4, weapons3);
        Terrorist terrorist4 = new Terrorist("ali", 1, weapons1);
        Terrorist terrorist5 = new Terrorist("mouhamad", 5, weapons2);
        Terrorist terrorist6 = new Terrorist("abu", 4, weapons3);
        Terrorist terrorist7 = new Terrorist("ali", 1, weapons1);
        Terrorist terrorist8 = new Terrorist("mouhamad", 3, weapons2);
        Terrorist terrorist9 = new Terrorist("abu", 2, weapons3);
        List<Terrorist> terrorists = new List<Terrorist>();
        terrorists.Add(terrorist1);
        terrorists.Add(terrorist2);
        terrorists.Add(terrorist3);
        terrorists.Add(terrorist4);
        terrorists.Add(terrorist5);
        terrorists.Add(terrorist6);
        terrorists.Add(terrorist7);
        terrorists.Add(terrorist8);
        terrorists.Add(terrorist9);
        Target target = new Target("car", "car", "gaza");
        List<Target> targets = new List<Target>();
        targets.Add(target);
        StrikeOption drone = new F16FighterJet("f16", 10, 60, targets, "ez");
        List<StrikeOption> strikes = new List<StrikeOption>();
        strikes.Add(drone);


        Hamas hamas = new Hamas(terrorists);
        Commander commander = new Commander("zamir", 65787, 60);
        Idf idf = new Idf(commander, strikes);


    }
}