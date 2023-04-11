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
            public int id; //auto incremented message id
            public string message; //text contents
            public long time; //seconds elapsed since program start

            //constructor
            public Message(int id, string message, long time)
            {
                this.id = id;
                this.message = message;
                this.time = time;
            }

            //ToString override
            public override string ToString()
            {
                return $"Id: {id} - Message: {message} - Posted at: {time} seconds";
            }
        }

        Stack<Message> msgStack; //stack containing messages
        int id; //incremented id
        Stopwatch stopwatch; //counts seconds since program start

        public Form1()
        {
            InitializeComponent();
        }

        //on load
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize and start stopwatch
            msgStack= new Stack<Message>();
            int id = 0;
            stopwatch= new Stopwatch();
            stopwatch.Start();
        }

        //*******************************************************************************************
        //Method: private void displayMessages()
        //Purpose: Refreshes and updates message listbox
        //********************************************************************************************
        private void displayMessages()
        {
            //clear listbox
            UI_Messages_Lstbx.Items.Clear();

            //iterate over stack and add to listbox
            foreach(Message m in msgStack) UI_Messages_Lstbx.Items.Add(m.ToString());
        }

        private void UI_AddPost_Btn_Click(object sender, EventArgs e)
        {
            //construct new message
            id++;
            Message msg = new Message(id,UI_NewPost_Txtbx.Text,(stopwatch.ElapsedMilliseconds/1000));

            //add to stack and update listbox
            msgStack.Push(msg);
            displayMessages();
            UI_NewPost_Txtbx.Text = null;
        }

        private void UI_DelLast_Btn_Click(object sender, EventArgs e)
        {
            //remove last message and update
            msgStack.Pop();
            displayMessages();
        }

        private void UI_DelById_Btn_Click(object sender, EventArgs e)
        {
            Stack<Message> tempStack = new Stack<Message>(); //temporary storage for stack
            int id; //id to remove
            
            //parse id from user
            int.TryParse(UI_Id_Tbx.Text, out id);

            //iterate over stack and save messages to temp stack
            foreach(Message m in msgStack) if(m.id != id) tempStack.Push(m);

            //clear old stack
            msgStack.Clear();

            //copy messages back from temp stack
            foreach(Message m in tempStack) msgStack.Push(m);

            //display and clear textbox
            displayMessages();
            UI_Id_Tbx.Text = null;
        }
    }
}
