using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingAssignment
{
    internal class ChatBot
    {
        public void RespondToQuery(string query)
        {
            Console.WriteLine($"[You entered query]: {query}");
            Console.WriteLine("Thank you for reaching out. How may I assist you further ?") ;
        }
        public void RespondToQuery(string query,bool isUrgent)
        {
            if (isUrgent)
            {
                Console.WriteLine($"[You entered query]: {query} on priority");
                Console.WriteLine("Your query has been marked as HIGH PRIORITY.Our support team will respond shortly");
            }
            else
            {
                this.RespondToQuery(query);
            }
        }
        public void RespondToQuery(string query,string languagecode)
        {
            if (languagecode == null) {
                Console.WriteLine("language code not specified");
                Console.WriteLine($"You entered query: {query}");
            }
            else
            {
                string response="";
                if (languagecode.ToLower() == "en")
                {

                    response = "Response: Thank you for reaching out. How may I assist you further?";
                }
                else if (languagecode.ToLower() == "es") { 
                    response= "Respuesta: Gracias por comunicarte. ¿Cómo puedo ayudarte?";
                }
                else if (languagecode.ToLower() == "fr")
                {
                    response = "Réponse : Merci de nous avoir contactés. Comment puis-je vous aider ?";
                }
                else if (languagecode.ToLower() == "de")
                {
                    response = "Antwort: Vielen Dank, dass Sie sich an uns gewendet haben. Wie kann ich Ihnen weiterhelfen?";
                }

                else
                {
                    response = "Response: Sorry, the requested language is not supported yet.";
                }
                Console.WriteLine($"[you entered query] : {query} in {languagecode}");
                Console.WriteLine(response);
            }
        }
    }
}
