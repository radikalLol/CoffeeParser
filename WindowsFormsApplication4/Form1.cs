using System;
using System.Windows.Forms;
using WindowsFormsApplication4.Core;
using WindowsFormsApplication4.Core.Optalist;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        string a;
        string[] Name= { };
        string[] Price = { };
        string[] Evaluation = { };
        string[] Discount = { };
        string[] Advice = { };
        SqlConnection sqlconnection;
        string connectingString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\автоматы\CoffeeParser\WindowsFormsApplication4\DataBaseCoffee.mdf;Integrated Security=True";

        ParserWorker <string[]> parser;

        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new OptParset()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewDataName += Parser_OnNewDataName;
            parser.OnNewDataPrice += Parser_OnNewDataPrice;
            parser.OnNewDataEvaluation += Parser_OnNewDataEvaluation;
            parser.OnNewDataDiscount += Parser_OnNewDataDiscount;
            parser.OnNewDataAdvice += Parser_OnNewDataAdvice;
        }

        private void Parser_OnNewDataEvaluation(object arg1, string[] arg2)
        {
            a = null;
            int f = arg2.Length;
            for(int i = 0; i < f;i++)
            {
               a += arg2[i]+',';
            }
              Evaluation = a.Split(',');
        }

        private void Parser_OnNewDataDiscount(object arg1, string[] arg2)
        {
            a = null;
            int f = arg2.Length;
            for (int i = 0; i < f; i++)
            {
                a += arg2[i] + ',';
            }
             Discount = a.Split(',');
        }

        private void Parser_OnNewDataAdvice(object arg1, string[] arg2)
        {
            a = null;
            int f = arg2.Length;
            for (int i = 0; i < f; i++)
            {
                a += arg2[i] + ',';
            }
            Advice = a.Split(',');
        }

        private void Parser_OnNewDataPrice(object arg1, string[] arg2)
        {
            a = null;
            int f = arg2.Length;
            for (int i = 0; i < f; i++)
            {
                a += arg2[i] + ',';
            }
            Price = a.Split(',');
        }

        private void Parser_OnNewDataName(object arg1, string[] arg2)
        {

            a = null;
            int f = arg2.Length;
            for (int i = 0; i < f; i++)
            {
                a += arg2[i] + ',';
            }
            Name = a.Split(',');
            

        }

        private void Parser_OnCompleted(object obj)
        {
            int PriceCheck;
            int DiscountCheck;
            int EvoluationCheck;
            int AdviceCheck;
            int[] PriceS = new int[Price.Length];
            int[] PricePoints = new int[Price.Length];
            int[] EvaluationPoints = new int[Evaluation.Length];
            int[] DiscountPoints = new int[Discount.Length];
            int[] AdvicePoints = new int[Advice.Length];
            int[] EvaluationS = new int[Evaluation.Length];
            int[] Points = new int[Name.Length];

            float max1 = 0;
            float max2 = 0;
            float max3 = 0;

            string a1 = "";
            string a2 = "";
            string a3 = "";

            if (checkBoxAdvice.Checked)
            {
                AdviceCheck = 1;
            }
            else
            {
                AdviceCheck = 0;
            }


            if (checkBoxDiscount.Checked)
            {
                DiscountCheck = 1;
            }
            else
            {
                DiscountCheck = 0;
            }

            if (checkBoxEvaluation.Checked)
            {
                EvoluationCheck = 1;
            }
            else
            {
                EvoluationCheck = 0;
            }

            if (checkBoxPrice.Checked)
            {
                PriceCheck = 1;
            }
            else
            {
                PriceCheck = 0;
            }

            for (int i = 0; i < Price.Length; i++)
            {
                string d = Price[i].Trim(' ', '₽').ToString();
                if (d != "")
                {
                    int n = int.Parse(d);
                    PriceS[i] = n;
                }
            }

            for (int i = 0; i < Evaluation.Length; i++)
            {
                if (Evaluation[i] != "")
                {
                    int n = int.Parse(Evaluation[i]);
                    EvaluationS[i] = n;
                }
            }

            for ( int i = 0; i<Name.Length; i++)
            {
                if (PriceS[i]<= 900)
                {
                   PricePoints[i] = 5;
                }
                if(PriceS[i] > 900 & PriceS[i] <= 1000)
                {
                    PricePoints[i] = 4;
                }
                if (PriceS[i] >1000 & PriceS[i] <= 1500)
                {
                    PricePoints[i] = 3;
                }
                if (PriceS[i] > 1500 & PriceS[i] <= 2000)
                {
                    PricePoints[i] = 2;
                }
                if( PriceS[i] > 2000)
                {
                    PricePoints[i] = 1;
                }
                 if (EvaluationS[i] == 5)
                {
                    EvaluationPoints[i] = 5;
                }
                if (EvaluationS[i] == 4)
                {
                    EvaluationPoints[i] = 4;
                }
                if (EvaluationS[i] == 3)
                {
                    EvaluationPoints[i] = 3;
                }
                if(EvaluationS[i] == 2)
                {
                    EvaluationPoints[i] = 2;
                }
                if(EvaluationS[i] == 1 || EvaluationS[i] == 0)
                {
                    EvaluationPoints[i] = 1;
                }
                if (Discount[i] == "-5%")
                {
                    DiscountPoints[i] = 2;
                }
                if(Discount[i] == "-15%")
                {
                    DiscountPoints[i] = 3;
                }
                if (Discount[i] == "-20%")
                {
                    DiscountPoints[i] = 4;
                }
                if (Discount[i] == "-25%")
                {
                    DiscountPoints[i] = 5;
                }
                if (Advice[i] == "для эспрессо")
                {
                    AdvicePoints[i] = 5;
                }
                if (Advice[i] == "для фильтра")
                {
                    AdvicePoints[i] = 4;
                }

                Points[i] = PriceCheck * PricePoints[i] + EvoluationCheck * EvaluationPoints[i] +
                    DiscountCheck * DiscountPoints[i] + AdviceCheck * AdvicePoints[i];

                if (Points[i] > max1)
                {
                    max3 = max2;
                    a3 = a2;
                    max2 = max1;
                    a2 = a1;
                    max1 = Points[i];
                    a1 = Name[i];
                }
                else if (Points[i] > max2)
                {
                    max3 = max2;
                    a3 = a2;
                    max2 = Points[i];
                    a2 = Name[i];
                }
                else if (Points[i] > max3)
                {
                    max3 = Points[i];
                    a3 = Name[i];
                }


                SqlConnection myConnection = new SqlConnection(connectingString);
                myConnection.Open();
                SqlCommand SAVESQL = new SqlCommand("INSERT INTO DataCoffee (Name,Price,Discount,CustomerEvaluation,ManufacturerAdvice) VALUES (@Name,@Price,@Discount,@CustomerEvaluation,@ManufacturerAdvice)", myConnection);

                SAVESQL.Parameters.Add("@Name", SqlDbType.NChar, 150).Value = Name[i];
                SAVESQL.Parameters.Add("@Price", SqlDbType.NChar, 150).Value = Price[i];
                SAVESQL.Parameters.Add("@Discount", SqlDbType.NChar, 150).Value = Discount[i];
                SAVESQL.Parameters.Add("@CustomerEvaluation", SqlDbType.NChar, 150).Value = Evaluation[i];
                SAVESQL.Parameters.Add("@ManufacturerAdvice", SqlDbType.NChar, 150).Value = Advice[i].ToString();
                SAVESQL.ExecuteNonQuery();
                myConnection.Close();
                this.dataCoffeeTableAdapter2.Fill(this.dataBaseCoffeeDataSet2.DataCoffee);
            }

            string[] Data = { "The Best Coffee for you: ", "The first place:", "Name:",
            a1, "Score:",max1.ToString(), "The Second place:", "Name:",a2, "Score:", max2.ToString(),
            "The Third place:", "Name:",a3, "Score:", max3.ToString()};
            listBox1.Items.AddRange(Data);
            MessageBox.Show("All works done!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Settings = new OptaSettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            parser.Abort();
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonBase.Height;
            panelLeft.Top = buttonBase.Top;
            this.dataCoffeeTableAdapter2.Fill(this.dataBaseCoffeeDataSet2.DataCoffee);

        }

        private void dataCoffeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataCoffeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseCoffeeDataSet);

        }

        private void dataCoffeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataCoffeeDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
