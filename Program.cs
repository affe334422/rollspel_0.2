using System.Runtime.CompilerServices;
int hlvl = 1;
int hp = 5 + 5 * hlvl;
int hdmg = hlvl + 2 * hlvl;
int hkrit = 30;

int flvl = hlvl - 1;
int fhp = 5 + 5 *flvl; 
int fdmg = 2 * flvl;
int fkrit = 30;

int hvinst = 0;
int fvinst = 0;

for(int hur_många_gånger = 1; hur_många_gånger != 1001; hur_många_gånger++){
    
    Console.WriteLine("test " + hur_många_gånger);
    för_att_nolla_någon_av_dem(ref hp, ref hdmg, hlvl);
    för_att_nolla_någon_av_dem1(ref fhp, ref fdmg, flvl);
    hlvl++;
    flvl++;
    fkrit++;
    
    ui(hp, hdmg);
    fui(fhp, fdmg);
    Console.WriteLine(fkrit);

    while(fhp != 0 && hp != 0){

        //string enter = "skriv 1 eller 2 sen tryck enter:";
        //sakta(enter);
        int attack_number1 = 1;//int.Parse(Console.ReadLine());

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
                hvinst++;
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
            if(attack_number1 == 2){
                if(hp == 0){
                    break;
                }  
            healing(ref hp, hlvl);
            } 
            ui(hp, hdmg);
            fui(fhp, fdmg);
        }
        if(hp == 0){
            fvinst++;
            break;
        }  
        
    }
}
Console.WriteLine("Du van "+ hvinst + " gånger");
Console.WriteLine("Råttan van "+ fvinst + " gånger");
   

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
        skada = skada * 2;
        hälsa = jag_tror - skada;

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

    if(skrit <= krit){ 
        skada = skada * 2;
        hälsa = jag_tror - skada;

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

static void healing(ref int hälsa, int lvl){
    int hälsa1 = hälsa;
    double hälsa2 = hälsa1;
    int hälsa3 = hälsa;
    int max = 5 + 5 * lvl;
    string mes1 = "Medans du healar ";
    string mes2 = " hp";

    hälsa1 = hälsa1 / 3;
    hälsa2 = hälsa2 / 3;
    
    if(hälsa1 <= hälsa2 - 0.5){
        hälsa = hälsa + hälsa1;
        
        if(hälsa >= 11){
            hälsa = 10;
            hälsa1 = max - hälsa3;
        }

        sakta(mes1);
        Console.Write(hälsa1);
        sakta(mes2);
        Console.WriteLine("");
    }
    else{
        hälsa = hälsa + hälsa1 + 1;
        if(hälsa >= 11){
            hälsa = 10;
            hälsa1 = max - hälsa3;
        }
        sakta(mes1);
        Console.Write(hälsa1);
        sakta(mes2);
        Console.WriteLine("");
    }
    
}

static void sakta(string mes){
    foreach (char c in mes){
            Console.Write(c);
            Thread.Sleep(0);
    }
}

static void för_att_nolla_någon_av_dem(ref int hälsa, ref int dmg, int lvl){
    hälsa = 5 + 5 * lvl;
    dmg = 2 * lvl;
}

static void för_att_nolla_någon_av_dem1(ref int hälsa, ref int dmg, int lvl){
    hälsa = 5 + 5 * lvl;
    int a = lvl /2;
    dmg = lvl + a;
}