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
        
        public void Number4711(ListBox listBox) {
            ClearList(listBox);
            for (int i = 4711; i <= 4736; i++) {
                listBox.Items.Add(i.ToString());
            }
        }

        public void DelOpgave1_2(ListBox listBox) {
            ClearList(listBox);

            for (int i = 1; i <= 25; i++)
                listBox.Items.Add($"Number {i}: {random.Next(100000, 1000001)}");
        }

        public void DelOpgave1_3(ListBox listBox) {
            ClearList(listBox);
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
            for (int i = 1; i <= 25; i++) {
                int Num = random.Next(100000, 1000001);
                ints.Add(Num);
                listBox.Items.Add(Num.ToString());
            }
            listBox.Items.Add("Unsorted done");
            ints.Sort();
            foreach (int i in ints)
                listBox.Items.Add(i.ToString());
            listBox.Items.Add("Sorted done");

        }
        public void DelOpgave1_5(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
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
            for (int i = 1; i <= 25; i++)                
                ints.Add(random.Next(100000, 1000001));
            foreach (int i in ints)
            listBox.Items.Add($"{i}-{ints.Average()} = {i-ints.Average()}");
        }
        public List<string> DelOpgave1_7(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            for (int i = 1; i <= 25; i++) {
                
                ints.Add(random.Next(100000, 1000001));
                
            }
            foreach (int i in ints)
            strings.Add($"{i}-{ints.Average()} = {i-ints.Average()}");
            return strings;
        }
        public void DelOpgave1_8(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            for (int i = 1; i <= 25; i++)
                ints.Add(random.Next(100000, 1000001));
            ints.Sort();
            foreach (int i in ints) {
                ListBoxItem lbxitem = new ListBoxItem();
                if (i % 2 == 0) 
                    lbxitem.Background = Brushes.HotPink;            
                else 
                    lbxitem.Background = Brushes.RoyalBlue;
                lbxitem.Content = $"{i}-{ints.Average()} = {i - ints.Average()}";
                listBox.Items.Add(lbxitem);                
            }
        }
        public void DelOpgave1_9(ListBox listBox) {
            ClearList(listBox);
            List<int> ints = new List<int>();
            List<ListBoxItem> list = new();
            for (int i = 1; i <= 25; i++)
                ints.Add(random.Next(100000, 1000001));
            ints.Sort();
            foreach (int i in ints) {
                ListBoxItem lbxitem = new ListBoxItem();
                if (i % 2 == 0)
                    lbxitem.Background = Brushes.HotPink;
                else
                    lbxitem.Background = Brushes.RoyalBlue;
                lbxitem.Content = $"{i}-{ints.Average()} = {i - ints.Average()}";
                list.Add(lbxitem);
            }
                listBox.ItemsSource = (list);
        }
    }
}
