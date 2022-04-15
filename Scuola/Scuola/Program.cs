// TEORIA 

// 1. C, D
// 2. B, C
// 3. A, D

using Scuola;

Console.WriteLine("Benvenuto a scuola!");

IRepositoryStudente repoStudente = new RepositoryStudenteMock();
IRepositoryVotazioni repoVotazioni = new RepositoryVotazioniMock();


bool continua = true;
while (continua == true)
{
    Menu();
    int scelta = Scegli();

    switch (scelta)
    {
        case 1:
            InserisciVotazione();
            break;
        case 2:
            VisualizzaVotazioni();
            break;
        case 0:
            Console.WriteLine("Ciao!");
            continua = false;
            break;
        default:
            Console.WriteLine("Scelta errata. Riprova.");
            break;
    }

}

void VisualizzaVotazioni()
{
    Console.WriteLine("Elenco Valutazioni");
    foreach (var item in repoVotazioni.GetAll())
    {
        Console.WriteLine(item);
    }

    MostraMaterie();

}

void InserisciVotazione()
{
    // Id studente, id materia, voto, giorno della prova
    VisualizzaStudenti();

    Console.WriteLine("Inserisci Id studente");
    int idStudente = int.Parse(Console.ReadLine());

    MostraMaterie();
    Console.WriteLine(" \n Inserisci Id Materia");
    int idMateria = int.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Voto");
    double voto = double.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci la data");
    DateTime giornoDellaProva = DateTime.Parse(Console.ReadLine());

    Votazione nuovaVotazione = new Votazione(idStudente, idMateria, voto, giornoDellaProva);
    bool aggiunto = repoVotazioni.Aggiungi(nuovaVotazione);

    if (aggiunto)
    {
        Console.WriteLine("Votazione inserita correttamente");
    }
    else
    {
        Console.WriteLine("Errore");

    }
}

void VisualizzaStudenti()
{
    Console.WriteLine("Elenco Studenti");
    foreach (var item in repoStudente.GetAll())
    {
        Console.WriteLine(item);
    }
    
}

void MostraMaterie()
{
    List<Materia> materie = new List<Materia>()
{
    new Materia(1, "Matematica"),
    new Materia(2, "Italiano"),
    new Materia(3, "Storia"),
    new Materia(4, "Biologia"),
};

    foreach (var item in materie)
    {
        Console.WriteLine(item.ToString());
    }
}

int Scegli()
{
    int sceltaUtente;
    do
    {
        Console.Write("Fai la tua scelta tra le possibili voci del menu: ");
    } while (!(int.TryParse(Console.ReadLine(), out sceltaUtente) && sceltaUtente >= 0 && sceltaUtente <= 2));
    return sceltaUtente;
}

void Menu()
{
    Console.WriteLine("-----------REGISTRO ELETTRONICO------------");
    Console.WriteLine("1. Inserisci votazione");
    Console.WriteLine("2. Visualizza valutazioni");

    Console.WriteLine("0. Exit");
}






