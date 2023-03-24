using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatNamespace;
using ChienNamespace;

namespace AmitieNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nbreHumeurChat = random.Next(0, 2);
            bool chatPeutAvoirAmi;
            bool amiDoggy = false;

            Chat chat = new Chat("Cat");
            Chien dog = new Chien("Dog");
            Chien doggy = new Chien("Doggy");

            dog.SetHumeurChien("Mauvaise");
            doggy.SetHumeurChien("Mauvaise");
            chat.SetAmiCat("Aucun");
            dog.SetAmiChien("Aucun");
            doggy.SetAmiChien("Aucun");

            if (nbreHumeurChat == 0) { chat.SetHumeurChat("Mauvaise"); chatPeutAvoirAmi = false; }
            else { chat.SetHumeurChat("Bonne"); chatPeutAvoirAmi = true; }

            Console.WriteLine($"Nom Chat: {chat.GetNomChat()}\nHumeur Cat: {chat.GetHumeur()}\nMeilleur Ami Cat: {chat.GetAmiCat()}\n");
            Console.WriteLine($"Nom Chien: {dog.GetNomChien()}\nHumeur Dog: {dog.GetHumeurChien()}\nMeilleur Ami Dog: {dog.GetAmiChien()}\n");
            Console.WriteLine($"Nom Chien: {doggy.GetNomChien()}\nHumeur Doggy: {doggy.GetHumeurChien()}\nMeilleur Ami Doggy: {doggy.GetAmiChien()}\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");

            if (chatPeutAvoirAmi == true) { chat.SetAmiCat("Dog"); dog.SetAmiChien("Cat"); dog.SetHumeurChien("Bonne"); }
            else { chat.SetAmiCat("Aucun"); dog.SetAmiChien("Aucun"); }

            Console.WriteLine($"Nom Chat: {chat.GetNomChat()}\nHumeur Cat: {chat.GetHumeur()}\nMeilleur Ami Cat: {chat.GetAmiCat()}\n");
            Console.WriteLine($"Nom Chien: {dog.GetNomChien()}\nHumeur Dog: {dog.GetHumeurChien()}\nMeilleur Ami Dog: {dog.GetAmiChien()}\n");
            Console.WriteLine($"Nom Chien: {doggy.GetNomChien()}\nHumeur Doggy: {doggy.GetHumeurChien()}\nMeilleur Ami Doggy: {doggy.GetAmiChien()}\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");

            if (amiDoggy == false) { doggy.SetHumeurChien("Mauvaise"); }
            else { doggy.SetHumeurChien("Bonne"); }

            if (amiDoggy == false) { chat.SetAmiCat("Aucun"); chat.SetHumeurChat("Mauvaise"); dog.SetAmiChien("Doggy"); doggy.SetAmiChien("Dog"); amiDoggy = true; doggy.SetHumeurChien("Bonne"); }
            else { doggy.SetAmiChien("Aucun"); }

            //if (nbreHumeurChat == 0) { humeurChat = "Mauvaise"; chatPeutAvoirAmi = false; }
            //else { humeurChat = "Bonne"; chatPeutAvoirAmi = true; }

            //if (chatPeutAvoirAmi == true) { amiChat = "Dog"; amiChien = "Cat"; }
            //else { amiChat = "Aucun"; amiChien = "Aucun"; }

            //if (amiDoggy == false) { humeurDoggy = "Mauvaise"; }
            //else { humeurDoggy = "Bonne"; }

            //if (amiDoggy == false) { amiChat = "Aucun"; amiChien = "Doggy"; amiChien2 = "Dog"; amiDoggy = true; humeurDoggy = "Bonne"; }
            //else { amiChien2 = "Aucun"; }

            //Chat chat = new Chat("Cat", humeurChat, amiChat);
            //Chien dog = new Chien("Dog", humeurDog, amiChien);
            //Chien doggy = new Chien("Doggy", humeurDoggy, amiChien2);


            Console.WriteLine($"Nom Chat: {chat.GetNomChat()}\nHumeur Cat: {chat.GetHumeur()}\nMeilleur Ami Cat: {chat.GetAmiCat()}\n");
            Console.WriteLine($"Nom Chien: {dog.GetNomChien()}\nHumeur Dog: {dog.GetHumeurChien()}\nMeilleur Ami Dog: {dog.GetAmiChien()}\n");
            Console.WriteLine($"Nom Chien: {doggy.GetNomChien()}\nHumeur Doggy: {doggy.GetHumeurChien()}\nMeilleur Ami Doggy: {doggy.GetAmiChien()}\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }
    }
}
