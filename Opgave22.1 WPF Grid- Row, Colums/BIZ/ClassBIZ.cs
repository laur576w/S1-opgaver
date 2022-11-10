using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opgave22._1_WPF_Grid__Row__Colums.BIZ {
    internal class ClassBIZ {

        private Random random = new Random();
        
        //clears box
        private void ClearList(ListBox listBox) {
            if (listBox.ItemsSource != null)
                listBox.ItemsSource = null;
            listBox.Items.Clear();
        }

        public decimal TruncateDecimal(decimal value, int precision) {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }

        public void Number4711(ListBox listBox) {
            ClearList(listBox);
            listBox.Items.Add("all numbers from 4711 to 4736");
            for (int i = 4711; i <= 4736; i++) {
                listBox.Items.Add(i.ToString());
            }
        }

        public void DelOpgave1_2(ListBox listBox) {
            ClearList(listBox);
            listBox.Items.Add("25 random numbers");
            for (int i = 1; i <= 25; i++)
                listBox.Items.Add($"Number {i}: {random.Next(100000, 1000001)}");
        }

        public void DelOpgave1_3(ListBox listBox) {
            ClearList(listBox);
            listBox.Items.Add("25 random numbers sorted");
            List<int> ints = new List<int>();
            for (int i = 1; i <= 25; i++)
                ints.Add(random.Next(100000, 1000001));
            ints.Sort();
            foreach (int i in ints)
                listBox.Items.Add(i.ToString());

        }

        public void DelOpgave1_4(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();

            listBox.Items.Add("Unsorted start");
            for (int i = 1; i <= 25; i++) {
                int Num = random.Next(100000, 1000001);
                ints.Add(Num);
                listBox.Items.Add(Num.ToString());
            }
            listBox.Items.Add("Unsorted end");
            ints.Sort();

            listBox.Items.Add("Sorted start");
            foreach (int i in ints)
                listBox.Items.Add(i.ToString());
            listBox.Items.Add("Sorted end");

        }
        public void DelOpgave1_5(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            listBox.Items.Add("Gennemsnitsværdi ud fra tallene");
            for (int i = 1; i <= 25; i++) {
                int Num = random.Next(100000, 1000001);
                ints.Add(Num);
                listBox.Items.Add(Num.ToString());
            }
            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi: {ints.Average()}");
        }
        public void DelOpgave1_6(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            listBox.Items.Add("random number subtracted from the random numbers average value");
            for (int i = 1; i <= 25; i++)                
                ints.Add(random.Next(100000, 1000001));
            foreach (int i in ints) {
                double average = i - ints.Average();
                average = Math.Round(average, 2);
                listBox.Items.Add($"{i}-{ints.Average()} = {average}");
            }
        }
        public List<string> DelOpgave1_7(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            strings.Add("random number subtracted from");
            strings.Add("the random numbers average value");
            strings.Add("but returned by string");
            for (int i = 1; i <= 25; i++) {
                
                ints.Add(random.Next(100000, 1000001));
                
            }
            foreach (int i in ints) {
                double average = i - ints.Average();
                average = Math.Round(average, 2);
                strings.Add($"{i}-{ints.Average()} = {average}");
            }
                return strings;
        }
        public void DelOpgave1_8(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            listBox.Items.Add("Shows the even random numbers");
            listBox.Items.Add("by HotPink and odd by RoyalBlue");
            for (int i = 1; i <= 25; i++)
                ints.Add(random.Next(100000, 1000001));
            ints.Sort();
            foreach (int i in ints) {
                ListBoxItem lbxitem = new ListBoxItem();
                if (i % 2 == 0) 
                    lbxitem.Background = Brushes.HotPink;            
                else 
                    lbxitem.Background = Brushes.RoyalBlue;
                double average = i - ints.Average();
                average = Math.Round(average, 2);
                lbxitem.Content = $"{i}-{ints.Average()} = {average}";
                listBox.Items.Add(lbxitem);                
            }
        }
        public void DelOpgave1_9(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            List<ListBoxItem> list = new();
            ListBoxItem a = new();
            a.Content = "all of pre-task combined";
            list.Add(a);
            for (int i = 1; i <= 25; i++)
                ints.Add(random.Next(100000, 1000001));
            ints.Sort();
            foreach (int i in ints) {
                ListBoxItem lbxitem = new ListBoxItem();
                if (i % 2 == 0)
                    lbxitem.Background = Brushes.HotPink;
                else
                    lbxitem.Background = Brushes.RoyalBlue;
                double average = i - ints.Average();
                average = Math.Round(average, 2);
                lbxitem.Content = $"{i}-{ints.Average()} = {average}";
                list.Add(lbxitem);
            }
                listBox.ItemsSource = (list);
        }
    }
}
