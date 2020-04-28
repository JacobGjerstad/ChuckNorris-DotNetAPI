using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisJoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetCategoryList();
        }

        public async void BtnJoke_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();

            MessageBox.Show(joke.JokeText);
        }

        public async void GetCategoryList()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();

            foreach (string c in categories)
            {
                cboxCategories.Items.Add(c);
            }
        }

    }
}
