using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоопар_работа_с_DatagridView
{
    public partial class Form1 : Form
    {
        List<Animal> Zoopark = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal an1 = new Animal
            {
                NameOfTheAnimal = "Жираф",
                Color = "желтый",
                Count = 3,
                weight = 3000,
                height = 4.5
            };
            Zoopark.Add(an1);
            Animal an2 = new Animal
            {
                NameOfTheAnimal = "Слон",
                Color = "серый",
                Count = 2,
                weight = 5000,
                height = 3.5
            };
            Zoopark.Add(an2);
            Animal an3 = new Animal
            {
                NameOfTheAnimal = "Тигр",
                Color = "черно-желтый",
                Count = 5,
                weight = 750,
                height = 1.2
            };
            Zoopark.Add(an3);
            Animal an4 = new Animal
            {
                NameOfTheAnimal = "Лев",
                Color = "желтый",
                Count = 6,
                weight = 500,
                height = 1.1
            };
            Zoopark.Add(an4);
            Animal an5 = new Animal
            {
                NameOfTheAnimal = "Обезьянка",
                Color = "коричневый",
                Count = 12,
                weight = 45,
                height = 1
            };
            Zoopark.Add(an5);
            animalBindingSource.DataSource = Zoopark;

        }
    }
}
