using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Alarm_O_clock
{
    public partial class CountryControl : Form
    {

        private SQLiteConnection DB = new SQLiteConnection("Data Source=CapitalDB.db; Version=3");
        public CountryControl()
        {
            InitializeComponent();
        }

        private void CountryControl_Load(object sender, EventArgs e)
        {
            //button1.Text = "Рашка";
            //Конект с бд, открываем
            DB.Open();

            List<Button> btns = new List<Button>();
                                btns.Add(button1);
                                btns.Add(button2);
                                btns.Add(button3);
                                btns.Add(button4);

            SQLiteCommand command = new SQLiteCommand("SELECT Capital FROM CapitalDB", DB);
            SQLiteDataReader reader = command.ExecuteReader();
            //string aa = reader[1].ToString();
            string answerCapital;
            string questionCountry;
            Random rng = new Random();

            List<string> capitalList = new List<string>();
            while (reader.Read())
            {
                capitalList.Add(reader.GetString(0));
            }

            for (int j = 4; j != 0; j -= 1)
            {
                string rngCapital = capitalList[rng.Next(capitalList.Count)];
                int btnsNumber;
                btnsNumber = rng.Next(0, j);
                btns[btnsNumber].Text = rngCapital;
                btns.RemoveAt(btnsNumber);

                if (j == 4)
                {
                    SQLiteCommand Capital = new SQLiteCommand("SELECT Country FROM CapitalDB WHERE Capital = @rngCapital", DB);
                    SQLiteParameter nameParam = new SQLiteParameter("@rngCapital", rngCapital);
                    Capital.Parameters.Add(nameParam);
                    SQLiteDataReader rdr = Capital.ExecuteReader();
                    rdr.Read();
                    questionCountry = rdr.GetString(0);
                    rdr.Close();
                    answerCapital = rngCapital;
                    label2.Text = questionCountry;
                }
                
                capitalList.Remove(rngCapital);

            }
            
            //string rngCountry = countryList[rng.Next(countryList.Count)];
            //button1.Text = rngCountry;
            //countryList.Remove(rngCountry);


            //foreach (string record in reader)
            //{
            //    Random rng = new Random();
            //    //button1.Text = rng.Next(record);
            //    button1.Text = record;
            //}
        }
    }
}
