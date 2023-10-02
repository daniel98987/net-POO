// See https://aka.ms/new-console-template for more information


using SuperHeroesApp;
using SuperHeroesApp.Models;
using System.Text;


SuperHeroe superMan = new SuperHeroe();
superMan.Id = 1;
superMan.Name = "SuperMan";
superMan.SecretIdentity = "Clark Kent";
superMan.City = "Metropols";
superMan.CanFly = true;

SuperPower canFly = new ();
SuperPower regeneration = new ();
SuperPower canEat = new SuperPower();
regeneration.Nombre = "Regeneration";
canEat.Nombre = "Eating";
canFly.Nombre = "Flying";
canFly.Descripcion = "Capacidad para volar y planear";
canFly.Nivel = PowerNivel.NivelDos;


//superMan.SuperPowers = new List<SuperPower>{ canFly }; 
List<SuperPower> powerList = new List<SuperPower>();
powerList.Add(canFly);powerList.Add(canEat);
superMan.SuperPowers = powerList;

string resultSuperPowers = superMan.UsingSuperPowers();
Console.WriteLine(resultSuperPowers);

AntiHeroe DeadPool = new();
DeadPool.Name = "DeadPool";
DeadPool.SecretIdentity = "DeadPool";
DeadPool.City = "Sin City";
DeadPool.CanFly = false;
DeadPool.SuperPowers = new List<SuperPower> { regeneration };

string resultSuperPowersDeadPool = DeadPool.UsingSuperPowers();
Console.WriteLine(resultSuperPowersDeadPool);

string accionAntiHeroe = DeadPool.DoingActionOfAntiHeroe("Atacking police");
Console.WriteLine($"{accionAntiHeroe}");
string deadPoolSavedWorld = DeadPool.SalvarElMundo();
Console.WriteLine(deadPoolSavedWorld);
string deadPoolSavedWorldTwo = DeadPool.SavingTheWorld();
var imprimirInfo = new ImprimirInfo();
imprimirInfo.ImprimirSuperHeroe(superMan);
imprimirInfo.ImprimirSuperHeroe(DeadPool);
enum PowerNivel
{
    NivelUno,
    NivelDos,
    NivelTres
}

