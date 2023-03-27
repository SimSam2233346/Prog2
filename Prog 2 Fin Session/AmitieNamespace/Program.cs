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
            else { doggy.SetHumeurChien("Bonne"); dog.SetHumeurChien("Bonne"); }

            if (amiDoggy == false) { chat.SetAmiCat("Aucun"); chat.SetHumeurChat("Mauvaise"); dog.SetAmiChien("Doggy"); doggy.SetAmiChien("Dog"); amiDoggy = true; doggy.SetHumeurChien("Bonne"); }
            else { doggy.SetAmiChien("Aucun"); }

            Console.WriteLine($"Nom Chat: {chat.GetNomChat()}\nHumeur Cat: {chat.GetHumeur()}\nMeilleur Ami Cat: {chat.GetAmiCat()}\n");
            Console.WriteLine($"Nom Chien: {dog.GetNomChien()}\nHumeur Dog: {dog.GetHumeurChien()}\nMeilleur Ami Dog: {dog.GetAmiChien()}\n");
            Console.WriteLine($"Nom Chien: {doggy.GetNomChien()}\nHumeur Doggy: {doggy.GetHumeurChien()}\nMeilleur Ami Doggy: {doggy.GetAmiChien()}\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }
    }
}
