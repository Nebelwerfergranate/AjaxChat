using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class ChatMessage
    {
        // автор сообщения, если null - автор сервер
        public ChatUser User;
        // время сообщения
        public DateTime Date = DateTime.Now;
        // текст сообщения
        public string Text = "";
    }
}