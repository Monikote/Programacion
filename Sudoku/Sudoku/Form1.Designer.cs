/** Author: Mónica Esteve
*   06-may-2016: main form: screen, draw cells 9x9 
*   Draw grid with 81 textbox to implement 9x9 matrix
*   The textbox must have the right name (tbxNum) and the right TabIndex
*   Behavior index (9x9 matrix) : 123 456 789 
*	  		                     XXX XXX XX81
*/
namespace Sudoku
{
    partial class Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx10 = new System.Windows.Forms.TextBox();
            this.tbx19 = new System.Windows.Forms.TextBox();
            this.tbx28 = new System.Windows.Forms.TextBox();
            this.tbx37 = new System.Windows.Forms.TextBox();
            this.tbx46 = new System.Windows.Forms.TextBox();
            this.tbx55 = new System.Windows.Forms.TextBox();
            this.tbx64 = new System.Windows.Forms.TextBox();
            this.tbx73 = new System.Windows.Forms.TextBox();
            this.tbx75 = new System.Windows.Forms.TextBox();
            this.tbx66 = new System.Windows.Forms.TextBox();
            this.tbx57 = new System.Windows.Forms.TextBox();
            this.tbx48 = new System.Windows.Forms.TextBox();
            this.tbx39 = new System.Windows.Forms.TextBox();
            this.tbx30 = new System.Windows.Forms.TextBox();
            this.tbx21 = new System.Windows.Forms.TextBox();
            this.tbx12 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx74 = new System.Windows.Forms.TextBox();
            this.tbx65 = new System.Windows.Forms.TextBox();
            this.tbx56 = new System.Windows.Forms.TextBox();
            this.tbx47 = new System.Windows.Forms.TextBox();
            this.tbx38 = new System.Windows.Forms.TextBox();
            this.tbx29 = new System.Windows.Forms.TextBox();
            this.tbx20 = new System.Windows.Forms.TextBox();
            this.tbx11 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx77 = new System.Windows.Forms.TextBox();
            this.tbx68 = new System.Windows.Forms.TextBox();
            this.tbx59 = new System.Windows.Forms.TextBox();
            this.tbx50 = new System.Windows.Forms.TextBox();
            this.tbx41 = new System.Windows.Forms.TextBox();
            this.tbx32 = new System.Windows.Forms.TextBox();
            this.tbx23 = new System.Windows.Forms.TextBox();
            this.tbx14 = new System.Windows.Forms.TextBox();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx78 = new System.Windows.Forms.TextBox();
            this.tbx69 = new System.Windows.Forms.TextBox();
            this.tbx60 = new System.Windows.Forms.TextBox();
            this.tbx51 = new System.Windows.Forms.TextBox();
            this.tbx42 = new System.Windows.Forms.TextBox();
            this.tbx33 = new System.Windows.Forms.TextBox();
            this.tbx24 = new System.Windows.Forms.TextBox();
            this.tbx15 = new System.Windows.Forms.TextBox();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.tbx76 = new System.Windows.Forms.TextBox();
            this.tbx67 = new System.Windows.Forms.TextBox();
            this.tbx58 = new System.Windows.Forms.TextBox();
            this.tbx49 = new System.Windows.Forms.TextBox();
            this.tbx40 = new System.Windows.Forms.TextBox();
            this.tbx31 = new System.Windows.Forms.TextBox();
            this.tbx22 = new System.Windows.Forms.TextBox();
            this.tbx13 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx80 = new System.Windows.Forms.TextBox();
            this.tbx71 = new System.Windows.Forms.TextBox();
            this.tbx62 = new System.Windows.Forms.TextBox();
            this.tbx53 = new System.Windows.Forms.TextBox();
            this.tbx44 = new System.Windows.Forms.TextBox();
            this.tbx35 = new System.Windows.Forms.TextBox();
            this.tbx26 = new System.Windows.Forms.TextBox();
            this.tbx17 = new System.Windows.Forms.TextBox();
            this.tbx8 = new System.Windows.Forms.TextBox();
            this.tbx81 = new System.Windows.Forms.TextBox();
            this.tbx72 = new System.Windows.Forms.TextBox();
            this.tbx63 = new System.Windows.Forms.TextBox();
            this.tbx54 = new System.Windows.Forms.TextBox();
            this.tbx45 = new System.Windows.Forms.TextBox();
            this.tbx36 = new System.Windows.Forms.TextBox();
            this.tbx27 = new System.Windows.Forms.TextBox();
            this.tbx18 = new System.Windows.Forms.TextBox();
            this.tbx9 = new System.Windows.Forms.TextBox();
            this.tbx79 = new System.Windows.Forms.TextBox();
            this.tbx70 = new System.Windows.Forms.TextBox();
            this.tbx61 = new System.Windows.Forms.TextBox();
            this.tbx52 = new System.Windows.Forms.TextBox();
            this.tbx43 = new System.Windows.Forms.TextBox();
            this.tbx34 = new System.Windows.Forms.TextBox();
            this.tbx25 = new System.Windows.Forms.TextBox();
            this.tbx16 = new System.Windows.Forms.TextBox();
            this.tbx7 = new System.Windows.Forms.TextBox();
            this.mngame = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_GNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_GLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_Level = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLevel_Easy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLevel_Intermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLevel_Hard = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnhelp_HowtoPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnabout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnabout_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.mngame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx1
            // 
            this.tbx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx1.Location = new System.Drawing.Point(44, 73);
            this.tbx1.MaxLength = 1;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(25, 20);
            this.tbx1.TabIndex = 1;
            this.tbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            // 
            // tbx10
            // 
            this.tbx10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx10.Location = new System.Drawing.Point(44, 93);
            this.tbx10.MaxLength = 1;
            this.tbx10.Name = "tbx10";
            this.tbx10.Size = new System.Drawing.Size(25, 20);
            this.tbx10.TabIndex = 10;
            this.tbx10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx10.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx19
            // 
            this.tbx19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx19.Location = new System.Drawing.Point(44, 113);
            this.tbx19.MaxLength = 1;
            this.tbx19.Name = "tbx19";
            this.tbx19.Size = new System.Drawing.Size(25, 20);
            this.tbx19.TabIndex = 19;
            this.tbx19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx19.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx28
            // 
            this.tbx28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx28.Location = new System.Drawing.Point(44, 139);
            this.tbx28.MaxLength = 1;
            this.tbx28.Name = "tbx28";
            this.tbx28.Size = new System.Drawing.Size(25, 20);
            this.tbx28.TabIndex = 28;
            this.tbx28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx28.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx37
            // 
            this.tbx37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx37.Location = new System.Drawing.Point(44, 159);
            this.tbx37.MaxLength = 1;
            this.tbx37.Name = "tbx37";
            this.tbx37.Size = new System.Drawing.Size(25, 20);
            this.tbx37.TabIndex = 37;
            this.tbx37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx37.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx46
            // 
            this.tbx46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx46.Location = new System.Drawing.Point(44, 179);
            this.tbx46.MaxLength = 1;
            this.tbx46.Name = "tbx46";
            this.tbx46.Size = new System.Drawing.Size(25, 20);
            this.tbx46.TabIndex = 46;
            this.tbx46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx46.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx55
            // 
            this.tbx55.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx55.Location = new System.Drawing.Point(44, 205);
            this.tbx55.MaxLength = 1;
            this.tbx55.Name = "tbx55";
            this.tbx55.Size = new System.Drawing.Size(25, 20);
            this.tbx55.TabIndex = 55;
            this.tbx55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx55.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx64
            // 
            this.tbx64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx64.Location = new System.Drawing.Point(44, 225);
            this.tbx64.MaxLength = 1;
            this.tbx64.Name = "tbx64";
            this.tbx64.Size = new System.Drawing.Size(25, 20);
            this.tbx64.TabIndex = 64;
            this.tbx64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx64.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx73
            // 
            this.tbx73.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx73.Location = new System.Drawing.Point(44, 245);
            this.tbx73.MaxLength = 1;
            this.tbx73.Name = "tbx73";
            this.tbx73.Size = new System.Drawing.Size(25, 20);
            this.tbx73.TabIndex = 73;
            this.tbx73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx73.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx73.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx75
            // 
            this.tbx75.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx75.Location = new System.Drawing.Point(94, 245);
            this.tbx75.MaxLength = 1;
            this.tbx75.Name = "tbx75";
            this.tbx75.Size = new System.Drawing.Size(25, 20);
            this.tbx75.TabIndex = 75;
            this.tbx75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx75.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx75.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx66
            // 
            this.tbx66.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx66.Location = new System.Drawing.Point(94, 225);
            this.tbx66.MaxLength = 1;
            this.tbx66.Name = "tbx66";
            this.tbx66.Size = new System.Drawing.Size(25, 20);
            this.tbx66.TabIndex = 66;
            this.tbx66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx66.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx66.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx57
            // 
            this.tbx57.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx57.Location = new System.Drawing.Point(94, 205);
            this.tbx57.MaxLength = 1;
            this.tbx57.Name = "tbx57";
            this.tbx57.Size = new System.Drawing.Size(25, 20);
            this.tbx57.TabIndex = 57;
            this.tbx57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx57.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx48
            // 
            this.tbx48.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx48.Location = new System.Drawing.Point(94, 179);
            this.tbx48.MaxLength = 1;
            this.tbx48.Name = "tbx48";
            this.tbx48.Size = new System.Drawing.Size(25, 20);
            this.tbx48.TabIndex = 48;
            this.tbx48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx48.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx39
            // 
            this.tbx39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx39.Location = new System.Drawing.Point(94, 159);
            this.tbx39.MaxLength = 1;
            this.tbx39.Name = "tbx39";
            this.tbx39.Size = new System.Drawing.Size(25, 20);
            this.tbx39.TabIndex = 39;
            this.tbx39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx39.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx30
            // 
            this.tbx30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx30.Location = new System.Drawing.Point(94, 139);
            this.tbx30.MaxLength = 1;
            this.tbx30.Name = "tbx30";
            this.tbx30.Size = new System.Drawing.Size(25, 20);
            this.tbx30.TabIndex = 30;
            this.tbx30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx30.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx21
            // 
            this.tbx21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx21.Location = new System.Drawing.Point(94, 113);
            this.tbx21.MaxLength = 1;
            this.tbx21.Name = "tbx21";
            this.tbx21.Size = new System.Drawing.Size(25, 20);
            this.tbx21.TabIndex = 21;
            this.tbx21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx21.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx12
            // 
            this.tbx12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx12.Location = new System.Drawing.Point(94, 93);
            this.tbx12.MaxLength = 1;
            this.tbx12.Name = "tbx12";
            this.tbx12.Size = new System.Drawing.Size(25, 20);
            this.tbx12.TabIndex = 12;
            this.tbx12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx12.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx3
            // 
            this.tbx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx3.Location = new System.Drawing.Point(94, 73);
            this.tbx3.MaxLength = 1;
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(25, 20);
            this.tbx3.TabIndex = 3;
            this.tbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx3.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx74
            // 
            this.tbx74.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx74.Location = new System.Drawing.Point(69, 245);
            this.tbx74.MaxLength = 1;
            this.tbx74.Name = "tbx74";
            this.tbx74.Size = new System.Drawing.Size(25, 20);
            this.tbx74.TabIndex = 74;
            this.tbx74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx74.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx74.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx65
            // 
            this.tbx65.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx65.Location = new System.Drawing.Point(69, 225);
            this.tbx65.MaxLength = 1;
            this.tbx65.Name = "tbx65";
            this.tbx65.Size = new System.Drawing.Size(25, 20);
            this.tbx65.TabIndex = 65;
            this.tbx65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx65.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx65.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx56
            // 
            this.tbx56.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx56.Location = new System.Drawing.Point(69, 205);
            this.tbx56.MaxLength = 1;
            this.tbx56.Name = "tbx56";
            this.tbx56.Size = new System.Drawing.Size(25, 20);
            this.tbx56.TabIndex = 56;
            this.tbx56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx56.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx47
            // 
            this.tbx47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx47.Location = new System.Drawing.Point(69, 179);
            this.tbx47.MaxLength = 1;
            this.tbx47.Name = "tbx47";
            this.tbx47.Size = new System.Drawing.Size(25, 20);
            this.tbx47.TabIndex = 47;
            this.tbx47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx47.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx38
            // 
            this.tbx38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx38.Location = new System.Drawing.Point(69, 159);
            this.tbx38.MaxLength = 1;
            this.tbx38.Name = "tbx38";
            this.tbx38.Size = new System.Drawing.Size(25, 20);
            this.tbx38.TabIndex = 38;
            this.tbx38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx38.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx29
            // 
            this.tbx29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx29.Location = new System.Drawing.Point(69, 139);
            this.tbx29.MaxLength = 1;
            this.tbx29.Name = "tbx29";
            this.tbx29.Size = new System.Drawing.Size(25, 20);
            this.tbx29.TabIndex = 29;
            this.tbx29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx29.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx20
            // 
            this.tbx20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx20.Location = new System.Drawing.Point(69, 113);
            this.tbx20.MaxLength = 1;
            this.tbx20.Name = "tbx20";
            this.tbx20.Size = new System.Drawing.Size(25, 20);
            this.tbx20.TabIndex = 20;
            this.tbx20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx20.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx11
            // 
            this.tbx11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx11.Location = new System.Drawing.Point(69, 93);
            this.tbx11.MaxLength = 1;
            this.tbx11.Name = "tbx11";
            this.tbx11.Size = new System.Drawing.Size(25, 20);
            this.tbx11.TabIndex = 11;
            this.tbx11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx11.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx2
            // 
            this.tbx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx2.Location = new System.Drawing.Point(69, 73);
            this.tbx2.MaxLength = 1;
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(25, 20);
            this.tbx2.TabIndex = 2;
            this.tbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx2.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx77
            // 
            this.tbx77.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx77.Location = new System.Drawing.Point(149, 245);
            this.tbx77.MaxLength = 1;
            this.tbx77.Name = "tbx77";
            this.tbx77.Size = new System.Drawing.Size(25, 20);
            this.tbx77.TabIndex = 77;
            this.tbx77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx77.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx77.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx68
            // 
            this.tbx68.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx68.Location = new System.Drawing.Point(149, 225);
            this.tbx68.MaxLength = 1;
            this.tbx68.Name = "tbx68";
            this.tbx68.Size = new System.Drawing.Size(25, 20);
            this.tbx68.TabIndex = 68;
            this.tbx68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx68.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx68.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx59
            // 
            this.tbx59.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx59.Location = new System.Drawing.Point(149, 205);
            this.tbx59.MaxLength = 1;
            this.tbx59.Name = "tbx59";
            this.tbx59.Size = new System.Drawing.Size(25, 20);
            this.tbx59.TabIndex = 59;
            this.tbx59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx59.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx50
            // 
            this.tbx50.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx50.Location = new System.Drawing.Point(149, 179);
            this.tbx50.MaxLength = 1;
            this.tbx50.Name = "tbx50";
            this.tbx50.Size = new System.Drawing.Size(25, 20);
            this.tbx50.TabIndex = 50;
            this.tbx50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx50.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx41
            // 
            this.tbx41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx41.Location = new System.Drawing.Point(149, 159);
            this.tbx41.MaxLength = 1;
            this.tbx41.Name = "tbx41";
            this.tbx41.Size = new System.Drawing.Size(25, 20);
            this.tbx41.TabIndex = 41;
            this.tbx41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx41.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx32
            // 
            this.tbx32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx32.Location = new System.Drawing.Point(149, 139);
            this.tbx32.MaxLength = 1;
            this.tbx32.Name = "tbx32";
            this.tbx32.Size = new System.Drawing.Size(25, 20);
            this.tbx32.TabIndex = 32;
            this.tbx32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx32.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx23
            // 
            this.tbx23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx23.Location = new System.Drawing.Point(149, 113);
            this.tbx23.MaxLength = 1;
            this.tbx23.Name = "tbx23";
            this.tbx23.Size = new System.Drawing.Size(25, 20);
            this.tbx23.TabIndex = 23;
            this.tbx23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx23.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx14
            // 
            this.tbx14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx14.Location = new System.Drawing.Point(149, 93);
            this.tbx14.MaxLength = 1;
            this.tbx14.Name = "tbx14";
            this.tbx14.Size = new System.Drawing.Size(25, 20);
            this.tbx14.TabIndex = 14;
            this.tbx14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx14.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx5
            // 
            this.tbx5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx5.Location = new System.Drawing.Point(149, 73);
            this.tbx5.MaxLength = 1;
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(25, 20);
            this.tbx5.TabIndex = 5;
            this.tbx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx5.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx78
            // 
            this.tbx78.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx78.Location = new System.Drawing.Point(174, 245);
            this.tbx78.MaxLength = 1;
            this.tbx78.Name = "tbx78";
            this.tbx78.Size = new System.Drawing.Size(25, 20);
            this.tbx78.TabIndex = 78;
            this.tbx78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx78.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx78.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx69
            // 
            this.tbx69.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx69.Location = new System.Drawing.Point(174, 225);
            this.tbx69.MaxLength = 1;
            this.tbx69.Name = "tbx69";
            this.tbx69.Size = new System.Drawing.Size(25, 20);
            this.tbx69.TabIndex = 69;
            this.tbx69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx69.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx69.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx60
            // 
            this.tbx60.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx60.Location = new System.Drawing.Point(174, 205);
            this.tbx60.MaxLength = 1;
            this.tbx60.Name = "tbx60";
            this.tbx60.Size = new System.Drawing.Size(25, 20);
            this.tbx60.TabIndex = 60;
            this.tbx60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx60.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx51
            // 
            this.tbx51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx51.Location = new System.Drawing.Point(174, 179);
            this.tbx51.MaxLength = 1;
            this.tbx51.Name = "tbx51";
            this.tbx51.Size = new System.Drawing.Size(25, 20);
            this.tbx51.TabIndex = 51;
            this.tbx51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx51.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx51.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx42
            // 
            this.tbx42.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx42.Location = new System.Drawing.Point(174, 159);
            this.tbx42.MaxLength = 1;
            this.tbx42.Name = "tbx42";
            this.tbx42.Size = new System.Drawing.Size(25, 20);
            this.tbx42.TabIndex = 42;
            this.tbx42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx42.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx33
            // 
            this.tbx33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx33.Location = new System.Drawing.Point(174, 139);
            this.tbx33.MaxLength = 1;
            this.tbx33.Name = "tbx33";
            this.tbx33.Size = new System.Drawing.Size(25, 20);
            this.tbx33.TabIndex = 33;
            this.tbx33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx33.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx24
            // 
            this.tbx24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx24.Location = new System.Drawing.Point(174, 113);
            this.tbx24.MaxLength = 1;
            this.tbx24.Name = "tbx24";
            this.tbx24.Size = new System.Drawing.Size(25, 20);
            this.tbx24.TabIndex = 24;
            this.tbx24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx24.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx15
            // 
            this.tbx15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx15.Location = new System.Drawing.Point(174, 93);
            this.tbx15.MaxLength = 1;
            this.tbx15.Name = "tbx15";
            this.tbx15.Size = new System.Drawing.Size(25, 20);
            this.tbx15.TabIndex = 15;
            this.tbx15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx15.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx6
            // 
            this.tbx6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx6.Location = new System.Drawing.Point(174, 73);
            this.tbx6.MaxLength = 1;
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(25, 20);
            this.tbx6.TabIndex = 6;
            this.tbx6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx6.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx76
            // 
            this.tbx76.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx76.Location = new System.Drawing.Point(124, 245);
            this.tbx76.MaxLength = 1;
            this.tbx76.Name = "tbx76";
            this.tbx76.Size = new System.Drawing.Size(25, 20);
            this.tbx76.TabIndex = 76;
            this.tbx76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx76.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx76.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx67
            // 
            this.tbx67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx67.Location = new System.Drawing.Point(124, 225);
            this.tbx67.MaxLength = 1;
            this.tbx67.Name = "tbx67";
            this.tbx67.Size = new System.Drawing.Size(25, 20);
            this.tbx67.TabIndex = 67;
            this.tbx67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx67.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx67.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx58
            // 
            this.tbx58.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx58.Location = new System.Drawing.Point(124, 205);
            this.tbx58.MaxLength = 1;
            this.tbx58.Name = "tbx58";
            this.tbx58.Size = new System.Drawing.Size(25, 20);
            this.tbx58.TabIndex = 58;
            this.tbx58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx58.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx49
            // 
            this.tbx49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx49.Location = new System.Drawing.Point(124, 179);
            this.tbx49.MaxLength = 1;
            this.tbx49.Name = "tbx49";
            this.tbx49.Size = new System.Drawing.Size(25, 20);
            this.tbx49.TabIndex = 49;
            this.tbx49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx49.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx40
            // 
            this.tbx40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx40.Location = new System.Drawing.Point(124, 159);
            this.tbx40.MaxLength = 1;
            this.tbx40.Name = "tbx40";
            this.tbx40.Size = new System.Drawing.Size(25, 20);
            this.tbx40.TabIndex = 40;
            this.tbx40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx40.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx31
            // 
            this.tbx31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx31.Location = new System.Drawing.Point(124, 139);
            this.tbx31.MaxLength = 1;
            this.tbx31.Name = "tbx31";
            this.tbx31.Size = new System.Drawing.Size(25, 20);
            this.tbx31.TabIndex = 31;
            this.tbx31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx31.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx22
            // 
            this.tbx22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx22.Location = new System.Drawing.Point(124, 113);
            this.tbx22.MaxLength = 1;
            this.tbx22.Name = "tbx22";
            this.tbx22.Size = new System.Drawing.Size(25, 20);
            this.tbx22.TabIndex = 22;
            this.tbx22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx22.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx13
            // 
            this.tbx13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx13.Location = new System.Drawing.Point(124, 93);
            this.tbx13.MaxLength = 1;
            this.tbx13.Name = "tbx13";
            this.tbx13.Size = new System.Drawing.Size(25, 20);
            this.tbx13.TabIndex = 13;
            this.tbx13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx13.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx4
            // 
            this.tbx4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx4.Location = new System.Drawing.Point(124, 73);
            this.tbx4.MaxLength = 1;
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(25, 20);
            this.tbx4.TabIndex = 4;
            this.tbx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx4.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx80
            // 
            this.tbx80.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx80.Location = new System.Drawing.Point(229, 245);
            this.tbx80.MaxLength = 1;
            this.tbx80.Name = "tbx80";
            this.tbx80.Size = new System.Drawing.Size(25, 20);
            this.tbx80.TabIndex = 80;
            this.tbx80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx80.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx80.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx71
            // 
            this.tbx71.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx71.Location = new System.Drawing.Point(229, 225);
            this.tbx71.MaxLength = 1;
            this.tbx71.Name = "tbx71";
            this.tbx71.Size = new System.Drawing.Size(25, 20);
            this.tbx71.TabIndex = 71;
            this.tbx71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx71.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx71.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx62
            // 
            this.tbx62.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx62.Location = new System.Drawing.Point(229, 205);
            this.tbx62.MaxLength = 1;
            this.tbx62.Name = "tbx62";
            this.tbx62.Size = new System.Drawing.Size(25, 20);
            this.tbx62.TabIndex = 62;
            this.tbx62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx62.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx53
            // 
            this.tbx53.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx53.Location = new System.Drawing.Point(229, 179);
            this.tbx53.MaxLength = 1;
            this.tbx53.Name = "tbx53";
            this.tbx53.Size = new System.Drawing.Size(25, 20);
            this.tbx53.TabIndex = 53;
            this.tbx53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx53.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx44
            // 
            this.tbx44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx44.Location = new System.Drawing.Point(229, 159);
            this.tbx44.MaxLength = 1;
            this.tbx44.Name = "tbx44";
            this.tbx44.Size = new System.Drawing.Size(25, 20);
            this.tbx44.TabIndex = 44;
            this.tbx44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx44.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx35
            // 
            this.tbx35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx35.Location = new System.Drawing.Point(229, 139);
            this.tbx35.MaxLength = 1;
            this.tbx35.Name = "tbx35";
            this.tbx35.Size = new System.Drawing.Size(25, 20);
            this.tbx35.TabIndex = 35;
            this.tbx35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx35.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx26
            // 
            this.tbx26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx26.Location = new System.Drawing.Point(229, 113);
            this.tbx26.MaxLength = 1;
            this.tbx26.Name = "tbx26";
            this.tbx26.Size = new System.Drawing.Size(25, 20);
            this.tbx26.TabIndex = 26;
            this.tbx26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx26.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx17
            // 
            this.tbx17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx17.Location = new System.Drawing.Point(229, 93);
            this.tbx17.MaxLength = 1;
            this.tbx17.Name = "tbx17";
            this.tbx17.Size = new System.Drawing.Size(25, 20);
            this.tbx17.TabIndex = 17;
            this.tbx17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx17.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx8
            // 
            this.tbx8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx8.Location = new System.Drawing.Point(229, 73);
            this.tbx8.MaxLength = 1;
            this.tbx8.Name = "tbx8";
            this.tbx8.Size = new System.Drawing.Size(25, 20);
            this.tbx8.TabIndex = 8;
            this.tbx8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx8.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx81
            // 
            this.tbx81.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx81.Location = new System.Drawing.Point(254, 245);
            this.tbx81.MaxLength = 1;
            this.tbx81.Name = "tbx81";
            this.tbx81.Size = new System.Drawing.Size(25, 20);
            this.tbx81.TabIndex = 81;
            this.tbx81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx81.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx81.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx72
            // 
            this.tbx72.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx72.Location = new System.Drawing.Point(254, 225);
            this.tbx72.MaxLength = 1;
            this.tbx72.Name = "tbx72";
            this.tbx72.Size = new System.Drawing.Size(25, 20);
            this.tbx72.TabIndex = 72;
            this.tbx72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx72.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx63
            // 
            this.tbx63.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx63.Location = new System.Drawing.Point(254, 205);
            this.tbx63.MaxLength = 1;
            this.tbx63.Name = "tbx63";
            this.tbx63.Size = new System.Drawing.Size(25, 20);
            this.tbx63.TabIndex = 63;
            this.tbx63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx63.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx54
            // 
            this.tbx54.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx54.Location = new System.Drawing.Point(254, 179);
            this.tbx54.MaxLength = 1;
            this.tbx54.Name = "tbx54";
            this.tbx54.Size = new System.Drawing.Size(25, 20);
            this.tbx54.TabIndex = 54;
            this.tbx54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx54.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx45
            // 
            this.tbx45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx45.Location = new System.Drawing.Point(254, 159);
            this.tbx45.MaxLength = 1;
            this.tbx45.Name = "tbx45";
            this.tbx45.Size = new System.Drawing.Size(25, 20);
            this.tbx45.TabIndex = 45;
            this.tbx45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx45.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx36
            // 
            this.tbx36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx36.Location = new System.Drawing.Point(254, 139);
            this.tbx36.MaxLength = 1;
            this.tbx36.Name = "tbx36";
            this.tbx36.Size = new System.Drawing.Size(25, 20);
            this.tbx36.TabIndex = 36;
            this.tbx36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx36.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx27
            // 
            this.tbx27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx27.Location = new System.Drawing.Point(254, 113);
            this.tbx27.MaxLength = 1;
            this.tbx27.Name = "tbx27";
            this.tbx27.Size = new System.Drawing.Size(25, 20);
            this.tbx27.TabIndex = 27;
            this.tbx27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx27.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx18
            // 
            this.tbx18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx18.Location = new System.Drawing.Point(254, 93);
            this.tbx18.MaxLength = 1;
            this.tbx18.Name = "tbx18";
            this.tbx18.Size = new System.Drawing.Size(25, 20);
            this.tbx18.TabIndex = 18;
            this.tbx18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx18.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx9
            // 
            this.tbx9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx9.Location = new System.Drawing.Point(254, 73);
            this.tbx9.MaxLength = 1;
            this.tbx9.Name = "tbx9";
            this.tbx9.Size = new System.Drawing.Size(25, 20);
            this.tbx9.TabIndex = 9;
            this.tbx9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx9.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx79
            // 
            this.tbx79.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx79.Location = new System.Drawing.Point(204, 245);
            this.tbx79.MaxLength = 1;
            this.tbx79.Name = "tbx79";
            this.tbx79.Size = new System.Drawing.Size(25, 20);
            this.tbx79.TabIndex = 79;
            this.tbx79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx79.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx79.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx70
            // 
            this.tbx70.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx70.Location = new System.Drawing.Point(204, 225);
            this.tbx70.MaxLength = 1;
            this.tbx70.Name = "tbx70";
            this.tbx70.Size = new System.Drawing.Size(25, 20);
            this.tbx70.TabIndex = 70;
            this.tbx70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx70.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx70.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx61
            // 
            this.tbx61.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx61.Location = new System.Drawing.Point(204, 205);
            this.tbx61.MaxLength = 1;
            this.tbx61.Name = "tbx61";
            this.tbx61.Size = new System.Drawing.Size(25, 20);
            this.tbx61.TabIndex = 61;
            this.tbx61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx61.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx52
            // 
            this.tbx52.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx52.Location = new System.Drawing.Point(204, 179);
            this.tbx52.MaxLength = 1;
            this.tbx52.Name = "tbx52";
            this.tbx52.Size = new System.Drawing.Size(25, 20);
            this.tbx52.TabIndex = 52;
            this.tbx52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx52.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx43
            // 
            this.tbx43.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx43.Location = new System.Drawing.Point(204, 159);
            this.tbx43.MaxLength = 1;
            this.tbx43.Name = "tbx43";
            this.tbx43.Size = new System.Drawing.Size(25, 20);
            this.tbx43.TabIndex = 43;
            this.tbx43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx43.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx34
            // 
            this.tbx34.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx34.Location = new System.Drawing.Point(204, 139);
            this.tbx34.MaxLength = 1;
            this.tbx34.Name = "tbx34";
            this.tbx34.Size = new System.Drawing.Size(25, 20);
            this.tbx34.TabIndex = 34;
            this.tbx34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx34.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx25
            // 
            this.tbx25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx25.Location = new System.Drawing.Point(204, 113);
            this.tbx25.MaxLength = 1;
            this.tbx25.Name = "tbx25";
            this.tbx25.Size = new System.Drawing.Size(25, 20);
            this.tbx25.TabIndex = 25;
            this.tbx25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx25.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx16
            // 
            this.tbx16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx16.Location = new System.Drawing.Point(204, 93);
            this.tbx16.MaxLength = 1;
            this.tbx16.Name = "tbx16";
            this.tbx16.Size = new System.Drawing.Size(25, 20);
            this.tbx16.TabIndex = 16;
            this.tbx16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx16.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // tbx7
            // 
            this.tbx7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx7.Location = new System.Drawing.Point(204, 73);
            this.tbx7.MaxLength = 1;
            this.tbx7.Name = "tbx7";
            this.tbx7.Size = new System.Drawing.Size(25, 20);
            this.tbx7.TabIndex = 7;
            this.tbx7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx7.TextChanged += new System.EventHandler(this.tbx_ValidateChar);
            this.tbx7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ValidateChar);
            // 
            // mngame
            // 
            this.mngame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.mnabout});
            this.mngame.Location = new System.Drawing.Point(0, 0);
            this.mngame.Name = "mngame";
            this.mngame.Size = new System.Drawing.Size(321, 24);
            this.mngame.TabIndex = 82;
            this.mngame.Text = "Game";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mngame_Game,
            this.mngame_Save,
            this.mngame_Level,
            this.mngame_Exit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mngame_Game
            // 
            this.mngame_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mngame_GNew,
            this.mngame_GLoad});
            this.mngame_Game.Name = "mngame_Game";
            this.mngame_Game.Size = new System.Drawing.Size(172, 22);
            this.mngame_Game.Text = "New Game";
            // 
            // mngame_GNew
            // 
            this.mngame_GNew.Name = "mngame_GNew";
            this.mngame_GNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mngame_GNew.Size = new System.Drawing.Size(175, 22);
            this.mngame_GNew.Text = "New Game";
            this.mngame_GNew.Click += new System.EventHandler(this.mngame_GNew_Click);
            // 
            // mngame_GLoad
            // 
            this.mngame_GLoad.Name = "mngame_GLoad";
            this.mngame_GLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mngame_GLoad.Size = new System.Drawing.Size(175, 22);
            this.mngame_GLoad.Text = "Load Game";
            this.mngame_GLoad.Click += new System.EventHandler(this.mngame_GLoad_Click);
            // 
            // mngame_Save
            // 
            this.mngame_Save.Name = "mngame_Save";
            this.mngame_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mngame_Save.Size = new System.Drawing.Size(172, 22);
            this.mngame_Save.Text = "Save Game";
            this.mngame_Save.Click += new System.EventHandler(this.mngame_Save_Click);
            // 
            // mngame_Level
            // 
            this.mngame_Level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLevel_Easy,
            this.mnLevel_Intermediate,
            this.mnLevel_Hard});
            this.mngame_Level.Name = "mngame_Level";
            this.mngame_Level.Size = new System.Drawing.Size(172, 22);
            this.mngame_Level.Text = "Level";
            this.mngame_Level.Click += new System.EventHandler(this.mngame_Level_Click);
            // 
            // mnLevel_Easy
            // 
            this.mnLevel_Easy.Checked = true;
            this.mnLevel_Easy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnLevel_Easy.Name = "mnLevel_Easy";
            this.mnLevel_Easy.Size = new System.Drawing.Size(152, 22);
            this.mnLevel_Easy.Text = "Easy";
            this.mnLevel_Easy.Click += new System.EventHandler(this.mnLevel_Easy_Click);
            // 
            // mnLevel_Intermediate
            // 
            this.mnLevel_Intermediate.Name = "mnLevel_Intermediate";
            this.mnLevel_Intermediate.Size = new System.Drawing.Size(152, 22);
            this.mnLevel_Intermediate.Text = "Intermediate";
            this.mnLevel_Intermediate.Click += new System.EventHandler(this.mnLevel_Intermediate_Click);
            // 
            // mnLevel_Hard
            // 
            this.mnLevel_Hard.Name = "mnLevel_Hard";
            this.mnLevel_Hard.Size = new System.Drawing.Size(152, 22);
            this.mnLevel_Hard.Text = "Hard";
            this.mnLevel_Hard.Click += new System.EventHandler(this.mnLevel_Hard_Click);
            // 
            // mngame_Exit
            // 
            this.mngame_Exit.Name = "mngame_Exit";
            this.mngame_Exit.Size = new System.Drawing.Size(172, 22);
            this.mngame_Exit.Text = "Exit";
            this.mngame_Exit.Click += new System.EventHandler(this.mngame_Exit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnhelp_HowtoPlay});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnhelp_HowtoPlay
            // 
            this.mnhelp_HowtoPlay.Name = "mnhelp_HowtoPlay";
            this.mnhelp_HowtoPlay.Size = new System.Drawing.Size(138, 22);
            this.mnhelp_HowtoPlay.Text = "How to Play";
            this.mnhelp_HowtoPlay.Click += new System.EventHandler(this.mnhelp_HowtoPlay_Click);
            // 
            // mnabout
            // 
            this.mnabout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnabout_Project});
            this.mnabout.Name = "mnabout";
            this.mnabout.Size = new System.Drawing.Size(52, 20);
            this.mnabout.Text = "About";
            this.mnabout.Click += new System.EventHandler(this.mnabout_Click);
            // 
            // mnabout_Project
            // 
            this.mnabout_Project.Name = "mnabout_Project";
            this.mnabout_Project.Size = new System.Drawing.Size(152, 22);
            this.mnabout_Project.Text = "Project";
            this.mnabout_Project.Click += new System.EventHandler(this.mnabout_Project_Click);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(321, 298);
            this.Controls.Add(this.mngame);
            this.Controls.Add(this.tbx80);
            this.Controls.Add(this.tbx71);
            this.Controls.Add(this.tbx62);
            this.Controls.Add(this.tbx53);
            this.Controls.Add(this.tbx44);
            this.Controls.Add(this.tbx35);
            this.Controls.Add(this.tbx26);
            this.Controls.Add(this.tbx17);
            this.Controls.Add(this.tbx8);
            this.Controls.Add(this.tbx81);
            this.Controls.Add(this.tbx72);
            this.Controls.Add(this.tbx63);
            this.Controls.Add(this.tbx54);
            this.Controls.Add(this.tbx45);
            this.Controls.Add(this.tbx36);
            this.Controls.Add(this.tbx27);
            this.Controls.Add(this.tbx18);
            this.Controls.Add(this.tbx9);
            this.Controls.Add(this.tbx79);
            this.Controls.Add(this.tbx70);
            this.Controls.Add(this.tbx61);
            this.Controls.Add(this.tbx52);
            this.Controls.Add(this.tbx43);
            this.Controls.Add(this.tbx34);
            this.Controls.Add(this.tbx25);
            this.Controls.Add(this.tbx16);
            this.Controls.Add(this.tbx7);
            this.Controls.Add(this.tbx77);
            this.Controls.Add(this.tbx68);
            this.Controls.Add(this.tbx59);
            this.Controls.Add(this.tbx50);
            this.Controls.Add(this.tbx41);
            this.Controls.Add(this.tbx32);
            this.Controls.Add(this.tbx23);
            this.Controls.Add(this.tbx14);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.tbx78);
            this.Controls.Add(this.tbx69);
            this.Controls.Add(this.tbx60);
            this.Controls.Add(this.tbx51);
            this.Controls.Add(this.tbx42);
            this.Controls.Add(this.tbx33);
            this.Controls.Add(this.tbx24);
            this.Controls.Add(this.tbx15);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.tbx76);
            this.Controls.Add(this.tbx67);
            this.Controls.Add(this.tbx58);
            this.Controls.Add(this.tbx49);
            this.Controls.Add(this.tbx40);
            this.Controls.Add(this.tbx31);
            this.Controls.Add(this.tbx22);
            this.Controls.Add(this.tbx13);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx74);
            this.Controls.Add(this.tbx65);
            this.Controls.Add(this.tbx56);
            this.Controls.Add(this.tbx47);
            this.Controls.Add(this.tbx38);
            this.Controls.Add(this.tbx29);
            this.Controls.Add(this.tbx20);
            this.Controls.Add(this.tbx11);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx75);
            this.Controls.Add(this.tbx66);
            this.Controls.Add(this.tbx57);
            this.Controls.Add(this.tbx48);
            this.Controls.Add(this.tbx39);
            this.Controls.Add(this.tbx30);
            this.Controls.Add(this.tbx21);
            this.Controls.Add(this.tbx12);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx73);
            this.Controls.Add(this.tbx64);
            this.Controls.Add(this.tbx55);
            this.Controls.Add(this.tbx46);
            this.Controls.Add(this.tbx37);
            this.Controls.Add(this.tbx28);
            this.Controls.Add(this.tbx19);
            this.Controls.Add(this.tbx10);
            this.Controls.Add(this.tbx1);
            this.MainMenuStrip = this.mngame;
            this.Name = "Screen";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.mngame.ResumeLayout(false);
            this.mngame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx10;
        private System.Windows.Forms.TextBox tbx19;
        private System.Windows.Forms.TextBox tbx28;
        private System.Windows.Forms.TextBox tbx37;
        private System.Windows.Forms.TextBox tbx46;
        private System.Windows.Forms.TextBox tbx55;
        private System.Windows.Forms.TextBox tbx64;
        private System.Windows.Forms.TextBox tbx73;
        private System.Windows.Forms.TextBox tbx75;
        private System.Windows.Forms.TextBox tbx66;
        private System.Windows.Forms.TextBox tbx57;
        private System.Windows.Forms.TextBox tbx48;
        private System.Windows.Forms.TextBox tbx39;
        private System.Windows.Forms.TextBox tbx30;
        private System.Windows.Forms.TextBox tbx21;
        private System.Windows.Forms.TextBox tbx12;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx74;
        private System.Windows.Forms.TextBox tbx65;
        private System.Windows.Forms.TextBox tbx56;
        private System.Windows.Forms.TextBox tbx47;
        private System.Windows.Forms.TextBox tbx38;
        private System.Windows.Forms.TextBox tbx29;
        private System.Windows.Forms.TextBox tbx20;
        private System.Windows.Forms.TextBox tbx11;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx77;
        private System.Windows.Forms.TextBox tbx68;
        private System.Windows.Forms.TextBox tbx59;
        private System.Windows.Forms.TextBox tbx50;
        private System.Windows.Forms.TextBox tbx41;
        private System.Windows.Forms.TextBox tbx32;
        private System.Windows.Forms.TextBox tbx23;
        private System.Windows.Forms.TextBox tbx14;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.TextBox tbx78;
        private System.Windows.Forms.TextBox tbx69;
        private System.Windows.Forms.TextBox tbx60;
        private System.Windows.Forms.TextBox tbx51;
        private System.Windows.Forms.TextBox tbx42;
        private System.Windows.Forms.TextBox tbx33;
        private System.Windows.Forms.TextBox tbx24;
        private System.Windows.Forms.TextBox tbx15;
        private System.Windows.Forms.TextBox tbx6;
        private System.Windows.Forms.TextBox tbx76;
        private System.Windows.Forms.TextBox tbx67;
        private System.Windows.Forms.TextBox tbx58;
        private System.Windows.Forms.TextBox tbx49;
        private System.Windows.Forms.TextBox tbx40;
        private System.Windows.Forms.TextBox tbx31;
        private System.Windows.Forms.TextBox tbx22;
        private System.Windows.Forms.TextBox tbx13;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx80;
        private System.Windows.Forms.TextBox tbx71;
        private System.Windows.Forms.TextBox tbx62;
        private System.Windows.Forms.TextBox tbx53;
        private System.Windows.Forms.TextBox tbx44;
        private System.Windows.Forms.TextBox tbx35;
        private System.Windows.Forms.TextBox tbx26;
        private System.Windows.Forms.TextBox tbx17;
        private System.Windows.Forms.TextBox tbx8;
        private System.Windows.Forms.TextBox tbx81;
        private System.Windows.Forms.TextBox tbx72;
        private System.Windows.Forms.TextBox tbx63;
        private System.Windows.Forms.TextBox tbx54;
        private System.Windows.Forms.TextBox tbx45;
        private System.Windows.Forms.TextBox tbx36;
        private System.Windows.Forms.TextBox tbx27;
        private System.Windows.Forms.TextBox tbx18;
        private System.Windows.Forms.TextBox tbx9;
        private System.Windows.Forms.TextBox tbx79;
        private System.Windows.Forms.TextBox tbx70;
        private System.Windows.Forms.TextBox tbx61;
        private System.Windows.Forms.TextBox tbx52;
        private System.Windows.Forms.TextBox tbx43;
        private System.Windows.Forms.TextBox tbx34;
        private System.Windows.Forms.TextBox tbx25;
        private System.Windows.Forms.TextBox tbx16;
        private System.Windows.Forms.TextBox tbx7;
        private System.Windows.Forms.MenuStrip mngame;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mngame_Game;
        private System.Windows.Forms.ToolStripMenuItem mngame_GNew;
        private System.Windows.Forms.ToolStripMenuItem mngame_GLoad;
        private System.Windows.Forms.ToolStripMenuItem mngame_Save;
        private System.Windows.Forms.ToolStripMenuItem mngame_Level;
        private System.Windows.Forms.ToolStripMenuItem mngame_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnhelp_HowtoPlay;
        private System.Windows.Forms.ToolStripMenuItem mnabout;
        private System.Windows.Forms.ToolStripMenuItem mnabout_Project;
        private System.Windows.Forms.ToolStripMenuItem mnLevel_Easy;
        private System.Windows.Forms.ToolStripMenuItem mnLevel_Intermediate;
        private System.Windows.Forms.ToolStripMenuItem mnLevel_Hard;
    }
}

