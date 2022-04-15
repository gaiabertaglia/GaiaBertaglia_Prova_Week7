using GestioneErroriPersonalizzata;

Console.WriteLine("Hello, World!");

RepositoryUtenteMock repoUtenti = new RepositoryUtenteMock();

Utente utenteTrovato = new Utente();

Console.WriteLine("Inserisci Id che desideri cercare");
int idDaCercare = int.Parse(Console.ReadLine());

utenteTrovato = repoUtenti.GetById(idDaCercare);

if(!(utenteTrovato == null))
{
    Console.WriteLine("Ecco l'utente che corrisponde all'Id da lei richiesto");
    Console.WriteLine($"{utenteTrovato.ToString()}");
}
else
{
    Console.WriteLine();
}















