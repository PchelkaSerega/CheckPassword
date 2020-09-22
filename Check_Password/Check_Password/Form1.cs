using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Check_Password
{
    public partial class Check_password : Form
    {
        public Check_password()
        {
            InitializeComponent();
        }
        int s = 0;
        bool cifra = false;
        bool bukva = false;
        bool simvol = false;
        string pass;

        public void Check()
        {
            pass = vvod1.Text;
            for (int i = 0; i < pass.Length; i++)
            {
                s++;
                if (pass[i] >= '0' & pass[i] <= '9')
                    cifra = true;
                if (pass[i] >= 'a' & pass[i] <= 'z')
                    bukva = true;
                if (pass[i] == '!' | pass[i] == '@' | pass[i] == '#' | pass[i] == '$' | pass[i] == '%' | pass[i] == '^')
                    simvol = true;
            }
            if (s <= 6)
                throw new Exception("Пароль должен состоять минимум из 6 символов");
            else
            if (cifra == false)
                throw new Exception("Пароль должен иметь минимум 1 цифру");
            else
            if (bukva == false)
                throw new Exception("Пароль должен иметь минимум одну латинскую букву");
            else
            if (simvol == false)
                throw new Exception("Пароль должен иметь минимум однин символ из: ! @ # $ % ^ ");
            else
            {
                wrong.Text = "Пароль успешно создан и сохранён";
                StreamWriter s = File.CreateText("password.txt");
                s.WriteLine(vvod1.Text);
                s.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Check();
            } 
            catch (Exception ex)
            {
                wrong.Text = (ex.Message);
            } 

        }

    }
  
}
