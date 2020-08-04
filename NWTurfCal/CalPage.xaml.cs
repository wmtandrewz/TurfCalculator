using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace NWTurfCal
{
    public partial class CalPage : ContentPage
    {

        private int Number { get; set; }

        private double tot = 0;
        private double sum = 0;

        public CalPage(int num)
        {
            InitializeComponent();

            this.Number = num;


            if(Number > 0)
            {
                for (int i = 0; i < Number; i++)
                {
                    var entry = new Entry
                    {
                        StyleId = $"chitEntry{i+1}",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.Center,
                        Placeholder = (i + 1).ToString(),
                        WidthRequest = 200,
                        Keyboard = Keyboard.Numeric,
                        FontSize = 14
                    };

                    chitValueLayout.Children.Add(entry);
                }
            }


            foreach (var item in chitValueLayout.Children)
            {
                Debug.WriteLine(item.StyleId);
            }

            //D button Calculation
            Dbutton.Clicked += delegate
             {
                 tot = 0;
                 for (int i = 0; i < Number; i++)
                 {
                     for (int j = i + 1; j < Number; j++)
                     {
                         var entry1 = (Entry)chitValueLayout.Children[i];
                         var entry2 = (Entry)chitValueLayout.Children[j];

                         sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text);
                         double summ = sum;
                         tot += summ;
                     }
                 }

                 double new_variable = Math.Round((tot * 0.95),2);
                 DLabel.Text = new_variable.ToString();


                 if(!string.IsNullOrEmpty(DEntry.Text))
                 {
                     var dTotal = Math.Round(new_variable * Double.Parse(DEntry.Text),2);
                     DLabel.Text = dTotal.ToString("#0.#0");
                 }


                 //Adding to Grand Total
                 double GrandTotal = Double.Parse(DLabel.Text)
                                    + Double.Parse(TLabel.Text)
                                    + Double.Parse(QLabel.Text)
                                    + Double.Parse(PLabel.Text)
                                    + Double.Parse(HLabel.Text);
                 TotalLabel.Text = "Rs." + GrandTotal.ToString("#0.#0");
             };

            //T button Calculation
            Tbutton.Clicked += delegate
            {
                tot = 0;
                double tott = 0;
                for (int i = 0; i < Number; i++)
                {
                    for (int j = i + 1; j < Number; j++)
                    {

                        for (int k = j + 1; k < Number; k++)
                        {
                            var entry1 = (Entry)chitValueLayout.Children[i];
                            var entry2 = (Entry)chitValueLayout.Children[j];
                            var entry3 = (Entry)chitValueLayout.Children[k];

                            sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text);

                            double summ = sum;

                            if (summ >= 600)
                            {
                                tott += 600;
                            }
                            else
                            {
                                sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text);

                                summ = sum;
                                tot += summ;
                            }

                        }
                    }

                    double a = tot + tott;
                    double new_variable = Math.Round((a * 0.95), 2);
                    TLabel.Text = new_variable.ToString();


                    if (!string.IsNullOrEmpty(TEntry.Text))
                    {
                        double price = Double.Parse(TEntry.Text) * a;
                        new_variable = Math.Round((price * 0.95),2);
                        TLabel.Text = new_variable.ToString("#0.#0");
                    }
                }

                //Adding to Grand Total
                double GrandTotal = Double.Parse(DLabel.Text)
                                   + Double.Parse(TLabel.Text)
                                   + Double.Parse(QLabel.Text)
                                   + Double.Parse(PLabel.Text)
                                   + Double.Parse(HLabel.Text);
                TotalLabel.Text = "Rs." + GrandTotal.ToString("#0.#0");
            };

            //Q button Calculation
            Qbutton.Clicked += delegate
            {
                tot = 0;
                double tott = 0;
                for (int i = 0; i < Number; i++)
                {
                    for (int j = i + 1; j < Number; j++)
                    {

                        for (int k = j + 1; k < Number; k++)
                        {

                            for (int l = k + 1; l < Number; l++)
                            {


                                var entry1 = (Entry)chitValueLayout.Children[i];
                                var entry2 = (Entry)chitValueLayout.Children[j];
                                var entry3 = (Entry)chitValueLayout.Children[k];
                                var entry4 = (Entry)chitValueLayout.Children[l];

                                sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text);

                                double summ = sum;

                                if (summ >= 700)
                                {
                                    tott += 700;
                                }
                                else
                                {
                                    sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text);

                                    summ = sum;
                                    tot += summ;
                                }
                            }
                        }
                    }

                    double a = tot + tott;
                    double new_variable = Math.Round((a * 0.95), 2);
                    QLabel.Text = new_variable.ToString();


                    if (!string.IsNullOrEmpty(QEntry.Text))
                    {
                        double price = Double.Parse(QEntry.Text) * a;
                        new_variable = Math.Round((price * 0.95), 2);
                        QLabel.Text = new_variable.ToString("#0.#0");
                    }
                }

                //Adding to Grand Total
                double GrandTotal = Double.Parse(DLabel.Text)
                                   + Double.Parse(TLabel.Text)
                                   + Double.Parse(QLabel.Text)
                                   + Double.Parse(PLabel.Text)
                                   + Double.Parse(HLabel.Text);
                TotalLabel.Text = "Rs." + GrandTotal.ToString("#0.#0");
            };

            //P button Calculation
            Pbutton.Clicked += delegate
            {
                tot = 0;
                double tott = 0;
                for (int i = 0; i < Number; i++)
                {
                    for (int j = i + 1; j < Number; j++)
                    {

                        for (int k = j + 1; k < Number; k++)
                        {

                            for (int l = k + 1; l < Number; l++)
                            {
                                for (int m = l + 1; m < Number; m++)
                                {

                                    var entry1 = (Entry)chitValueLayout.Children[i];
                                    var entry2 = (Entry)chitValueLayout.Children[j];
                                    var entry3 = (Entry)chitValueLayout.Children[k];
                                    var entry4 = (Entry)chitValueLayout.Children[l];
                                    var entry5 = (Entry)chitValueLayout.Children[m];

                                    sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text) * Double.Parse(entry5.Text);

                                    double summ = sum;

                                    if (summ >= 800)
                                    {
                                        tott += 800;
                                    }
                                    else
                                    {
                                        sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text) * Double.Parse(entry5.Text);

                                        summ = sum;
                                        tot += summ;
                                    }
                                }
                            }
                        }
                    }

                    double a = tot + tott;
                    double new_variable = Math.Round((a * 0.95), 2);
                    PLabel.Text = new_variable.ToString();


                    if (!string.IsNullOrEmpty(PEntry.Text))
                    {
                        double price = Double.Parse(PEntry.Text) * a;
                        new_variable = Math.Round((price * 0.95), 2);
                        PLabel.Text = new_variable.ToString("#0.#0");
                    }
                }

                //Adding to Grand Total
                double GrandTotal = Double.Parse(DLabel.Text)
                                   + Double.Parse(TLabel.Text)
                                   + Double.Parse(QLabel.Text)
                                   + Double.Parse(PLabel.Text)
                                   + Double.Parse(HLabel.Text);
                TotalLabel.Text = "Rs." + GrandTotal.ToString("#0.#0");
            };

            //H button Calculation
            Hbutton.Clicked += delegate
            {
                tot = 0;
                double tott = 0;
                for (int i = 0; i < Number; i++)
                {
                    for (int j = i + 1; j < Number; j++)
                    {
                        for (int k = j + 1; k < Number; k++)
                        {
                            for (int l = k + 1; l < Number; l++)
                            {
                                for (int m = l + 1; m < Number; m++)
                                {
                                    for (int n = m + 1; n < Number; n++)
                                    {

                                        var entry1 = (Entry)chitValueLayout.Children[i];
                                        var entry2 = (Entry)chitValueLayout.Children[j];
                                        var entry3 = (Entry)chitValueLayout.Children[k];
                                        var entry4 = (Entry)chitValueLayout.Children[l];
                                        var entry5 = (Entry)chitValueLayout.Children[m];
                                        var entry6 = (Entry)chitValueLayout.Children[n];

                                        sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text) * Double.Parse(entry5.Text) * Double.Parse(entry6.Text);

                                        double summ = sum;

                                        if (summ >= 800)
                                        {
                                            tott += 800;
                                        }
                                        else
                                        {
                                            sum = Double.Parse(entry1.Text) * Double.Parse(entry2.Text) * Double.Parse(entry3.Text) * Double.Parse(entry4.Text) * Double.Parse(entry5.Text) * Double.Parse(entry6.Text);

                                            summ = sum;
                                            tot += summ;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    double a = tot + tott;
                    double new_variable = Math.Round((a * 0.95), 2);
                    HLabel.Text = new_variable.ToString();


                    if (!string.IsNullOrEmpty(HEntry.Text))
                    {
                        double price = Double.Parse(HEntry.Text) * a;
                        new_variable = Math.Round((price * 0.95), 2);
                        HLabel.Text = new_variable.ToString("#0.#0");
                    }
                }

                //Adding to Grand Total
                double GrandTotal = Double.Parse(DLabel.Text)
                                   + Double.Parse(TLabel.Text)
                                   + Double.Parse(QLabel.Text)
                                   + Double.Parse(PLabel.Text)
                                   + Double.Parse(HLabel.Text);
                TotalLabel.Text = "Rs." + GrandTotal.ToString("#0.#0");
            };

        }
    }
}
