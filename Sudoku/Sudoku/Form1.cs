/** 
*   23-may-2016: link board model as matrix 9x9 textbox
*   Tetboxt can only contain number 1 to 9 
*	Draw menu file  		                    
*/
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

namespace Sudoku
{
    public partial class Screen : Form
    {
        TextBox[,] board = new TextBox[9,9];
             
        public Screen()
        {
            InitializeComponent();

            // made board
            AsignComponent(); 
        }

        private void Screen_Load(object sender, EventArgs e)
        {

        }
         
        // event tbx: Allow only numbers 1 to 9
        private void tbx_ValidateChar(object sender, EventArgs e)
        { 
            TextBox tbx = (TextBox)sender;

            string valid = "123456789";
            if (valid.Contains(tbx.Text))
                tbx.Text = tbx.Text;
            else
                tbx.Text = "";
            Console.Write(board[0, 0]);
            
            //board[1, 0].Text ="5"; //test
        }

        // link textbox to board
        private void AsignComponent()
        {
            board[0, 0] = tbx1;
            board[1, 0] = tbx10;
            board[2, 0] = tbx19;
            board[3, 0] = tbx28;
            board[4, 0] = tbx37;
            board[5, 0] = tbx46;
            board[6, 0] = tbx55;
            board[7, 0] = tbx64;
            board[8, 0] = tbx73;

            board[0, 1] = tbx2;
            board[1, 1] = tbx11;
            board[2, 1] = tbx20;
            board[3, 1] = tbx29;
            board[4, 1] = tbx38;
            board[5, 1] = tbx47;
            board[6, 1] = tbx56;
            board[7, 1] = tbx65;
            board[8, 1] = tbx74;

            board[0, 2] = tbx3;
            board[1, 2] = tbx12;
            board[2, 2] = tbx21;
            board[3, 2] = tbx30;
            board[4, 2] = tbx39;
            board[5, 2] = tbx48;
            board[6, 2] = tbx57;
            board[7, 2] = tbx66;
            board[8, 2] = tbx75;

            board[0, 3] = tbx4;
            board[1, 3] = tbx13;
            board[2, 3] = tbx22;
            board[3, 3] = tbx31;
            board[4, 3] = tbx40;
            board[5, 3] = tbx49;
            board[6, 3] = tbx58;
            board[7, 3] = tbx67;
            board[8, 3] = tbx76;

            board[0, 4] = tbx5;
            board[1, 4] = tbx14;
            board[2, 4] = tbx23;
            board[3, 4] = tbx32;
            board[4, 4] = tbx41;
            board[5, 4] = tbx50;
            board[6, 4] = tbx59;
            board[7, 4] = tbx68;
            board[8, 4] = tbx77;

            board[0, 5] = tbx6;
            board[1, 5] = tbx15;
            board[2, 5] = tbx24;
            board[3, 5] = tbx33;
            board[4, 5] = tbx42;
            board[5, 5] = tbx51;
            board[6, 5] = tbx60;
            board[7, 5] = tbx69;
            board[8, 5] = tbx78;

            board[0, 6] = tbx7;
            board[1, 6] = tbx16;
            board[2, 6] = tbx25;
            board[3, 6] = tbx34;
            board[4, 6] = tbx43;
            board[5, 6] = tbx52;
            board[6, 6] = tbx61;
            board[7, 6] = tbx70;
            board[8, 6] = tbx79;

            board[0, 7] = tbx8;
            board[1, 7] = tbx17;
            board[2, 7] = tbx26;
            board[3, 7] = tbx35;
            board[4, 7] = tbx44;
            board[5, 7] = tbx53;
            board[6, 7] = tbx62;
            board[7, 7] = tbx71;
            board[8, 7] = tbx80;

            board[0, 8] = tbx9;
            board[1, 8] = tbx18;
            board[2, 8] = tbx27;
            board[3, 8] = tbx36;
            board[4, 8] = tbx45;
            board[5, 8] = tbx54;
            board[6, 8] = tbx63;
            board[7, 8] = tbx72;
            board[8, 8] = tbx81;
        }

        private void mnfile_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mngame_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mngame_GNew_Click(object sender, EventArgs e)
        {
            // to-do:  as load but load random file in repository
            
        }

        private void mngame_GLoad_Click(object sender, EventArgs e)
        {
            // to_do: load, ask file to the user
            // read the repository of files
            // to do: dialogresutl to ask the name of file
            string namefile="";
            string[] listaFicheros = Directory.GetFiles(".", "*.txt");
            foreach (string fichero in listaFicheros)
                namefile = fichero;

            string line = "";
            if (File.Exists(namefile))
            {
                StreamReader fileload = File.OpenText(namefile);
                int numline = 0;
                do
                {
                    line = fileload.ReadLine();
                    if (line != null)
                        fillBoard(line, numline++);
                }
                while (line != null);
                fileload.Close();
            }
            else
                // to:do exit or confirm??
                MessageBox.Show("This file doesn't exists.");
        }


        private void fillBoard(string line, int row)
        {
            string[] data = line.Split(' ');
            for (int cell = 0; cell < data.Count(); cell++)
            {
                // if contains a value fill and disable write permission
                if (!data[cell].Trim().Equals("*"))
                {
                    board[row, cell].ReadOnly = true;
                    board[row, cell].Text = data[cell];
                }
            } 
        }

        private void mngame_Level_Click(object sender, EventArgs e)
        {
            // enable logic of several levels
        }

        private void mngame_Save_Click(object sender, EventArgs e)
        {
            // to_do: save-game
        }

        private void mnLevel_Easy_Click(object sender, EventArgs e)
        {

        }

        private void mnLevel_Intermediate_Click(object sender, EventArgs e)
        {

        }

        private void mnLevel_Hard_Click(object sender, EventArgs e)
        {

        }

        private void mnabout_Project_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku by Mónica Esteve ");
        }

        private void mnabout_Click(object sender, EventArgs e)
        {
           // to-do read a file
        }

        private void mnhelp_HowtoPlay_Click(object sender, EventArgs e)
        {
            // to-do read a file
            MessageBox.Show("Filled with numbers from 1 to 9 without repeating any number in the same row or column group");
        }
    }
}
 
