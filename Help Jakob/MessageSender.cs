using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Jakob
{
    /// <summary>
    /// A class only for sending message eitger to specific or all
    /// </summary>
    public class MessageSender
    {
        MessageConverter mesConv = new MessageConverter();//Refering to class converter Because a sender shouldnt convert

        /// <summary>
        /// for sending a message to specific, where it first chooses between the 2 different types of messages from enum. before executing
        /// </summary>
        /// <param name="type"></param>
        /// <param name="m"></param>
        /// <param name="isHTML"></param>
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = mesConv.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = mesConv.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        /// <summary>
        /// for sending a message to all, where it first chooses between the 2 different types of messages from enum. before executing
        /// </summary>
        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = mesConv.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = mesConv.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
