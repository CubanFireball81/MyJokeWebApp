using System;
namespace MyJokesWebApp.Models
{
    public class Joke
    {
        //  Properties
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //  Constructor
        public Joke()
        {

        }
    }
}

