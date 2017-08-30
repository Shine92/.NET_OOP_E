using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0830_OOP_E {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();   
        }
        void Talk(CHuman objHuman) {
            objHuman.Speak();
        }
        private void button1_Click(object sender, EventArgs e) {
           CHuman obj = new CHuman();
            int Ago = obj.Ago = 99;
            string Name = obj.Name = "夏娃";
            button1.Text = " Ago: " + Ago + " Name: " + Name;
            obj.Speak();
            
        }

        private void button2_Click(object sender, EventArgs e) {
            CHuman obj = new CMale();
            obj.Ago = 25;
            obj.Name = "黃睿里";
            button2.Text = " Ago: " + obj.Ago + " Name: " + obj.Name;
            Talk(obj);
        }
        
        private void button3_Click(object sender, EventArgs e) {
            CHuman obj = new CFemale();
            obj.Speak();
        }

        private void button4_Click(object sender, EventArgs e) {
            CHuman obj = new CHuman();
            button4.Text ="嬰兒 " + "年齡: " + obj.Ago.ToString();
        }
    }
    class CHuman {
        private string _Nanme;
        private int _Ago;
        private double _Weight;
        public CHuman() {
            this._Weight = 0.21;
            this.Ago = 1;
            this.Name = "我沒有名字";
        }

        public string Name {
            set {
                this._Nanme = value;
            }
            get {
                return this._Nanme;
            }
        }
        public int Ago {
            set {
                if (value > 0) {
                    this._Ago = value;
                }
            }
            get {
                return this._Ago;
            }
        }
        public virtual void Speak() {
            MessageBox.Show("CHuman :...");
        }
    }
    class CMale : CHuman {

        public override void Speak() {
            MessageBox.Show("CMale: Hi!");
        }
    }
    class CFemale : CHuman {

        public override void Speak() {
            //base.Speak();
            //MessageBox.Show("CFeMale: Hello~");
        }
    }
}

