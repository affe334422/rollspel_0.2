using System.Runtime.CompilerServices;
int hlvl = 10;
int hp = 5 + 5 * hlvl;
int hdmg = 2 * hlvl + hlvl;
int hkrit = 30;

int hvinst = 0;
int fvinst = 0;

fight_sekvens(ref hlvl, ref hp, ref hdmg, ref hkrit);
fight_sekvens(ref hlvl, ref hp, ref hdmg, ref hkrit);


static void fight_sekvens(ref int lvl, ref int hp, ref int dubdmg, ref int crit){
    int hjälte_lvl = lvl;
    int hjälte_hp = hp;
    int hjälte_dmg = dubdmg;
    int hjälte_crit = crit;

    int fiende_lvl = lvl;
    int fiende_hp = 5 + 5 * fiende_lvl;
    int fiende_dmg = 2 * fiende_lvl;
    int fiende_crit = 30;

    Console.WriteLine("test");

    ui(hjälte_hp, hjälte_dmg, hjälte_lvl);
    fui(fiende_hp, fiende_dmg, fiende_lvl);

    while(fiende_hp != 0 && hjälte_hp != 0){
        string enter = "skriv 1 för att attackera eller 2 för att öka ditt hp sen tryck enter:";
        sakta(enter, 50);
        int attack_number1 = int.Parse(Console.ReadLine());

        if(attack_number1 == 1){
            Console.WriteLine("");
            for(int a = 0; a != 1; a++){
                dmg(ref fiende_hp, hjälte_dmg, hjälte_crit);
                if(fiende_hp <= 0){
                    fiende_hp = 0;
                    ui(hjälte_hp, hjälte_dmg, hjälte_lvl);
                    fui(fiende_hp, fiende_dmg, fiende_lvl);// ska ändras om jag har mer fiender, ta väck namnet så det skrivs innan.
                    Console.WriteLine("Råttan dog");//om jag lägger till mer fiende namn så ska den ändras.
                    hjälte_lvl++;
                    break;
                }
                ui(hjälte_hp, hjälte_dmg, hjälte_lvl);
                fui(fiende_hp, fiende_dmg, fiende_lvl);
            }
            if(fiende_hp == 0){
                Random kap = new Random();
                fiende_lvl = hjälte_lvl + kap.Next(0, hjälte_lvl+1);
                break;
            }
        }

        for(int a = 0; a != 1; a++){
            f_dmg(ref hjälte_hp, fiende_dmg, fiende_crit);
            if(hjälte_hp <= 0){
                hjälte_hp = 0;
                ui(hjälte_hp, hjälte_dmg, hjälte_lvl);
                fui(fiende_hp, fiende_dmg, fiende_lvl);
                if(fiende_lvl >= 2){
                    fiende_lvl--;
                }
                Console.WriteLine("Du dog");
                break;
            }
            if(attack_number1 == 2){
                if(hjälte_hp == 0){
                    break;
                }
                healing(ref hjälte_hp, hjälte_lvl);
            }
            ui(hjälte_hp, hjälte_dmg, hjälte_lvl);
            fui(fiende_hp, fiende_dmg, fiende_lvl);
        }
        if(hjälte_hp == 0){
            break;
        }

    }

    hp = hjälte_hp;
    dubdmg = hjälte_dmg;
    lvl = hjälte_lvl;

}

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

    int max = 5 + 5 * lvl;
    int potion = lvl + max / 3;
    int mellan = 0;
    double potion1 = lvl + max / 3;
    string mes1 = "Medans du healar ";
    string mes2 = " hp";

    int tid2 = 50;

    if(potion >= potion1 - 0.5){
        hälsa = hälsa + potion;
        if(hälsa >= max + 1){
            mellan = hälsa - max;
            potion = potion - mellan;
            hälsa = max;
        }
        sakta(mes1,tid2);
        Console.Write(potion);
        sakta(mes2, tid2);
        Console.WriteLine("");
    }    
    else{
        hälsa = hälsa + potion + 1;
        if(hälsa >= max + 1){
            mellan = hälsa - max;
            potion = potion - mellan;
            hälsa = max;
        }
        sakta(mes1,tid2);
        Console.Write(potion);
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