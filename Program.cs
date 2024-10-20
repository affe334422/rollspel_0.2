using System.Runtime.CompilerServices;
int hlvl = 1;
int hp = 5 + 5 * hlvl;
int hdmg = hlvl + 2 * hlvl;
int hkrit = 30;

int flvl = hlvl;
int fhp = 5 + 5 *flvl; 
int fdmg = 2 * flvl;
int fkrit = 30;

int hvinst = 0;
int fvinst = 0;

for(int hur_många_gånger = 1; hur_många_gånger != 11; hur_många_gånger++){
    if(hur_många_gånger == 1){
        
    }
    Console.WriteLine("test " + hur_många_gånger);
    för_att_nolla_någon_av_dem(ref hp, ref hdmg, hlvl);
    för_att_nolla_någon_av_dem1(ref fhp, ref fdmg, flvl);
    fkrit++;
    
    ui(hp, hdmg, hlvl);
    fui(fhp, fdmg, flvl);
    Console.WriteLine(fkrit);

    while(fhp != 0 && hp != 0){

        string enter = "skriv 1 för att attackera eller 2 för att öka ditt hp sen tryck enter:";
        sakta(enter, 50);
        int attack_number1 = int.Parse(Console.ReadLine());

        if(attack_number1 == 1){
            Console.WriteLine("");
            for(int a = 0; a != 1; a++){
                dmg(ref fhp, hdmg, hkrit);
                if(fhp <= 0){
                    fhp = 0;
                    ui(hp, hdmg, hlvl);
                    fui(fhp, fdmg, flvl);
                    Console.WriteLine("Råttan dog");
                    hlvl++;
                    break;
                }
                ui(hp, hdmg, hlvl);
                fui(fhp, fdmg, flvl);
            }
            if(fhp == 0){
                Random kap = new Random();
                flvl = hlvl + kap.Next(0, hlvl +2);
                hvinst++;
                break;
            }     
        }

        for(int a = 0; a != 1; a++){
            f_dmg(ref hp, fdmg, fkrit);
            if(hp <= 0){
                hp = 0;
                ui(hp, hdmg, hlvl);
                fui(fhp, fdmg, flvl);
                if(flvl >= 2){
                    flvl--;
                }
                Console.WriteLine("Du dog");
                break;
            }
            if(attack_number1 == 2){
                if(hp == 0){
                    break;
                }  
            healing(ref hp, hlvl);
            } 
            ui(hp, hdmg, hlvl);
            fui(fhp, fdmg, flvl);
        }
        if(hp == 0){
            fvinst++;
            break;
        }  
        
    }
}
Console.WriteLine("Du van "+ hvinst + " gånger");
Console.WriteLine("Råttan van "+ fvinst + " gånger");
   

static void ui(int ahp, int admg, int lvl){
    string mes1 = "Du: lvl "+ lvl;
    string mes2 = "hp "+ ahp;
    string mes3 = "dmg "+ admg;

    int tid1 = 30;

    sakta(mes1, tid1);
    Console.WriteLine("");
    sakta(mes2, tid1);
    Console.WriteLine("");
    sakta(mes3, tid1);
    Console.WriteLine("");
    Console.WriteLine("");
}

static void fui(int ahp, int admg, int lvl){
    string mes1 = "Råtta: lvl "+ lvl;
    string mes2 = "hp "+ ahp;
    string mes3 = "dmg "+ admg;

    int tid1 = 30;

    sakta(mes1, tid1);
    Console.WriteLine("");
    sakta(mes2, tid1);
    Console.WriteLine("");
    sakta(mes3, tid1);
    Console.WriteLine("");
    Console.WriteLine("");
}

static void dmg(ref int hälsa, int skada, int krit){
    Random rnd = new Random();
    int skrit = rnd.Next(1,101);
    int jag_tror = hälsa;
    string mes1 = "Du gör ";
    string mes2 = " skada till råttan";

    int tid2 = 50;

    if(skrit<=krit){ 
        skada = skada * 2;
        hälsa = jag_tror - skada;

        sakta(mes1, tid2);

        Console.Write(skada);

        sakta(mes2, tid2);
        Console.WriteLine("");
    }
    else{
        hälsa = jag_tror - skada;

        sakta(mes1, tid2);

        Console.Write(skada);

        sakta(mes2, tid2);
        Console.WriteLine("");
    }
}

static void f_dmg(ref int hälsa, int skada, int krit){
    Random rnd = new Random();
    int skrit = rnd.Next(1,101);
    int jag_tror = hälsa;
    string mes1 = "Råttan gör ";
    string mes2 = " skada till dig";

    int tid2 = 50;

    if(skrit <= krit){ 
        skada = skada * 2;
        hälsa = jag_tror - skada;

        sakta(mes1, tid2);

        Console.Write(skada);

        sakta(mes2, tid2);
        Console.WriteLine("");
    }
    else{
        hälsa = jag_tror - skada;

        sakta(mes1, tid2);

        Console.Write(skada);

        sakta(mes2, tid2);
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

    int tid2 = 50;

    hälsa1 = hälsa1 / 3;
    hälsa2 = hälsa2 / 3;
    
    if(hälsa1 <= hälsa2 - 0.5){
        hälsa = hälsa + hälsa1;
        
        if(hälsa >= 11){
            hälsa = 10;
            hälsa1 = max - hälsa3;
        }

        sakta(mes1, tid2);
        Console.Write(hälsa1);
        sakta(mes2, tid2);
        Console.WriteLine("");
    }
    else{
        hälsa = hälsa + hälsa1 + 1;
        if(hälsa >= 11){
            hälsa = 10;
            hälsa1 = max - hälsa3;
        }
        sakta(mes1, tid2);
        Console.Write(hälsa1);
        sakta(mes2, tid2);
        Console.WriteLine("");
    }
    
}

static void sakta(string mes, int tid){
    foreach (char c in mes){
            Console.Write(c);
            Thread.Sleep(tid);
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