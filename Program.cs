int hp = 10;
int hdmg = 2;
int hkrit = 100;

int fhp = 10; 
int fdmg = 2;
int fkrit = 20;


Console.WriteLine("test");
ui(hp, hdmg);
ui(fhp, fdmg);

while(fhp != 0 && hp != 0){

Console.WriteLine("skriv 1:");
int attack_number1 = int.Parse(Console.ReadLine());

    if(attack_number1 == 1){

        for(int a = 0; a != 1; a++){
            dmg(ref fhp, hdmg, hkrit);
            if(fhp <= 0){
                fhp = 0;
            }
            ui(hp, hdmg);
            ui(fhp, fdmg);
        }    
    }

}

   

static void ui(int ahp, int admg){
    Console.WriteLine("hp "+ ahp);
    Console.WriteLine("dmg "+ admg);
}

static void dmg(ref int hälsa, int skada, int krit){
    Random rnd = new Random();
    int skrit = rnd.Next(1,101);

    if(skrit<=krit){
        int jag_tror = hälsa;
        hälsa = jag_tror - skada *2;
    }
    else{
        int jag_tror = hälsa;
        hälsa = jag_tror - skada;
    }
}