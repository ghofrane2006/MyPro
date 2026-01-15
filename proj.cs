public class program
{
    static void Main (string[] args)
    {
        string username;
        string password;
        int tentatives=3;
        while(tentatives>0)
        {
            Console.WriteLine("Nom d'utilisateur:");
            username=Console.ReadLine();
            Console.WriteLine("Mot de passe:");
            password=Console.ReadLine();
            if(username=="admin" && password=="123456")
            {
                Console.WriteLine("Connexion réussie!");
                break;
            }
            else
            {
                tentatives--;
                Console.WriteLine("Nom d'utilisateur ou mot de passe incorrect. Il vous reste " + tentatives + " tentatives.");
            }   
        }

    }
}

