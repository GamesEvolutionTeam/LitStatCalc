using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPECIAL_calc_3
{
    /*public class StatsEventArgs
    {
        private int str=1;

        public StatsEventArgs()
        {
        }

        public int Str
        {
            get
            {
                return str;
            }
            set
            {
                if ((value > 0) && (value < 11))
                {
                    str = value;
                }
            }
        }
    }*/
    public partial class Charinfo : Form
    {
        public Charinfo()
        {
            InitializeComponent();
        }

        /*public class StatsEventArgs
        {
            private int str = 1;
            public int Str
            {
                get
                {
                    return str;
                }
                set
                {
                    if ((value > 0) && (value < 11))
                    {
                        str = value;
                    }
                }
            }*/

//Глобальные переменные очков характеристик
        int Str=1, Per=1, Tgh=1, Chr=1, Itl=1, Agl=1, Lck=1, Lwmn=0, Lwmnn=1, Lwvalmin=9, Lwvalmax;
//Лейблы с изменяющимися значениями
        private void Kbval_Click(object sender, EventArgs e)
        {

        }

        private void Odval_Click(object sender, EventArgs e)
        {

        }

        private void Mgval_Click(object sender, EventArgs e)
        {

        }

        private void Suval_Click(object sender, EventArgs e)
        {

        }

        private void Syaval_Click(object sender, EventArgs e)
        {

        }

        private void Srval_Click(object sender, EventArgs e)
        {

        }

        private void Reval_Click(object sender, EventArgs e)
        {

        }

        private void Svval_Click(object sender, EventArgs e)
        {

        }

        private void Chkval_Click(object sender, EventArgs e)
        {

        }

        private void Mhlval_Click(object sender, EventArgs e)
        {

        }

        private void Thlval_Click(object sender, EventArgs e)
        {

        }

        private void Psnval_Click(object sender, EventArgs e)
        {

        }

        private void Radval_Click(object sender, EventArgs e)
        {

        }

        private void Eyeval_Click(object sender, EventArgs e)
        {

        }

        private void Rhnval_Click(object sender, EventArgs e)
        {

        }

        private void Lhnval_Click(object sender, EventArgs e)
        {

        }

        private void Rlgval_Click(object sender, EventArgs e)
        {

        }

        private void Llgval_Click(object sender, EventArgs e)
        {

        }
        //Лейблы навыков
        private void Lwlbl_Click(object sender, EventArgs e)
        {
            
        }

        

        
        //Выбор навыков
        

        private void Lwval_Click(object sender, EventArgs e)
        {
            
        }

        private void Skillpts_Click(object sender, EventArgs e)
        {

        }

        //Основные характеристики
        private void Addpts_Click(object sender, EventArgs e)
        {

        }        

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void Strval_Click(object sender, EventArgs e)
            {

            }
        
        private void Statplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Strval.Text)>=1) && (int.Parse(Strval.Text) < 10) && (int.Parse(Addpts.Text)>0))
            {
                Strval.Text = Convert.ToString(int.Parse(Strval.Text) + 1);
                Str = int.Parse(Strval.Text);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Mgval.Text = Convert.ToString(Str * 25 + 25);
                if ((Str - 5) > 0)
                {
                    Hoval.Text = Convert.ToString(Str - 5);
                }
                else
                {
                    Hoval.Text = "1";
                }
                Mhlval.Text = Convert.ToString(15 + Str + Tgh * 2);
                Thlval.Text = Convert.ToString(15 + Str + Tgh * 2);

            }
            
        }

        private void Statminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Strval.Text) > 1) && (int.Parse(Strval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Strval.Text = Convert.ToString(int.Parse(Strval.Text) - 1);
                Str = int.Parse(Strval.Text);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Mgval.Text = Convert.ToString(Str * 25 + 25);
                if ((Str - 5) > 0)
                {
                    Hoval.Text = Convert.ToString(Str - 5);
                }
                else
                {
                    Hoval.Text = "1";
                }
                Mhlval.Text = Convert.ToString(15 + Str + Tgh * 2);
                Thlval.Text = Convert.ToString(15 + Str + Tgh * 2);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Perval_Click(object sender, EventArgs e)
        {

        }

        private void Perminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Perval.Text) > 1) && (int.Parse(Perval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Perval.Text = Convert.ToString(int.Parse(Perval.Text) - 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Per = int.Parse(Perval.Text);
                Reval.Text = Convert.ToString(Per * 2);
            }
        }

        private void Perplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Perval.Text) >= 1) && (int.Parse(Perval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Perval.Text = Convert.ToString(int.Parse(Perval.Text) + 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Per = int.Parse(Perval.Text);
                Reval.Text = Convert.ToString(Per * 2);
            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }        

        private void Tghval_Click(object sender, EventArgs e)
        {

        }        

        private void Tghminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Tghval.Text) > 1) && (int.Parse(Tghval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Tghval.Text = Convert.ToString(int.Parse(Tghval.Text) - 1);
                Tgh = int.Parse(Tghval.Text);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Syaval.Text = Convert.ToString(Tgh*5);
                Srval.Text = Convert.ToString(Tgh * 2);
                if (Tgh / 3 > 1)
                {
                    Svval.Text = Convert.ToString(Tgh/3);
                }
                else
                {
                    Svval.Text = "1";
                }
                Mhlval.Text = Convert.ToString(15 + Str + Tgh * 2);
                Thlval.Text = Convert.ToString(15 + Str + Tgh * 2);

            }
        }        

        private void Tghplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Tghval.Text) >= 1) && (int.Parse(Tghval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Tghval.Text = Convert.ToString(int.Parse(Tghval.Text) + 1);
                Tgh = int.Parse(Tghval.Text);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Syaval.Text = Convert.ToString(Tgh * 5);
                Srval.Text = Convert.ToString(Tgh * 2);
                if (Tgh / 3 > 1)
                {
                    Svval.Text = Convert.ToString(Tgh / 3);
                }
                else
                {
                    Svval.Text = "1";
                }
                Mhlval.Text = Convert.ToString(15 + Str + Tgh * 2);
                Thlval.Text = Convert.ToString(15 + Str + Tgh * 2);

            }
        }        

        private void label4_Click(object sender, EventArgs e)
        {

        }        

        private void Chrval_Click(object sender, EventArgs e)
        {

        }        

        private void Chrminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Chrval.Text) > 1) && (int.Parse(Chrval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Chrval.Text = Convert.ToString(int.Parse(Chrval.Text) - 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Chr = int.Parse(Chrval.Text);
            }
        }        

        private void Chrplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Chrval.Text) >= 1) && (int.Parse(Chrval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Chrval.Text = Convert.ToString(int.Parse(Chrval.Text) + 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Chr = int.Parse(Chrval.Text);
            }
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void Itlval_Click(object sender, EventArgs e)
        {

        }        

        private void Itlminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Itlval.Text) > 1) && (int.Parse(Itlval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Itlval.Text = Convert.ToString(int.Parse(Itlval.Text) - 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Itl = int.Parse(Itlval.Text);
                Skillpts.Text = Convert.ToString(Itl * 2 + 5);
            }
        }        

        private void Itlplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Itlval.Text) >= 1) && (int.Parse(Itlval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Itlval.Text = Convert.ToString(int.Parse(Itlval.Text) + 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Itl = int.Parse(Itlval.Text);
                Skillpts.Text = Convert.ToString(Itl * 2 + 5);
            }
        }
        
        private void label6_Click(object sender, EventArgs e)
        {

        }        

        private void Aglval_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkBox2.CheckState))
            {
                Lwmn = 20;
                Lwmnn = 2;                
                Lwval.Text = Convert.ToString(int.Parse(Lwval.Text) + Lwmn);
                Lwvalmax = int.Parse(Lwval.Text);
            }
            else
            {
                Lwmn = 20;
                Lwmnn = 1;                
                Lwval.Text = Convert.ToString(int.Parse(Lwval.Text) - Lwmn);
                Lwvalmin = int.Parse(Lwval.Text);
            }

        }

        private void Aglminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Aglval.Text) > 1) && (int.Parse(Aglval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Aglval.Text = Convert.ToString(int.Parse(Aglval.Text) - 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Kbval.Text = Aglval.Text;
                Odval.Text = Convert.ToString(int.Parse(Aglval.Text) / 2 + 5);
                Agl = int.Parse(Aglval.Text);
                if (Convert.ToBoolean(checkBox2.CheckState))
                {
                    Lwmn = 20;
                    Lwmnn = 2;                    
                }
                else
                {
                    Lwmn = 0;
                    Lwmnn = 1;
                }
                Lwval.Text = Convert.ToString(int.Parse(Aglval.Text) * 4 + 5 + Lwmn);
                Lwvalmin = int.Parse(Lwval.Text);
            }
        }        

        private void Aglplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Aglval.Text) >= 1) && (int.Parse(Aglval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Aglval.Text = Convert.ToString(int.Parse(Aglval.Text) + 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Kbval.Text = Aglval.Text;
                Odval.Text = Convert.ToString(int.Parse(Aglval.Text) / 2 + 5);
                Agl = int.Parse(Aglval.Text);
                if (Convert.ToBoolean(checkBox2.CheckState))
                {
                    Lwmn = 20;
                    Lwmnn = 2;
                }
                else
                {
                    Lwmn = 0;
                    Lwmnn = 1;
                }
                Lwval.Text = Convert.ToString(int.Parse(Aglval.Text) * 4 + 5 + Lwmn);
                Lwvalmin = int.Parse(Lwval.Text);
            }
        }

        

        private void Lwpls_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkBox2.CheckState))
            {
                Lwmn = 20;
                Lwmnn = 2;
            }
            else
            {
                Lwmn = 0;
                Lwmnn = 1;
            }
            if (int.Parse(Skillpts.Text)>0)
            { 
                Lwval.Text = Convert.ToString(int.Parse(Lwval.Text) + 1 * Lwmnn);
                Skillpts.Text = Convert.ToString(int.Parse(Skillpts.Text) - 1);
            }
        }

        private void Lwmin_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkBox2.CheckState))
            {
                Lwmn = 20;
                Lwmnn = 2;
            }
            else
            {
                Lwmn = 0;
                Lwmnn = 1;
            }
            if (Convert.ToBoolean(checkBox2.CheckState))
            {
                if (Lwvalmax < int.Parse(Lwval.Text))
                {
                    Lwval.Text = Convert.ToString(int.Parse(Lwval.Text) - 1 * Lwmnn);
                    Skillpts.Text = Convert.ToString(int.Parse(Skillpts.Text) + 1);
                }
            }
            else
            {
                if (Lwvalmin < int.Parse(Lwval.Text))
                {
                    Lwval.Text = Convert.ToString(int.Parse(Lwval.Text) - 1 * Lwmnn);
                    Skillpts.Text = Convert.ToString(int.Parse(Skillpts.Text) + 1);
                }
            }                      
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }        

        private void Lckval_Click(object sender, EventArgs e)
        {

        }        

        private void Lckminus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Lckval.Text) > 1) && (int.Parse(Lckval.Text) <= 10) && (int.Parse(Addpts.Text) >= 0))
            {
                Lckval.Text = Convert.ToString(int.Parse(Lckval.Text) - 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) + 1);
                Lck = int.Parse(Lckval.Text);
                Chkval.Text = Convert.ToString(Lck);
            }
        }        

        private void Lckplus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Lckval.Text) >= 1) && (int.Parse(Lckval.Text) < 10) && (int.Parse(Addpts.Text) > 0))
            {
                Lckval.Text = Convert.ToString(int.Parse(Lckval.Text) + 1);
                Addpts.Text = Convert.ToString(int.Parse(Addpts.Text) - 1);
                Lck = int.Parse(Lckval.Text);
                Chkval.Text = Convert.ToString(Lck);
            }
        }

//Лейблы с названиями
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }        

        private void label10_Click(object sender, EventArgs e)
        {

        }        

        private void label11_Click(object sender, EventArgs e)
        {

        }        

        private void label13_Click(object sender, EventArgs e)
        {

        }        

        private void label14_Click(object sender, EventArgs e)
        {

        }        

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }        

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }        

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

    }
    }

