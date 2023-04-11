/* 
 * ICA #17 - Posting Messages (CMPE1666)
 * 
 * Posting Messages to Listbox
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 11 APR 2023 - Created, tested, finished
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA17_ANNA
{
    public partial class Form1 : Form
    {
        //struct to store message data
        public struct Message
        {
            public int id;
            public string message;
            public long time;

            public Message(int id, string message, long time)
            {
                this.id = id;
                this.message = message;
                this.time = time;
            }

            public override string ToString()
            {
                return $"Id: {id} - Message: {message} - Posted at: {time} seconds";
            }
        }

        Stack<Message> msgStack;
        int id;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msgStack= new Stack<Message>();
            int id = 0;
            stopwatch= new Stopwatch();
            stopwatch.Start();
        }

        private void displayMessages()
        {
            UI_Messages_Lstbx.Items.Clear();
            foreach(Message m in msgStack)
            {
                UI_Messages_Lstbx.Items.Add(m.ToString());
            }
        }

        private void UI_AddPost_Btn_Click(object sender, EventArgs e)
        {
            id++;
            Message msg = new Message(id,UI_NewPost_Txtbx.Text,(stopwatch.ElapsedMilliseconds/1000));
            msgStack.Push(msg);
            displayMessages();
            UI_NewPost_Txtbx.Text = null;
        }
    }
}
