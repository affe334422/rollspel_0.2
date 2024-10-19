using System.Runtime.CompilerServices;

int hp = 10;
int hdmg = 2;
int hkrit = 30;

int fhp = 10; 
int fdmg = 1;
int fkrit = 20;


Console.WriteLine("test");
ui(hp, hdmg);
fui(fhp, fdmg);

while(fhp != 0 && hp != 0){

string enter = "skriv 1 sen tryck enter:";
sakta(enter);
int attack_number1 = int.Parse(Console.ReadLine());

    if(attack_number1 == 1){
        Console.WriteLine("");
        for(int a = 0; a != 1; a++){
            dmg(ref fhp, hdmg, hkrit);
            if(fhp <= 0){
                fhp = 0;
                ui(hp, hdmg);
                fui(fhp, fdmg);
                Console.WriteLine("Råttan dog");
                break;
            }
            ui(hp, hdmg);
            fui(fhp, fdmg);
        }
        if(fhp == 0){
            break;
        }     
    }

    for(int a = 0; a != 1; a++){
        f_dmg(ref hp, fdmg, fkrit);
        if(hp <= 0){
            hp = 0;
            ui(hp, hdmg);
            fui(fhp, fdmg);
            Console.WriteLine("Du dog");
            break;
        }
        ui(hp, hdmg);
        fui(fhp, fdmg);
    }
    if(hp == 0){
        break;
    }  
    
}

   

static void ui(int ahp, int admg){
    string mes1 = "Du:";
    string mes2 = "hp "+ ahp;
    string mes3 = "dmg "+ admg;

    sakta(mes1);
    Console.WriteLine("");
    sakta(mes2);
    Console.WriteLine("");
    sakta(mes3);
    Console.WriteLine("");
    Console.WriteLine("");
}

static void fui(int ahp, int admg){
    string mes1 = "Råtta:";
    string mes2 = "hp "+ ahp;
    string mes3 = "dmg "+ admg;

    sakta(mes1);
    Console.WriteLine("");
    sakta(mes2);
    Console.WriteLine("");
    sakta(mes3);
    Console.WriteLine("");
    Console.WriteLine("");
}

static void dmg(ref int hälsa, int skada, int krit){
    Random rnd = new Random();
    int skrit = rnd.Next(1,101);
    int jag_tror = hälsa;
    string mes1 = "Du gör ";
    string mes2 = " skada till råttan";

    if(skrit<=krit){ 
        hälsa = jag_tror - skada *2;

        sakta(mes1);

        Console.Write(skada);

        sakta(mes2);
        Console.WriteLine("");
    }
    else{
        hälsa = jag_tror - skada;

        sakta(mes1);

        Console.Write(skada);

        sakta(mes2);
        Console.WriteLine("");
    }
}

static void f_dmg(ref int hälsa, int skada, int krit){
    Random rnd = new Random();
    int skrit = rnd.Next(1,101);
    int jag_tror = hälsa;
    string mes1 = "Råttan gör ";
    string mes2 = " skada till dig";

    if(skrit<=krit){ 
        hälsa = jag_tror - skada *2;

        sakta(mes1);

        Console.Write(skada);

        sakta(mes2);
        Console.WriteLine("");
    }
    else{
        hälsa = jag_tror - skada;

        sakta(mes1);

        Console.Write(skada);

        sakta(mes2);
        Console.WriteLine("");
    }
}

static void sakta(string mes){
    foreach (char c in mes){
            Console.Write(c);
            Thread.Sleep(50);
    }
}