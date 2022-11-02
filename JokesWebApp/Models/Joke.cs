using System.Security;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeAnswer { get; set; }

        public string JokeQuestions { get; set; }    
        

        public Joke()
        {
 
        }
    }
}
