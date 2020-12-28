using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessorRobot
{
    public partial class Form1 : Form
    {
        enum TypeMode { Con, Vow };
        enum EditMode { Edit, Progress };

        struct jaso
        {
            public string value;    // 'ㄱ'...
            public string cve;      // c.
            //public jaso() { value = null; cve = null; }
        }

        TypeMode g_typeMode = TypeMode.Con;
        EditMode g_editMode = EditMode.Progress;

        Stack<jaso> g_typed = new Stack<jaso>();

        jaso g_ch1;
        jaso g_ch2;
        Queue<string> g_queEdit = new Queue<string>();  // Editing Chars

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// input alphabet and return han conso.
        /// </summary>
        /// <param name="ch1">Keys.R, so : qwert asdfg zxcvb</param>
        /// <returns></returns>
        string GetConso(Keys key)
        {
            string ret;

            switch (key)
            {
                case Keys.R: ret = "ㄱ"; break;
                case Keys.T: ret = "ㅅ"; break;
                case Keys.E: ret = "ㄷ"; break;
                case Keys.W: ret = "ㅈ"; break;
                case Keys.Q: ret = "ㅂ"; break;

                case Keys.A: ret = "ㅁ"; break;
                case Keys.S: ret = "ㄴ"; break;
                case Keys.D: ret = "ㅇ"; break;
                case Keys.F: ret = "ㄹ"; break;
                case Keys.G: ret = "ㅎ"; break;

                default: ret = null; break;
            }

            return ret;
        }

        /// <summary>
        /// return if it conso or vow
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        string IsCorV(string con)
        {
            switch (con)
            {
                case "ㄱ": case "ㄴ": case "ㄷ":
                case "ㄹ": case "ㅁ": case "ㅂ":
                case "ㅅ": case "ㅈ": case "ㅊ":
                case "ㅋ": case "ㅌ": case "ㅍ":
                case "ㅎ": case "ㄲ": case "ㄸ":
                case "ㅃ": case "ㅆ": case "ㅉ":
                    return "c";
                case "ㅏ": case "ㅑ": case "ㅓ":
                case "ㅕ": case "ㅗ": case "ㅛ":
                case "ㅜ": case "ㅠ": case "ㅡ":
                case "ㅣ": case "ㅐ": case "ㅒ":
                case "ㅔ": case "ㅖ": 
                    return "v";
                default:
                    return "e";
            }
        }

        string GetVowel(Keys key)
        {
            string ret;

            switch (key)
            {
                case Keys.W: ret = "ㅗ"; break;
                case Keys.E: ret = "ㅛ"; break;
                case Keys.R: ret = "ㅜ"; break;
                case Keys.T: ret = "ㅠ"; break;

                case Keys.S: ret = "ㅓ"; break;
                case Keys.D: ret = "ㅕ"; break;
                case Keys.F: ret = "ㅏ"; break;
                case Keys.G: ret = "ㅑ"; break;

                case Keys.V: ret = "ㅡ"; break;
                case Keys.B: ret = "ㅣ"; break;

                case Keys.X: ret = "ㅐ"; break;
                case Keys.C: ret = "ㅔ"; break;

                default: ret = null; break;
            }

            return ret;
        }

        /// <summary>
        /// Pop Jaso Temporarilly
        /// </summary>
        /// <returns></returns>
        jaso PopTemp()
        {
            jaso ret = new jaso();
            ret.cve = null;
            ret.value = null;

            if (g_typed.Count > 0)
            {
                ret = g_typed.Pop();

                return ret;
            }
            return ret;    // return NULL if Nothing to Pop
        }

        void PushBack(string ch1, string cve)
        {
            jaso ret = new jaso();
            ret.cve = cve;
            ret.value = ch1;

            g_typed.Push(ret);
        }
        void PushBack(jaso j1)
        {
            g_typed.Push(j1);
        }

        /// <summary>
        /// Change type mode (to c, or v)
        /// </summary>
        /// <param name="mode"></param>
        void ChangeMode(TypeMode mode)
        {
            g_typeMode = mode;
            if (mode == TypeMode.Con)
            {   // change label
                lblConso1.BackColor = Color.Red;
                lblConso2.BackColor = Color.Red;
                lblVowels1.BackColor = Color.LightGray;
                lblVowels2.BackColor = Color.LightGray;
            }
            else
            {
                lblConso1.BackColor = Color.LightGray;
                lblConso2.BackColor = Color.LightGray;
                lblVowels1.BackColor = Color.Red;
                lblVowels2.BackColor = Color.Red;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (g_editMode == EditMode.Edit)
            {
            }
            else
            {   // Progress (Not Editing)
                if (e.KeyCode == Keys.Space)
                {
                    g_typeMode = TypeMode.Con;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    jaso ch1 = PopTemp();
                    jaso ch2 = PopTemp();
                    Console.WriteLine("Ch2-1: {0}, {1}", ch2.value, ch1.value);

                    PushBack(ch1.value, ch1.cve);

                    textBox2.Text = string.Join("", g_typed.ToArray());
                }
                else if (e.KeyCode == Keys.D3)
                {
                    jaso ch1 = PopTemp();
                    jaso ch2 = PopTemp();

                    if (ch1.value == null || ch2.value == null)
                        Console.WriteLine("Null No! Stack has {0}", g_typed.Count);
                    else
                    {
                        Console.WriteLine("Ch2-1: {0}, {1}", ch2.value, ch1.value);

                        // PUSH BACK AFTER EDIT
                        PushBack(ch2);
                        PushBack(ch1);
                    }
                }
                else if (g_typeMode == TypeMode.Con)
                {
                    Console.WriteLine("Beat it");
                    string tmp = GetConso(e.KeyCode);
                    if (null != tmp)
                    {
                        textBox2.Text += tmp;

                        jaso ch1;
                        ch1.value = GetConso(e.KeyCode);
                        ch1.cve = IsCorV(ch1.value);
                        g_typed.Push(ch1);

                        ChangeMode(TypeMode.Vow);
                    }
                }
                else
                {
                    Console.WriteLine("Voo Woo");
                    string tmp = GetVowel(e.KeyCode);
                    if (null != tmp)
                    {
                        textBox2.Text += tmp;

                        jaso ch1;
                        ch1.value = GetVowel(e.KeyCode);
                        ch1.cve = IsCorV(ch1.value);
                        g_typed.Push(ch1);

                        ChangeMode(TypeMode.Con);
                    }

                }
            }

        }
    }
}
