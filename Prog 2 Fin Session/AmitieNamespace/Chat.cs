using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNamespace
{
    public class Chat
    {
        private string nomChat;
        private string humeurChat;
        private string amiCat;

        //public Chat(string chat,string humeurChat, string amiCat)
        //{
        //    this.nomChat = chat;
        //    this.humeurChat = humeurChat;
        //    this.amiCat = amiCat;
        //}

        public Chat(string chat)
        {
            this.nomChat = chat;
        }

        public string GetNomChat() { return nomChat; }

        public string GetHumeur() { return humeurChat; }
        public void SetHumeurChat(string humeurChat) { this.humeurChat = humeurChat; }

        public string GetAmiCat() { return amiCat; }
        public void SetAmiCat(string amiChat) { this.amiCat = amiChat; }
    }
}
