using Exo_Banque.Classe;
using Exo_Banque.Interface;
using Microsoft.VisualBasic;
using System.Security.Cryptography;


/*
// Creation des personne 

Console.WriteLine("Bienvuenue dans votre Banque : ");
Console.WriteLine();

Personne p1 = new Personne();
Courant cr = new Courant();
Personne p2 = new Personne();
Courant cr2 = new Courant();

p1.Nom = "BREL";
p1.Prenom = "Jack";
p1.DateNaiss = new DateTime(1980, 10, 4);

cr.Titulaire = p1;
cr.Numero = "0001225";
cr.LigneDeCredit = 100;
cr.Depot(50);
//Console.WriteLine($"Depots de {cr.Depot}");
cr.Retrait(500);
//Console.WriteLine($"Retrait de {cr.Retrait}");
Console.WriteLine($"Solde avant Interet {cr.Solde}");
cr.AppliquerInteret();
Console.WriteLine($"Solde de {p1.Nom} est {cr.Solde}");


Console.WriteLine("-------------------");

p2.Nom = "MESSI";
p2.Prenom = "LEO";
p2.DateNaiss = new DateTime(1985, 6, 5);
cr2.Titulaire = p2;
cr2.Numero = "124365";
cr2.LigneDeCredit = 50;
cr2.Depot(600);
//Console.WriteLine($"Depots de {cr2.Depot}");
cr2.Retrait(100);
//Console.WriteLine($"Retrait de {cr2.Retrait}");
Console.WriteLine($"Solde avant Interet {cr2.Solde}");
cr2.AppliquerInteret();
Console.WriteLine($"Solde de {p2.Nom} est {cr2.Solde}");





// Creation 





//Console.WriteLine( $"Solde");






//Console.WriteLine($"Nom : {p1.Nom}" +
//              $"\n Prenom : {p1.Prenom}" +
//              $"\n Date de Naissance :{(p1.DateNaiss)}");

////Console.WriteLine($"Solde : {cr.Solde}"); // 50 
////Console.WriteLine($"Solde : {cr2.Solde}");
////cr2.AppliquerInteret();





////Console.Clear();

//// Verification du compte bancaire

Banque bq = new Banque();
bq.Nom = "Belfius";
bq.Ajouter(cr);
Console.WriteLine(bq[cr.Numero].Numero);
//bq.Supprimer(cr.Numero);
Console.WriteLine(bq[cr.Numero]);
//bq["12365895577"].Depot(800);

Console.WriteLine("mamamam");
Console.WriteLine(bq.AvoirDesComptes(p1));
Console.WriteLine(bq.AvoirDesComptes(p2));


//bq.Nom = "BNP";
//bq.Ajouter(cr2);
//Console.WriteLine(bq[cr2.Numero].Numero);



////foreach(KeyValuePair<string , Courant> test in bq.Compte)
////{
////    Console.WriteLine($"Proprietaire: {test.Value.Titulaire.Nom} . Num du Compte est : {test.Key} . et le solde bancaire est : {test.Value.Solde}");
////}

//Compte compte = new Courant();

//if(compte is Epargne)
//{
//    Epargne compteEp = (Epargne)compte;
//    Console.WriteLine(compteEp.DateDernierRetrait);
//}



//string test = "kkjhhh";
////IEnumerable<char> result = test.Where(c => c== 'k').Select(c=>'j');

//List<int>   
//foreach (char ce in result)
//{
//    Console.WriteLine(ce);
//}

*/


/*
    Console.WriteLine("Bienveue chez SAM bank");
    Console.WriteLine();

    Personne p3 = new Personne("Doe", "Jack",new DateTime(1980,10,5));


Console.WriteLine(p3.DateNaiss);

    // Compte Courant
    Courant cr3 = new Courant("0000001", 100,p3);



    // Compte Epargne
    Epargne e = new Epargne("0000002", p3);




    // Banque
    Banque bq2 = new Banque()
    {
        Nom = "Banque SAM"
    };

    //Ajouter un compte courant a la banque BBQ
    bq2.Ajouter(cr3);

    //Ajouter un compte Epargne a la banque BBQ
    bq2.Ajouter(e);


    Console.WriteLine($"le Solde Bancaire de {p3.Nom} {p3.Prenom} est : {bq2["0000002"].Solde}");

    // Depot de 800 eur
    bq2["0000002"].Depot(800);
    Console.WriteLine($"Depot de   {bq2["0000002"].Solde} Eur");

    // Retrait de 400Eur
    bq2["0000002"].Retrait(400);
    Console.WriteLine($"Retrait de {bq2["0000002"].Solde} Eur");

//Avoir de compte 
Console.WriteLine($"Avoir des comptes de {bq2.AvoirDesComptes(p3)}");


// Utilisation Interface : Autre Methode de la Banque

Console.WriteLine("-------Utilisation des interfaces-------- ");
    //// Affecatation d objet a mon interface
    //ICustomer cu = bq2["0000001"];

    ////Affichage avant depot
    //Console.WriteLine($"Le Solde avant Depot : {cu.Solde} Euro");


    ////Affichage aprés depot
    //cu.Depot(1150);
    //Console.WriteLine($"Le Solde aprés Depot de 150 : {cu.Solde} Euro");

    //// Affichage aprés retrait
    //cu.Retrait(80);
    //Console.WriteLine($"Le Solde aprés Retrait de 80 : {cu.Solde} Euro");

    Console.WriteLine();
    Console.WriteLine("------------ Exception -----------------");

// Depot de -100 Trycatch
//try
//{
//    cr3.Depot(-100);
//}
//catch (ArgumentOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message);
//}

////Retrait: ligne deCredit

//try
//{
//    cr3.Retrait(-100);
//}
//catch (ArgumentOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message);
//}

//// Solde Insuffisant : 

//try
//{
//    cr3.Retrait(300);
//}

//catch (SoldeInsuffisantException ex)
//{

//    Console.WriteLine(ex.Message);
//}

*/

Banque banque = new Banque("Technofutur Bank");

Personne morrisPhilippe = new Personne("Morris", "Philippe", new DateTime(1940, 3, 10));

Courant compte1 = new Courant("00001", 500, morrisPhilippe);

Epargne compte2 = new Epargne("00002", morrisPhilippe);

Console.WriteLine($"Le Solde de {morrisPhilippe.Nom} {morrisPhilippe.Prenom} chez {banque.Nom} est :  {compte1.Solde}");



banque.Ajouter(compte1);
compte1.Retrait(200); // event : Le compte 00001 vient de passer en negatif
banque.Ajouter(compte2);



////banque["00001"]?.Depot(-500);
////banque["00001"]?.Depot(800);
//////banque["00001"]?.Retrait(-750);
////banque["00001"]?.Retrait(750);

//banque["00002"]?.Depot(500);

//banque["00001"]?.AppliquerInteret();
//banque["00002"]?.AppliquerInteret();

//if (banque["00001"] is not null)
//{
//    Console.WriteLine($"Solde du compte '{banque["00001"]!.Numero}' : {banque["00001"]!.Solde}");
//}

//if (banque["00002"] is not null)
//{
//    Console.WriteLine($"Solde du compte '{banque["00002"]!.Numero}' : {banque["00002"]!.Solde}");
//}

//Console.WriteLine($"Avoir des comptes de {chuckNorris.Prenom} {chuckNorris.Nom} : {banque.AvoirDesComptes(chuckNorris)}");
Console.ReadLine();



  


















